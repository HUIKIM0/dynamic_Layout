using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dynamic_Layout
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //★3. ucClorMenu.cs의 이벤트 등록. Button이랑 pColor(색상선택)
            ucFormColorMenu.eColorSender += UcFormColorMenu_eColorSender;


            // Form1.cs에 있는 판넬 더블클릭 시 이벤트 일어나야함. 등록
            ucPanel1.eLableDoubleClickHandler += UcPanel_eLableDoubleClickHandler;
            ucPanel2.eLableDoubleClickHandler += UcPanel_eLableDoubleClickHandler;
            ucPanel3.eLableDoubleClickHandler += UcPanel_eLableDoubleClickHandler;
            ucPanel4.eLableDoubleClickHandler += UcPanel_eLableDoubleClickHandler;

        }



        private void UcFormColorMenu_eColorSender(Button btn, Color color, List<Button> listbutton)
        {
            string strPanelName = string.Empty;

             switch (btn.Name)
            {
                case "btn1":
                    ucPanel1.BackColor = color;
                    strPanelName = "Panel Top";
                    TextResult();
                    break;

                case "btn2":
                    ucPanel2.BackColor = color;
                    strPanelName = "Panel Center1";
                    TextResult();
                    break;

                case "btn3":
                    ucPanel3.BackColor = color;
                    strPanelName = "Panel Center2";
                    TextResult();
                    break;

                case "btn4":
                    ucPanel4.BackColor = color;
                    strPanelName = "Panel Right";
                    TextResult();
                    break;


                case "btn5":
                    fbtnPanelRe_Click(listbutton);

                    string strReset = string.Format("★초기화 완료★");
                    lboxLog.Items.Add(strReset);
                    break;

                default:
                    break;

                void TextResult()
                {
                    string strResult = null;

                    strResult = string.Format("선택: {0}, {1}의 색상을 {2} 로 변경 완료!", btn.Name, strPanelName, color.ToString());
                    lboxLog.Items.Add(strResult);
                }
            }             
        }

        private void UcPanel_eLableDoubleClickHandler(object sender, EventArgs e)
        {
            //ucFormColorMenu.fButtonColorChange((ucPanel)sender);
            string strResult = ucFormColorMenu.fButtonColorChange((ucPanel)sender);   //ucPanel이라고 꼭!
            lboxLog.Items.Add(strResult);

        }


        //판낼,버튼 초기화 Function
        private void fbtnPanelRe_Click(List<Button> btn)
        { 

            ucPanel1.BackColor = Color.FromArgb(192, 192, 255);
            ucPanel2.BackColor = Color.DarkTurquoise;
            ucPanel3.BackColor = Color.PaleVioletRed;
            ucPanel4.BackColor = Color.PaleGreen;

            int ListCount = btn.Count;

            for (int i = 0; i < ListCount; i++)
            {
                if (btn[i] is Button)
                {
                    btn[i].BackColor = Color.Gray;
                }
            }

        }
    }
}

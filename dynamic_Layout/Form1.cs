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



        private void UcFormColorMenu_eColorSender(Button arg1, Color arg2)
        {
            string strPanelName = string.Empty;



            switch (arg1.Name)
            {
                case "btn1":
                    ucPanel1.BackColor = arg2;
                    strPanelName = "Panel Top";

                    TextResult();
                    break;

                case "btn2":
                    ucPanel2.BackColor = arg2;
                    strPanelName = "Panel Center1";

                    TextResult();
                    break;

                case "btn3":
                    ucPanel3.BackColor = arg2;
                    strPanelName = "Panel Center2";

                    TextResult();
                    break;

                case "btn4":
                    ucPanel4.BackColor = arg2;
                    strPanelName = "Panel Right";

                    TextResult();
                    break;


                case "btn5":

                    this.ucPanel1.BackColor = Color.FromArgb(192, 192, 255);
                    this.ucPanel2.BackColor = Color.DarkTurquoise;
                    this.ucPanel3.BackColor = Color.PaleVioletRed;
                    this.ucPanel4.BackColor = Color.PaleGreen;

                    string Reset = null;
                    Reset = string.Format("★Panel 초기화 완료★");
                    lboxLog.Items.Add(Reset);

                    break;

                default:
                    break;

                void TextResult()
                {
                    string strResult = null;

                    strResult = string.Format("선택: {0}, {1}의 색상을 {2} 로 변경 완료!", arg1.Name, strPanelName, arg2.ToString());
                    lboxLog.Items.Add(strResult);
                }

            }             

        }


        private void UcPanel_eLableDoubleClickHandler(object sender, EventArgs e)
        {
            string strResult = ucFormColorMenu.fButtonColorChange((ucPanel)sender);
            lboxLog.Items.Add(strResult);
        }


        // 판넬 색상 초기화기능(...ㅎ)
        //private void btnPanelRe_Click(object sender, EventArgs e)
        //{
        //    string strResult = string.Empty;


        //    this.ucPanel1.BackColor = Color.FromArgb(192, 192, 255);
        //    this.ucPanel2.BackColor = Color.DarkTurquoise;
        //    this.ucPanel3.BackColor = Color.PaleVioletRed;
        //    this.ucPanel4.BackColor = Color.PaleGreen;

        //    string strbtnName = string.Empty;


        //    strResult = string.Format("★Panel 색상 초기화 완료★");
        //    lboxLog.Items.Add(strResult);
        //}

    }
}

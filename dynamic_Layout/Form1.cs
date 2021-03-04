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

        // ucPanel2.BackColor = default(Color);  -> 색상 원래대로 돌려놓기

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //3. ucClorMenu.cs의 이벤트 등록. Button이랑 pColor 받음
            ucFormColorMenu.eColorSender += UcFormColorMenu_eColorSender;
        }

        private void UcFormColorMenu_eColorSender(Button arg1, Color arg2)
        {
            string strPanelName = string.Empty;

            switch (arg1.Name)
            {
                case "btn1":
                    ucPanel1.BackColor = arg2;
                    strPanelName = "Panel Top";
                    break;

                case "btn2":
                    ucPanel2.BackColor = arg2;
                    strPanelName = "Panel Center1";
                    break;

                case "btn3":
                    ucPanel3.BackColor = arg2;
                    strPanelName = "Panel Center2";
                    break;

                case "btn4":
                    ucPanel4.BackColor = arg2;
                    strPanelName = "Panel Right";
                    break;
                default:
                    break;

            }
            string strResult = string.Format("선택: {0}, {1}의 색상을 {2} 로 변경 완료!",arg1.Name,strPanelName,arg2.ToString());
            lboxLog.Items.Add(strResult);
        }
    }
}

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
    public partial class ucColorMenu : UserControl
    {

        //★1. delegate event 선언
        public delegate void delColorSender(Button dSender, Color dColor, List<Button> listBtn);
        public event delColorSender eColorSender;

        // 1-2 기본 EventHandler 버전
        //public event EventHandler eColorEventHandler;

        // 1-3 제네릭 형태의 delgate 버전
        //public event Action<Button,Color> eColorAction;


        List<Button> _btnlist = new List<Button>();  //초기화 작업 위해 btn1~4 넣을 List

        public ucColorMenu()
        {
            InitializeComponent();
        }

        //Button btn;

        // 로드되면 -> 버튼만든다
        private void ucColorMenu_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 5; i++)
            {
                Button btn = new Button();   //for 돌때마다 매번 new 해줘서 new Button 으로 작업~ for 안에 있어야함

                //btn = new Button();

                if (i <= 4)
                {
                    btn.Name = "btn" + i;
                    btn.Text = string.Format("P{0} 색상변경", i);
                    btn.BackColor = Color.Gray;
                    btn.Margin = new Padding(5, 20, 0, 0);
                    btn.Size = new Size(100, 30);
                    _btnlist.Add(btn);
                    btn.Click += Btn_Click;

                }

                else if(i == 5)
                {
                    btn.Name = "btn" + i;
                    btn.Text = string.Format("초기화");
                    btn.BackColor = Color.Gray;
                    btn.Margin = new Padding(5, 20, 0, 0);
                    btn.Size = new Size(100, 30);
                    _btnlist.Add(btn);
                    btn.Click += Btn_Click;
                   
                }

                flpMenu.Controls.Add(btn);
            }
        }

        //ColorDialog
        private void pColor_Click(object sender, EventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();   

            if (dRet == DialogResult.OK)  
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }


        //★2. delegate event 값 넘기기.
        private void Btn_Click(object sender, EventArgs e)
        {
            eColorSender((Button)sender, pColor.BackColor, _btnlist);
        }



        //판넬을 더블클릭 -> 판넬 색상 == 버튼 색상 되게
        //여기서 함수를 만들어 준 이유는 이 파일에 버튼,색상정보 다 있음 Main에서 함수호출로 Panel만 받아오면 쉽다
        public string fButtonColorChange(ucPanel oPanel)   
        {
            string strResult = string.Empty;
            string strbtnName = string.Empty;   // Load시에 이미 btn.Name을 줬으므로 

            switch (oPanel.Name)
            {
                case "ucPanel1":
                    strbtnName = "btn1";
                    break;

                case "ucPanel2":
                    strbtnName = "btn2";
                    break;

                case "ucPanel3":
                    strbtnName = "btn3";
                    break;

                case "ucPanel4":
                    strbtnName = "btn4";
                    break;

            }

            strResult = fBtnSearch(strbtnName, oPanel.Name, oPanel.BackColor);  
            return strResult;
        }


        //FlowLayoutPanel에서 ★원하는 컨트롤(버튼) 찾아오는 함수★
        private string fBtnSearch(string strbtnName, string strPanelName, Color oColor)
        {
            string strResult = string.Empty;

            foreach (var oitem in flpMenu.Controls)  //ucColorMenu.cs의 flpMenu에 담긴 컨트롤들
            {
                if(oitem is Button)
                {
                    Button obtn = oitem as Button;

                    if (obtn.Name.Equals(strbtnName)) 
                    {
                        obtn.BackColor = oColor;
                        strResult = string.Format("{0} Panel DoubleClick, {1}의 색상을 {2}로 Panel 색상과 같게 변경", strPanelName, strbtnName, oColor.ToString());
                        return strResult;
                    }
                }
            }
            return null;   //컨트롤러가 제대로 없으면 null반환(없으니까)
        }

    }
}

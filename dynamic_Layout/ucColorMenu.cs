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
        public delegate void delColorSender(Button dSender, Color dColor);
        public event delColorSender eColorSender;

        // 1-2 기본 EventHandler 버전
        //public event EventHandler eColorEventHandler;

        // 1-3 제네릭 형태의 delgate 버전
        //public event Action<Button,Color> eColorAction;

        public ucColorMenu()
        {
            InitializeComponent();
        }


        // 로드되면 -> 버튼만든다
        private void ucColorMenu_Load(object sender, EventArgs e)
        {

            for (int i = 1; i <= 5; i++)
            {
                Button btn = new Button();

                if(i <= 4)
                {
                    btn.Name = "btn" + i;
                    btn.Text = string.Format("P{0} 색상변경", i);
                    btn.BackColor = Color.Gray;
                    btn.Margin = new Padding(5, 20, 0, 0);
                    btn.Size = new Size(100, 30);
                    btn.Click += Btn_Click;

                }


                else if(i == 5)
                {
                    btn.Name = "btn" + i;
                    btn.Text = string.Format("초기화");
                    btn.BackColor = Color.Gray;
                    btn.Margin = new Padding(5, 20, 0, 0);
                    btn.Size = new Size(100, 30);
                    btn.Click += Btn_Click;
                }

                flpMenu.Controls.Add(btn);


            }

        }



        private void Btn_Click(object sender, EventArgs e)
        {
            //★2. delegate event 값 넘기기. 아애 버튼만 쓸거니까 (Button)sender 해줘도 무방
            eColorSender((Button)sender, pColor.BackColor);
        }


        private void pColor_Click(object sender, EventArgs e)
        {
            DialogResult dRet = cDialogColor.ShowDialog();    //ColorDialog 불러서 선택한 뒤 결과값까지 받아옴

            if (dRet == DialogResult.OK)   //정상일때 선택 된 Color를 Panel에 뿌려줌 
            {
                pColor.BackColor = cDialogColor.Color;
            }
        }


        //판넬을 더블클릭 -> 해당 판넬의 색상과 같은 색이 버튼에 입혀지게 써먹을거임
        //그래서 판낼에 따른 버튼을 매칭. main form에서 panel값 넘겨받으면 매칭하고 색상바꾸고~!
        public string fButtonColorChange(ucPanel oPanel)
        {

            string strResult = string.Empty;
            string strbtnName = string.Empty;

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
            strResult = fBtnSearch(strbtnName, oPanel.BackColor, oPanel.Name);
            return strResult;
        }


        //FlowLayoutPanel에서 ★원하는 컨트롤(버튼) 찾아오는 함수★
        private string fBtnSearch(string strbtnName, Color oColor, string strPanelName)
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
            return null;
        }

    }
}

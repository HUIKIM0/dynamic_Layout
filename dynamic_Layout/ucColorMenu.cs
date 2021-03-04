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

        //1. delegate event 선언
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

        private void ucColorMenu_Load(object sender, EventArgs e)
        {

            for (int i = 1; i < 5; i++)
            {
                Button btn = new Button();

                btn.Name = "btn" + i;
                btn.Text = string.Format("P{0} 색상변경", i);
                btn.BackColor = Color.Gray;
                btn.Margin = new Padding(5, 20, 0, 0);
                btn.Size = new Size(100, 30);
                btn.Click += Btn_Click;

                flpMenu.Controls.Add(btn);
            }



        }

        private void Btn_Click(object sender, EventArgs e)
        {
            //2. delegate event 값 넘기기. 아애 버튼만 쓸거니까 (Button)sender 해줘도 무방
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
    }
}

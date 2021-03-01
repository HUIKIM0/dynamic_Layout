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
        public ucColorMenu()
        {
            InitializeComponent();
        }

        private void ucColorMenu_Load(object sender, EventArgs e)
        {

        }


        //private void PColor_MouseClick(object sender, System.Windows.Forms.MouseEventArgs e)
        //{

        //}

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

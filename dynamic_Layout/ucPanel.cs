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
    public partial class ucPanel : UserControl
    {
        public event EventHandler eLableDoubleClickHandler;


        public ucPanel()
        {
            InitializeComponent();
        }

        // Panel의 사이즈(유저 컨트롤)가 바뀔때 이벤트
        private void PanelSizeChanged(object sender, EventArgs e)
        {
            lblPanel.Text = string.Format("({0},{1})",lblPanel.Width,lblPanel.Height);
        }


        // 더블클릭하면 이벤트
        private void lblPanel_DoubleClick(object sender, EventArgs e)
        {
            
            eLableDoubleClickHandler(this, e);

        }
    }
}

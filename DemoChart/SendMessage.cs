using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoChart
{
    public partial class SendMessage : UserControl
    {
        public SendMessage()
        {
            InitializeComponent();
            text.SizeChanged += MyLabel_SizeChanged;
        }
        public void setText(string mText)
        {
            text.Text = mText;
        }
        private void MyLabel_SizeChanged(object sender, EventArgs e)
        {
            // Thay đổi kích thước của UserControl để bao trọn Label
            Size s = new Size(260, text.Height);
            Size = s;
        }
    }
}

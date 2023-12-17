using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoChart
{
    public partial class ContainerGantChart : UserControl
    {
        private int itemCount = 0;
        private int currentIndex = 0;
        private int currentX = 0, currentY = 0;
        public ContainerGantChart()
        {
            InitializeComponent();
            container.AutoScroll = true;
        }
        //public void addItemAtNext(ItemGantchart item)
        //{
        //    if(currentX + item.Width - 10 > container.Width)
        //    {
        //        currentY += (20 + item.Height);
        //        currentX = 0;
        //    }
        //    item.Location = new Point(currentX, currentY);

        //    currentX += item.Width;
        //    container.Controls.Add(item);
        //    container.Controls.SetChildIndex(item, currentIndex);
        //    currentIndex++;
        //}
        public void addItemAtNext(ItemGantchart item)
        {
            //if (currentX + item.Width - 10 > container.Width)
            //{
            //    currentY += (20 + item.Height);
            //    currentX = 0;
            //}
            int MARGIN = 2;
            item.Location = new Point(currentX, currentY);

            currentX += (item.Width + MARGIN);
            container.Controls.Add(item);
            container.Controls.SetChildIndex(item, currentIndex);
            currentIndex++;
        }
        public void clearControls()
        {
            container.Controls.Clear();
            currentX = 0;
            ItemGantchart.indexOfItem = 1;
        }
    }
}

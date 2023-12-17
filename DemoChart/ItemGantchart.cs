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
    public partial class ItemGantchart : UserControl
    {
        //private Queue<Process> queue;
        //private int endTime = 0;
        private int processTime = 0;

        Color[] colors = { Color.Red, Color.Gray, Color.Green, Color.Blue, Color.Black
                , Color.Brown, Color.BlueViolet, Color.Yellow, Color.Pink};
        public static int indexOfItem = 1;
        public ItemGantchart()
        {
            InitializeComponent();
            if (indexOfItem == 1)
                TimeStart.Visible = true; // visivible timeStart of first process
            indexOfItem++;
        }
      
        public void setEndTime(int endTime)
        {
            TimeEnd.Text = endTime + "";
            int startTime = endTime - processTime;
            setSatartTime(startTime);
        }
        public void setSatartTime(int  satartTime)
        {
            if (true)
            {
                TimeStart.Text = satartTime + "";
            }
        }

        public void setColor(int idProcess)
        {
            if(idProcess == -1) {
                lbName.Text = "Waiting"; // wet name base on idprocess
                this.panel1.BackColor = colors[8];
                return;
            }
            lbName.Text = "p" + idProcess; // wet name base on idprocess
            if (idProcess <= 9)
            {
                this.panel1.BackColor = colors[idProcess - 1];
            }
        }
        public void setQueue(Queue<Process> queue)
        {
            if(queue != null && queue.Count > 0)
            {
                String s = "{";
                for (int i = 0; i < queue.Count - 1; i++)
                {
                    s += (queue.ElementAt(i).name + ": "+queue.ElementAt(i).TimeRemain + ", ");
                }
                int j = queue.Count - 1;
                s += (queue.ElementAt(j).name + ": " + queue.ElementAt(j).TimeRemain + "}");
                lbQueue.Text = s;
            }
         
        }
        public void setProcessTime(int processTime)
        {
            
            this.processTime = processTime;
            int T = 10;
            Width += processTime * T;
            panel1.Width += processTime * T;
            TimeEnd.Location = new Point(TimeEnd.Location.X + processTime * T, TimeEnd.Location.Y);
            
        }
    }
}

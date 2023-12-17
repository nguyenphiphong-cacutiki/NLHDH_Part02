using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace DemoChart
{
    public partial class ItemProcess2 : UserControl
    {
        private int processOrder;
        public int ProcessOrder
        {
            get { return processOrder; }
        }

        public ItemProcess2(int order)
        {
            InitializeComponent();
            processOrder = order;
            lbName.Text = "P" + processOrder;
        }

        public ItemProcess2(int processOrder, int arrivalTime, int burstTime)
        {
            InitializeComponent();

            processOrder = processOrder;
            arrivalTime = arrivalTime;
            burstTime = burstTime;

            // Gán giá trị cho các label hoặc biến tương ứng dựa trên thời gian xuất hiện và thời gian sử dụng CPU
            // Ví dụ:
            lbName.Text = "Process " + processOrder;
            tbArrivalTime.Text = arrivalTime.ToString();
            tbBurstTime.Text = burstTime.ToString();
        }

        public string getName()
        {
            return lbName.Text.ToString();
        }
        public int getID()
        {
            return processOrder;
        }
        public int getArrivalTime()
        {
            try
            {
                return int.Parse(tbArrivalTime.Text);
            }catch(Exception) {
                throw new Exception();
            }
        }
        public int getBurstTime()
        {
            try
            {
                return int.Parse(tbBurstTime.Text);
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }
        public int getWaitingTime()
        {
            return int.Parse(WaitingTime);
        }

        String CompletionTime = "";
        String TurnaroundTime = "";
        String WaitingTime = "";
        public void setCompletionTime(int time)
        {
            CompletionTime = time + "";
        }
        public void setTurnaroundTime(int time)
        {
            TurnaroundTime = time + "";
        }
        public void setWaitingTime(int time)
        {
            WaitingTime = time + "";
        }


        public void showCompletionTime()
        {
            lbCompletionTime.Text = CompletionTime;
        }
        public void showTurnaroundTime()
        {
            lbTurnaroundTime.Text = TurnaroundTime;
        }
        public void showWaitingTime()
        {
            lbWaitingTime.Text = WaitingTime;
        }

        public void clearResult()
        {
            lbCompletionTime.Text = "";
            lbTurnaroundTime.Text = "";
            lbWaitingTime.Text = "";
        }

        public event EventHandler OnDeleteButtonClick;

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Gửi thông điệp đến Form chứa UserControl
            OnDeleteButtonClick?.Invoke(this, EventArgs.Empty);
        }

        public void UpdateOrder(int newOrder)
        {
            processOrder = newOrder;
            // Cập nhật số thứ tự ở giao diện người dùng (nếu cần)
            lbName.Text = "P" + processOrder;
        }
    }
}

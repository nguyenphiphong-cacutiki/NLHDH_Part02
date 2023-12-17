using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace DemoChart
{
    public partial class Algorithm : Form
    {
        private int maxProcessOrder = 0;
        public static bool checkq = false;
        private List<ItemProcess2> itemProcess2s = new List<ItemProcess2>();
        private Point destination = new Point(261, 124);
        private bool isAceptRunAlgorithm = true;
        public Algorithm()
        {
            InitializeComponent();
            timerShowResult.Tick += tick_showResult;
            timerShowText.Tick += tick_showText;
            // timeq
            lbTimeq.Hide();
            txtTimeq.Hide();
            lbms.Hide();
            // set container for gen Gant chart
            RunAlgorithm.setContainer(containerGantChart1);
        }

        // Sự kiện load form
        private void Algorithm_Load(object sender, EventArgs e)
        {
            this.Size = new System.Drawing.Size(700, 700);
            UpdateProcessOrder();
        }

        // Thêm tiến trình thủ công
        private void btAddProcess_Click(object sender, EventArgs e)
        {
            int newOrder = GetMaxProcessOrder() + 1;
            ItemProcess2 newItem = new ItemProcess2(newOrder);
            flowContainer.Controls.Add(newItem);
            newItem.OnDeleteButtonClick += ItemProcess2_OnDeleteButtonClick;
        }

        //Thêm tiến trình theo random
        private void btnRandom_Click(object sender, EventArgs e)
        {
            GenerateRandomProcesses();
        }

        private void GenerateRandomProcesses()
        {
            Random random = new Random();
            flowContainer.Controls.Clear(); // Xóa các điều khiển hiện tại
            List<ItemProcess2> randomProcesses = new List<ItemProcess2>();
            ItemProcess2 ItemFirst = new ItemProcess2(1, 0, random.Next(3, 25));
            ItemFirst.OnDeleteButtonClick += ItemProcess2_OnDeleteButtonClick;
            randomProcesses.Add(ItemFirst);

            // Tạo 15 quy trình ngẫu nhiên
            int start = 1;
            for (int i = 0; i < 15; i++)
            {
                int arrivalTime = random.Next(start+1, start + 4);
                start = arrivalTime;
                int burstTime = random.Next(5, 15);

                int newOrder = GetMaxProcessOrder() + 1;
                ItemProcess2 newItem = new ItemProcess2(newOrder, arrivalTime, burstTime);
                newItem.OnDeleteButtonClick += ItemProcess2_OnDeleteButtonClick;
                randomProcesses.Add(newItem);
            }

            //Chọn 5 tiến trình đầu tiên
            randomProcesses = randomProcesses.Take(5).ToList();

            // Sắp xếp quy trình theo thời gian xuất hiện
            randomProcesses = randomProcesses.OrderBy(process => process.getArrivalTime()).ToList();
          

            // Thêm các quy trình đã sắp xếp vào flowContainer
            foreach (var process in randomProcesses)
            {
                flowContainer.Controls.Add(process);
            }

            UpdateProcessOrder();
        }

        // Lấy danh sách các tiến trình đã được thêm
        private List<ItemProcess2> getListItemControlProcess()
        {
            List<ItemProcess2> list = new List<ItemProcess2>();
            foreach(ItemProcess2 itemProcess2 in flowContainer.Controls)
            {
                list.Add(itemProcess2);
            }
            return list;
        }
       
        // Lựa chọn tiến trình thực hiện
        private void buttonAlgorithmClick(object sender, EventArgs e)
        {
            lbTimeq.Hide();
            txtTimeq.Hide();
            lbms.Hide();
            MoveControl moveControl = new MoveControl(this);
            if (isAceptRunAlgorithm)
            {
                isAceptRunAlgorithm = false;
                itemProcess2s = getListItemControlProcess();
                //RunAlgorithm.runAlgorithm(itemProcess2s, 1, 1);
                Button bt = sender as Button;
                if(bt.Text == btFCFS.Text || bt.Text == btSJF.Text || bt.Text == btSRTN.Text)
                {
                    if (bt.Text == btFCFS.Text)
                    {
                        RunAlgorithm.runAlgorithm(itemProcess2s, RunAlgorithm.FCFS, 1);
                    }
                    else if (bt.Text == btSJF.Text)
                    {
                        RunAlgorithm.runAlgorithm(itemProcess2s, RunAlgorithm.SJF, 1);
                    }
                    else if (bt.Text == btSRTN.Text)
                    {
                        RunAlgorithm.runAlgorithm(itemProcess2s, RunAlgorithm.SRTN, 1);
                    }

                    resetLocaion();
                    clearResultProcess();
                    bt.BringToFront();                  
                    moveControl.move(bt, destination);
                }

                //showResult();
                if (bt.Text == btRR.Text)
                {
                    resetLocaion();
                    lbTimeq.Show();
                    txtTimeq.Show();
                    txtTimeq.Text = "";
                    clearResultProcess();
                }

            }
        }

        // Đối với RR, khi click cần nhập thời gian q để thực thi thuật toán
        private void txtTimeq_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int q = int.Parse(txtTimeq.Text);
                if (q > 0)
                {
                    checkq = true;
                    RunAlgorithm.runAlgorithm(itemProcess2s, RunAlgorithm.RR, q);
                    btRR.BringToFront();
                    MoveControl moveControl = new MoveControl(this);
                    moveControl.move(btRR, destination);

                    lbms.Hide();
                }
                else
                {
                    lbms.Show();
                    lbms.Text = "q phải lớn hơn 0";
                }
            }
            catch (FormatException ex)
            {
                lbms.Show();
                lbms.Text = "Vui lòng nhập thời gian q hợp lệ";
            }
        }

        // Đưa các button trở về vị trí ban đầu
        private void resetLocaion()
        {
            btFCFS.Location = new Point(35, 54);
            btRR.Location = new Point(200, 54);
            btSJF.Location = new Point(365, 54);
            btSRTN.Location = new Point(530, 54);
        }

        //
        private void perOneShowResult(int i, int j)
        {

            if(j == 1)
                itemProcess2s.ElementAt(i).showCompletionTime();
            else if(j == 2)
                itemProcess2s.ElementAt(i).showTurnaroundTime();
            else if(j == 3)
                itemProcess2s.ElementAt(i).showWaitingTime();
        }
        System.Windows.Forms.Timer timerShowResult = new System.Windows.Forms.Timer();
        System.Windows.Forms.Timer timerShowText = new System.Windows.Forms.Timer();
        int i = 0, j = 1;
        bool startTick = true;
        String textResult = "";
        int curentCharTextResult = 0;
        

        public void showResult()
        {
            timerShowResult.Interval = 300;
            timerShowResult.Start();
        }

        //Hiển thị kết quả
        private void showText()
        {
            tbTextResult.Text = "Kết quả:";
            textResult = getAVG_TimeWaiting();
            timerShowText.Interval = 50;
            timerShowText.Start();
        }

        private void tick_showResult(Object send, EventArgs e)
        {
            perOneShowResult(i, j);
            j++;
            if(j > 3)
            {
                i++; j = 1;
            }
            if (i == itemProcess2s.Count)
            {
                timerShowResult.Stop();
                timerShowResult.Dispose();
                showText();
                i = 0; j = 1;
            }
        }

        private void tick_showText(Object send, EventArgs e)
        {
            tbTextResult.AppendText(textResult.ElementAt(curentCharTextResult).ToString());
            curentCharTextResult++;
            if (curentCharTextResult == textResult.Length)
            {
                timerShowText.Stop();
                timerShowText.Dispose();
                tbTextResult.Text = "kết quả:" + textResult;
                curentCharTextResult = 0;
                isAceptRunAlgorithm = true;
            }
        }

        private String getAVG_TimeWaiting()
        {
            float time = 0;
            foreach(ItemProcess2 item in itemProcess2s)
            {
                time += item.getWaitingTime();
            }
            return " Thời gian chờ trung bình là: "+ (time / itemProcess2s.Count).ToString() + " giây";
        }     

        private void clearResultProcess()
        {
            foreach(ItemProcess2 item in itemProcess2s)
            {
                item.clearResult();
            }
        }

        //Thực hiện xóa 1 tiến trình
        private void ItemProcess2_OnDeleteButtonClick(object sender, EventArgs e)
        {
            if (sender is ItemProcess2 deletedItem)
            {
                flowContainer.Controls.Remove(deletedItem); // Xóa UserControl khỏi FlowLayoutPanel
                deletedItem.Dispose(); // Giải phóng tài nguyên của UserControl
                UpdateProcessOrder(); //Update số hiệu tiến trình sau khi xóa
            }
        }

        //Cập nhật số hiệu tiến trình
        private void UpdateProcessOrder()
        {
            int order = 1;
            foreach (ItemProcess2 item in flowContainer.Controls)
            {
                item.UpdateOrder(order);
                order++;

                if (item.ProcessOrder > maxProcessOrder)
                {
                    maxProcessOrder = item.ProcessOrder;
                }
            }
        }

        //Lấy số hiệu tiến trình lớn nhất
        private int GetMaxProcessOrder()
        {
            int maxOrder = 0;
            foreach (ItemProcess2 item in flowContainer.Controls)
            {
                if (item.ProcessOrder >= maxOrder)
                {
                    maxOrder = item.ProcessOrder;
                }
            }
            return maxOrder;
        }
    }
}

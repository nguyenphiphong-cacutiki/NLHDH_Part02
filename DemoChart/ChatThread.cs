using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoChart
{
    public partial class ChatThread : Form
    {
        bool isRuning = true;
        Thread threadA, threadB;
        bool isAReceive = false, isBReceive = false;
        bool isASend = false, isBSend = false;
        String aReceive = "", bReceive = "";

        private void btSendA_Click(object sender, EventArgs e)
        {
            isASend = true;
        }

        private void btSendB_Click(object sender, EventArgs e)
        {
            isBSend = true;
        }
        private void scroolPanelToBottom()
        {
            flowA.AutoScrollPosition = new Point(0, flowA.VerticalScroll.Maximum);
            flowB.AutoScrollPosition = new Point(0, flowB.VerticalScroll.Maximum);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            isRuning = false;
        }

        public ChatThread()
        {
            InitializeComponent();

        }





        private void Form1_Load_1(object sender, EventArgs e)
        {
            threadA = new Thread(threadAWorking);
            threadB = new Thread(threadBWorking);

            threadA.Start();
            threadB.Start();
        }
        private void threadAWorking()
        {
            try
            {
                while (isRuning)
                {
                    if (isAReceive)
                    {
                        try
                        {
                            Invoke(new Action(() =>
                            {
                                // nhận tin nhắn
                                ArriveMessage a = new ArriveMessage();
                                a.setText(aReceive);
                                flowA.Controls.Add(a);
                                scroolPanelToBottom();


                                // tắt nhận
                                isAReceive = false;
                            }));
                        }
                        catch (Exception ex) { }
                    }
                    if (isASend)
                    {
                        try
                        {
                            Invoke(new Action(() =>
                            {
                                // gửi tin nhắn
                                bReceive = tbA.Text;
                                isBReceive = true;

                                SendMessage sendMessage = new SendMessage();
                                sendMessage.setText(tbA.Text);
                                flowA.Controls.Add(sendMessage);
                                scroolPanelToBottom();

                                // xóa text đã gửi
                                tbA.Text = "";
                                // tắt gửi
                                isASend = false;
                            }));
                        }
                        catch (Exception ex) { }
                       
                    }
                }
            }catch(Exception ex) { }
        }
        private void threadBWorking()
        {
            try
            {
                while (isRuning)
                {
                    if (isBReceive)
                    {
                        try
                        {
                            Invoke(new Action(() =>
                            {
                                // nhận tin nhắn
                                ArriveMessage arriveMessage = new ArriveMessage();
                                arriveMessage.setText(bReceive);
                                flowB.Controls.Add(arriveMessage);
                                scroolPanelToBottom();


                                // tắt nhận
                                isBReceive = false;
                            }));
                        }
                        catch (Exception ex) { }
                    }
                    if (isBSend)
                    {
                        try
                        {
                            Invoke(new Action(() =>
                            {
                                // gửi tin nhắn
                                aReceive = tbB.Text;
                                isAReceive = true;

                                SendMessage sendMessage = new SendMessage();
                                sendMessage.setText(tbB.Text);
                                flowB.Controls.Add(sendMessage);
                                scroolPanelToBottom();


                                // xóa text đã gửi
                                tbB.Text = "";

                                // tắt gửi
                                isBSend = false;
                            }));
                        }
                        catch (Exception ex) { }

                    }
                }
            }
            catch (Exception ex) { }
        }
    }
}

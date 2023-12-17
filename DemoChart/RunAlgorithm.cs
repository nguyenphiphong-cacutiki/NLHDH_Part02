using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace DemoChart
{
    public class Process
    {
        public int id { get; set; } = 0;
        public string name { get; set; }
        public int ArrivalTime { get; set; }
        public int BurstTime { get; set; }
        public int CompletionTime { get; set; } = 0;
        public int TurnaroundTime { get; set; }
        public int WaitingTime { get; set; }
        public bool isInQueue { get; set; }
        public int TimeRemain { get; set; }
        public bool isComplete { get; set; } = false;
    }
    internal class RunAlgorithm
    {
        public const int FCFS = 0;
        public const int RR = 1;
        public const int SJF = 2;
        public const int SRTN = 3;

        public static ContainerGantChart CONTAINER = null;
        public static void setContainer(ContainerGantChart container)
        {
            CONTAINER = container;
        }
        public static void runAlgorithm(List<ItemProcess2> itemProcess2s, int mode, int timeQuantum)
        {
            List<Process> processList = new List<Process>();
            foreach (ItemProcess2 itemProcess2 in itemProcess2s)
            {
                Process process = new Process();
                try
                {
                    process.ArrivalTime = itemProcess2.getArrivalTime();
                    process.BurstTime = itemProcess2.getBurstTime();
                    process.TimeRemain = process.BurstTime;
                    process.id = itemProcess2.getID();
                    process.name = itemProcess2.getName();
                }
                catch (Exception)
                {
                    return;
                    throw new Exception();
                }
                processList.Add(process);
            }
            // sắp xếp thời gian đến tăng dần
            for(int i = 0; i < processList.Count - 1; i++)
            {
                for(int j = i + 1; j < processList.Count; j++)
                {
                    if (processList[i].ArrivalTime > processList[j].ArrivalTime)
                    {
                        Process p = processList[i];
                        processList[i] = processList[j];
                        processList[j] = p;
                    }
                }
            }

            switch (mode)
            {
                case FCFS: RunFCFS(processList); break;
                case RR: RunRR(processList, timeQuantum); break;
                case SJF: RunSJF(processList); break;
                case SRTN: RunSRTN(processList); break;
            }
            // ánh xạ lại các process tương tứng
            foreach(Process p in processList)
            {
                itemProcess2s[p.id - 1].setCompletionTime(p.CompletionTime);
                itemProcess2s[p.id - 1].setTurnaroundTime(p.TurnaroundTime);
                itemProcess2s[p.id - 1].setWaitingTime(p.WaitingTime);
            }
            //for (int i = 0; i < processList.Count; i++)
            //{
            //    itemProcess2s.ElementAt(i).setCompletionTime(processList.ElementAt(i).CompletionTime);
            //    itemProcess2s.ElementAt(i).setTurnaroundTime(processList.ElementAt(i).TurnaroundTime);
            //    itemProcess2s.ElementAt(i).setWaitingTime(processList.ElementAt(i).WaitingTime);
            //}
        }
        public static void RunFCFS(List<Process> processes)
        {
            CONTAINER.clearControls();
            int currentTime = 0;
            foreach (var process in processes)
            {
                if (currentTime < process.ArrivalTime)
                {
                    int WaitTime = currentTime; //**edit
                    currentTime = process.ArrivalTime;
                    WaitTime = currentTime - WaitTime;//**edit

                    // gen chart //**edit
                    ItemGantchart itemGantchartWait = new ItemGantchart();
                    itemGantchartWait.setProcessTime(WaitTime);
                    itemGantchartWait.setEndTime(currentTime);
                    itemGantchartWait.setColor(-1);
                    CONTAINER.addItemAtNext(itemGantchartWait);

                }
                // gen chart
                ItemGantchart itemGantchart = new ItemGantchart();
                itemGantchart.setProcessTime(process.TimeRemain);
                itemGantchart.setEndTime(currentTime + process.TimeRemain);
                itemGantchart.setColor(process.id);
                CONTAINER.addItemAtNext(itemGantchart);
                // set up
                process.CompletionTime = currentTime + process.BurstTime;
                process.TurnaroundTime = process.CompletionTime - process.ArrivalTime;
                process.WaitingTime = process.TurnaroundTime - process.BurstTime;

                currentTime = process.CompletionTime;
            }
        }
        public static void RunRR(List<Process> processes, int timeQuantum)
        {
            CONTAINER.clearControls();
            Queue<Process> queue = new Queue<Process>();
            int currentTime = 0;
            int amountCommpleteProccess = 0;
            // nếu tiến trình đầu tiên bắt đầu từ 0 thì thêm vào luôn
            if (processes[0].ArrivalTime == 0)
            {
                queue.Enqueue(processes[0]);
                processes[0].isInQueue = true;
            }
            else
            {
                int WaitTime = currentTime;
                // ngược lại thì dịch current time rồi mới thêm vào
                currentTime = processes[0].ArrivalTime;
                queue.Enqueue(processes[0]);
                processes[0].isInQueue = true;

                WaitTime = currentTime - WaitTime;
                // gen chart //**edit
                ItemGantchart itemGantchartWait = new ItemGantchart();
                itemGantchartWait.setProcessTime(WaitTime);
                itemGantchartWait.setEndTime(currentTime);
                itemGantchartWait.setColor(-1);
                CONTAINER.addItemAtNext(itemGantchartWait);
            }
           
            
            
            while (amountCommpleteProccess < processes.Count)
            {
                
                ItemGantchart itemGantchart = new ItemGantchart();
                itemGantchart.setQueue(queue);
                if(queue.Count > 0)
                {
                    Process p = queue.Dequeue();
                    //MessageBox.Show("Số lượng sau khi dequeue: " + queue.Count);
                    if (p.TimeRemain <= timeQuantum)
                    {
                        // biểu diễn biểu đồ Gant
                        itemGantchart.setProcessTime(p.TimeRemain);
                        itemGantchart.setEndTime(currentTime + p.TimeRemain);
                        itemGantchart.setColor(p.id);
                        CONTAINER.addItemAtNext(itemGantchart);
                        // kết thúc tiến tình này và cập nhật currentTime
                        p.CompletionTime = currentTime + p.TimeRemain;
                        p.TurnaroundTime = p.CompletionTime - p.ArrivalTime;
                        p.WaitingTime = p.TurnaroundTime - p.BurstTime;
                        p.isComplete = true;
                        p.TimeRemain = 0;
                        currentTime = p.CompletionTime;
                        amountCommpleteProccess++;
                        //
                        // cập nhật queue
                        for (int i = 0; i < processes.Count; i++)
                        {
                            if (processes[i].ArrivalTime <= currentTime)
                            {
                                if (processes[i].isInQueue == false)
                                {
                                    queue.Enqueue(processes[i]);
                                    processes[i].isInQueue = true;

                                }
                            }
                        }
                        //MessageBox.Show("if " + queue.Count);
                    }
                    else
                    {
                        // biểu diễn biểu đồ Gant
                        itemGantchart.setProcessTime(timeQuantum);
                        itemGantchart.setEndTime(currentTime + timeQuantum);
                        itemGantchart.setColor(p.id);
                        CONTAINER.addItemAtNext(itemGantchart);
                        // nếu chạy dài hơn thì chạy timequantam, sau đó thêm mới các tiến trình đến 
                        // rồi mới thêm nó vào cuối của queue
                        p.TimeRemain -= timeQuantum;
                        currentTime += timeQuantum;
                        // cập nhật queue
                        for (int i = 0; i < processes.Count; i++)
                        {
                            if (processes[i].ArrivalTime <= currentTime)
                            {
                                if (processes[i].isInQueue == false)
                                {
                                    queue.Enqueue(processes[i]);
                                    processes[i].isInQueue = true;
                                }
                            }
                        }
                        queue.Enqueue(p);
                        //MessageBox.Show("else " + queue.Count);
                    }
                }
                else
                {
                    // cập nhật queue và current time khi bị ngắt quãng
                    for (int i = 0; i < processes.Count; i++)
                    {

                        if (processes[i].isInQueue == false)
                        {
                            int WaitTime = currentTime;
                            // đưa tiến trình tiếp theo vào hàng đợi và cập nhật current time
                            queue.Enqueue(processes[i]);
                            currentTime = processes[i].ArrivalTime;

                            WaitTime = currentTime - WaitTime;

                            // gen chart //**edit
                            ItemGantchart itemGantchartWait = new ItemGantchart();
                            itemGantchartWait.setProcessTime(WaitTime);
                            itemGantchartWait.setEndTime(currentTime);
                            itemGantchartWait.setColor(-1);
                            CONTAINER.addItemAtNext(itemGantchartWait);
                            break;
                        }
                        
                    }
                }
            }





            //processes[i].CompletionTime = currentTime;
            //processes[i].TurnaroundTime = processes[i].CompletionTime - processes[i].ArrivalTime;
            //processes[i].WaitingTime = processes[i].TurnaroundTime - processes[i].BurstTime;
            //remainingTime[i] = 0;

        }
        public static void RunSJF(List<Process> processes)
        {
            CONTAINER.clearControls();
            
            int currentTime = 0;
            int amountCommpleteProccess = 0;
            int queueItemCount = 0;

            // add process to queue
            while (amountCommpleteProccess < processes.Count)
            {
                for (int i = 0; i < processes.Count; i++)
                {
                    if (processes.ElementAt(i).ArrivalTime <= currentTime && processes.ElementAt(i).CompletionTime == 0)
                    {  // chưa chạy)
                        processes.ElementAt(i).isInQueue = true;
                        queueItemCount++;
                        //Console.WriteLine(i);
                    }

                }
                if(queueItemCount > 0)
                {
                    // có tiến trình trong hàng đợi thì chạy
                    // tìm tiến trình nhỏ nhất 
                    int indexMin = 0;
                    for (int i = 0; i < processes.Count; i++)
                    {
                        if (processes.ElementAt(i).isInQueue)
                        {
                            indexMin = i;
                            break;
                        }
                    }
                    for (int i = 0; i < processes.Count; i++)
                    {
                        if (processes.ElementAt(i).isInQueue)
                            if (processes.ElementAt(i).BurstTime < processes.ElementAt(indexMin).BurstTime)
                            {
                                indexMin = i;
                                Console.WriteLine(indexMin);
                            }
                    }
                    // get item Gant
                    ItemGantchart itemGantchart = new ItemGantchart();
                    Process p = processes.ElementAt(indexMin);
                    itemGantchart.setProcessTime(p.TimeRemain);
                    itemGantchart.setEndTime(currentTime + p.TimeRemain);
                    itemGantchart.setColor(p.id);
                    CONTAINER.addItemAtNext(itemGantchart);

                    // set up 
                    currentTime += processes.ElementAt(indexMin).BurstTime;
                    processes.ElementAt(indexMin).CompletionTime = currentTime;
                    processes.ElementAt(indexMin).TurnaroundTime = currentTime - processes.ElementAt(indexMin).ArrivalTime;

                    processes.ElementAt(indexMin).WaitingTime = processes.ElementAt(indexMin).TurnaroundTime - processes.ElementAt(indexMin).BurstTime;
                    processes.ElementAt(indexMin).isInQueue = false;
                    queueItemCount--;
                    amountCommpleteProccess++;
                }
                else
                {
                    // ko có nghĩa là bị ngắt quãng, dịch current time đến tiến trình tiếp theo chưa chạy
                    for (int i = 0; i < processes.Count; i++)
                    {

                        if (processes[i].CompletionTime == 0)
                        {
                            int WaitTime = currentTime;

                            currentTime = processes[i].ArrivalTime;

                            WaitTime = currentTime - WaitTime;

                            // gen chart //**edit
                            ItemGantchart itemGantchartWait = new ItemGantchart();
                            itemGantchartWait.setProcessTime(WaitTime);
                            itemGantchartWait.setEndTime(currentTime);
                            itemGantchartWait.setColor(-1);
                            CONTAINER.addItemAtNext(itemGantchartWait);
                            break;
                        }

                    }

                }

               
            }
        }
        public static void RunSJF_Backup(List<Process> processes)
        {
            int n = processes.Count;
            bool[] completed = new bool[n];
            int currentTime = 0;
            int completedProcesses = 0;

            while (completedProcesses < n)
            {
                int shortestJobIndex = -1;
                int shortestBurstTime = int.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (!completed[i] && processes[i].ArrivalTime <= currentTime && processes[i].BurstTime < shortestBurstTime)
                    {
                        shortestJobIndex = i;
                        shortestBurstTime = processes[i].BurstTime;
                    }
                }

                if (shortestJobIndex == -1)
                {
                    currentTime++;
                    continue;
                }

                Process currentProcess = processes[shortestJobIndex];
                currentProcess.CompletionTime = currentTime + currentProcess.BurstTime;
                currentProcess.TurnaroundTime = currentProcess.CompletionTime - currentProcess.ArrivalTime;
                currentProcess.WaitingTime = currentProcess.TurnaroundTime - currentProcess.BurstTime;
                completed[shortestJobIndex] = true;
                currentTime = currentProcess.CompletionTime;
                completedProcesses++;
            }
        }

        public static void RunSRTN(List<Process> processes)
        {
            CONTAINER.clearControls();
            int currentTime = 0;
            int amountCommpleteProccess = 0;
            int appearProccessIndex = -1;
            int queueItemCount = 0;


            while (amountCommpleteProccess < processes.Count)
            {
                // tìm tiến trình vào
                for (int i = 0; i < processes.Count; i++)
                {
                    if (processes[i].ArrivalTime == currentTime)
                    {
                        processes[i].isInQueue = true;
                        queueItemCount++;
                        appearProccessIndex = i;
                    }

                }

                // nếu trong queue đã có tiến trình thì cạy
                if (queueItemCount > 0)
                {
                    // tìm tiến trình có thời gian còn lại nhỏ nhất đề chạy 
                    int indexMin = 0;
                    // set mặc định cho min
                    for (int i = 0; i < processes.Count; i++)
                    {
                        if (processes[i].isInQueue)
                        {
                            indexMin = i;
                            break;
                        }
                    }
                    // tìm min
                    for (int i = 0; i < processes.Count; i++)
                    {
                        if (processes.ElementAt(i).isInQueue)
                            if (processes[i].TimeRemain < processes[indexMin].TimeRemain)
                            {
                                indexMin = i;
                            }
                    }
                    // tìm thời gian tiến trình min đó chạy
                    ItemGantchart itemGantchart = new ItemGantchart();

                    if (appearProccessIndex < processes.Count - 1)
                    {
                        // vẫn còn tiến trình mới vào
                        if (processes[appearProccessIndex + 1].ArrivalTime < currentTime + processes[indexMin].TimeRemain)
                        {
                            // gen Gant chart
                            Process p = processes.ElementAt(indexMin);
                            itemGantchart.setProcessTime(processes[appearProccessIndex + 1].ArrivalTime - currentTime);
                            itemGantchart.setEndTime(currentTime + processes[appearProccessIndex + 1].ArrivalTime - currentTime);
                            itemGantchart.setColor(p.id);
                            CONTAINER.addItemAtNext(itemGantchart);
                            // tiến trình min chạy đến khi có tiến trình mới vào mà nó vẫn chưa chạy xong
                            processes[indexMin].TimeRemain -= (processes[appearProccessIndex + 1].ArrivalTime - currentTime);
                            currentTime = processes[appearProccessIndex + 1].ArrivalTime;
                        }
                        else //if (processes[appearProccessIndex + 1].ArrivalTime > currentTime + processes[indexMin].TimeRemain)
                        {

                            // gen chart
                            Process p = processes.ElementAt(indexMin);
                            itemGantchart.setProcessTime(p.TimeRemain);
                            itemGantchart.setEndTime(currentTime + p.TimeRemain);
                            itemGantchart.setColor(p.id);
                            CONTAINER.addItemAtNext(itemGantchart);
                            // tiến trình min chạy xong mà không có tiến trình mới vào hoặc đúng lúc có tiến trình mới vào
                            // -> hoàn thành tiến trình min này
                            processes[indexMin].CompletionTime = currentTime + processes[indexMin].TimeRemain;
                            processes[indexMin].TurnaroundTime = processes[indexMin].CompletionTime - processes[indexMin].ArrivalTime;
                            processes[indexMin].WaitingTime = processes[indexMin].TurnaroundTime - processes[indexMin].BurstTime;
                            processes[indexMin].isInQueue = false;
                            queueItemCount--;
                            processes[indexMin].isComplete = true;
                            currentTime = processes[indexMin].CompletionTime;

                            amountCommpleteProccess++;
                        }
                    }
                    else
                    {

                        // gen chart 
                        Process p = processes.ElementAt(indexMin);
                        itemGantchart.setProcessTime(p.TimeRemain);
                        itemGantchart.setEndTime(currentTime + p.TimeRemain);
                        itemGantchart.setColor(p.id);
                        CONTAINER.addItemAtNext(itemGantchart);
                        // không có tiến trình mới nào nữa, thì nó sẽ chạy đến khi hoàn thành luôn
                        processes[indexMin].CompletionTime = currentTime + processes[indexMin].TimeRemain;
                        processes[indexMin].TurnaroundTime = processes[indexMin].CompletionTime - processes[indexMin].ArrivalTime;
                        processes[indexMin].WaitingTime = processes[indexMin].TurnaroundTime - processes[indexMin].BurstTime;
                        processes[indexMin].isInQueue = false;
                        queueItemCount--;
                        processes[indexMin].isComplete = true;
                        currentTime = processes[indexMin].CompletionTime;

                        amountCommpleteProccess++;
                    }
                }
                else
                {
                    int WaitTime = currentTime;
                    // ngược lại thì dịch chuyển current time đến tiến trình tiếp theo
                    currentTime = processes[appearProccessIndex + 1].ArrivalTime;

                    // 
                    WaitTime = currentTime - WaitTime;


                    // gen chart //**edit
                    ItemGantchart itemGantchartWait = new ItemGantchart();
                    itemGantchartWait.setProcessTime(WaitTime);
                    itemGantchartWait.setEndTime(currentTime);
                    itemGantchartWait.setColor(-1);
                    CONTAINER.addItemAtNext(itemGantchartWait);

                }
            }


        }
        public static void RunSRTN_Backup(List<Process> processes)
        {
            int n = processes.Count;
            bool[] completed = new bool[n];
            int currentTime = 0;
            int completedProcesses = 0;

            while (completedProcesses < n)
            {
                int shortestJobIndex = -1;
                int shortestRemainingTime = int.MaxValue;

                for (int i = 0; i < n; i++)
                {
                    if (!completed[i] && processes[i].ArrivalTime <= currentTime && processes[i].BurstTime < shortestRemainingTime)
                    {
                        shortestJobIndex = i;
                        shortestRemainingTime = processes[i].BurstTime;
                    }
                }

                if (shortestJobIndex == -1)
                {
                    currentTime++;
                    continue;
                }

                Process currentProcess = processes[shortestJobIndex];
                currentProcess.BurstTime--; // Giảm thời gian sử dụng CPU của tiến trình hiện tại đi 1 đơn vị
                currentTime++;

                if (currentProcess.BurstTime == 0)
                {
                    currentProcess.CompletionTime = currentTime;
                    currentProcess.TurnaroundTime = currentProcess.CompletionTime - currentProcess.ArrivalTime;
                    currentProcess.WaitingTime = currentProcess.TurnaroundTime - currentProcess.BurstTime;
                    completed[shortestJobIndex] = true;
                    completedProcesses++;
                }
            }
        }

    }
}

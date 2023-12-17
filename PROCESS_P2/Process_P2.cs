using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROCESS_P2
{
    public partial class Process_P2 : Form
    {
        /*private void InitializeChart()
        {
            // Tạo Series cho Chart
            Series memoryUsageSeries = new Series("MemoryUsage");
            Series cpuUsageSeries = new Series("CpuUsage");

            // Thêm Series vào Chart
            chart1.Series.Add(memoryUsageSeries);
            chart1.Series.Add(cpuUsageSeries);

            // Đặt kiểu đồ thị
            memoryUsageSeries.ChartType = SeriesChartType.Column;
            cpuUsageSeries.ChartType = SeriesChartType.Column;

            // Đặt màu sắc cho các cột
            memoryUsageSeries.Color = System.Drawing.Color.Blue;
            cpuUsageSeries.Color = System.Drawing.Color.Red;
        }*/

        public Process_P2()
        {
            InitializeComponent();
            comboBoxApplications.Items.Add("Notepad");
            comboBoxApplications.Items.Add("Chrome");
            comboBoxApplications.Items.Add("Explorer");

            // Initialize the chart
        //    InitializeChart();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GetAndDisplayAllProcessesInfo();
            //GetAndDisplayChromeProcessesInfoChart();
        }

        private void GetAndDisplayAllProcessesInfo()
        {
            Process[] processes = Process.GetProcesses();

            foreach (Process process in processes)
            {
                try
                {
                    // Cố gắng lấy thông tin của tiến trình
                    ProcessInfoControl processInfoControl = new ProcessInfoControl(process);
                    flowLayoutPanelProcesses.Controls.Add(processInfoControl);
                }
                catch (Exception ex)
                {
                    // Nếu có lỗi quyền truy cập, bạn có thể xử lý ở đây (ví dụ: bỏ qua hoặc ghi log)
                    Console.WriteLine($"Lỗi khi truy cập tiến trình {process.ProcessName}: {ex.Message}");
                }
            }
        }


        private void comboBoxApplications_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lấy tên ứng dụng được chọn từ ComboBox
            string selectedAppName = comboBoxApplications.SelectedItem as string;

            if (!string.IsNullOrEmpty(selectedAppName))
            {
                String name = null;
                if (selectedAppName.Trim() == "Chrome") name = "chrome.exe";
                else if (selectedAppName.Trim() == "Notepad") name = "notepad.exe";
                else if (selectedAppName.Trim() == "Explorer") name = "explorer.exe";
                // Thực hiện tạo và mở tiến trình mới với ứng dụng đã chọn
                CreateAndOpenNewProcess(name);
            }
        }

        private void CreateAndOpenNewProcess(string applicationName)
        {
            try
            {
                // Tạo một tiến trình mới
                Process newProcess = new Process();

                // Đặt đường dẫn tới ứng dụng bạn muốn mở
                newProcess.StartInfo.FileName = applicationName;

                // Khởi động tiến trình
                newProcess.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi khi tạo và mở tiến trình mới: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*private void GetAndDisplayChromeProcessesInfoChart()
        {
            Process[] processes = Process.GetProcessesByName("chrome");

            foreach (Process process in processes)
            {
                // Thêm dữ liệu của tiến trình vào Series của Chart
                chart1.Series["MemoryUsage"].Points.AddXY(process.ProcessName, process.WorkingSet64 / 1024);
                chart1.Series["CpuUsage"].Points.AddXY(process.ProcessName, process.TotalProcessorTime.TotalSeconds);
            }

            // Tùy chỉnh thêm để đảm bảo dữ liệu hiển thị đẹp mắt
            CustomizeChart();
        }

        private void CustomizeChart()
        {
            // Tùy chỉnh đồ thị để đảm bảo dữ liệu hiển thị đẹp mắt
            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = -45;
            chart1.ChartAreas[0].AxisX.Interval = 1;
            chart1.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chart1.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;

            // Đặt tên cho các trục và đồ thị
            chart1.ChartAreas[0].AxisX.Title = "Process";
            chart1.ChartAreas[0].AxisY.Title = "Usage";

            // Đặt tên cho các series
            chart1.Series["MemoryUsage"].Name = "MemoryUsage";
            chart1.Series["CpuUsage"].Name = "CpuUsage";

            chart1.Series["MemoryUsage"].LegendText = "Memory Usage (KB)";
            chart1.Series["CpuUsage"].LegendText = "CPU Usage (s)";
        }*/
    }
}

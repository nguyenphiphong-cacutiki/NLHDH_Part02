using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PROCESS_P2
{
    public partial class Process_P2 : Form
    {
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
    }
}

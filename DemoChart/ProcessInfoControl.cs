using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROCESS_P2
{
    public partial class ProcessInfoControl : UserControl
    {
        public ProcessInfoControl(Process process)
        {
            InitializeComponent();
            labelProcessId.Text = process.Id.ToString();
            labelProcessName.Text = process.ProcessName;
            labelProcessStartTime.Text = $"{process.StartTime}";
            labelProcessMemoryUsage.Text = $"{process.WorkingSet64 / 1024} KB";
            labelProcessCPUsage.Text = $"{process.TotalProcessorTime.TotalSeconds:F2} s";           
        }
    }
}

namespace PROCESS_P2
{
    partial class ProcessInfoControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labelProcessCPUsage = new System.Windows.Forms.Label();
            this.labelProcessMemoryUsage = new System.Windows.Forms.Label();
            this.labelProcessStartTime = new System.Windows.Forms.Label();
            this.labelProcessName = new System.Windows.Forms.Label();
            this.labelProcessId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.labelProcessCPUsage, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProcessMemoryUsage, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProcessStartTime, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProcessName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelProcessId, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1098, 46);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // labelProcessCPUsage
            // 
            this.labelProcessCPUsage.AutoSize = true;
            this.labelProcessCPUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessCPUsage.Location = new System.Drawing.Point(879, 0);
            this.labelProcessCPUsage.Name = "labelProcessCPUsage";
            this.labelProcessCPUsage.Size = new System.Drawing.Size(216, 46);
            this.labelProcessCPUsage.TabIndex = 4;
            this.labelProcessCPUsage.Text = "label5";
            this.labelProcessCPUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessMemoryUsage
            // 
            this.labelProcessMemoryUsage.AutoSize = true;
            this.labelProcessMemoryUsage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessMemoryUsage.Location = new System.Drawing.Point(660, 0);
            this.labelProcessMemoryUsage.Name = "labelProcessMemoryUsage";
            this.labelProcessMemoryUsage.Size = new System.Drawing.Size(213, 46);
            this.labelProcessMemoryUsage.TabIndex = 3;
            this.labelProcessMemoryUsage.Text = "label4";
            this.labelProcessMemoryUsage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessStartTime
            // 
            this.labelProcessStartTime.AutoSize = true;
            this.labelProcessStartTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessStartTime.Location = new System.Drawing.Point(441, 0);
            this.labelProcessStartTime.Name = "labelProcessStartTime";
            this.labelProcessStartTime.Size = new System.Drawing.Size(213, 46);
            this.labelProcessStartTime.TabIndex = 2;
            this.labelProcessStartTime.Text = "label3";
            this.labelProcessStartTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessName
            // 
            this.labelProcessName.AutoSize = true;
            this.labelProcessName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessName.Location = new System.Drawing.Point(222, 0);
            this.labelProcessName.Name = "labelProcessName";
            this.labelProcessName.Size = new System.Drawing.Size(213, 46);
            this.labelProcessName.TabIndex = 1;
            this.labelProcessName.Text = "label2";
            this.labelProcessName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelProcessId
            // 
            this.labelProcessId.AutoSize = true;
            this.labelProcessId.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelProcessId.Location = new System.Drawing.Point(3, 0);
            this.labelProcessId.Name = "labelProcessId";
            this.labelProcessId.Size = new System.Drawing.Size(213, 46);
            this.labelProcessId.TabIndex = 0;
            this.labelProcessId.Text = "label1";
            this.labelProcessId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ProcessInfoControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "ProcessInfoControl";
            this.Size = new System.Drawing.Size(1098, 46);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelProcessCPUsage;
        private System.Windows.Forms.Label labelProcessMemoryUsage;
        private System.Windows.Forms.Label labelProcessStartTime;
        private System.Windows.Forms.Label labelProcessName;
        private System.Windows.Forms.Label labelProcessId;
    }
}

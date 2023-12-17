namespace DemoChart
{
    partial class ItemProcess2
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbBurstTime = new System.Windows.Forms.TextBox();
            this.tbArrivalTime = new System.Windows.Forms.TextBox();
            this.lbWaitingTime = new System.Windows.Forms.Label();
            this.lbTurnaroundTime = new System.Windows.Forms.Label();
            this.lbCompletionTime = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.btnDelete);
            this.panel2.Controls.Add(this.tbBurstTime);
            this.panel2.Controls.Add(this.tbArrivalTime);
            this.panel2.Controls.Add(this.lbWaitingTime);
            this.panel2.Controls.Add(this.lbTurnaroundTime);
            this.panel2.Controls.Add(this.lbCompletionTime);
            this.panel2.Controls.Add(this.lbName);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(928, 51);
            this.panel2.TabIndex = 2;
            // 
            // tbBurstTime
            // 
            this.tbBurstTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbBurstTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbBurstTime.Location = new System.Drawing.Point(300, 11);
            this.tbBurstTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbBurstTime.Name = "tbBurstTime";
            this.tbBurstTime.Size = new System.Drawing.Size(115, 28);
            this.tbBurstTime.TabIndex = 7;
            this.tbBurstTime.Text = "10";
            this.tbBurstTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbArrivalTime
            // 
            this.tbArrivalTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbArrivalTime.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.tbArrivalTime.Location = new System.Drawing.Point(142, 12);
            this.tbArrivalTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbArrivalTime.Name = "tbArrivalTime";
            this.tbArrivalTime.Size = new System.Drawing.Size(115, 28);
            this.tbArrivalTime.TabIndex = 6;
            this.tbArrivalTime.Text = "10";
            this.tbArrivalTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbWaitingTime
            // 
            this.lbWaitingTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbWaitingTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbWaitingTime.Location = new System.Drawing.Point(742, 3);
            this.lbWaitingTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbWaitingTime.Name = "lbWaitingTime";
            this.lbWaitingTime.Size = new System.Drawing.Size(123, 42);
            this.lbWaitingTime.TabIndex = 5;
            this.lbWaitingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbTurnaroundTime
            // 
            this.lbTurnaroundTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbTurnaroundTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbTurnaroundTime.Location = new System.Drawing.Point(585, 3);
            this.lbTurnaroundTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTurnaroundTime.Name = "lbTurnaroundTime";
            this.lbTurnaroundTime.Size = new System.Drawing.Size(123, 42);
            this.lbTurnaroundTime.TabIndex = 4;
            this.lbTurnaroundTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbCompletionTime
            // 
            this.lbCompletionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbCompletionTime.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbCompletionTime.Location = new System.Drawing.Point(429, 3);
            this.lbCompletionTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCompletionTime.Name = "lbCompletionTime";
            this.lbCompletionTime.Size = new System.Drawing.Size(123, 42);
            this.lbCompletionTime.TabIndex = 3;
            this.lbCompletionTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbName
            // 
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lbName.Location = new System.Drawing.Point(3, 3);
            this.lbName.Margin = new System.Windows.Forms.Padding(0);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(123, 42);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Tiến trình 1";
            this.lbName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(872, 8);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(51, 36);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "X";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ItemProcess2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "ItemProcess2";
            this.Size = new System.Drawing.Size(926, 51);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbWaitingTime;
        private System.Windows.Forms.Label lbTurnaroundTime;
        private System.Windows.Forms.Label lbCompletionTime;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbBurstTime;
        private System.Windows.Forms.TextBox tbArrivalTime;
        private System.Windows.Forms.Button btnDelete;
    }
}

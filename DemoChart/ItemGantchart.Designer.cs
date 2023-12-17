namespace DemoChart
{
    partial class ItemGantchart
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
            this.TimeStart = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbQueue = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimeStart
            // 
            this.TimeStart.AutoSize = true;
            this.TimeStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimeStart.Location = new System.Drawing.Point(2, 2);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(14, 13);
            this.TimeStart.TabIndex = 0;
            this.TimeStart.Text = "0";
            this.TimeStart.Visible = false;
            // 
            // TimeEnd
            // 
            this.TimeEnd.AutoSize = true;
            this.TimeEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.TimeEnd.Location = new System.Drawing.Point(132, 2);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(21, 13);
            this.TimeEnd.TabIndex = 1;
            this.TimeEnd.Text = "10";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(-1, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(152, 12);
            this.panel1.TabIndex = 2;
            // 
            // lbQueue
            // 
            this.lbQueue.AutoSize = true;
            this.lbQueue.Location = new System.Drawing.Point(-1, 32);
            this.lbQueue.Name = "lbQueue";
            this.lbQueue.Size = new System.Drawing.Size(0, 13);
            this.lbQueue.TabIndex = 3;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lbName.Location = new System.Drawing.Point(58, 2);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(36, 13);
            this.lbName.TabIndex = 4;
            this.lbName.Text = "P100";
            // 
            // ItemGantchart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.lbQueue);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.TimeStart);
            this.Name = "ItemGantchart";
            this.Size = new System.Drawing.Size(151, 50);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TimeStart;
        private System.Windows.Forms.Label TimeEnd;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbQueue;
        private System.Windows.Forms.Label lbName;
    }
}

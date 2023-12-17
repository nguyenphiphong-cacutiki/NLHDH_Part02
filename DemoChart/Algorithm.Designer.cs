namespace DemoChart
{
    partial class Algorithm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.btFCFS = new System.Windows.Forms.Button();
            this.btRR = new System.Windows.Forms.Button();
            this.btSJF = new System.Windows.Forms.Button();
            this.btSRTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.flowContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btAddProcess = new System.Windows.Forms.Button();
            this.tbTextResult = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbTimeq = new System.Windows.Forms.Label();
            this.txtTimeq = new System.Windows.Forms.TextBox();
            this.lbms = new System.Windows.Forms.Label();
            this.btnRandom = new System.Windows.Forms.Button();
            this.containerGantChart1 = new DemoChart.ContainerGantChart();
            this.itemProcess1 = new DemoChart.ItemProcess();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(423, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thuật toán";
            // 
            // btFCFS
            // 
            this.btFCFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btFCFS.ForeColor = System.Drawing.Color.Red;
            this.btFCFS.Location = new System.Drawing.Point(52, 83);
            this.btFCFS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btFCFS.Name = "btFCFS";
            this.btFCFS.Size = new System.Drawing.Size(141, 57);
            this.btFCFS.TabIndex = 1;
            this.btFCFS.Text = "FCFS";
            this.btFCFS.UseVisualStyleBackColor = true;
            this.btFCFS.Click += new System.EventHandler(this.buttonAlgorithmClick);
            // 
            // btRR
            // 
            this.btRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btRR.ForeColor = System.Drawing.Color.Red;
            this.btRR.Location = new System.Drawing.Point(300, 83);
            this.btRR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btRR.Name = "btRR";
            this.btRR.Size = new System.Drawing.Size(141, 57);
            this.btRR.TabIndex = 2;
            this.btRR.Text = "RR";
            this.btRR.UseVisualStyleBackColor = true;
            this.btRR.Click += new System.EventHandler(this.buttonAlgorithmClick);
            // 
            // btSJF
            // 
            this.btSJF.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSJF.ForeColor = System.Drawing.Color.Red;
            this.btSJF.Location = new System.Drawing.Point(548, 83);
            this.btSJF.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSJF.Name = "btSJF";
            this.btSJF.Size = new System.Drawing.Size(141, 57);
            this.btSJF.TabIndex = 3;
            this.btSJF.Text = "SJF";
            this.btSJF.UseVisualStyleBackColor = true;
            this.btSJF.Click += new System.EventHandler(this.buttonAlgorithmClick);
            // 
            // btSRTN
            // 
            this.btSRTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btSRTN.ForeColor = System.Drawing.Color.Red;
            this.btSRTN.Location = new System.Drawing.Point(795, 83);
            this.btSRTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btSRTN.Name = "btSRTN";
            this.btSRTN.Size = new System.Drawing.Size(141, 57);
            this.btSRTN.TabIndex = 4;
            this.btSRTN.Text = "SRTN";
            this.btSRTN.UseVisualStyleBackColor = true;
            this.btSRTN.Click += new System.EventHandler(this.buttonAlgorithmClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(45, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(334, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Thuật toán sử dụng: ";
            // 
            // flowContainer
            // 
            this.flowContainer.AutoScroll = true;
            this.flowContainer.Location = new System.Drawing.Point(52, 438);
            this.flowContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowContainer.Name = "flowContainer";
            this.flowContainer.Size = new System.Drawing.Size(932, 254);
            this.flowContainer.TabIndex = 6;
            // 
            // btAddProcess
            // 
            this.btAddProcess.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btAddProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btAddProcess.ForeColor = System.Drawing.Color.Lime;
            this.btAddProcess.Location = new System.Drawing.Point(181, 276);
            this.btAddProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btAddProcess.Name = "btAddProcess";
            this.btAddProcess.Size = new System.Drawing.Size(260, 62);
            this.btAddProcess.TabIndex = 7;
            this.btAddProcess.Text = "Thêm tiến trình";
            this.btAddProcess.UseVisualStyleBackColor = false;
            this.btAddProcess.Click += new System.EventHandler(this.btAddProcess_Click);
            // 
            // tbTextResult
            // 
            this.tbTextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.tbTextResult.Location = new System.Drawing.Point(54, 853);
            this.tbTextResult.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTextResult.Name = "tbTextResult";
            this.tbTextResult.ReadOnly = true;
            this.tbTextResult.Size = new System.Drawing.Size(882, 35);
            this.tbTextResult.TabIndex = 8;
            this.tbTextResult.Text = "Kết quả: ";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(392, 191);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 57);
            this.button1.TabIndex = 10;
            this.button1.Text = "FCFS";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // lbTimeq
            // 
            this.lbTimeq.AutoSize = true;
            this.lbTimeq.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTimeq.Location = new System.Drawing.Point(554, 209);
            this.lbTimeq.Name = "lbTimeq";
            this.lbTimeq.Size = new System.Drawing.Size(153, 25);
            this.lbTimeq.TabIndex = 11;
            this.lbTimeq.Text = "Time Quantum: ";
            // 
            // txtTimeq
            // 
            this.txtTimeq.Location = new System.Drawing.Point(732, 209);
            this.txtTimeq.Name = "txtTimeq";
            this.txtTimeq.Size = new System.Drawing.Size(100, 26);
            this.txtTimeq.TabIndex = 12;
            this.txtTimeq.TextChanged += new System.EventHandler(this.txtTimeq_TextChanged);
            // 
            // lbms
            // 
            this.lbms.AutoSize = true;
            this.lbms.Location = new System.Drawing.Point(567, 251);
            this.lbms.Name = "lbms";
            this.lbms.Size = new System.Drawing.Size(51, 20);
            this.lbms.TabIndex = 13;
            this.lbms.Text = "label3";
            // 
            // btnRandom
            // 
            this.btnRandom.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnRandom.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnRandom.ForeColor = System.Drawing.Color.Lime;
            this.btnRandom.Location = new System.Drawing.Point(548, 276);
            this.btnRandom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRandom.Name = "btnRandom";
            this.btnRandom.Size = new System.Drawing.Size(260, 62);
            this.btnRandom.TabIndex = 16;
            this.btnRandom.Text = "Random";
            this.btnRandom.UseVisualStyleBackColor = false;
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // containerGantChart1
            // 
            this.containerGantChart1.AutoScroll = true;
            this.containerGantChart1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.containerGantChart1.Location = new System.Drawing.Point(54, 716);
            this.containerGantChart1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.containerGantChart1.Name = "containerGantChart1";
            this.containerGantChart1.Size = new System.Drawing.Size(884, 108);
            this.containerGantChart1.TabIndex = 14;
            // 
            // itemProcess1
            // 
            this.itemProcess1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.itemProcess1.Location = new System.Drawing.Point(52, 343);
            this.itemProcess1.Margin = new System.Windows.Forms.Padding(0);
            this.itemProcess1.Name = "itemProcess1";
            this.itemProcess1.Size = new System.Drawing.Size(872, 91);
            this.itemProcess1.TabIndex = 9;
            // 
            // Algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 903);
            this.Controls.Add(this.btnRandom);
            this.Controls.Add(this.containerGantChart1);
            this.Controls.Add(this.lbms);
            this.Controls.Add(this.txtTimeq);
            this.Controls.Add(this.lbTimeq);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.itemProcess1);
            this.Controls.Add(this.tbTextResult);
            this.Controls.Add(this.btAddProcess);
            this.Controls.Add(this.flowContainer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSRTN);
            this.Controls.Add(this.btSJF);
            this.Controls.Add(this.btRR);
            this.Controls.Add(this.btFCFS);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Algorithm";
            this.Text = "Algorithm";
            this.Load += new System.EventHandler(this.Algorithm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btFCFS;
        private System.Windows.Forms.Button btRR;
        private System.Windows.Forms.Button btSJF;
        private System.Windows.Forms.Button btSRTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowContainer;
        private System.Windows.Forms.Button btAddProcess;
        private System.Windows.Forms.TextBox tbTextResult;
        private ItemProcess itemProcess1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbTimeq;
        private System.Windows.Forms.TextBox txtTimeq;
        private System.Windows.Forms.Label lbms;
        private ContainerGantChart containerGantChart1;
        private System.Windows.Forms.Button btnRandom;
    }
}
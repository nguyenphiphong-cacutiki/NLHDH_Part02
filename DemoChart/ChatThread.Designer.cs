namespace DemoChart
{
    partial class ChatThread
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btSendA = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbA = new System.Windows.Forms.TextBox();
            this.flowA = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btSendB = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbB = new System.Windows.Forms.TextBox();
            this.flowB = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btSendA);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbA);
            this.groupBox1.Controls.Add(this.flowA);
            this.groupBox1.Location = new System.Drawing.Point(26, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(295, 340);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Luồng A";
            // 
            // btSendA
            // 
            this.btSendA.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSendA.Location = new System.Drawing.Point(3, 316);
            this.btSendA.Name = "btSendA";
            this.btSendA.Size = new System.Drawing.Size(289, 23);
            this.btSendA.TabIndex = 3;
            this.btSendA.Text = "Gửi";
            this.btSendA.UseVisualStyleBackColor = true;
            this.btSendA.Click += new System.EventHandler(this.btSendA_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 276);
            this.label1.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 40);
            this.label1.TabIndex = 2;
            // 
            // tbA
            // 
            this.tbA.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbA.Location = new System.Drawing.Point(3, 256);
            this.tbA.Name = "tbA";
            this.tbA.Size = new System.Drawing.Size(289, 20);
            this.tbA.TabIndex = 1;
            // 
            // flowA
            // 
            this.flowA.AutoScroll = true;
            this.flowA.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowA.Location = new System.Drawing.Point(3, 16);
            this.flowA.Name = "flowA";
            this.flowA.Size = new System.Drawing.Size(289, 240);
            this.flowA.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btSendB);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbB);
            this.groupBox2.Controls.Add(this.flowB);
            this.groupBox2.Location = new System.Drawing.Point(340, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(296, 340);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Luồng B";
            // 
            // btSendB
            // 
            this.btSendB.Dock = System.Windows.Forms.DockStyle.Top;
            this.btSendB.Location = new System.Drawing.Point(3, 316);
            this.btSendB.Name = "btSendB";
            this.btSendB.Size = new System.Drawing.Size(290, 23);
            this.btSendB.TabIndex = 7;
            this.btSendB.Text = "gửi";
            this.btSendB.UseVisualStyleBackColor = true;
            this.btSendB.Click += new System.EventHandler(this.btSendB_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(3, 276);
            this.label2.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(290, 40);
            this.label2.TabIndex = 6;
            // 
            // tbB
            // 
            this.tbB.Dock = System.Windows.Forms.DockStyle.Top;
            this.tbB.Location = new System.Drawing.Point(3, 256);
            this.tbB.Name = "tbB";
            this.tbB.Size = new System.Drawing.Size(290, 20);
            this.tbB.TabIndex = 5;
            // 
            // flowB
            // 
            this.flowB.AutoScroll = true;
            this.flowB.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowB.Location = new System.Drawing.Point(3, 16);
            this.flowB.Name = "flowB";
            this.flowB.Size = new System.Drawing.Size(290, 240);
            this.flowB.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 364);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbA;
        private System.Windows.Forms.FlowLayoutPanel flowA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btSendA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSendB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbB;
        private System.Windows.Forms.FlowLayoutPanel flowB;
    }
}


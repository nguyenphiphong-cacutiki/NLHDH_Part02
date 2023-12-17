namespace DemoChart
{
    partial class ArriveMessage
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
            this.text = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.BackColor = System.Drawing.Color.HotPink;
            this.text.Dock = System.Windows.Forms.DockStyle.Left;
            this.text.Location = new System.Drawing.Point(0, 0);
            this.text.MaximumSize = new System.Drawing.Size(180, 100);
            this.text.Name = "text";
            this.text.Padding = new System.Windows.Forms.Padding(3);
            this.text.Size = new System.Drawing.Size(41, 19);
            this.text.TabIndex = 0;
            this.text.Text = "label1";
            this.text.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ArriveMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.text);
            this.MaximumSize = new System.Drawing.Size(260, 100);
            this.MinimumSize = new System.Drawing.Size(260, 20);
            this.Name = "ArriveMessage";
            this.Size = new System.Drawing.Size(260, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label text;
    }
}

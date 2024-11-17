namespace ThreadPriority
{
    partial class frmTrackThread
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblThread = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // lblThread
            // 
            lblThread.AutoSize = true;
            lblThread.Font = new Font("Tahoma", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblThread.Location = new Point(86, 72);
            lblThread.Name = "lblThread";
            lblThread.Size = new Size(146, 25);
            lblThread.TabIndex = 0;
            lblThread.Text = "-Thread Start-";
            // 
            // button1
            // 
            button1.Font = new Font("Tahoma", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(103, 143);
            button1.Name = "button1";
            button1.Size = new Size(109, 30);
            button1.TabIndex = 1;
            button1.Text = "Run";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // frmTrackThread
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(347, 234);
            Controls.Add(button1);
            Controls.Add(lblThread);
            Name = "frmTrackThread";
            Text = "frmTrackThread";
            Load += frmTrackThread_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblThread;
        private Button button1;
    }
}

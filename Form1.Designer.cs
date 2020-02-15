namespace Kylggr
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.lbl_RunningProcess = new System.Windows.Forms.Label();
            this.tmr_ActiveWindow = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_RunningProcess
            // 
            this.lbl_RunningProcess.AutoSize = true;
            this.lbl_RunningProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lbl_RunningProcess.Location = new System.Drawing.Point(12, 9);
            this.lbl_RunningProcess.Name = "lbl_RunningProcess";
            this.lbl_RunningProcess.Size = new System.Drawing.Size(109, 39);
            this.lbl_RunningProcess.TabIndex = 0;
            this.lbl_RunningProcess.Text = "label1";
            // 
            // tmr_ActiveWindow
            // 
            this.tmr_ActiveWindow.Enabled = true;
            this.tmr_ActiveWindow.Interval = 10;
            this.tmr_ActiveWindow.Tick += new System.EventHandler(this.tmr_ActiveWindow_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 61);
            this.Controls.Add(this.lbl_RunningProcess);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_RunningProcess;
        private System.Windows.Forms.Timer tmr_ActiveWindow;
    }
}


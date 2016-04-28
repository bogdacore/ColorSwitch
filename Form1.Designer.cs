namespace ColorSwitch
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
            this.pbBall = new System.Windows.Forms.PictureBox();
            this.timerMove = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerHit = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).BeginInit();
            this.SuspendLayout();
            // 
            // pbBall
            // 
            this.pbBall.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pbBall.Location = new System.Drawing.Point(0, 0);
            this.pbBall.Name = "pbBall";
            this.pbBall.Size = new System.Drawing.Size(24, 22);
            this.pbBall.TabIndex = 0;
            this.pbBall.TabStop = false;
            // 
            // timerMove
            // 
            this.timerMove.Interval = 1;
            this.timerMove.Tick += new System.EventHandler(this.timerMove_Tick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(77, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(100, 12);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // timerHit
            // 
            this.timerHit.Interval = 1;
            this.timerHit.Tick += new System.EventHandler(this.timerHit_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbBall);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Switch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbBall)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbBall;
        private System.Windows.Forms.Timer timerMove;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerHit;
    }
}


namespace Svetofar
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
            this.red_btn = new System.Windows.Forms.Button();
            this.yellow_btn = new System.Windows.Forms.Button();
            this.green_btn = new System.Windows.Forms.Button();
            this.control_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.myTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // red_btn
            // 
            this.red_btn.Location = new System.Drawing.Point(15, 16);
            this.red_btn.Name = "red_btn";
            this.red_btn.Size = new System.Drawing.Size(75, 58);
            this.red_btn.TabIndex = 0;
            this.red_btn.UseVisualStyleBackColor = true;
            this.red_btn.Click += new System.EventHandler(this.redbutton_Click);
            // 
            // yellow_btn
            // 
            this.yellow_btn.Location = new System.Drawing.Point(15, 80);
            this.yellow_btn.Name = "yellow_btn";
            this.yellow_btn.Size = new System.Drawing.Size(75, 58);
            this.yellow_btn.TabIndex = 1;
            this.yellow_btn.UseVisualStyleBackColor = true;
            // 
            // green_btn
            // 
            this.green_btn.Location = new System.Drawing.Point(15, 144);
            this.green_btn.Name = "green_btn";
            this.green_btn.Size = new System.Drawing.Size(75, 63);
            this.green_btn.TabIndex = 2;
            this.green_btn.UseVisualStyleBackColor = true;
            // 
            // control_btn
            // 
            this.control_btn.Location = new System.Drawing.Point(112, 264);
            this.control_btn.Name = "control_btn";
            this.control_btn.Size = new System.Drawing.Size(75, 23);
            this.control_btn.TabIndex = 3;
            this.control_btn.Text = "START";
            this.control_btn.UseVisualStyleBackColor = true;
            this.control_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.red_btn);
            this.panel1.Controls.Add(this.yellow_btn);
            this.panel1.Controls.Add(this.green_btn);
            this.panel1.Location = new System.Drawing.Point(97, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(106, 224);
            this.panel1.TabIndex = 4;
            // 
            // myTimer
            // 
            this.myTimer.Interval = 1;
            this.myTimer.Tick += new System.EventHandler(this.myTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.control_btn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button red_btn;
        private System.Windows.Forms.Button yellow_btn;
        private System.Windows.Forms.Button green_btn;
        private System.Windows.Forms.Button control_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer myTimer;
    }
}


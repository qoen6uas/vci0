namespace abctest
{
    partial class Form2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHELLO = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLOGOUT = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnUDELETE = new System.Windows.Forms.Button();
            this.btnUUPDATE = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateBlue;
            this.panel1.Controls.Add(this.lblHELLO);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnLOGOUT);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(153, 418);
            this.panel1.TabIndex = 12;
            // 
            // lblHELLO
            // 
            this.lblHELLO.AutoSize = true;
            this.lblHELLO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblHELLO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHELLO.Location = new System.Drawing.Point(17, 133);
            this.lblHELLO.Name = "lblHELLO";
            this.lblHELLO.Size = new System.Drawing.Size(120, 18);
            this.lblHELLO.TabIndex = 15;
            this.lblHELLO.Text = "Welcome User";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::abctest.Properties.Resources.최종_로고_____________removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(3, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnLOGOUT
            // 
            this.btnLOGOUT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnLOGOUT.Location = new System.Drawing.Point(10, 372);
            this.btnLOGOUT.Name = "btnLOGOUT";
            this.btnLOGOUT.Size = new System.Drawing.Size(134, 22);
            this.btnLOGOUT.TabIndex = 13;
            this.btnLOGOUT.Text = "로그아웃";
            this.btnLOGOUT.UseVisualStyleBackColor = true;
            this.btnLOGOUT.Click += new System.EventHandler(this.btnLOGOUT_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(178, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "사용자 모니터링";
            // 
            // btnUDELETE
            // 
            this.btnUDELETE.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUDELETE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUDELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUDELETE.ForeColor = System.Drawing.Color.White;
            this.btnUDELETE.Location = new System.Drawing.Point(604, 351);
            this.btnUDELETE.Name = "btnUDELETE";
            this.btnUDELETE.Size = new System.Drawing.Size(122, 29);
            this.btnUDELETE.TabIndex = 18;
            this.btnUDELETE.Text = "사용자 삭제";
            this.btnUDELETE.UseVisualStyleBackColor = false;
            this.btnUDELETE.Click += new System.EventHandler(this.btnUDELETE_Click);
            // 
            // btnUUPDATE
            // 
            this.btnUUPDATE.BackColor = System.Drawing.Color.SlateBlue;
            this.btnUUPDATE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUUPDATE.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnUUPDATE.ForeColor = System.Drawing.Color.White;
            this.btnUUPDATE.Location = new System.Drawing.Point(468, 351);
            this.btnUUPDATE.Name = "btnUUPDATE";
            this.btnUUPDATE.Size = new System.Drawing.Size(122, 29);
            this.btnUUPDATE.TabIndex = 19;
            this.btnUUPDATE.Text = "사용자 수정";
            this.btnUUPDATE.UseVisualStyleBackColor = false;
            this.btnUUPDATE.Click += new System.EventHandler(this.btnUUPDATE_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(183, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(583, 278);
            this.flowLayoutPanel1.TabIndex = 20;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(788, 418);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btnUUPDATE);
            this.Controls.Add(this.btnUDELETE);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLOGOUT;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblHELLO;
        private System.Windows.Forms.Button btnUDELETE;
        private System.Windows.Forms.Button btnUUPDATE;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer1;
    }
}
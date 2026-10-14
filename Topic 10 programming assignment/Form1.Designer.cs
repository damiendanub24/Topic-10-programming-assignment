namespace Topic_10_programming_assignment
{
    partial class Computerinfo
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
            this.btnCPU = new System.Windows.Forms.Button();
            this.btnRAM = new System.Windows.Forms.Button();
            this.btnSSD = new System.Windows.Forms.Button();
            this.btnPSU = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.btnOP = new System.Windows.Forms.Button();
            this.imgRAM = new System.Windows.Forms.PictureBox();
            this.imgCPU = new System.Windows.Forms.PictureBox();
            this.imgPSU = new System.Windows.Forms.PictureBox();
            this.imgSSD = new System.Windows.Forms.PictureBox();
            this.imgOP = new System.Windows.Forms.PictureBox();
            this.imgIP = new System.Windows.Forms.PictureBox();
            this.lblOP = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblPSU = new System.Windows.Forms.Label();
            this.lblSSD = new System.Windows.Forms.Label();
            this.lblRAM = new System.Windows.Forms.Label();
            this.lblCPU = new System.Windows.Forms.Label();
            this.lblINFO = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgRAM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPSU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSSD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIP)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCPU
            // 
            this.btnCPU.BackColor = System.Drawing.Color.Silver;
            this.btnCPU.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnCPU.Location = new System.Drawing.Point(12, 12);
            this.btnCPU.Name = "btnCPU";
            this.btnCPU.Size = new System.Drawing.Size(75, 23);
            this.btnCPU.TabIndex = 0;
            this.btnCPU.Text = "CPU";
            this.btnCPU.UseVisualStyleBackColor = false;
            this.btnCPU.Click += new System.EventHandler(this.btnCPU_Click);
            // 
            // btnRAM
            // 
            this.btnRAM.BackColor = System.Drawing.Color.Silver;
            this.btnRAM.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnRAM.Location = new System.Drawing.Point(12, 60);
            this.btnRAM.Name = "btnRAM";
            this.btnRAM.Size = new System.Drawing.Size(75, 23);
            this.btnRAM.TabIndex = 1;
            this.btnRAM.Text = "RAM";
            this.btnRAM.UseVisualStyleBackColor = false;
            this.btnRAM.Click += new System.EventHandler(this.btnRAM_Click);
            // 
            // btnSSD
            // 
            this.btnSSD.BackColor = System.Drawing.Color.Silver;
            this.btnSSD.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnSSD.Location = new System.Drawing.Point(12, 111);
            this.btnSSD.Name = "btnSSD";
            this.btnSSD.Size = new System.Drawing.Size(75, 23);
            this.btnSSD.TabIndex = 2;
            this.btnSSD.Text = "SSD";
            this.btnSSD.UseVisualStyleBackColor = false;
            this.btnSSD.Click += new System.EventHandler(this.btnSSD_Click);
            // 
            // btnPSU
            // 
            this.btnPSU.BackColor = System.Drawing.Color.Silver;
            this.btnPSU.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnPSU.Location = new System.Drawing.Point(12, 165);
            this.btnPSU.Name = "btnPSU";
            this.btnPSU.Size = new System.Drawing.Size(75, 35);
            this.btnPSU.TabIndex = 3;
            this.btnPSU.Text = "Power Supply";
            this.btnPSU.UseVisualStyleBackColor = false;
            this.btnPSU.Click += new System.EventHandler(this.btnPSU_Click);
            // 
            // btnIP
            // 
            this.btnIP.BackColor = System.Drawing.Color.Silver;
            this.btnIP.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnIP.Location = new System.Drawing.Point(12, 232);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(75, 36);
            this.btnIP.TabIndex = 4;
            this.btnIP.Text = "Input Peripheral";
            this.btnIP.UseVisualStyleBackColor = false;
            this.btnIP.Click += new System.EventHandler(this.btnIP_Click);
            // 
            // btnOP
            // 
            this.btnOP.BackColor = System.Drawing.Color.Silver;
            this.btnOP.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnOP.Location = new System.Drawing.Point(12, 297);
            this.btnOP.Name = "btnOP";
            this.btnOP.Size = new System.Drawing.Size(75, 35);
            this.btnOP.TabIndex = 5;
            this.btnOP.Text = "Output Peripheral";
            this.btnOP.UseVisualStyleBackColor = false;
            this.btnOP.Click += new System.EventHandler(this.btnOP_Click);
            // 
            // imgRAM
            // 
            this.imgRAM.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.imgRAM.Image = global::Topic_10_programming_assignment.Properties.Resources.images__2_;
            this.imgRAM.Location = new System.Drawing.Point(93, 11);
            this.imgRAM.Name = "imgRAM";
            this.imgRAM.Size = new System.Drawing.Size(254, 234);
            this.imgRAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgRAM.TabIndex = 11;
            this.imgRAM.TabStop = false;
            this.imgRAM.Visible = false;
            // 
            // imgCPU
            // 
            this.imgCPU.Image = global::Topic_10_programming_assignment.Properties.Resources.images__1_;
            this.imgCPU.Location = new System.Drawing.Point(93, 12);
            this.imgCPU.Name = "imgCPU";
            this.imgCPU.Size = new System.Drawing.Size(254, 234);
            this.imgCPU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgCPU.TabIndex = 10;
            this.imgCPU.TabStop = false;
            this.imgCPU.Visible = false;
            // 
            // imgPSU
            // 
            this.imgPSU.Image = global::Topic_10_programming_assignment.Properties.Resources.images__4_;
            this.imgPSU.Location = new System.Drawing.Point(93, 12);
            this.imgPSU.Name = "imgPSU";
            this.imgPSU.Size = new System.Drawing.Size(254, 234);
            this.imgPSU.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPSU.TabIndex = 9;
            this.imgPSU.TabStop = false;
            this.imgPSU.Visible = false;
            // 
            // imgSSD
            // 
            this.imgSSD.Image = global::Topic_10_programming_assignment.Properties.Resources.images__3_;
            this.imgSSD.Location = new System.Drawing.Point(93, 11);
            this.imgSSD.Name = "imgSSD";
            this.imgSSD.Size = new System.Drawing.Size(254, 235);
            this.imgSSD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgSSD.TabIndex = 8;
            this.imgSSD.TabStop = false;
            this.imgSSD.Visible = false;
            // 
            // imgOP
            // 
            this.imgOP.Image = global::Topic_10_programming_assignment.Properties.Resources.images__6_;
            this.imgOP.Location = new System.Drawing.Point(93, 12);
            this.imgOP.Name = "imgOP";
            this.imgOP.Size = new System.Drawing.Size(254, 234);
            this.imgOP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOP.TabIndex = 7;
            this.imgOP.TabStop = false;
            this.imgOP.Visible = false;
            // 
            // imgIP
            // 
            this.imgIP.Image = global::Topic_10_programming_assignment.Properties.Resources.images__5_;
            this.imgIP.Location = new System.Drawing.Point(93, 12);
            this.imgIP.Name = "imgIP";
            this.imgIP.Size = new System.Drawing.Size(254, 234);
            this.imgIP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgIP.TabIndex = 6;
            this.imgIP.TabStop = false;
            this.imgIP.Visible = false;
            // 
            // lblOP
            // 
            this.lblOP.BackColor = System.Drawing.Color.Silver;
            this.lblOP.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblOP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblOP.Location = new System.Drawing.Point(353, 11);
            this.lblOP.Name = "lblOP";
            this.lblOP.Size = new System.Drawing.Size(189, 71);
            this.lblOP.TabIndex = 12;
            this.lblOP.Text = "The output peripheral is used to convert digital stuff so you can see, or hear it" +
    ", such as a screen or speakers";
            this.lblOP.Visible = false;
            // 
            // lblIP
            // 
            this.lblIP.BackColor = System.Drawing.Color.Silver;
            this.lblIP.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblIP.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblIP.Location = new System.Drawing.Point(353, 11);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(189, 71);
            this.lblIP.TabIndex = 13;
            this.lblIP.Text = "The input peripheral is used to convert stuff into computer inputs, such as a mic" +
    "rophone, mouse or keyboard.";
            this.lblIP.Visible = false;
            // 
            // lblPSU
            // 
            this.lblPSU.BackColor = System.Drawing.Color.Silver;
            this.lblPSU.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblPSU.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPSU.Location = new System.Drawing.Point(353, 12);
            this.lblPSU.Name = "lblPSU";
            this.lblPSU.Size = new System.Drawing.Size(189, 71);
            this.lblPSU.TabIndex = 14;
            this.lblPSU.Text = "The power supply converts high voltage AC (Alternate Current) power into lower vo" +
    "ltage DC (Direct Current)\r\n that the pc can safely use";
            this.lblPSU.Visible = false;
            // 
            // lblSSD
            // 
            this.lblSSD.BackColor = System.Drawing.Color.Silver;
            this.lblSSD.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblSSD.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSSD.Location = new System.Drawing.Point(353, 12);
            this.lblSSD.Name = "lblSSD";
            this.lblSSD.Size = new System.Drawing.Size(189, 71);
            this.lblSSD.TabIndex = 15;
            this.lblSSD.Text = "The SSD (Solid State Drive) is a high speed storage drive that will permanently h" +
    "old your DATA, and apps unless manually deleted";
            this.lblSSD.Visible = false;
            // 
            // lblRAM
            // 
            this.lblRAM.BackColor = System.Drawing.Color.Silver;
            this.lblRAM.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblRAM.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblRAM.Location = new System.Drawing.Point(353, 12);
            this.lblRAM.Name = "lblRAM";
            this.lblRAM.Size = new System.Drawing.Size(189, 71);
            this.lblRAM.TabIndex = 16;
            this.lblRAM.Text = "The RAM (Random Acces Memory) is storage to temporarily hold data while your comp" +
    "uter is powered on, such as: Graphic shaders, and software operations.";
            this.lblRAM.Visible = false;
            // 
            // lblCPU
            // 
            this.lblCPU.BackColor = System.Drawing.Color.Silver;
            this.lblCPU.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblCPU.Location = new System.Drawing.Point(353, 12);
            this.lblCPU.Name = "lblCPU";
            this.lblCPU.Size = new System.Drawing.Size(189, 71);
            this.lblCPU.TabIndex = 17;
            this.lblCPU.Text = "The CPU (Central Processing Unit) is the brain of a computer, it does everything " +
    "from telling your hardware what to do, to doing all of your software calculation" +
    "s.";
            this.lblCPU.Visible = false;
            // 
            // lblINFO
            // 
            this.lblINFO.AutoSize = true;
            this.lblINFO.BackColor = System.Drawing.Color.Silver;
            this.lblINFO.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblINFO.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblINFO.Location = new System.Drawing.Point(99, 313);
            this.lblINFO.Name = "lblINFO";
            this.lblINFO.Size = new System.Drawing.Size(598, 31);
            this.lblINFO.TabIndex = 18;
            this.lblINFO.Text = "Select a button to learn more about a component";
            // 
            // Computerinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Yellow;
            this.ClientSize = new System.Drawing.Size(709, 353);
            this.Controls.Add(this.lblINFO);
            this.Controls.Add(this.lblCPU);
            this.Controls.Add(this.lblRAM);
            this.Controls.Add(this.lblSSD);
            this.Controls.Add(this.lblPSU);
            this.Controls.Add(this.lblIP);
            this.Controls.Add(this.lblOP);
            this.Controls.Add(this.imgRAM);
            this.Controls.Add(this.imgCPU);
            this.Controls.Add(this.imgPSU);
            this.Controls.Add(this.imgSSD);
            this.Controls.Add(this.imgOP);
            this.Controls.Add(this.imgIP);
            this.Controls.Add(this.btnOP);
            this.Controls.Add(this.btnIP);
            this.Controls.Add(this.btnPSU);
            this.Controls.Add(this.btnSSD);
            this.Controls.Add(this.btnRAM);
            this.Controls.Add(this.btnCPU);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "Computerinfo";
            this.Text = "Computer components";
            ((System.ComponentModel.ISupportInitialize)(this.imgRAM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgPSU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgSSD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgOP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgIP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCPU;
        private System.Windows.Forms.Button btnRAM;
        private System.Windows.Forms.Button btnSSD;
        private System.Windows.Forms.Button btnPSU;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.Button btnOP;
        private System.Windows.Forms.PictureBox imgIP;
        private System.Windows.Forms.PictureBox imgOP;
        private System.Windows.Forms.PictureBox imgSSD;
        private System.Windows.Forms.PictureBox imgPSU;
        private System.Windows.Forms.PictureBox imgCPU;
        private System.Windows.Forms.PictureBox imgRAM;
        private System.Windows.Forms.Label lblOP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblPSU;
        private System.Windows.Forms.Label lblSSD;
        private System.Windows.Forms.Label lblRAM;
        private System.Windows.Forms.Label lblCPU;
        private System.Windows.Forms.Label lblINFO;
    }
}


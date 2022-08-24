namespace Lithium___Battery_Saver
{
    partial class Form1
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
            this.bpercentagelabel = new System.Windows.Forms.Label();
            this.blifelabel = new System.Windows.Forms.Label();
            this.bpluginlabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.minimizepicture = new System.Windows.Forms.PictureBox();
            this.exitpicture = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pluggedinpicture = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.timepicture = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bpercentagepicture = new System.Windows.Forms.PictureBox();
            this.titlelabel = new System.Windows.Forms.Label();
            this.controlsbutton = new System.Windows.Forms.Button();
            this.detailsbutton = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.minimizepicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitpicture)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluggedinpicture)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timepicture)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpercentagepicture)).BeginInit();
            this.SuspendLayout();
            // 
            // bpercentagelabel
            // 
            this.bpercentagelabel.AutoSize = true;
            this.bpercentagelabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bpercentagelabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bpercentagelabel.ForeColor = System.Drawing.Color.White;
            this.bpercentagelabel.Location = new System.Drawing.Point(18, 132);
            this.bpercentagelabel.Name = "bpercentagelabel";
            this.bpercentagelabel.Size = new System.Drawing.Size(17, 23);
            this.bpercentagelabel.TabIndex = 0;
            this.bpercentagelabel.Text = "-";
            this.bpercentagelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // blifelabel
            // 
            this.blifelabel.AutoSize = true;
            this.blifelabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.blifelabel.ForeColor = System.Drawing.Color.White;
            this.blifelabel.Location = new System.Drawing.Point(18, 132);
            this.blifelabel.Name = "blifelabel";
            this.blifelabel.Size = new System.Drawing.Size(17, 23);
            this.blifelabel.TabIndex = 1;
            this.blifelabel.Text = "-";
            this.blifelabel.Click += new System.EventHandler(this.blifelabel_Click);
            // 
            // bpluginlabel
            // 
            this.bpluginlabel.AutoSize = true;
            this.bpluginlabel.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bpluginlabel.ForeColor = System.Drawing.Color.White;
            this.bpluginlabel.Location = new System.Drawing.Point(18, 132);
            this.bpluginlabel.Name = "bpluginlabel";
            this.bpluginlabel.Size = new System.Drawing.Size(17, 23);
            this.bpluginlabel.TabIndex = 2;
            this.bpluginlabel.Text = "-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panel1.Controls.Add(this.minimizepicture);
            this.panel1.Controls.Add(this.exitpicture);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(759, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 577);
            this.panel1.TabIndex = 3;
            // 
            // minimizepicture
            // 
            this.minimizepicture.BackColor = System.Drawing.Color.Transparent;
            this.minimizepicture.BackgroundImage = global::Lithium___Battery_Saver.Properties.Resources.minimize;
            this.minimizepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.minimizepicture.ErrorImage = null;
            this.minimizepicture.InitialImage = null;
            this.minimizepicture.Location = new System.Drawing.Point(122, 12);
            this.minimizepicture.Name = "minimizepicture";
            this.minimizepicture.Size = new System.Drawing.Size(18, 18);
            this.minimizepicture.TabIndex = 4;
            this.minimizepicture.TabStop = false;
            this.minimizepicture.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // exitpicture
            // 
            this.exitpicture.BackgroundImage = global::Lithium___Battery_Saver.Properties.Resources.cancelbutton;
            this.exitpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.exitpicture.Location = new System.Drawing.Point(156, 12);
            this.exitpicture.Name = "exitpicture";
            this.exitpicture.Size = new System.Drawing.Size(18, 18);
            this.exitpicture.TabIndex = 4;
            this.exitpicture.TabStop = false;
            this.exitpicture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel4.Controls.Add(this.pluggedinpicture);
            this.panel4.Controls.Add(this.bpluginlabel);
            this.panel4.Location = new System.Drawing.Point(19, 405);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(160, 160);
            this.panel4.TabIndex = 1;
            // 
            // pluggedinpicture
            // 
            this.pluggedinpicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pluggedinpicture.ErrorImage = null;
            this.pluggedinpicture.InitialImage = global::Lithium___Battery_Saver.Properties.Resources.notpluggedin;
            this.pluggedinpicture.Location = new System.Drawing.Point(18, 12);
            this.pluggedinpicture.Name = "pluggedinpicture";
            this.pluggedinpicture.Size = new System.Drawing.Size(120, 120);
            this.pluggedinpicture.TabIndex = 3;
            this.pluggedinpicture.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel3.Controls.Add(this.timepicture);
            this.panel3.Controls.Add(this.blifelabel);
            this.panel3.Location = new System.Drawing.Point(20, 221);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(160, 160);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // timepicture
            // 
            this.timepicture.BackgroundImage = global::Lithium___Battery_Saver.Properties.Resources.time;
            this.timepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timepicture.Location = new System.Drawing.Point(18, 12);
            this.timepicture.Name = "timepicture";
            this.timepicture.Size = new System.Drawing.Size(120, 120);
            this.timepicture.TabIndex = 2;
            this.timepicture.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(50)))));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel2.Controls.Add(this.bpercentagepicture);
            this.panel2.Controls.Add(this.bpercentagelabel);
            this.panel2.Location = new System.Drawing.Point(19, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(160, 160);
            this.panel2.TabIndex = 0;
            // 
            // bpercentagepicture
            // 
            this.bpercentagepicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bpercentagepicture.ErrorImage = null;
            this.bpercentagepicture.InitialImage = global::Lithium___Battery_Saver.Properties.Resources.battery100;
            this.bpercentagepicture.Location = new System.Drawing.Point(18, 12);
            this.bpercentagepicture.Name = "bpercentagepicture";
            this.bpercentagepicture.Size = new System.Drawing.Size(120, 120);
            this.bpercentagepicture.TabIndex = 2;
            this.bpercentagepicture.TabStop = false;
            // 
            // titlelabel
            // 
            this.titlelabel.AutoSize = true;
            this.titlelabel.Font = new System.Drawing.Font("Showcard Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.titlelabel.ForeColor = System.Drawing.Color.SteelBlue;
            this.titlelabel.Location = new System.Drawing.Point(12, 29);
            this.titlelabel.Name = "titlelabel";
            this.titlelabel.Size = new System.Drawing.Size(734, 59);
            this.titlelabel.TabIndex = 5;
            this.titlelabel.Text = "LITHIUM - BATTERY OPTIMIZER";
            this.titlelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // controlsbutton
            // 
            this.controlsbutton.BackColor = System.Drawing.Color.Transparent;
            this.controlsbutton.Location = new System.Drawing.Point(32, 112);
            this.controlsbutton.Name = "controlsbutton";
            this.controlsbutton.Size = new System.Drawing.Size(354, 44);
            this.controlsbutton.TabIndex = 6;
            this.controlsbutton.Text = "CONTROLS";
            this.controlsbutton.UseVisualStyleBackColor = false;
            this.controlsbutton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // detailsbutton
            // 
            this.detailsbutton.Location = new System.Drawing.Point(392, 112);
            this.detailsbutton.Name = "detailsbutton";
            this.detailsbutton.Size = new System.Drawing.Size(345, 44);
            this.detailsbutton.TabIndex = 7;
            this.detailsbutton.Text = "DETAILS";
            this.detailsbutton.UseVisualStyleBackColor = true;
            this.detailsbutton.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(32, 173);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(705, 387);
            this.panel5.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(951, 577);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.detailsbutton);
            this.Controls.Add(this.controlsbutton);
            this.Controls.Add(this.titlelabel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lithium - Battery Saver";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.minimizepicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exitpicture)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pluggedinpicture)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timepicture)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpercentagepicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label bpercentagelabel;
        private Label blifelabel;
        private Label bpluginlabel;
        private Panel panel1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private PictureBox exitpicture;
        private PictureBox minimizepicture;
        private PictureBox pluggedinpicture;
        private PictureBox timepicture;
        private PictureBox bpercentagepicture;
        private Label titlelabel;
        private Button controlsbutton;
        private Button detailsbutton;
        private Panel panel5;
    }
}
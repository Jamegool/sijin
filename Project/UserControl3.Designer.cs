namespace Project
{
    partial class UserControl3
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
            this.button19 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.userControl51 = new Project.UserControl5();
            this.userControl41 = new Project.UserControl4();
            this.SuspendLayout();
            // 
            // button19
            // 
            this.button19.Location = new System.Drawing.Point(235, 375);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(130, 52);
            this.button19.TabIndex = 9;
            this.button19.Text = "เปิดกะการขาย";
            this.button19.UseVisualStyleBackColor = true;
            // 
            // button18
            // 
            this.button18.Enabled = false;
            this.button18.Location = new System.Drawing.Point(27, 377);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(190, 50);
            this.button18.TabIndex = 4;
            this.button18.Text = "เวลาเข้างาน : 00:00";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(441, 40);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(235, 67);
            this.button16.TabIndex = 6;
            this.button16.Text = "Back End";
            this.button16.UseVisualStyleBackColor = true;
            this.button16.Click += new System.EventHandler(this.button16_Click);
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(82, 40);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(235, 67);
            this.button15.TabIndex = 7;
            this.button15.Text = "Front End";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(644, 377);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(110, 40);
            this.button12.TabIndex = 5;
            this.button12.Text = "ออกจากระบบ";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // userControl51
            // 
            this.userControl51.Location = new System.Drawing.Point(53, 128);
            this.userControl51.Name = "userControl51";
            this.userControl51.Size = new System.Drawing.Size(731, 206);
            this.userControl51.TabIndex = 11;
            // 
            // userControl41
            // 
            this.userControl41.Location = new System.Drawing.Point(53, 128);
            this.userControl41.Name = "userControl41";
            this.userControl41.Size = new System.Drawing.Size(731, 206);
            this.userControl41.TabIndex = 10;
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.userControl51);
            this.Controls.Add(this.userControl41);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button12);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(784, 461);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button12;
        private UserControl4 userControl41;
        private UserControl5 userControl51;
    }
}

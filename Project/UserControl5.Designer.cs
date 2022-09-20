namespace Project
{
    partial class UserControl5
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
            this.button17 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(35, 24);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(132, 84);
            this.button17.TabIndex = 1;
            this.button17.Text = "ข้อมูลโต๊ะ";
            this.button17.UseVisualStyleBackColor = true;
            this.button17.Click += new System.EventHandler(this.button17_Click);
            // 
            // UserControl5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button17);
            this.Name = "UserControl5";
            this.Size = new System.Drawing.Size(731, 206);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button17;
    }
}

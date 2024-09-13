namespace Online_Store
{
    partial class Settings
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
            this.DarkMode = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // DarkMode
            // 
            this.DarkMode.AutoSize = true;
            this.DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.DarkMode.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 11F, System.Drawing.FontStyle.Bold);
            this.DarkMode.Location = new System.Drawing.Point(323, 376);
            this.DarkMode.Name = "DarkMode";
            this.DarkMode.Size = new System.Drawing.Size(121, 26);
            this.DarkMode.TabIndex = 29;
            this.DarkMode.Text = "Dark Mode";
            this.DarkMode.UseVisualStyleBackColor = false;
            this.DarkMode.CheckedChanged += new System.EventHandler(this.DarkMode_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 539);
            this.Controls.Add(this.DarkMode);
            this.Name = "Settings";
            this.Text = "Settings";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox DarkMode;
    }
}
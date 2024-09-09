namespace Sales_market_applicatinon_v2
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            this.lb_login = new System.Windows.Forms.Label();
            this.signup_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.password = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.confirmation = new System.Windows.Forms.TextBox();
            this.btncheck = new System.Windows.Forms.Button();
            this.btn_sign = new System.Windows.Forms.Button();
            this.pictureBox_exit = new System.Windows.Forms.PictureBox();
            this.pictureBox_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_login
            // 
            this.lb_login.AutoSize = true;
            this.lb_login.Font = new System.Drawing.Font("Tahoma", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_login.ForeColor = System.Drawing.Color.White;
            this.lb_login.Location = new System.Drawing.Point(619, 21);
            this.lb_login.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_login.Name = "lb_login";
            this.lb_login.Size = new System.Drawing.Size(186, 57);
            this.lb_login.TabIndex = 17;
            this.lb_login.Text = "Sign Up";
            // 
            // signup_name
            // 
            this.signup_name.BackColor = System.Drawing.Color.White;
            this.signup_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.signup_name.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_name.Location = new System.Drawing.Point(567, 197);
            this.signup_name.Margin = new System.Windows.Forms.Padding(4);
            this.signup_name.MaxLength = 26;
            this.signup_name.Name = "signup_name";
            this.signup_name.Size = new System.Drawing.Size(285, 30);
            this.signup_name.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(622, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 41);
            this.label1.TabIndex = 19;
            this.label1.Text = "Your Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(622, 257);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 41);
            this.label2.TabIndex = 21;
            this.label2.Text = "Password";
            // 
            // password
            // 
            this.password.BackColor = System.Drawing.Color.White;
            this.password.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password.Location = new System.Drawing.Point(567, 318);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.MaxLength = 26;
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(285, 30);
            this.password.TabIndex = 20;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 20F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(565, 375);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(287, 41);
            this.label3.TabIndex = 23;
            this.label3.Text = "Confirm Password";
            // 
            // confirmation
            // 
            this.confirmation.BackColor = System.Drawing.Color.White;
            this.confirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.confirmation.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmation.Location = new System.Drawing.Point(567, 441);
            this.confirmation.Margin = new System.Windows.Forms.Padding(4);
            this.confirmation.MaxLength = 26;
            this.confirmation.Name = "confirmation";
            this.confirmation.PasswordChar = '*';
            this.confirmation.Size = new System.Drawing.Size(285, 30);
            this.confirmation.TabIndex = 22;
            // 
            // btncheck
            // 
            this.btncheck.BackColor = System.Drawing.Color.SkyBlue;
            this.btncheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncheck.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncheck.Location = new System.Drawing.Point(903, 550);
            this.btncheck.Margin = new System.Windows.Forms.Padding(4);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(113, 54);
            this.btncheck.TabIndex = 24;
            this.btncheck.Text = "Submit";
            this.btncheck.UseVisualStyleBackColor = false;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // btn_sign
            // 
            this.btn_sign.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sign.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sign.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sign.ForeColor = System.Drawing.Color.White;
            this.btn_sign.Location = new System.Drawing.Point(409, 550);
            this.btn_sign.Margin = new System.Windows.Forms.Padding(4);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(113, 54);
            this.btn_sign.TabIndex = 25;
            this.btn_sign.Text = "Go Back";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // pictureBox_exit
            // 
            this.pictureBox_exit.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_exit.Image")));
            this.pictureBox_exit.Location = new System.Drawing.Point(977, -1);
            this.pictureBox_exit.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_exit.Name = "pictureBox_exit";
            this.pictureBox_exit.Size = new System.Drawing.Size(51, 59);
            this.pictureBox_exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_exit.TabIndex = 16;
            this.pictureBox_exit.TabStop = false;
            this.pictureBox_exit.Click += new System.EventHandler(this.pictureBox_exit_Click);
            // 
            // pictureBox_logo
            // 
            this.pictureBox_logo.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_logo.Image")));
            this.pictureBox_logo.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_logo.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox_logo.Name = "pictureBox_logo";
            this.pictureBox_logo.Size = new System.Drawing.Size(401, 619);
            this.pictureBox_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_logo.TabIndex = 1;
            this.pictureBox_logo.TabStop = false;
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(1029, 617);
            this.Controls.Add(this.btn_sign);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.confirmation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signup_name);
            this.Controls.Add(this.lb_login);
            this.Controls.Add(this.pictureBox_exit);
            this.Controls.Add(this.pictureBox_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Sign_up";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_logo;
        private System.Windows.Forms.PictureBox pictureBox_exit;
        private System.Windows.Forms.Label lb_login;
        private System.Windows.Forms.TextBox signup_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox confirmation;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.Button btn_sign;
    }
}
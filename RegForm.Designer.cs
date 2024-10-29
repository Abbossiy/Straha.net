namespace StrahaNet
{
    partial class RegForm
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
            this.returnLabel = new System.Windows.Forms.Label();
            this.registerButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.loginBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.repeatPassBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // returnLabel
            // 
            this.returnLabel.AutoSize = true;
            this.returnLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.returnLabel.Location = new System.Drawing.Point(447, 466);
            this.returnLabel.Name = "returnLabel";
            this.returnLabel.Size = new System.Drawing.Size(166, 17);
            this.returnLabel.TabIndex = 11;
            this.returnLabel.Text = "Возврат к авторизации";
            this.returnLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.returnLabel.Click += new System.EventHandler(this.returnLabel_Click);
            // 
            // registerButton
            // 
            this.registerButton.BackColor = System.Drawing.Color.RosyBrown;
            this.registerButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.registerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registerButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerButton.Location = new System.Drawing.Point(460, 389);
            this.registerButton.Name = "registerButton";
            this.registerButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.registerButton.Size = new System.Drawing.Size(136, 74);
            this.registerButton.TabIndex = 10;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = false;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordBox.ForeColor = System.Drawing.Color.RosyBrown;
            this.passwordBox.Location = new System.Drawing.Point(478, 322);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(100, 18);
            this.passwordBox.TabIndex = 9;
            this.passwordBox.Text = "Пароль";
            this.passwordBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // loginBox
            // 
            this.loginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.loginBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginBox.ForeColor = System.Drawing.Color.RosyBrown;
            this.loginBox.Location = new System.Drawing.Point(478, 271);
            this.loginBox.Name = "loginBox";
            this.loginBox.Size = new System.Drawing.Size(100, 18);
            this.loginBox.TabIndex = 8;
            this.loginBox.Text = "Логин";
            this.loginBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(384, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(265, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Страха.net";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StrahaNet.Properties.Resources.samolet;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::StrahaNet.Properties.Resources.kisspng_third_party_logistics_freight_forwarding_agency_fr_5add4b85177b25_7066775015244522290962;
            this.pictureBox1.Location = new System.Drawing.Point(1, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(342, 266);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // repeatPassBox
            // 
            this.repeatPassBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.repeatPassBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.repeatPassBox.ForeColor = System.Drawing.Color.RosyBrown;
            this.repeatPassBox.Location = new System.Drawing.Point(478, 365);
            this.repeatPassBox.Name = "repeatPassBox";
            this.repeatPassBox.Size = new System.Drawing.Size(100, 18);
            this.repeatPassBox.TabIndex = 12;
            this.repeatPassBox.Text = "Повтор пароля";
            this.repeatPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 617);
            this.Controls.Add(this.repeatPassBox);
            this.Controls.Add(this.returnLabel);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.loginBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "RegForm";
            this.Text = "RegForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label returnLabel;
        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox loginBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repeatPassBox;
    }
}
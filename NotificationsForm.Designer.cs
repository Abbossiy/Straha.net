namespace StrahaNet
{
    partial class NotificationsForm
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
            this.toMainButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toMainButton
            // 
            this.toMainButton.BackColor = System.Drawing.Color.RosyBrown;
            this.toMainButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.toMainButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.toMainButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toMainButton.Location = new System.Drawing.Point(12, 12);
            this.toMainButton.Name = "toMainButton";
            this.toMainButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toMainButton.Size = new System.Drawing.Size(125, 62);
            this.toMainButton.TabIndex = 13;
            this.toMainButton.Text = "На главную";
            this.toMainButton.UseVisualStyleBackColor = false;
            this.toMainButton.Click += new System.EventHandler(this.toMainButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::StrahaNet.Properties.Resources._754755745720573;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.InitialImage = global::StrahaNet.Properties.Resources.kisspng_third_party_logistics_freight_forwarding_agency_fr_5add4b85177b25_7066775015244522290962;
            this.pictureBox1.Location = new System.Drawing.Point(475, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(555, 352);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // NotificationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 617);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toMainButton);
            this.Name = "NotificationsForm";
            this.Text = "NotificationsForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toMainButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
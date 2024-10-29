namespace StrahaNet
{
    partial class ApplicationsForm
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
            this.toMainButton.Size = new System.Drawing.Size(136, 74);
            this.toMainButton.TabIndex = 22;
            this.toMainButton.Text = "На главную";
            this.toMainButton.UseVisualStyleBackColor = false;
            this.toMainButton.Click += new System.EventHandler(this.toMainButton_Click);
            // 
            // ApplicationsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 617);
            this.Controls.Add(this.toMainButton);
            this.Name = "ApplicationsForm";
            this.Text = "ApplicationsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button toMainButton;
    }
}
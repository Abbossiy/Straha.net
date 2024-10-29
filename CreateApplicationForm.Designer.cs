namespace StrahaNet
{
    partial class CreateApplicationForm
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
            this.priceLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.countryStartBox = new System.Windows.Forms.TextBox();
            this.toMainButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dateStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dateReturn = new System.Windows.Forms.DateTimePicker();
            this.countryEndBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.priceLabel.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.priceLabel.Location = new System.Drawing.Point(528, 418);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(0, 17);
            this.priceLabel.TabIndex = 8;
            this.priceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.RosyBrown;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(466, 491);
            this.saveButton.Name = "saveButton";
            this.saveButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.saveButton.Size = new System.Drawing.Size(125, 74);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // countryStartBox
            // 
            this.countryStartBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryStartBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryStartBox.ForeColor = System.Drawing.Color.RosyBrown;
            this.countryStartBox.Location = new System.Drawing.Point(445, 239);
            this.countryStartBox.Name = "countryStartBox";
            this.countryStartBox.Size = new System.Drawing.Size(156, 18);
            this.countryStartBox.TabIndex = 5;
            this.countryStartBox.Text = "Страна отправления";
            this.countryStartBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.toMainButton.TabIndex = 12;
            this.toMainButton.Text = "На главную";
            this.toMainButton.UseVisualStyleBackColor = false;
            this.toMainButton.Click += new System.EventHandler(this.toMainButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(369, 320);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 14;
            this.label2.Text = "Дата вылета";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dateStart
            // 
            this.dateStart.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.dateStart.Location = new System.Drawing.Point(316, 340);
            this.dateStart.Name = "dateStart";
            this.dateStart.Size = new System.Drawing.Size(200, 20);
            this.dateStart.TabIndex = 13;
            this.dateStart.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(578, 320);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Дата возврата";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateReturn
            // 
            this.dateReturn.CalendarMonthBackground = System.Drawing.Color.RosyBrown;
            this.dateReturn.Location = new System.Drawing.Point(531, 340);
            this.dateReturn.Name = "dateReturn";
            this.dateReturn.Size = new System.Drawing.Size(200, 20);
            this.dateReturn.TabIndex = 15;
            // 
            // countryEndBox
            // 
            this.countryEndBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.countryEndBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countryEndBox.ForeColor = System.Drawing.Color.RosyBrown;
            this.countryEndBox.Location = new System.Drawing.Point(445, 279);
            this.countryEndBox.Name = "countryEndBox";
            this.countryEndBox.Size = new System.Drawing.Size(156, 18);
            this.countryEndBox.TabIndex = 18;
            this.countryEndBox.Text = "Страна назначения";
            this.countryEndBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // CreateApplicationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1033, 617);
            this.Controls.Add(this.countryEndBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateReturn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.toMainButton);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.countryStartBox);
            this.Name = "CreateApplicationForm";
            this.Text = "CreateApplicationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox countryStartBox;
        private System.Windows.Forms.Button toMainButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateReturn;
        private System.Windows.Forms.TextBox countryEndBox;
    }
}
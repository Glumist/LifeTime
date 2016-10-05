namespace Days
{
    partial class FormChangeHour
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
            this.rbForward = new System.Windows.Forms.RadioButton();
            this.rbBackward = new System.Windows.Forms.RadioButton();
            this.dtpTimeShift = new System.Windows.Forms.DateTimePicker();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbForward
            // 
            this.rbForward.AutoSize = true;
            this.rbForward.Checked = true;
            this.rbForward.Location = new System.Drawing.Point(19, 11);
            this.rbForward.Name = "rbForward";
            this.rbForward.Size = new System.Drawing.Size(62, 17);
            this.rbForward.TabIndex = 0;
            this.rbForward.TabStop = true;
            this.rbForward.Text = "Вперед";
            this.rbForward.UseVisualStyleBackColor = true;
            // 
            // rbBackward
            // 
            this.rbBackward.AutoSize = true;
            this.rbBackward.Location = new System.Drawing.Point(19, 34);
            this.rbBackward.Name = "rbBackward";
            this.rbBackward.Size = new System.Drawing.Size(57, 17);
            this.rbBackward.TabIndex = 1;
            this.rbBackward.Text = "Назад";
            this.rbBackward.UseVisualStyleBackColor = true;
            // 
            // dtpTimeShift
            // 
            this.dtpTimeShift.CustomFormat = "HH:mm";
            this.dtpTimeShift.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeShift.Location = new System.Drawing.Point(102, 21);
            this.dtpTimeShift.Name = "dtpTimeShift";
            this.dtpTimeShift.ShowUpDown = true;
            this.dtpTimeShift.Size = new System.Drawing.Size(53, 20);
            this.dtpTimeShift.TabIndex = 2;
            this.dtpTimeShift.Value = new System.DateTime(2015, 11, 13, 0, 0, 0, 0);
            // 
            // btOk
            // 
            this.btOk.Location = new System.Drawing.Point(12, 57);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 3;
            this.btOk.Text = "OK";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Location = new System.Drawing.Point(93, 57);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 4;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // ChangeHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(187, 87);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.dtpTimeShift);
            this.Controls.Add(this.rbBackward);
            this.Controls.Add(this.rbForward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangeHour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Смена часового пояса";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbForward;
        private System.Windows.Forms.RadioButton rbBackward;
        private System.Windows.Forms.DateTimePicker dtpTimeShift;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
    }
}
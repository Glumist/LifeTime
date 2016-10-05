namespace Days
{
    partial class FormSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.gbUses = new System.Windows.Forms.GroupBox();
            this.chbEveryYear = new System.Windows.Forms.CheckBox();
            this.chbUseYears = new System.Windows.Forms.CheckBox();
            this.chbUseMonthes = new System.Windows.Forms.CheckBox();
            this.chbUseWeeks = new System.Windows.Forms.CheckBox();
            this.chbUseDays = new System.Windows.Forms.CheckBox();
            this.chbUseHours = new System.Windows.Forms.CheckBox();
            this.chbUseMinutes = new System.Windows.Forms.CheckBox();
            this.chbUseSeconds = new System.Windows.Forms.CheckBox();
            this.nudPreviousDays = new System.Windows.Forms.NumericUpDown();
            this.nudNextDays = new System.Windows.Forms.NumericUpDown();
            this.nudRecalcDays = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.gbCalcMethods = new System.Windows.Forms.GroupBox();
            this.chbExponent = new System.Windows.Forms.CheckBox();
            this.chbSameDigits = new System.Windows.Forms.CheckBox();
            this.tbMidNums = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.gbUses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreviousDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextDays)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecalcDays)).BeginInit();
            this.gbCalcMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbUses
            // 
            this.gbUses.Controls.Add(this.chbUseYears);
            this.gbUses.Controls.Add(this.chbUseMonthes);
            this.gbUses.Controls.Add(this.chbUseWeeks);
            this.gbUses.Controls.Add(this.chbUseDays);
            this.gbUses.Controls.Add(this.chbUseHours);
            this.gbUses.Controls.Add(this.chbUseMinutes);
            this.gbUses.Controls.Add(this.chbUseSeconds);
            this.gbUses.Location = new System.Drawing.Point(12, 12);
            this.gbUses.Name = "gbUses";
            this.gbUses.Size = new System.Drawing.Size(96, 179);
            this.gbUses.TabIndex = 0;
            this.gbUses.TabStop = false;
            this.gbUses.Text = "Использовать";
            // 
            // chbEveryYear
            // 
            this.chbEveryYear.AutoSize = true;
            this.chbEveryYear.Location = new System.Drawing.Point(6, 65);
            this.chbEveryYear.Name = "chbEveryYear";
            this.chbEveryYear.Size = new System.Drawing.Size(87, 17);
            this.chbEveryYear.TabIndex = 7;
            this.chbEveryYear.Text = "Каждый год";
            this.chbEveryYear.UseVisualStyleBackColor = true;
            // 
            // chbUseYears
            // 
            this.chbUseYears.AutoSize = true;
            this.chbUseYears.Location = new System.Drawing.Point(6, 157);
            this.chbUseYears.Name = "chbUseYears";
            this.chbUseYears.Size = new System.Drawing.Size(52, 17);
            this.chbUseYears.TabIndex = 6;
            this.chbUseYears.Text = "Годы";
            this.chbUseYears.UseVisualStyleBackColor = true;
            // 
            // chbUseMonthes
            // 
            this.chbUseMonthes.AutoSize = true;
            this.chbUseMonthes.Location = new System.Drawing.Point(6, 134);
            this.chbUseMonthes.Name = "chbUseMonthes";
            this.chbUseMonthes.Size = new System.Drawing.Size(67, 17);
            this.chbUseMonthes.TabIndex = 5;
            this.chbUseMonthes.Text = "Месяцы";
            this.chbUseMonthes.UseVisualStyleBackColor = true;
            // 
            // chbUseWeeks
            // 
            this.chbUseWeeks.AutoSize = true;
            this.chbUseWeeks.Location = new System.Drawing.Point(6, 111);
            this.chbUseWeeks.Name = "chbUseWeeks";
            this.chbUseWeeks.Size = new System.Drawing.Size(64, 17);
            this.chbUseWeeks.TabIndex = 4;
            this.chbUseWeeks.Text = "Недели";
            this.chbUseWeeks.UseVisualStyleBackColor = true;
            // 
            // chbUseDays
            // 
            this.chbUseDays.AutoSize = true;
            this.chbUseDays.Location = new System.Drawing.Point(6, 88);
            this.chbUseDays.Name = "chbUseDays";
            this.chbUseDays.Size = new System.Drawing.Size(47, 17);
            this.chbUseDays.TabIndex = 3;
            this.chbUseDays.Text = "Дни";
            this.chbUseDays.UseVisualStyleBackColor = true;
            // 
            // chbUseHours
            // 
            this.chbUseHours.AutoSize = true;
            this.chbUseHours.Location = new System.Drawing.Point(6, 65);
            this.chbUseHours.Name = "chbUseHours";
            this.chbUseHours.Size = new System.Drawing.Size(54, 17);
            this.chbUseHours.TabIndex = 2;
            this.chbUseHours.Text = "Часы";
            this.chbUseHours.UseVisualStyleBackColor = true;
            // 
            // chbUseMinutes
            // 
            this.chbUseMinutes.AutoSize = true;
            this.chbUseMinutes.Location = new System.Drawing.Point(6, 42);
            this.chbUseMinutes.Name = "chbUseMinutes";
            this.chbUseMinutes.Size = new System.Drawing.Size(65, 17);
            this.chbUseMinutes.TabIndex = 1;
            this.chbUseMinutes.Text = "Минуты";
            this.chbUseMinutes.UseVisualStyleBackColor = true;
            // 
            // chbUseSeconds
            // 
            this.chbUseSeconds.AutoSize = true;
            this.chbUseSeconds.Location = new System.Drawing.Point(6, 19);
            this.chbUseSeconds.Name = "chbUseSeconds";
            this.chbUseSeconds.Size = new System.Drawing.Size(70, 17);
            this.chbUseSeconds.TabIndex = 0;
            this.chbUseSeconds.Text = "Секунды";
            this.chbUseSeconds.UseVisualStyleBackColor = true;
            // 
            // nudPreviousDays
            // 
            this.nudPreviousDays.Location = new System.Drawing.Point(244, 144);
            this.nudPreviousDays.Name = "nudPreviousDays";
            this.nudPreviousDays.Size = new System.Drawing.Size(50, 20);
            this.nudPreviousDays.TabIndex = 8;
            // 
            // nudNextDays
            // 
            this.nudNextDays.Location = new System.Drawing.Point(244, 168);
            this.nudNextDays.Name = "nudNextDays";
            this.nudNextDays.Size = new System.Drawing.Size(50, 20);
            this.nudNextDays.TabIndex = 9;
            // 
            // nudRecalcDays
            // 
            this.nudRecalcDays.Location = new System.Drawing.Point(244, 192);
            this.nudRecalcDays.Name = "nudRecalcDays";
            this.nudRecalcDays.Size = new System.Drawing.Size(50, 20);
            this.nudRecalcDays.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "События за последние ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(112, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "События за следующие";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(112, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Перерасчет каждые";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "дней";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(300, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "дней";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(300, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "дней";
            // 
            // btOk
            // 
            this.btOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btOk.Location = new System.Drawing.Point(172, 224);
            this.btOk.Name = "btOk";
            this.btOk.Size = new System.Drawing.Size(75, 23);
            this.btOk.TabIndex = 11;
            this.btOk.Text = "ОК";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            this.btCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Location = new System.Drawing.Point(253, 224);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(75, 23);
            this.btCancel.TabIndex = 12;
            this.btCancel.Text = "Отмена";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // gbCalcMethods
            // 
            this.gbCalcMethods.Controls.Add(this.label7);
            this.gbCalcMethods.Controls.Add(this.tbMidNums);
            this.gbCalcMethods.Controls.Add(this.chbSameDigits);
            this.gbCalcMethods.Controls.Add(this.chbEveryYear);
            this.gbCalcMethods.Controls.Add(this.chbExponent);
            this.gbCalcMethods.Location = new System.Drawing.Point(113, 12);
            this.gbCalcMethods.Name = "gbCalcMethods";
            this.gbCalcMethods.Size = new System.Drawing.Size(218, 128);
            this.gbCalcMethods.TabIndex = 13;
            this.gbCalcMethods.TabStop = false;
            this.gbCalcMethods.Text = "Формулы";
            // 
            // chbExponent
            // 
            this.chbExponent.AutoSize = true;
            this.chbExponent.Location = new System.Drawing.Point(6, 19);
            this.chbExponent.Name = "chbExponent";
            this.chbExponent.Size = new System.Drawing.Size(84, 17);
            this.chbExponent.TabIndex = 0;
            this.chbExponent.Text = "1..9 * 10 ^ n";
            this.chbExponent.UseVisualStyleBackColor = true;
            // 
            // chbSameDigits
            // 
            this.chbSameDigits.AutoSize = true;
            this.chbSameDigits.Location = new System.Drawing.Point(6, 42);
            this.chbSameDigits.Name = "chbSameDigits";
            this.chbSameDigits.Size = new System.Drawing.Size(138, 17);
            this.chbSameDigits.TabIndex = 8;
            this.chbSameDigits.Text = "1..9 + .. + (1..9 * 10 ^ n)";
            this.chbSameDigits.UseVisualStyleBackColor = true;
            // 
            // tbMidNums
            // 
            this.tbMidNums.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbMidNums.Location = new System.Drawing.Point(6, 100);
            this.tbMidNums.Name = "tbMidNums";
            this.tbMidNums.Size = new System.Drawing.Size(206, 20);
            this.tbMidNums.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(4, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(159, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Промежуточные между 1 и 10";
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.ClientSize = new System.Drawing.Size(339, 263);
            this.Controls.Add(this.gbCalcMethods);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudRecalcDays);
            this.Controls.Add(this.nudNextDays);
            this.Controls.Add(this.nudPreviousDays);
            this.Controls.Add(this.gbUses);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Настройки";
            this.gbUses.ResumeLayout(false);
            this.gbUses.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPreviousDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNextDays)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudRecalcDays)).EndInit();
            this.gbCalcMethods.ResumeLayout(false);
            this.gbCalcMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbUses;
        private System.Windows.Forms.CheckBox chbEveryYear;
        private System.Windows.Forms.CheckBox chbUseYears;
        private System.Windows.Forms.CheckBox chbUseMonthes;
        private System.Windows.Forms.CheckBox chbUseWeeks;
        private System.Windows.Forms.CheckBox chbUseDays;
        private System.Windows.Forms.CheckBox chbUseHours;
        private System.Windows.Forms.CheckBox chbUseMinutes;
        private System.Windows.Forms.CheckBox chbUseSeconds;
        private System.Windows.Forms.NumericUpDown nudPreviousDays;
        private System.Windows.Forms.NumericUpDown nudNextDays;
        private System.Windows.Forms.NumericUpDown nudRecalcDays;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.GroupBox gbCalcMethods;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMidNums;
        private System.Windows.Forms.CheckBox chbSameDigits;
        private System.Windows.Forms.CheckBox chbExponent;
    }
}
namespace LifeTime.Forms
{
    partial class FormAddContact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddContact));
            this.label_FullName = new System.Windows.Forms.Label();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.dtpBirth = new System.Windows.Forms.DateTimePicker();
            this.label_BirthDate = new System.Windows.Forms.Label();
            this.tbInfo = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.button_Cancel = new System.Windows.Forms.Button();
            this.button_Ok = new System.Windows.Forms.Button();
            this.label_AtThisMoment = new System.Windows.Forms.Label();
            this.label_Seconds = new System.Windows.Forms.Label();
            this.label_Minutes = new System.Windows.Forms.Label();
            this.label_Hours = new System.Windows.Forms.Label();
            this.label_Days = new System.Windows.Forms.Label();
            this.label_Weeks = new System.Windows.Forms.Label();
            this.label_Months = new System.Windows.Forms.Label();
            this.label_Years = new System.Windows.Forms.Label();
            this.lYears = new System.Windows.Forms.Label();
            this.lMonthes = new System.Windows.Forms.Label();
            this.lWeeks = new System.Windows.Forms.Label();
            this.lDays = new System.Windows.Forms.Label();
            this.lHours = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lSeconds = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_FullName
            // 
            resources.ApplyResources(this.label_FullName, "label_FullName");
            this.label_FullName.Name = "label_FullName";
            // 
            // tbFio
            // 
            resources.ApplyResources(this.tbFio, "tbFio");
            this.tbFio.Name = "tbFio";
            // 
            // dtpBirth
            // 
            resources.ApplyResources(this.dtpBirth, "dtpBirth");
            this.dtpBirth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirth.Name = "dtpBirth";
            this.dtpBirth.ValueChanged += new System.EventHandler(this.dtpBirth_ValueChanged);
            // 
            // label_BirthDate
            // 
            resources.ApplyResources(this.label_BirthDate, "label_BirthDate");
            this.label_BirthDate.Name = "label_BirthDate";
            // 
            // tbInfo
            // 
            resources.ApplyResources(this.tbInfo, "tbInfo");
            this.tbInfo.Name = "tbInfo";
            // 
            // label_Info
            // 
            resources.ApplyResources(this.label_Info, "label_Info");
            this.label_Info.Name = "label_Info";
            // 
            // button_Cancel
            // 
            resources.ApplyResources(this.button_Cancel, "button_Cancel");
            this.button_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Cancel.Name = "button_Cancel";
            this.button_Cancel.UseVisualStyleBackColor = true;
            this.button_Cancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // button_Ok
            // 
            resources.ApplyResources(this.button_Ok, "button_Ok");
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            this.button_Ok.Click += new System.EventHandler(this.btOk_Click);
            // 
            // label_AtThisMoment
            // 
            resources.ApplyResources(this.label_AtThisMoment, "label_AtThisMoment");
            this.label_AtThisMoment.Name = "label_AtThisMoment";
            // 
            // label_Seconds
            // 
            resources.ApplyResources(this.label_Seconds, "label_Seconds");
            this.label_Seconds.Name = "label_Seconds";
            // 
            // label_Minutes
            // 
            resources.ApplyResources(this.label_Minutes, "label_Minutes");
            this.label_Minutes.Name = "label_Minutes";
            // 
            // label_Hours
            // 
            resources.ApplyResources(this.label_Hours, "label_Hours");
            this.label_Hours.Name = "label_Hours";
            // 
            // label_Days
            // 
            resources.ApplyResources(this.label_Days, "label_Days");
            this.label_Days.Name = "label_Days";
            // 
            // label_Weeks
            // 
            resources.ApplyResources(this.label_Weeks, "label_Weeks");
            this.label_Weeks.Name = "label_Weeks";
            // 
            // label_Months
            // 
            resources.ApplyResources(this.label_Months, "label_Months");
            this.label_Months.Name = "label_Months";
            // 
            // label_Years
            // 
            resources.ApplyResources(this.label_Years, "label_Years");
            this.label_Years.Name = "label_Years";
            // 
            // lYears
            // 
            resources.ApplyResources(this.lYears, "lYears");
            this.lYears.Name = "lYears";
            // 
            // lMonthes
            // 
            resources.ApplyResources(this.lMonthes, "lMonthes");
            this.lMonthes.Name = "lMonthes";
            // 
            // lWeeks
            // 
            resources.ApplyResources(this.lWeeks, "lWeeks");
            this.lWeeks.Name = "lWeeks";
            // 
            // lDays
            // 
            resources.ApplyResources(this.lDays, "lDays");
            this.lDays.Name = "lDays";
            // 
            // lHours
            // 
            resources.ApplyResources(this.lHours, "lHours");
            this.lHours.Name = "lHours";
            // 
            // lMinutes
            // 
            resources.ApplyResources(this.lMinutes, "lMinutes");
            this.lMinutes.Name = "lMinutes";
            // 
            // lSeconds
            // 
            resources.ApplyResources(this.lSeconds, "lSeconds");
            this.lSeconds.Name = "lSeconds";
            // 
            // FormAddContact
            // 
            this.AcceptButton = this.button_Ok;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Cancel;
            this.Controls.Add(this.lYears);
            this.Controls.Add(this.lMonthes);
            this.Controls.Add(this.lWeeks);
            this.Controls.Add(this.lDays);
            this.Controls.Add(this.lHours);
            this.Controls.Add(this.lMinutes);
            this.Controls.Add(this.lSeconds);
            this.Controls.Add(this.label_Years);
            this.Controls.Add(this.label_Months);
            this.Controls.Add(this.label_Weeks);
            this.Controls.Add(this.label_Days);
            this.Controls.Add(this.label_Hours);
            this.Controls.Add(this.label_Minutes);
            this.Controls.Add(this.label_Seconds);
            this.Controls.Add(this.label_AtThisMoment);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.button_Cancel);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.tbInfo);
            this.Controls.Add(this.label_BirthDate);
            this.Controls.Add(this.dtpBirth);
            this.Controls.Add(this.tbFio);
            this.Controls.Add(this.label_FullName);
            this.Name = "FormAddContact";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.DateTimePicker dtpBirth;
        private System.Windows.Forms.Label label_BirthDate;
        private System.Windows.Forms.TextBox tbInfo;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.Button button_Cancel;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.Label label_AtThisMoment;
        private System.Windows.Forms.Label label_Seconds;
        private System.Windows.Forms.Label label_Minutes;
        private System.Windows.Forms.Label label_Hours;
        private System.Windows.Forms.Label label_Days;
        private System.Windows.Forms.Label label_Weeks;
        private System.Windows.Forms.Label label_Months;
        private System.Windows.Forms.Label label_Years;
        private System.Windows.Forms.Label lYears;
        private System.Windows.Forms.Label lMonthes;
        private System.Windows.Forms.Label lWeeks;
        private System.Windows.Forms.Label lDays;
        private System.Windows.Forms.Label lHours;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lSeconds;
    }
}
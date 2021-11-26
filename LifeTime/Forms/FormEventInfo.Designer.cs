namespace LifeTime.Forms
{
    partial class FormEventInfo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEventInfo));
            this.btOk = new System.Windows.Forms.Button();
            this.label_Date = new System.Windows.Forms.Label();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.tbEventInfo = new System.Windows.Forms.TextBox();
            this.label_Info = new System.Windows.Forms.Label();
            this.gbContactInfo = new System.Windows.Forms.GroupBox();
            this.label_ContactInfo = new System.Windows.Forms.Label();
            this.tbContactInfo = new System.Windows.Forms.TextBox();
            this.label_ContactBirthDate = new System.Windows.Forms.Label();
            this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
            this.tbFio = new System.Windows.Forms.TextBox();
            this.label_ContactFullName = new System.Windows.Forms.Label();
            this.gbContactInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // btOk
            // 
            resources.ApplyResources(this.btOk, "btOk");
            this.btOk.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btOk.Name = "btOk";
            this.btOk.UseVisualStyleBackColor = true;
            // 
            // label_Date
            // 
            resources.ApplyResources(this.label_Date, "label_Date");
            this.label_Date.Name = "label_Date";
            // 
            // dtpEventDate
            // 
            resources.ApplyResources(this.dtpEventDate, "dtpEventDate");
            this.dtpEventDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEventDate.Name = "dtpEventDate";
            // 
            // tbEventInfo
            // 
            resources.ApplyResources(this.tbEventInfo, "tbEventInfo");
            this.tbEventInfo.Name = "tbEventInfo";
            // 
            // label_Info
            // 
            resources.ApplyResources(this.label_Info, "label_Info");
            this.label_Info.Name = "label_Info";
            // 
            // gbContactInfo
            // 
            resources.ApplyResources(this.gbContactInfo, "gbContactInfo");
            this.gbContactInfo.Controls.Add(this.label_ContactInfo);
            this.gbContactInfo.Controls.Add(this.tbContactInfo);
            this.gbContactInfo.Controls.Add(this.label_ContactBirthDate);
            this.gbContactInfo.Controls.Add(this.dtpBirthDate);
            this.gbContactInfo.Controls.Add(this.tbFio);
            this.gbContactInfo.Controls.Add(this.label_ContactFullName);
            this.gbContactInfo.Name = "gbContactInfo";
            this.gbContactInfo.TabStop = false;
            // 
            // label_ContactInfo
            // 
            resources.ApplyResources(this.label_ContactInfo, "label_ContactInfo");
            this.label_ContactInfo.Name = "label_ContactInfo";
            // 
            // tbContactInfo
            // 
            resources.ApplyResources(this.tbContactInfo, "tbContactInfo");
            this.tbContactInfo.Name = "tbContactInfo";
            // 
            // label_ContactBirthDate
            // 
            resources.ApplyResources(this.label_ContactBirthDate, "label_ContactBirthDate");
            this.label_ContactBirthDate.Name = "label_ContactBirthDate";
            // 
            // dtpBirthDate
            // 
            resources.ApplyResources(this.dtpBirthDate, "dtpBirthDate");
            this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpBirthDate.Name = "dtpBirthDate";
            // 
            // tbFio
            // 
            resources.ApplyResources(this.tbFio, "tbFio");
            this.tbFio.Name = "tbFio";
            // 
            // label_ContactFullName
            // 
            resources.ApplyResources(this.label_ContactFullName, "label_ContactFullName");
            this.label_ContactFullName.Name = "label_ContactFullName";
            // 
            // FormEventInfo
            // 
            this.AcceptButton = this.btOk;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btOk;
            this.Controls.Add(this.gbContactInfo);
            this.Controls.Add(this.label_Info);
            this.Controls.Add(this.tbEventInfo);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.label_Date);
            this.Controls.Add(this.btOk);
            this.Name = "FormEventInfo";
            this.gbContactInfo.ResumeLayout(false);
            this.gbContactInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btOk;
        private System.Windows.Forms.Label label_Date;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox tbEventInfo;
        private System.Windows.Forms.Label label_Info;
        private System.Windows.Forms.GroupBox gbContactInfo;
        private System.Windows.Forms.Label label_ContactInfo;
        private System.Windows.Forms.TextBox tbContactInfo;
        private System.Windows.Forms.Label label_ContactBirthDate;
        private System.Windows.Forms.DateTimePicker dtpBirthDate;
        private System.Windows.Forms.TextBox tbFio;
        private System.Windows.Forms.Label label_ContactFullName;
    }
}
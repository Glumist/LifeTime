namespace LifeTime.Forms
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeHour));
            this.rbForward = new System.Windows.Forms.RadioButton();
            this.rbBackward = new System.Windows.Forms.RadioButton();
            this.dtpTimeShift = new System.Windows.Forms.DateTimePicker();
            this.btOk = new System.Windows.Forms.Button();
            this.btCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rbForward
            // 
            resources.ApplyResources(this.rbForward, "rbForward");
            this.rbForward.Checked = true;
            this.rbForward.Name = "rbForward";
            this.rbForward.TabStop = true;
            this.rbForward.UseVisualStyleBackColor = true;
            // 
            // rbBackward
            // 
            resources.ApplyResources(this.rbBackward, "rbBackward");
            this.rbBackward.Name = "rbBackward";
            this.rbBackward.UseVisualStyleBackColor = true;
            // 
            // dtpTimeShift
            // 
            resources.ApplyResources(this.dtpTimeShift, "dtpTimeShift");
            this.dtpTimeShift.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTimeShift.Name = "dtpTimeShift";
            this.dtpTimeShift.ShowUpDown = true;
            this.dtpTimeShift.Value = new System.DateTime(2015, 11, 13, 0, 0, 0, 0);
            // 
            // btOk
            // 
            resources.ApplyResources(this.btOk, "btOk");
            this.btOk.Name = "btOk";
            this.btOk.UseVisualStyleBackColor = true;
            this.btOk.Click += new System.EventHandler(this.btOk_Click);
            // 
            // btCancel
            // 
            resources.ApplyResources(this.btCancel, "btCancel");
            this.btCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btCancel.Name = "btCancel";
            this.btCancel.UseVisualStyleBackColor = true;
            // 
            // FormChangeHour
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btCancel;
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.btOk);
            this.Controls.Add(this.dtpTimeShift);
            this.Controls.Add(this.rbBackward);
            this.Controls.Add(this.rbForward);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormChangeHour";
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
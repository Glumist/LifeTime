namespace LifeTime.Forms
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.label_Version = new System.Windows.Forms.Label();
            this.label_Author = new System.Windows.Forms.Label();
            this.label_Email = new System.Windows.Forms.Label();
            this.button_Ok = new System.Windows.Forms.Button();
            this.textBox_AuthorEmail = new System.Windows.Forms.TextBox();
            this.textBox_AuthorName = new System.Windows.Forms.TextBox();
            this.textBox_Version = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_Version
            // 
            resources.ApplyResources(this.label_Version, "label_Version");
            this.label_Version.Name = "label_Version";
            // 
            // label_Author
            // 
            resources.ApplyResources(this.label_Author, "label_Author");
            this.label_Author.Name = "label_Author";
            // 
            // label_Email
            // 
            resources.ApplyResources(this.label_Email, "label_Email");
            this.label_Email.Name = "label_Email";
            // 
            // button_Ok
            // 
            resources.ApplyResources(this.button_Ok, "button_Ok");
            this.button_Ok.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button_Ok.Name = "button_Ok";
            this.button_Ok.UseVisualStyleBackColor = true;
            // 
            // textBox_AuthorEmail
            // 
            resources.ApplyResources(this.textBox_AuthorEmail, "textBox_AuthorEmail");
            this.textBox_AuthorEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AuthorEmail.Name = "textBox_AuthorEmail";
            this.textBox_AuthorEmail.ReadOnly = true;
            this.textBox_AuthorEmail.TabStop = false;
            // 
            // textBox_AuthorName
            // 
            resources.ApplyResources(this.textBox_AuthorName, "textBox_AuthorName");
            this.textBox_AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AuthorName.Name = "textBox_AuthorName";
            this.textBox_AuthorName.ReadOnly = true;
            this.textBox_AuthorName.TabStop = false;
            // 
            // textBox_Version
            // 
            resources.ApplyResources(this.textBox_Version, "textBox_Version");
            this.textBox_Version.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Version.Name = "textBox_Version";
            this.textBox_Version.ReadOnly = true;
            this.textBox_Version.TabStop = false;
            // 
            // FormAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.button_Ok;
            this.Controls.Add(this.textBox_Version);
            this.Controls.Add(this.textBox_AuthorName);
            this.Controls.Add(this.textBox_AuthorEmail);
            this.Controls.Add(this.button_Ok);
            this.Controls.Add(this.label_Email);
            this.Controls.Add(this.label_Author);
            this.Controls.Add(this.label_Version);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.Label label_Author;
        private System.Windows.Forms.Label label_Email;
        private System.Windows.Forms.Button button_Ok;
        private System.Windows.Forms.TextBox textBox_AuthorEmail;
        private System.Windows.Forms.TextBox textBox_AuthorName;
        private System.Windows.Forms.TextBox textBox_Version;
    }
}
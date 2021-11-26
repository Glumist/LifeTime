namespace LifeTime.Forms
{
    partial class FormCalculations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCalculations));
            this.pParameters = new System.Windows.Forms.Panel();
            this.gbSorting = new System.Windows.Forms.GroupBox();
            this.rbResultByTypes = new System.Windows.Forms.RadioButton();
            this.rbResultByDates = new System.Windows.Forms.RadioButton();
            this.nudMonthesStep = new System.Windows.Forms.NumericUpDown();
            this.nudWeeksStep = new System.Windows.Forms.NumericUpDown();
            this.nudDaysStep = new System.Windows.Forms.NumericUpDown();
            this.nudHoursStep = new System.Windows.Forms.NumericUpDown();
            this.nudMinutesStep = new System.Windows.Forms.NumericUpDown();
            this.chbMonthes = new System.Windows.Forms.CheckBox();
            this.chbWeeks = new System.Windows.Forms.CheckBox();
            this.chbDays = new System.Windows.Forms.CheckBox();
            this.chbHours = new System.Windows.Forms.CheckBox();
            this.chbMinutes = new System.Windows.Forms.CheckBox();
            this.chbSeconds = new System.Windows.Forms.CheckBox();
            this.nudSecondsStep = new System.Windows.Forms.NumericUpDown();
            this.btCalculate = new System.Windows.Forms.Button();
            this.dgvEvents = new System.Windows.Forms.DataGridView();
            this.colDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pParameters.SuspendLayout();
            this.gbSorting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthesStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeksStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).BeginInit();
            this.SuspendLayout();
            // 
            // pParameters
            // 
            resources.ApplyResources(this.pParameters, "pParameters");
            this.pParameters.Controls.Add(this.gbSorting);
            this.pParameters.Controls.Add(this.nudMonthesStep);
            this.pParameters.Controls.Add(this.nudWeeksStep);
            this.pParameters.Controls.Add(this.nudDaysStep);
            this.pParameters.Controls.Add(this.nudHoursStep);
            this.pParameters.Controls.Add(this.nudMinutesStep);
            this.pParameters.Controls.Add(this.chbMonthes);
            this.pParameters.Controls.Add(this.chbWeeks);
            this.pParameters.Controls.Add(this.chbDays);
            this.pParameters.Controls.Add(this.chbHours);
            this.pParameters.Controls.Add(this.chbMinutes);
            this.pParameters.Controls.Add(this.chbSeconds);
            this.pParameters.Controls.Add(this.nudSecondsStep);
            this.pParameters.Controls.Add(this.btCalculate);
            this.pParameters.Name = "pParameters";
            // 
            // gbSorting
            // 
            resources.ApplyResources(this.gbSorting, "gbSorting");
            this.gbSorting.Controls.Add(this.rbResultByTypes);
            this.gbSorting.Controls.Add(this.rbResultByDates);
            this.gbSorting.Name = "gbSorting";
            this.gbSorting.TabStop = false;
            // 
            // rbResultByTypes
            // 
            resources.ApplyResources(this.rbResultByTypes, "rbResultByTypes");
            this.rbResultByTypes.Checked = true;
            this.rbResultByTypes.Name = "rbResultByTypes";
            this.rbResultByTypes.TabStop = true;
            this.rbResultByTypes.UseVisualStyleBackColor = true;
            // 
            // rbResultByDates
            // 
            resources.ApplyResources(this.rbResultByDates, "rbResultByDates");
            this.rbResultByDates.Name = "rbResultByDates";
            this.rbResultByDates.UseVisualStyleBackColor = true;
            // 
            // nudMonthesStep
            // 
            resources.ApplyResources(this.nudMonthesStep, "nudMonthesStep");
            this.nudMonthesStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudMonthesStep.Name = "nudMonthesStep";
            // 
            // nudWeeksStep
            // 
            resources.ApplyResources(this.nudWeeksStep, "nudWeeksStep");
            this.nudWeeksStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudWeeksStep.Name = "nudWeeksStep";
            // 
            // nudDaysStep
            // 
            resources.ApplyResources(this.nudDaysStep, "nudDaysStep");
            this.nudDaysStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudDaysStep.Name = "nudDaysStep";
            // 
            // nudHoursStep
            // 
            resources.ApplyResources(this.nudHoursStep, "nudHoursStep");
            this.nudHoursStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudHoursStep.Name = "nudHoursStep";
            // 
            // nudMinutesStep
            // 
            resources.ApplyResources(this.nudMinutesStep, "nudMinutesStep");
            this.nudMinutesStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudMinutesStep.Name = "nudMinutesStep";
            // 
            // chbMonthes
            // 
            resources.ApplyResources(this.chbMonthes, "chbMonthes");
            this.chbMonthes.Name = "chbMonthes";
            this.chbMonthes.UseVisualStyleBackColor = true;
            // 
            // chbWeeks
            // 
            resources.ApplyResources(this.chbWeeks, "chbWeeks");
            this.chbWeeks.Name = "chbWeeks";
            this.chbWeeks.UseVisualStyleBackColor = true;
            // 
            // chbDays
            // 
            resources.ApplyResources(this.chbDays, "chbDays");
            this.chbDays.Name = "chbDays";
            this.chbDays.UseVisualStyleBackColor = true;
            // 
            // chbHours
            // 
            resources.ApplyResources(this.chbHours, "chbHours");
            this.chbHours.Name = "chbHours";
            this.chbHours.UseVisualStyleBackColor = true;
            // 
            // chbMinutes
            // 
            resources.ApplyResources(this.chbMinutes, "chbMinutes");
            this.chbMinutes.Name = "chbMinutes";
            this.chbMinutes.UseVisualStyleBackColor = true;
            // 
            // chbSeconds
            // 
            resources.ApplyResources(this.chbSeconds, "chbSeconds");
            this.chbSeconds.Name = "chbSeconds";
            this.chbSeconds.UseVisualStyleBackColor = true;
            // 
            // nudSecondsStep
            // 
            resources.ApplyResources(this.nudSecondsStep, "nudSecondsStep");
            this.nudSecondsStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudSecondsStep.Name = "nudSecondsStep";
            // 
            // btCalculate
            // 
            resources.ApplyResources(this.btCalculate, "btCalculate");
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // dgvEvents
            // 
            resources.ApplyResources(this.dgvEvents, "dgvEvents");
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AllowUserToResizeRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colInfo});
            this.dgvEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DateString";
            resources.ApplyResources(this.colDate, "colDate");
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colInfo
            // 
            this.colInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInfo.DataPropertyName = "Info";
            resources.ApplyResources(this.colInfo, "colInfo");
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            // 
            // FormCalculations
            // 
            this.AcceptButton = this.btCalculate;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.pParameters);
            this.Name = "FormCalculations";
            this.Load += new System.EventHandler(this.FormCalculations_Load);
            this.pParameters.ResumeLayout(false);
            this.pParameters.PerformLayout();
            this.gbSorting.ResumeLayout(false);
            this.gbSorting.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthesStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudWeeksStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudDaysStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudHoursStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinutesStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSecondsStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pParameters;
        private System.Windows.Forms.DataGridView dgvEvents;
        private System.Windows.Forms.NumericUpDown nudSecondsStep;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.NumericUpDown nudMonthesStep;
        private System.Windows.Forms.NumericUpDown nudWeeksStep;
        private System.Windows.Forms.NumericUpDown nudDaysStep;
        private System.Windows.Forms.NumericUpDown nudHoursStep;
        private System.Windows.Forms.NumericUpDown nudMinutesStep;
        private System.Windows.Forms.CheckBox chbMonthes;
        private System.Windows.Forms.CheckBox chbWeeks;
        private System.Windows.Forms.CheckBox chbDays;
        private System.Windows.Forms.CheckBox chbHours;
        private System.Windows.Forms.CheckBox chbMinutes;
        private System.Windows.Forms.CheckBox chbSeconds;
        private System.Windows.Forms.GroupBox gbSorting;
        private System.Windows.Forms.RadioButton rbResultByTypes;
        private System.Windows.Forms.RadioButton rbResultByDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
    }
}
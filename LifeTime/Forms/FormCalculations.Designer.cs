namespace Days
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.groupBox1.SuspendLayout();
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
            this.pParameters.Controls.Add(this.groupBox1);
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
            this.pParameters.Dock = System.Windows.Forms.DockStyle.Left;
            this.pParameters.Location = new System.Drawing.Point(0, 0);
            this.pParameters.Name = "pParameters";
            this.pParameters.Size = new System.Drawing.Size(220, 682);
            this.pParameters.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbResultByTypes);
            this.groupBox1.Controls.Add(this.rbResultByDates);
            this.groupBox1.Location = new System.Drawing.Point(9, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 45);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Результат";
            // 
            // rbResultByTypes
            // 
            this.rbResultByTypes.AutoSize = true;
            this.rbResultByTypes.Checked = true;
            this.rbResultByTypes.Location = new System.Drawing.Point(3, 19);
            this.rbResultByTypes.Name = "rbResultByTypes";
            this.rbResultByTypes.Size = new System.Drawing.Size(74, 17);
            this.rbResultByTypes.TabIndex = 1;
            this.rbResultByTypes.TabStop = true;
            this.rbResultByTypes.Text = "По видам";
            this.rbResultByTypes.UseVisualStyleBackColor = true;
            // 
            // rbResultByDates
            // 
            this.rbResultByDates.AutoSize = true;
            this.rbResultByDates.Location = new System.Drawing.Point(121, 19);
            this.rbResultByDates.Name = "rbResultByDates";
            this.rbResultByDates.Size = new System.Drawing.Size(73, 17);
            this.rbResultByDates.TabIndex = 0;
            this.rbResultByDates.Text = "По датам";
            this.rbResultByDates.UseVisualStyleBackColor = true;
            // 
            // nudMonthesStep
            // 
            this.nudMonthesStep.Location = new System.Drawing.Point(83, 139);
            this.nudMonthesStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudMonthesStep.Name = "nudMonthesStep";
            this.nudMonthesStep.Size = new System.Drawing.Size(126, 20);
            this.nudMonthesStep.TabIndex = 11;
            this.nudMonthesStep.ThousandsSeparator = true;
            // 
            // nudWeeksStep
            // 
            this.nudWeeksStep.Location = new System.Drawing.Point(83, 113);
            this.nudWeeksStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudWeeksStep.Name = "nudWeeksStep";
            this.nudWeeksStep.Size = new System.Drawing.Size(126, 20);
            this.nudWeeksStep.TabIndex = 10;
            this.nudWeeksStep.ThousandsSeparator = true;
            // 
            // nudDaysStep
            // 
            this.nudDaysStep.Location = new System.Drawing.Point(83, 87);
            this.nudDaysStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudDaysStep.Name = "nudDaysStep";
            this.nudDaysStep.Size = new System.Drawing.Size(126, 20);
            this.nudDaysStep.TabIndex = 9;
            this.nudDaysStep.ThousandsSeparator = true;
            // 
            // nudHoursStep
            // 
            this.nudHoursStep.Location = new System.Drawing.Point(83, 61);
            this.nudHoursStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudHoursStep.Name = "nudHoursStep";
            this.nudHoursStep.Size = new System.Drawing.Size(126, 20);
            this.nudHoursStep.TabIndex = 8;
            this.nudHoursStep.ThousandsSeparator = true;
            // 
            // nudMinutesStep
            // 
            this.nudMinutesStep.Location = new System.Drawing.Point(83, 35);
            this.nudMinutesStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudMinutesStep.Name = "nudMinutesStep";
            this.nudMinutesStep.Size = new System.Drawing.Size(126, 20);
            this.nudMinutesStep.TabIndex = 7;
            this.nudMinutesStep.ThousandsSeparator = true;
            // 
            // chbMonthes
            // 
            this.chbMonthes.AutoSize = true;
            this.chbMonthes.Location = new System.Drawing.Point(12, 141);
            this.chbMonthes.Name = "chbMonthes";
            this.chbMonthes.Size = new System.Drawing.Size(67, 17);
            this.chbMonthes.TabIndex = 5;
            this.chbMonthes.Text = "Месяцы";
            this.chbMonthes.UseVisualStyleBackColor = true;
            // 
            // chbWeeks
            // 
            this.chbWeeks.AutoSize = true;
            this.chbWeeks.Location = new System.Drawing.Point(12, 115);
            this.chbWeeks.Name = "chbWeeks";
            this.chbWeeks.Size = new System.Drawing.Size(64, 17);
            this.chbWeeks.TabIndex = 4;
            this.chbWeeks.Text = "Недели";
            this.chbWeeks.UseVisualStyleBackColor = true;
            // 
            // chbDays
            // 
            this.chbDays.AutoSize = true;
            this.chbDays.Location = new System.Drawing.Point(12, 89);
            this.chbDays.Name = "chbDays";
            this.chbDays.Size = new System.Drawing.Size(47, 17);
            this.chbDays.TabIndex = 3;
            this.chbDays.Text = "Дни";
            this.chbDays.UseVisualStyleBackColor = true;
            // 
            // chbHours
            // 
            this.chbHours.AutoSize = true;
            this.chbHours.Location = new System.Drawing.Point(12, 63);
            this.chbHours.Name = "chbHours";
            this.chbHours.Size = new System.Drawing.Size(54, 17);
            this.chbHours.TabIndex = 2;
            this.chbHours.Text = "Часы";
            this.chbHours.UseVisualStyleBackColor = true;
            // 
            // chbMinutes
            // 
            this.chbMinutes.AutoSize = true;
            this.chbMinutes.Location = new System.Drawing.Point(12, 37);
            this.chbMinutes.Name = "chbMinutes";
            this.chbMinutes.Size = new System.Drawing.Size(65, 17);
            this.chbMinutes.TabIndex = 1;
            this.chbMinutes.Text = "Минуты";
            this.chbMinutes.UseVisualStyleBackColor = true;
            // 
            // chbSeconds
            // 
            this.chbSeconds.AutoSize = true;
            this.chbSeconds.Location = new System.Drawing.Point(12, 12);
            this.chbSeconds.Name = "chbSeconds";
            this.chbSeconds.Size = new System.Drawing.Size(70, 17);
            this.chbSeconds.TabIndex = 0;
            this.chbSeconds.Text = "Секунды";
            this.chbSeconds.UseVisualStyleBackColor = true;
            // 
            // nudSecondsStep
            // 
            this.nudSecondsStep.Location = new System.Drawing.Point(83, 9);
            this.nudSecondsStep.Maximum = new decimal(new int[] {
            1935228928,
            7,
            0,
            0});
            this.nudSecondsStep.Name = "nudSecondsStep";
            this.nudSecondsStep.Size = new System.Drawing.Size(126, 20);
            this.nudSecondsStep.TabIndex = 6;
            this.nudSecondsStep.ThousandsSeparator = true;
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(73, 216);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(75, 23);
            this.btCalculate.TabIndex = 12;
            this.btCalculate.Text = "Расчитать";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // dgvEvents
            // 
            this.dgvEvents.AllowUserToAddRows = false;
            this.dgvEvents.AllowUserToDeleteRows = false;
            this.dgvEvents.AllowUserToResizeRows = false;
            this.dgvEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDate,
            this.colInfo});
            this.dgvEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvEvents.Location = new System.Drawing.Point(220, 0);
            this.dgvEvents.MultiSelect = false;
            this.dgvEvents.Name = "dgvEvents";
            this.dgvEvents.ReadOnly = true;
            this.dgvEvents.RowHeadersVisible = false;
            this.dgvEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEvents.Size = new System.Drawing.Size(345, 682);
            this.dgvEvents.TabIndex = 1;
            // 
            // colDate
            // 
            this.colDate.DataPropertyName = "DateString";
            this.colDate.HeaderText = "Дата";
            this.colDate.Name = "colDate";
            this.colDate.ReadOnly = true;
            // 
            // colInfo
            // 
            this.colInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colInfo.DataPropertyName = "Info";
            this.colInfo.HeaderText = "Срок";
            this.colInfo.Name = "colInfo";
            this.colInfo.ReadOnly = true;
            // 
            // FormCalculations
            // 
            this.AcceptButton = this.btCalculate;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 682);
            this.Controls.Add(this.dgvEvents);
            this.Controls.Add(this.pParameters);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormCalculations";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Расчеты";
            this.Load += new System.EventHandler(this.FormCalculations_Load);
            this.pParameters.ResumeLayout(false);
            this.pParameters.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbResultByTypes;
        private System.Windows.Forms.RadioButton rbResultByDates;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInfo;
    }
}
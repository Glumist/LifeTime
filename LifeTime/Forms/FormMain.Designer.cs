namespace LifeTime.Forms
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tcEvents = new System.Windows.Forms.TabControl();
            this.tpFuture = new System.Windows.Forms.TabPage();
            this.dgvFutureEvents = new System.Windows.Forms.DataGridView();
            this.colFutureEventsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFutureEventsContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFutureEventsInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tpPast = new System.Windows.Forms.TabPage();
            this.dgvPastEvents = new System.Windows.Forms.DataGridView();
            this.colPastEventsDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPastEventsContact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPastEventsInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.msContact = new System.Windows.Forms.MenuStrip();
            this.контактToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiEditContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRemoveContact = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiCalculations = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiChangeHour = new System.Windows.Forms.ToolStripMenuItem();
            this.tscbContactSort = new System.Windows.Forms.ToolStripComboBox();
            this.tstbFilter = new System.Windows.Forms.ToolStripTextBox();
            this.tsmiEnableFilter = new System.Windows.Forms.ToolStripMenuItem();
            this.tcMain = new System.Windows.Forms.TabControl();
            this.tpEvents = new System.Windows.Forms.TabPage();
            this.tpContacts = new System.Windows.Forms.TabPage();
            this.dgvContacts = new System.Windows.Forms.DataGridView();
            this.colFio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colContactInfo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bsContacts = new System.Windows.Forms.BindingSource(this.components);
            this.ssContactLifeTime = new System.Windows.Forms.StatusStrip();
            this.tsslContactLifeTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslMiddle = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslContactCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.tsmiSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiRecalc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiLanguage = new System.Windows.Forms.ToolStripMenuItem();
            this.niMain = new System.Windows.Forms.NotifyIcon(this.components);
            this.cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiShow = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.tMain = new System.Windows.Forms.Timer(this.components);
            this.tcEvents.SuspendLayout();
            this.tpFuture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutureEvents)).BeginInit();
            this.tpPast.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastEvents)).BeginInit();
            this.msContact.SuspendLayout();
            this.tcMain.SuspendLayout();
            this.tpEvents.SuspendLayout();
            this.tpContacts.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).BeginInit();
            this.ssContactLifeTime.SuspendLayout();
            this.msMain.SuspendLayout();
            this.cmsTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // tcEvents
            // 
            this.tcEvents.Controls.Add(this.tpFuture);
            this.tcEvents.Controls.Add(this.tpPast);
            this.tcEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcEvents.Location = new System.Drawing.Point(3, 3);
            this.tcEvents.Name = "tcEvents";
            this.tcEvents.SelectedIndex = 0;
            this.tcEvents.Size = new System.Drawing.Size(961, 556);
            this.tcEvents.TabIndex = 0;
            // 
            // tpFuture
            // 
            this.tpFuture.Controls.Add(this.dgvFutureEvents);
            this.tpFuture.Location = new System.Drawing.Point(4, 22);
            this.tpFuture.Name = "tpFuture";
            this.tpFuture.Padding = new System.Windows.Forms.Padding(3);
            this.tpFuture.Size = new System.Drawing.Size(953, 530);
            this.tpFuture.TabIndex = 0;
            this.tpFuture.Text = "Будущие";
            this.tpFuture.UseVisualStyleBackColor = true;
            // 
            // dgvFutureEvents
            // 
            this.dgvFutureEvents.AllowUserToAddRows = false;
            this.dgvFutureEvents.AllowUserToDeleteRows = false;
            this.dgvFutureEvents.AllowUserToResizeRows = false;
            this.dgvFutureEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFutureEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFutureEventsDate,
            this.colFutureEventsContact,
            this.colFutureEventsInfo});
            this.dgvFutureEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFutureEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvFutureEvents.Location = new System.Drawing.Point(3, 3);
            this.dgvFutureEvents.Name = "dgvFutureEvents";
            this.dgvFutureEvents.ReadOnly = true;
            this.dgvFutureEvents.RowHeadersVisible = false;
            this.dgvFutureEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFutureEvents.ShowEditingIcon = false;
            this.dgvFutureEvents.Size = new System.Drawing.Size(947, 524);
            this.dgvFutureEvents.TabIndex = 0;
            this.dgvFutureEvents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFutureEvents_CellDoubleClick);
            // 
            // colFutureEventsDate
            // 
            this.colFutureEventsDate.DataPropertyName = "DateString";
            this.colFutureEventsDate.HeaderText = "Дата";
            this.colFutureEventsDate.Name = "colFutureEventsDate";
            this.colFutureEventsDate.ReadOnly = true;
            // 
            // colFutureEventsContact
            // 
            this.colFutureEventsContact.DataPropertyName = "Contact";
            this.colFutureEventsContact.HeaderText = "Контакт";
            this.colFutureEventsContact.Name = "colFutureEventsContact";
            this.colFutureEventsContact.ReadOnly = true;
            this.colFutureEventsContact.Width = 300;
            // 
            // colFutureEventsInfo
            // 
            this.colFutureEventsInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colFutureEventsInfo.DataPropertyName = "Info";
            this.colFutureEventsInfo.HeaderText = "Инфо";
            this.colFutureEventsInfo.Name = "colFutureEventsInfo";
            this.colFutureEventsInfo.ReadOnly = true;
            // 
            // tpPast
            // 
            this.tpPast.Controls.Add(this.dgvPastEvents);
            this.tpPast.Location = new System.Drawing.Point(4, 22);
            this.tpPast.Name = "tpPast";
            this.tpPast.Padding = new System.Windows.Forms.Padding(3);
            this.tpPast.Size = new System.Drawing.Size(953, 530);
            this.tpPast.TabIndex = 1;
            this.tpPast.Text = "Прошлые";
            this.tpPast.UseVisualStyleBackColor = true;
            // 
            // dgvPastEvents
            // 
            this.dgvPastEvents.AllowUserToAddRows = false;
            this.dgvPastEvents.AllowUserToDeleteRows = false;
            this.dgvPastEvents.AllowUserToResizeRows = false;
            this.dgvPastEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPastEvents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colPastEventsDate,
            this.colPastEventsContact,
            this.colPastEventsInfo});
            this.dgvPastEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPastEvents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvPastEvents.Location = new System.Drawing.Point(3, 3);
            this.dgvPastEvents.MultiSelect = false;
            this.dgvPastEvents.Name = "dgvPastEvents";
            this.dgvPastEvents.ReadOnly = true;
            this.dgvPastEvents.RowHeadersVisible = false;
            this.dgvPastEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPastEvents.ShowEditingIcon = false;
            this.dgvPastEvents.Size = new System.Drawing.Size(947, 524);
            this.dgvPastEvents.TabIndex = 1;
            this.dgvPastEvents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPastEvents_CellDoubleClick);
            // 
            // colPastEventsDate
            // 
            this.colPastEventsDate.DataPropertyName = "DateString";
            this.colPastEventsDate.HeaderText = "Дата";
            this.colPastEventsDate.Name = "colPastEventsDate";
            this.colPastEventsDate.ReadOnly = true;
            // 
            // colPastEventsContact
            // 
            this.colPastEventsContact.DataPropertyName = "Contact";
            this.colPastEventsContact.HeaderText = "Контакт";
            this.colPastEventsContact.Name = "colPastEventsContact";
            this.colPastEventsContact.ReadOnly = true;
            this.colPastEventsContact.Width = 300;
            // 
            // colPastEventsInfo
            // 
            this.colPastEventsInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colPastEventsInfo.DataPropertyName = "Info";
            this.colPastEventsInfo.HeaderText = "Инфо";
            this.colPastEventsInfo.Name = "colPastEventsInfo";
            this.colPastEventsInfo.ReadOnly = true;
            // 
            // msContact
            // 
            this.msContact.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.контактToolStripMenuItem,
            this.tsmiCalculations,
            this.tsmiChangeHour,
            this.tscbContactSort,
            this.tstbFilter,
            this.tsmiEnableFilter});
            this.msContact.Location = new System.Drawing.Point(3, 3);
            this.msContact.Name = "msContact";
            this.msContact.Size = new System.Drawing.Size(961, 27);
            this.msContact.TabIndex = 1;
            this.msContact.Text = "menuStrip1";
            // 
            // контактToolStripMenuItem
            // 
            this.контактToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddContact,
            this.tsmiEditContact,
            this.tsmiRemoveContact});
            this.контактToolStripMenuItem.Image = global::LifeTime.Properties.Resources.iconContact;
            this.контактToolStripMenuItem.Name = "контактToolStripMenuItem";
            this.контактToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.контактToolStripMenuItem.Text = "Контакт";
            // 
            // tsmiAddContact
            // 
            this.tsmiAddContact.Image = global::LifeTime.Properties.Resources.iconAdd;
            this.tsmiAddContact.Name = "tsmiAddContact";
            this.tsmiAddContact.Size = new System.Drawing.Size(154, 22);
            this.tsmiAddContact.Text = "Добавить";
            this.tsmiAddContact.Click += new System.EventHandler(this.tsmiAddContact_Click);
            // 
            // tsmiEditContact
            // 
            this.tsmiEditContact.Image = global::LifeTime.Properties.Resources.iconEdit;
            this.tsmiEditContact.Name = "tsmiEditContact";
            this.tsmiEditContact.Size = new System.Drawing.Size(154, 22);
            this.tsmiEditContact.Text = "Редактировать";
            this.tsmiEditContact.Click += new System.EventHandler(this.tsmiEditContact_Click);
            // 
            // tsmiRemoveContact
            // 
            this.tsmiRemoveContact.Image = global::LifeTime.Properties.Resources.iconDelete;
            this.tsmiRemoveContact.Name = "tsmiRemoveContact";
            this.tsmiRemoveContact.Size = new System.Drawing.Size(154, 22);
            this.tsmiRemoveContact.Text = "Удалить";
            this.tsmiRemoveContact.Click += new System.EventHandler(this.tsmiRemoveContact_Click);
            // 
            // tsmiCalculations
            // 
            this.tsmiCalculations.Image = global::LifeTime.Properties.Resources.iconCalculator;
            this.tsmiCalculations.Name = "tsmiCalculations";
            this.tsmiCalculations.Size = new System.Drawing.Size(81, 23);
            this.tsmiCalculations.Text = "Расчеты";
            this.tsmiCalculations.Click += new System.EventHandler(this.tsmiCalculations_Click);
            // 
            // tsmiChangeHour
            // 
            this.tsmiChangeHour.Image = global::LifeTime.Properties.Resources.iconClock;
            this.tsmiChangeHour.Name = "tsmiChangeHour";
            this.tsmiChangeHour.Size = new System.Drawing.Size(161, 23);
            this.tsmiChangeHour.Text = "Сменить часовой пояс";
            this.tsmiChangeHour.Click += new System.EventHandler(this.tsmiChangeHour_Click);
            // 
            // tscbContactSort
            // 
            this.tscbContactSort.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tscbContactSort.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tscbContactSort.Items.AddRange(new object[] {
            "По именам",
            "По датам"});
            this.tscbContactSort.MaxDropDownItems = 2;
            this.tscbContactSort.Name = "tscbContactSort";
            this.tscbContactSort.Size = new System.Drawing.Size(90, 23);
            this.tscbContactSort.ToolTipText = "Сортировка";
            this.tscbContactSort.SelectedIndexChanged += new System.EventHandler(this.tscbContactSort_SelectedIndexChanged);
            // 
            // tstbFilter
            // 
            this.tstbFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstbFilter.Name = "tstbFilter";
            this.tstbFilter.Size = new System.Drawing.Size(100, 23);
            this.tstbFilter.Visible = false;
            this.tstbFilter.TextChanged += new System.EventHandler(this.tstbFilter_TextChanged);
            // 
            // tsmiEnableFilter
            // 
            this.tsmiEnableFilter.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiEnableFilter.CheckOnClick = true;
            this.tsmiEnableFilter.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsmiEnableFilter.Image = global::LifeTime.Properties.Resources.iconFilter;
            this.tsmiEnableFilter.Name = "tsmiEnableFilter";
            this.tsmiEnableFilter.Size = new System.Drawing.Size(28, 23);
            this.tsmiEnableFilter.Text = "Фильтр";
            this.tsmiEnableFilter.ToolTipText = "Фильтр";
            this.tsmiEnableFilter.CheckedChanged += new System.EventHandler(this.tsmiEnableFilter_CheckedChanged);
            // 
            // tcMain
            // 
            this.tcMain.Controls.Add(this.tpEvents);
            this.tcMain.Controls.Add(this.tpContacts);
            this.tcMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcMain.Location = new System.Drawing.Point(0, 24);
            this.tcMain.Name = "tcMain";
            this.tcMain.SelectedIndex = 0;
            this.tcMain.Size = new System.Drawing.Size(975, 588);
            this.tcMain.TabIndex = 2;
            this.tcMain.SelectedIndexChanged += new System.EventHandler(this.tcMain_SelectedIndexChanged);
            // 
            // tpEvents
            // 
            this.tpEvents.Controls.Add(this.tcEvents);
            this.tpEvents.Location = new System.Drawing.Point(4, 22);
            this.tpEvents.Name = "tpEvents";
            this.tpEvents.Padding = new System.Windows.Forms.Padding(3);
            this.tpEvents.Size = new System.Drawing.Size(967, 562);
            this.tpEvents.TabIndex = 0;
            this.tpEvents.Text = "События";
            this.tpEvents.UseVisualStyleBackColor = true;
            // 
            // tpContacts
            // 
            this.tpContacts.Controls.Add(this.dgvContacts);
            this.tpContacts.Controls.Add(this.msContact);
            this.tpContacts.Controls.Add(this.ssContactLifeTime);
            this.tpContacts.Location = new System.Drawing.Point(4, 22);
            this.tpContacts.Name = "tpContacts";
            this.tpContacts.Padding = new System.Windows.Forms.Padding(3);
            this.tpContacts.Size = new System.Drawing.Size(967, 562);
            this.tpContacts.TabIndex = 1;
            this.tpContacts.Text = "Контакты";
            this.tpContacts.UseVisualStyleBackColor = true;
            // 
            // dgvContacts
            // 
            this.dgvContacts.AllowUserToAddRows = false;
            this.dgvContacts.AllowUserToDeleteRows = false;
            this.dgvContacts.AllowUserToResizeRows = false;
            this.dgvContacts.AutoGenerateColumns = false;
            this.dgvContacts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContacts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colFio,
            this.colBirthDate,
            this.colContactInfo});
            this.dgvContacts.DataSource = this.bsContacts;
            this.dgvContacts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvContacts.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvContacts.Location = new System.Drawing.Point(3, 30);
            this.dgvContacts.MultiSelect = false;
            this.dgvContacts.Name = "dgvContacts";
            this.dgvContacts.RowHeadersVisible = false;
            this.dgvContacts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContacts.Size = new System.Drawing.Size(961, 507);
            this.dgvContacts.TabIndex = 2;
            this.dgvContacts.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContacts_CellDoubleClick);
            this.dgvContacts.SelectionChanged += new System.EventHandler(this.dgvContacts_SelectionChanged);
            this.dgvContacts.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvContacts_KeyDown);
            // 
            // colFio
            // 
            this.colFio.DataPropertyName = "Fio";
            this.colFio.HeaderText = "ФИО";
            this.colFio.Name = "colFio";
            this.colFio.ReadOnly = true;
            this.colFio.Width = 300;
            // 
            // colBirthDate
            // 
            this.colBirthDate.DataPropertyName = "BirthDateString";
            this.colBirthDate.HeaderText = "Дата рождения";
            this.colBirthDate.Name = "colBirthDate";
            this.colBirthDate.ReadOnly = true;
            // 
            // colContactInfo
            // 
            this.colContactInfo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colContactInfo.DataPropertyName = "Info";
            this.colContactInfo.HeaderText = "Инфо";
            this.colContactInfo.Name = "colContactInfo";
            this.colContactInfo.ReadOnly = true;
            // 
            // ssContactLifeTime
            // 
            this.ssContactLifeTime.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslContactLifeTime,
            this.tsslMiddle,
            this.tsslContactCount});
            this.ssContactLifeTime.Location = new System.Drawing.Point(3, 537);
            this.ssContactLifeTime.Name = "ssContactLifeTime";
            this.ssContactLifeTime.Size = new System.Drawing.Size(961, 22);
            this.ssContactLifeTime.TabIndex = 3;
            // 
            // tsslContactLifeTime
            // 
            this.tsslContactLifeTime.Name = "tsslContactLifeTime";
            this.tsslContactLifeTime.Size = new System.Drawing.Size(0, 17);
            // 
            // tsslMiddle
            // 
            this.tsslMiddle.Name = "tsslMiddle";
            this.tsslMiddle.Size = new System.Drawing.Size(946, 17);
            this.tsslMiddle.Spring = true;
            // 
            // tsslContactCount
            // 
            this.tsslContactCount.Name = "tsslContactCount";
            this.tsslContactCount.Size = new System.Drawing.Size(0, 17);
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSettings,
            this.tsmiRecalc,
            this.tsmiAbout,
            this.tsmiLanguage});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(975, 24);
            this.msMain.TabIndex = 3;
            this.msMain.Text = "menuStrip2";
            // 
            // tsmiSettings
            // 
            this.tsmiSettings.Image = global::LifeTime.Properties.Resources.iconSettings;
            this.tsmiSettings.Name = "tsmiSettings";
            this.tsmiSettings.Size = new System.Drawing.Size(95, 20);
            this.tsmiSettings.Text = "Настройки";
            this.tsmiSettings.Click += new System.EventHandler(this.tsmiSettings_Click);
            // 
            // tsmiRecalc
            // 
            this.tsmiRecalc.Image = global::LifeTime.Properties.Resources.iconRecalc;
            this.tsmiRecalc.Name = "tsmiRecalc";
            this.tsmiRecalc.Size = new System.Drawing.Size(138, 20);
            this.tsmiRecalc.Text = "Пересчет событий";
            this.tsmiRecalc.Click += new System.EventHandler(this.tsmiRecalc_Click);
            // 
            // tsmiAbout
            // 
            this.tsmiAbout.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsmiAbout.Name = "tsmiAbout";
            this.tsmiAbout.Size = new System.Drawing.Size(94, 20);
            this.tsmiAbout.Text = "О программе";
            this.tsmiAbout.Click += new System.EventHandler(this.tsmiAbout_Click);
            // 
            // tsmiLanguage
            // 
            this.tsmiLanguage.Name = "tsmiLanguage";
            this.tsmiLanguage.Size = new System.Drawing.Size(46, 20);
            this.tsmiLanguage.Text = "Язык";
            // 
            // niMain
            // 
            this.niMain.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.niMain.BalloonTipTitle = "События на сегодня";
            this.niMain.ContextMenuStrip = this.cmsTray;
            this.niMain.Icon = ((System.Drawing.Icon)(resources.GetObject("niMain.Icon")));
            this.niMain.Text = "События";
            this.niMain.BalloonTipClicked += new System.EventHandler(this.niMain_BalloonTipClicked);
            this.niMain.DoubleClick += new System.EventHandler(this.niMain_DoubleClick);
            // 
            // cmsTray
            // 
            this.cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiShow,
            this.tsmiExit});
            this.cmsTray.Name = "cmsTray";
            this.cmsTray.Size = new System.Drawing.Size(155, 48);
            // 
            // tsmiShow
            // 
            this.tsmiShow.Name = "tsmiShow";
            this.tsmiShow.Size = new System.Drawing.Size(154, 22);
            this.tsmiShow.Text = "Показать окно";
            this.tsmiShow.Click += new System.EventHandler(this.tsmiShow_Click);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(154, 22);
            this.tsmiExit.Text = "Выйти";
            this.tsmiExit.Click += new System.EventHandler(this.tsmiExit_Click);
            // 
            // tMain
            // 
            this.tMain.Interval = 60000;
            this.tMain.Tick += new System.EventHandler(this.tMain_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 612);
            this.Controls.Add(this.tcMain);
            this.Controls.Add(this.msMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMain;
            this.Name = "FormMain";
            this.Text = "События";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Resize += new System.EventHandler(this.FormMain_Resize);
            this.tcEvents.ResumeLayout(false);
            this.tpFuture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFutureEvents)).EndInit();
            this.tpPast.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPastEvents)).EndInit();
            this.msContact.ResumeLayout(false);
            this.msContact.PerformLayout();
            this.tcMain.ResumeLayout(false);
            this.tpEvents.ResumeLayout(false);
            this.tpContacts.ResumeLayout(false);
            this.tpContacts.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContacts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsContacts)).EndInit();
            this.ssContactLifeTime.ResumeLayout(false);
            this.ssContactLifeTime.PerformLayout();
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.cmsTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tcEvents;
        private System.Windows.Forms.TabPage tpFuture;
        private System.Windows.Forms.TabPage tpPast;
        private System.Windows.Forms.MenuStrip msContact;
        private System.Windows.Forms.DataGridView dgvFutureEvents;
        private System.Windows.Forms.TabControl tcMain;
        private System.Windows.Forms.TabPage tpEvents;
        private System.Windows.Forms.TabPage tpContacts;
        private System.Windows.Forms.DataGridView dgvContacts;
        private System.Windows.Forms.DataGridView dgvPastEvents;
        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem tsmiSettings;
        private System.Windows.Forms.ToolStripMenuItem tsmiRecalc;
        private System.Windows.Forms.NotifyIcon niMain;
        private System.Windows.Forms.ContextMenuStrip cmsTray;
        private System.Windows.Forms.ToolStripMenuItem tsmiShow;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.Timer tMain;
        private System.Windows.Forms.BindingSource bsContacts;
        private System.Windows.Forms.ToolStripMenuItem tsmiAbout;
        private System.Windows.Forms.ToolStripMenuItem tsmiChangeHour;
        private System.Windows.Forms.ToolStripMenuItem tsmiCalculations;
        private System.Windows.Forms.StatusStrip ssContactLifeTime;
        private System.Windows.Forms.ToolStripStatusLabel tsslContactLifeTime;
        private System.Windows.Forms.ToolStripComboBox tscbContactSort;
        private System.Windows.Forms.ToolStripStatusLabel tsslContactCount;
        private System.Windows.Forms.ToolStripStatusLabel tsslMiddle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colContactInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFutureEventsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFutureEventsContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFutureEventsInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPastEventsDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPastEventsContact;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPastEventsInfo;
        private System.Windows.Forms.ToolStripMenuItem контактToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddContact;
        private System.Windows.Forms.ToolStripMenuItem tsmiEditContact;
        private System.Windows.Forms.ToolStripMenuItem tsmiRemoveContact;
        private System.Windows.Forms.ToolStripTextBox tstbFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiEnableFilter;
        private System.Windows.Forms.ToolStripMenuItem tsmiLanguage;
    }
}


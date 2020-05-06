namespace BackupRestore
{
    partial class frmMain
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
            System.Windows.Forms.Label nameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.bar4 = new DevExpress.XtraBars.Bar();
            this.bar5 = new DevExpress.XtraBars.Bar();
            this.bar6 = new DevExpress.XtraBars.Bar();
            this.tempdbDataSet = new BackupRestore.tempdbDataSet();
            this.databasesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databasesTableAdapter = new BackupRestore.tempdbDataSetTableAdapters.databasesTableAdapter();
            this.tableAdapterManager = new BackupRestore.tempdbDataSetTableAdapters.TableAdapterManager();
            this.databasesGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.DATABASE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar7 = new DevExpress.XtraBars.Bar();
            this.barBackUp = new DevExpress.XtraBars.BarButtonItem();
            this.barRestore = new DevExpress.XtraBars.BarButtonItem();
            this.barCheckRestore = new DevExpress.XtraBars.BarCheckItem();
            this.barCreateDevice = new DevExpress.XtraBars.BarButtonItem();
            this.barExit = new DevExpress.XtraBars.BarButtonItem();
            this.bar9 = new DevExpress.XtraBars.Bar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barResoreOvertime = new DevExpress.XtraBars.BarButtonItem();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.backup_devicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backup_devicesTableAdapter = new BackupRestore.tempdbDataSetTableAdapters.backup_devicesTableAdapter();
            this.sP_STT_BACKUPBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sP_STT_BACKUPTableAdapter = new BackupRestore.tempdbDataSetTableAdapters.SP_STT_BACKUPTableAdapter();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbXoasaoluu = new System.Windows.Forms.CheckBox();
            this.positionTextBox = new System.Windows.Forms.TextBox();
            this.nameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.sP_STT_BACKUPGridControl = new DevExpress.XtraGrid.GridControl();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colposition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbackup_start_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coluser_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.datePickerTime = new System.Windows.Forms.DateTimePicker();
            this.datePickerDay = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_devicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(6, 2);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(117, 17);
            nameLabel.TabIndex = 1;
            nameLabel.Text = "Tên cơ sở dữ liệu";
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.Text = "Tools";
            // 
            // bar2
            // 
            this.bar2.BarName = "Tools";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.Text = "Tools";
            // 
            // bar3
            // 
            this.bar3.BarName = "Tools";
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar3.Text = "Tools";
            // 
            // bar4
            // 
            this.bar4.BarName = "Tools";
            this.bar4.DockCol = 0;
            this.bar4.DockRow = 0;
            this.bar4.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar4.Text = "Tools";
            // 
            // bar5
            // 
            this.bar5.BarName = "Tools";
            this.bar5.DockCol = 0;
            this.bar5.DockRow = 0;
            this.bar5.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar5.Text = "Tools";
            // 
            // bar6
            // 
            this.bar6.BarName = "Tools";
            this.bar6.DockCol = 0;
            this.bar6.DockRow = 0;
            this.bar6.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar6.Text = "Tools";
            // 
            // tempdbDataSet
            // 
            this.tempdbDataSet.DataSetName = "tempdbDataSet";
            this.tempdbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databasesBindingSource
            // 
            this.databasesBindingSource.DataMember = "databases";
            this.databasesBindingSource.DataSource = this.tempdbDataSet;
            // 
            // databasesTableAdapter
            // 
            this.databasesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.UpdateOrder = BackupRestore.tempdbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // databasesGridControl
            // 
            this.databasesGridControl.DataSource = this.databasesBindingSource;
            this.databasesGridControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.databasesGridControl.Location = new System.Drawing.Point(0, 37);
            this.databasesGridControl.MainView = this.gridView1;
            this.databasesGridControl.Name = "databasesGridControl";
            this.databasesGridControl.Size = new System.Drawing.Size(244, 497);
            this.databasesGridControl.TabIndex = 1;
            this.databasesGridControl.Tag = "Tuanquen";
            this.databasesGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.databasesGridControl.Click += new System.EventHandler(this.databasesGridControl_Click);
            this.databasesGridControl.MouseClick += new System.Windows.Forms.MouseEventHandler(this.databasesGridControl_MouseClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.DATABASE,
            this.colname1});
            this.gridView1.GridControl = this.databasesGridControl;
            this.gridView1.Name = "gridView1";
            // 
            // DATABASE
            // 
            this.DATABASE.Caption = "Cơ sở dữ liệu";
            this.DATABASE.FieldName = "name";
            this.DATABASE.MinWidth = 25;
            this.DATABASE.Name = "DATABASE";
            this.DATABASE.OptionsColumn.AllowEdit = false;
            this.DATABASE.Visible = true;
            this.DATABASE.VisibleIndex = 0;
            this.DATABASE.Width = 94;
            // 
            // colname1
            // 
            this.colname1.FieldName = "name";
            this.colname1.MinWidth = 25;
            this.colname1.Name = "colname1";
            this.colname1.Width = 94;
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar7,
            this.bar9});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barBackUp,
            this.barRestore,
            this.barResoreOvertime,
            this.barCreateDevice,
            this.barExit,
            this.barCheckRestore});
            this.barManager1.MaxItemId = 9;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.barManager1.StatusBar = this.bar9;
            // 
            // bar7
            // 
            this.bar7.BarName = "Tools";
            this.bar7.DockCol = 0;
            this.bar7.DockRow = 0;
            this.bar7.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar7.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barBackUp, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barRestore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barCheckRestore, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barCreateDevice, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barExit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar7.Text = "Tools";
            // 
            // barBackUp
            // 
            this.barBackUp.Caption = "Backup";
            this.barBackUp.Id = 0;
            this.barBackUp.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barBackUp.ImageOptions.Image")));
            this.barBackUp.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barBackUp.ImageOptions.LargeImage")));
            this.barBackUp.Name = "barBackUp";
            this.barBackUp.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBackUp_ItemClick);
            // 
            // barRestore
            // 
            this.barRestore.Caption = "Restore";
            this.barRestore.Id = 1;
            this.barRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barRestore.ImageOptions.Image")));
            this.barRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barRestore.ImageOptions.LargeImage")));
            this.barRestore.Name = "barRestore";
            this.barRestore.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barRestore_ItemClick);
            // 
            // barCheckRestore
            // 
            this.barCheckRestore.Caption = " Restore over time";
            this.barCheckRestore.CheckBoxVisibility = DevExpress.XtraBars.CheckBoxVisibility.BeforeText;
            this.barCheckRestore.Id = 8;
            this.barCheckRestore.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCheckRestore.ImageOptions.Image")));
            this.barCheckRestore.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barCheckRestore.ImageOptions.LargeImage")));
            this.barCheckRestore.Name = "barCheckRestore";
            this.barCheckRestore.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.barCheckRestore_CheckedChanged);
            // 
            // barCreateDevice
            // 
            this.barCreateDevice.Caption = "Create Backup Device";
            this.barCreateDevice.Id = 4;
            this.barCreateDevice.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCreateDevice.ImageOptions.Image")));
            this.barCreateDevice.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barCreateDevice.ImageOptions.LargeImage")));
            this.barCreateDevice.Name = "barCreateDevice";
            this.barCreateDevice.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCreateDevice_ItemClick);
            // 
            // barExit
            // 
            this.barExit.Caption = "Exit";
            this.barExit.Id = 5;
            this.barExit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barExit.ImageOptions.Image")));
            this.barExit.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barExit.ImageOptions.LargeImage")));
            this.barExit.Name = "barExit";
            this.barExit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barExit_ItemClick);
            // 
            // bar9
            // 
            this.bar9.BarName = "Status bar";
            this.bar9.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar9.DockCol = 0;
            this.bar9.DockRow = 0;
            this.bar9.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar9.OptionsBar.AllowQuickCustomization = false;
            this.bar9.OptionsBar.DrawDragBorder = false;
            this.bar9.OptionsBar.UseWholeRow = true;
            this.bar9.Text = "Status bar";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(909, 37);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 534);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(909, 24);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 37);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 497);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(909, 37);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 497);
            // 
            // barResoreOvertime
            // 
            this.barResoreOvertime.Caption = "Restore over time";
            this.barResoreOvertime.Id = 3;
            this.barResoreOvertime.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barResoreOvertime.ImageOptions.Image")));
            this.barResoreOvertime.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barResoreOvertime.ImageOptions.LargeImage")));
            this.barResoreOvertime.Name = "barResoreOvertime";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // backup_devicesBindingSource
            // 
            this.backup_devicesBindingSource.DataMember = "backup_devices";
            this.backup_devicesBindingSource.DataSource = this.tempdbDataSet;
            // 
            // backup_devicesTableAdapter
            // 
            this.backup_devicesTableAdapter.ClearBeforeFill = true;
            // 
            // sP_STT_BACKUPBindingSource
            // 
            this.sP_STT_BACKUPBindingSource.DataMember = "SP_STT_BACKUP";
            this.sP_STT_BACKUPBindingSource.DataSource = this.tempdbDataSet;
            // 
            // sP_STT_BACKUPTableAdapter
            // 
            this.sP_STT_BACKUPTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.sP_STT_BACKUPGridControl);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(244, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(665, 346);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbXoasaoluu);
            this.groupBox3.Controls.Add(this.positionTextBox);
            this.groupBox3.Controls.Add(nameLabel);
            this.groupBox3.Controls.Add(this.nameTextEdit);
            this.groupBox3.Location = new System.Drawing.Point(7, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(646, 54);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // cbXoasaoluu
            // 
            this.cbXoasaoluu.AutoSize = true;
            this.cbXoasaoluu.Location = new System.Drawing.Point(28, 27);
            this.cbXoasaoluu.Name = "cbXoasaoluu";
            this.cbXoasaoluu.Size = new System.Drawing.Size(438, 21);
            this.cbXoasaoluu.TabIndex = 4;
            this.cbXoasaoluu.Text = "Xóa tất cả các bản sao lưu cũ trong file trước khi sao lưu bản mới\r\n";
            this.cbXoasaoluu.UseVisualStyleBackColor = true;
            this.cbXoasaoluu.CheckedChanged += new System.EventHandler(this.cbXoasaoluu_CheckedChanged);
            // 
            // positionTextBox
            // 
            this.positionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.sP_STT_BACKUPBindingSource, "position", true));
            this.positionTextBox.Location = new System.Drawing.Point(310, -1);
            this.positionTextBox.Name = "positionTextBox";
            this.positionTextBox.ReadOnly = true;
            this.positionTextBox.Size = new System.Drawing.Size(41, 22);
            this.positionTextBox.TabIndex = 3;
            // 
            // nameTextEdit
            // 
            this.nameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.databasesBindingSource, "name", true));
            this.nameTextEdit.Location = new System.Drawing.Point(129, -3);
            this.nameTextEdit.MenuManager = this.barManager1;
            this.nameTextEdit.Name = "nameTextEdit";
            this.nameTextEdit.Properties.ReadOnly = true;
            this.nameTextEdit.Size = new System.Drawing.Size(175, 22);
            this.nameTextEdit.TabIndex = 2;
            // 
            // sP_STT_BACKUPGridControl
            // 
            this.sP_STT_BACKUPGridControl.DataSource = this.sP_STT_BACKUPBindingSource;
            this.sP_STT_BACKUPGridControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sP_STT_BACKUPGridControl.Location = new System.Drawing.Point(3, 61);
            this.sP_STT_BACKUPGridControl.MainView = this.gridView2;
            this.sP_STT_BACKUPGridControl.MenuManager = this.barManager1;
            this.sP_STT_BACKUPGridControl.Name = "sP_STT_BACKUPGridControl";
            this.sP_STT_BACKUPGridControl.Size = new System.Drawing.Size(659, 282);
            this.sP_STT_BACKUPGridControl.TabIndex = 0;
            this.sP_STT_BACKUPGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            this.sP_STT_BACKUPGridControl.Click += new System.EventHandler(this.sP_STT_BACKUPGridControl_Click);
            // 
            // gridView2
            // 
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colposition,
            this.colname,
            this.colbackup_start_date,
            this.coluser_name});
            this.gridView2.GridControl = this.sP_STT_BACKUPGridControl;
            this.gridView2.Name = "gridView2";
            // 
            // colposition
            // 
            this.colposition.Caption = "Bản sao lưu thứ";
            this.colposition.FieldName = "position";
            this.colposition.MinWidth = 25;
            this.colposition.Name = "colposition";
            this.colposition.OptionsColumn.AllowEdit = false;
            this.colposition.Visible = true;
            this.colposition.VisibleIndex = 0;
            this.colposition.Width = 94;
            // 
            // colname
            // 
            this.colname.Caption = "Diễn giải";
            this.colname.FieldName = "name";
            this.colname.MinWidth = 25;
            this.colname.Name = "colname";
            this.colname.OptionsColumn.AllowEdit = false;
            this.colname.Visible = true;
            this.colname.VisibleIndex = 1;
            this.colname.Width = 94;
            // 
            // colbackup_start_date
            // 
            this.colbackup_start_date.Caption = "Ngày giờ sao lưu";
            this.colbackup_start_date.DisplayFormat.FormatString = "dd/MM/yyyy HH:mm:ss";
            this.colbackup_start_date.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.colbackup_start_date.FieldName = "backup_start_date";
            this.colbackup_start_date.MinWidth = 25;
            this.colbackup_start_date.Name = "colbackup_start_date";
            this.colbackup_start_date.OptionsColumn.AllowEdit = false;
            this.colbackup_start_date.Visible = true;
            this.colbackup_start_date.VisibleIndex = 2;
            this.colbackup_start_date.Width = 94;
            // 
            // coluser_name
            // 
            this.coluser_name.Caption = "User sao lưu";
            this.coluser_name.FieldName = "user_name";
            this.coluser_name.MinWidth = 25;
            this.coluser_name.Name = "coluser_name";
            this.coluser_name.OptionsColumn.AllowEdit = false;
            this.coluser_name.Visible = true;
            this.coluser_name.VisibleIndex = 3;
            this.coluser_name.Width = 94;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.datePickerTime);
            this.groupBox2.Controls.Add(this.datePickerDay);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(244, 383);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(665, 151);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // datePickerTime
            // 
            this.datePickerTime.CustomFormat = "HH:mm:ss ";
            this.datePickerTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerTime.Location = new System.Drawing.Point(415, 37);
            this.datePickerTime.Name = "datePickerTime";
            this.datePickerTime.ShowUpDown = true;
            this.datePickerTime.Size = new System.Drawing.Size(125, 22);
            this.datePickerTime.TabIndex = 5;
            this.datePickerTime.Value = new System.DateTime(2020, 4, 21, 18, 57, 7, 0);
            // 
            // datePickerDay
            // 
            this.datePickerDay.CustomFormat = "dd-MM-yyyy";
            this.datePickerDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datePickerDay.Location = new System.Drawing.Point(266, 37);
            this.datePickerDay.Name = "datePickerDay";
            this.datePickerDay.Size = new System.Drawing.Size(125, 22);
            this.datePickerDay.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(468, 51);
            this.label2.TabIndex = 1;
            this.label2.Text = resources.GetString("label2.Text");
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(230, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày giờ để khôi phục thời điểm đó";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 558);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.databasesGridControl);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tempdbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databasesGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.backup_devicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sP_STT_BACKUPGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.Bar bar4;
        private DevExpress.XtraBars.Bar bar5;
        private DevExpress.XtraBars.Bar bar6;
        private tempdbDataSet tempdbDataSet;
        private System.Windows.Forms.BindingSource databasesBindingSource;
        private tempdbDataSetTableAdapters.databasesTableAdapter databasesTableAdapter;
        private tempdbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private DevExpress.XtraGrid.GridControl databasesGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn DATABASE;
        private DevExpress.XtraGrid.Columns.GridColumn colname1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar7;
        private DevExpress.XtraBars.BarButtonItem barBackUp;
        private DevExpress.XtraBars.BarButtonItem barRestore;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraBars.BarButtonItem barResoreOvertime;
        private DevExpress.XtraBars.BarButtonItem barCreateDevice;
        private DevExpress.XtraBars.BarButtonItem barExit;
        private DevExpress.XtraBars.Bar bar9;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DevExpress.XtraBars.BarCheckItem barCheckRestore;
        private System.Windows.Forms.BindingSource backup_devicesBindingSource;
        private tempdbDataSetTableAdapters.backup_devicesTableAdapter backup_devicesTableAdapter;
        private System.Windows.Forms.BindingSource sP_STT_BACKUPBindingSource;
        private tempdbDataSetTableAdapters.SP_STT_BACKUPTableAdapter sP_STT_BACKUPTableAdapter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.TextEdit nameTextEdit;
        private DevExpress.XtraGrid.GridControl sP_STT_BACKUPGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private System.Windows.Forms.CheckBox cbXoasaoluu;
        private System.Windows.Forms.TextBox positionTextBox;
        private DevExpress.XtraGrid.Columns.GridColumn colposition;
        private DevExpress.XtraGrid.Columns.GridColumn colname;
        private DevExpress.XtraGrid.Columns.GridColumn colbackup_start_date;
        private DevExpress.XtraGrid.Columns.GridColumn coluser_name;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datePickerTime;
        private System.Windows.Forms.DateTimePicker datePickerDay;
    }
}
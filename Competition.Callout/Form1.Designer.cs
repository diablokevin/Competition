namespace Competition.Callout
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ribbonControl1 = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.lb_serve = new DevExpress.XtraBars.BarStaticItem();
            this.btn_Register = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Callout = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Register_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.btn_Callout_Cancel = new DevExpress.XtraBars.BarButtonItem();
            this.Combox_Status = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemComboBox1 = new DevExpress.XtraEditors.Repository.RepositoryItemComboBox();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.controlpanel = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar1 = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.tip_RaceNum = new System.Windows.Forms.Label();
            this.txt_RaceNum = new System.Windows.Forms.TextBox();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.EventName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CompetitorName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RaceNum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BeginTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lb_status = new DevExpress.XtraBars.BarStaticItem();
            this.Id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_eventname = new System.Windows.Forms.Label();
            this.lb_racenum = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_company = new System.Windows.Forms.Label();
            this.lb_begin = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbonControl1
            // 
            this.ribbonControl1.ExpandCollapseItem.Id = 0;
            this.ribbonControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbonControl1.ExpandCollapseItem,
            this.ribbonControl1.SearchEditItem,
            this.lb_serve,
            this.btn_Register,
            this.btn_Callout,
            this.btn_Register_Cancel,
            this.btn_Callout_Cancel,
            this.Combox_Status,
            this.barButtonItem1,
            this.lb_status});
            this.ribbonControl1.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl1.MaxItemId = 11;
            this.ribbonControl1.Name = "ribbonControl1";
            this.ribbonControl1.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.controlpanel});
            this.ribbonControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemComboBox1});
            this.ribbonControl1.Size = new System.Drawing.Size(911, 160);
            this.ribbonControl1.StatusBar = this.ribbonStatusBar1;
            // 
            // lb_serve
            // 
            this.lb_serve.Caption = "服务器连接状态";
            this.lb_serve.Id = 1;
            this.lb_serve.Name = "lb_serve";
            // 
            // btn_Register
            // 
            this.btn_Register.Caption = "签到";
            this.btn_Register.Id = 2;
            this.btn_Register.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Register.ImageOptions.Image")));
            this.btn_Register.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Register.ImageOptions.LargeImage")));
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Register_ItemClick);
            // 
            // btn_Callout
            // 
            this.btn_Callout.Caption = "呼叫";
            this.btn_Callout.Id = 3;
            this.btn_Callout.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Callout.ImageOptions.Image")));
            this.btn_Callout.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Callout.ImageOptions.LargeImage")));
            this.btn_Callout.Name = "btn_Callout";
            this.btn_Callout.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Callout_ItemClick);
            // 
            // btn_Register_Cancel
            // 
            this.btn_Register_Cancel.Caption = "取消签到";
            this.btn_Register_Cancel.Id = 4;
            this.btn_Register_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Register_Cancel.ImageOptions.Image")));
            this.btn_Register_Cancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Register_Cancel.ImageOptions.LargeImage")));
            this.btn_Register_Cancel.Name = "btn_Register_Cancel";
            this.btn_Register_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Register_Cancel_ItemClick);
            // 
            // btn_Callout_Cancel
            // 
            this.btn_Callout_Cancel.Caption = "取消呼叫";
            this.btn_Callout_Cancel.Id = 5;
            this.btn_Callout_Cancel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btn_Callout_Cancel.ImageOptions.Image")));
            this.btn_Callout_Cancel.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btn_Callout_Cancel.ImageOptions.LargeImage")));
            this.btn_Callout_Cancel.Name = "btn_Callout_Cancel";
            this.btn_Callout_Cancel.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btn_Callout_Cancel_ItemClick);
            // 
            // Combox_Status
            // 
            this.Combox_Status.Caption = "状态";
            this.Combox_Status.Edit = this.repositoryItemComboBox1;
            this.Combox_Status.Id = 7;
            this.Combox_Status.Name = "Combox_Status";
            // 
            // repositoryItemComboBox1
            // 
            this.repositoryItemComboBox1.AutoHeight = false;
            this.repositoryItemComboBox1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemComboBox1.Name = "repositoryItemComboBox1";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "修改";
            this.barButtonItem1.Id = 8;
            this.barButtonItem1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.Image")));
            this.barButtonItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem1.ImageOptions.LargeImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // controlpanel
            // 
            this.controlpanel.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1,
            this.ribbonPageGroup2,
            this.ribbonPageGroup3});
            this.controlpanel.Name = "controlpanel";
            this.controlpanel.Text = "控制面板";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Register);
            this.ribbonPageGroup1.ItemLinks.Add(this.btn_Register_Cancel);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "签到";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Callout);
            this.ribbonPageGroup2.ItemLinks.Add(this.btn_Callout_Cancel);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "呼叫";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.Combox_Status);
            this.ribbonPageGroup3.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "强制修改赛程状态";
            // 
            // ribbonStatusBar1
            // 
            this.ribbonStatusBar1.ItemLinks.Add(this.lb_serve);
            this.ribbonStatusBar1.ItemLinks.Add(this.lb_status);
            this.ribbonStatusBar1.Location = new System.Drawing.Point(0, 489);
            this.ribbonStatusBar1.Name = "ribbonStatusBar1";
            this.ribbonStatusBar1.Ribbon = this.ribbonControl1;
            this.ribbonStatusBar1.Size = new System.Drawing.Size(911, 24);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lb_begin);
            this.groupControl1.Controls.Add(this.lb_company);
            this.groupControl1.Controls.Add(this.lb_name);
            this.groupControl1.Controls.Add(this.lb_racenum);
            this.groupControl1.Controls.Add(this.lb_eventname);
            this.groupControl1.Controls.Add(this.label5);
            this.groupControl1.Controls.Add(this.label4);
            this.groupControl1.Controls.Add(this.label3);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.tip_RaceNum);
            this.groupControl1.Controls.Add(this.txt_RaceNum);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 160);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 329);
            this.groupControl1.TabIndex = 2;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(45, 120);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(109, 29);
            this.simpleButton1.TabIndex = 4;
            this.simpleButton1.Text = "签到";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // tip_RaceNum
            // 
            this.tip_RaceNum.AutoSize = true;
            this.tip_RaceNum.Location = new System.Drawing.Point(26, 43);
            this.tip_RaceNum.Name = "tip_RaceNum";
            this.tip_RaceNum.Size = new System.Drawing.Size(139, 14);
            this.tip_RaceNum.TabIndex = 4;
            this.tip_RaceNum.Text = "输入选手编号或扫条形码";
            // 
            // txt_RaceNum
            // 
            this.txt_RaceNum.Location = new System.Drawing.Point(45, 70);
            this.txt_RaceNum.Name = "txt_RaceNum";
            this.txt_RaceNum.Size = new System.Drawing.Size(109, 22);
            this.txt_RaceNum.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = typeof(Competition.EF.Models.Schedule);
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(200, 160);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(711, 329);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.Id,
            this.EventName,
            this.CompetitorName,
            this.RaceNum,
            this.Company,
            this.BeginTime,
            this.EndTime,
            this.Status});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.Name = "gridView1";
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.EventName, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // EventName
            // 
            this.EventName.Caption = "项目名称";
            this.EventName.FieldName = "Event.Name";
            this.EventName.Name = "EventName";
            this.EventName.OptionsColumn.AllowEdit = false;
            this.EventName.Visible = true;
            this.EventName.VisibleIndex = 0;
            // 
            // CompetitorName
            // 
            this.CompetitorName.Caption = "选手姓名";
            this.CompetitorName.FieldName = "Competitor.Name";
            this.CompetitorName.Name = "CompetitorName";
            this.CompetitorName.OptionsColumn.AllowEdit = false;
            this.CompetitorName.Visible = true;
            this.CompetitorName.VisibleIndex = 1;
            // 
            // RaceNum
            // 
            this.RaceNum.Caption = "选手编号";
            this.RaceNum.FieldName = "Competitor.Race_num";
            this.RaceNum.Name = "RaceNum";
            this.RaceNum.OptionsColumn.AllowEdit = false;
            this.RaceNum.Visible = true;
            this.RaceNum.VisibleIndex = 0;
            // 
            // Company
            // 
            this.Company.Caption = "选手单位";
            this.Company.FieldName = "Competitor.Company.Name";
            this.Company.Name = "Company";
            this.Company.OptionsColumn.AllowEdit = false;
            this.Company.Visible = true;
            this.Company.VisibleIndex = 2;
            // 
            // BeginTime
            // 
            this.BeginTime.Caption = "开始时间";
            this.BeginTime.DisplayFormat.FormatString = "MM/dd HH:mm:ss";
            this.BeginTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.BeginTime.FieldName = "PlanBeginTime";
            this.BeginTime.Name = "BeginTime";
            this.BeginTime.OptionsColumn.AllowEdit = false;
            this.BeginTime.Visible = true;
            this.BeginTime.VisibleIndex = 3;
            // 
            // EndTime
            // 
            this.EndTime.Caption = "结束时间";
            this.EndTime.DisplayFormat.FormatString = "MM/dd HH:mm:ss";
            this.EndTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.EndTime.FieldName = "PlanEndTime";
            this.EndTime.Name = "EndTime";
            this.EndTime.OptionsColumn.AllowEdit = false;
            this.EndTime.Visible = true;
            this.EndTime.VisibleIndex = 4;
            // 
            // Status
            // 
            this.Status.Caption = "状态";
            this.Status.FieldName = "Status";
            this.Status.Name = "Status";
            this.Status.OptionsColumn.AllowEdit = false;
            this.Status.Visible = true;
            this.Status.VisibleIndex = 5;
            // 
            // lb_status
            // 
            this.lb_status.Caption = "barStaticItem1";
            this.lb_status.Id = 10;
            this.lb_status.Name = "lb_status";
            // 
            // Id
            // 
            this.Id.Caption = "Id";
            this.Id.FieldName = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = true;
            this.Id.VisibleIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 14);
            this.label1.TabIndex = 5;
            this.label1.Text = "项目";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 14);
            this.label2.TabIndex = 6;
            this.label2.Text = "选手编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 14);
            this.label3.TabIndex = 7;
            this.label3.Text = "选手姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 14);
            this.label4.TabIndex = 8;
            this.label4.Text = "选手单位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 14);
            this.label5.TabIndex = 9;
            this.label5.Text = "开始时间";
            // 
            // lb_eventname
            // 
            this.lb_eventname.AutoSize = true;
            this.lb_eventname.Location = new System.Drawing.Point(93, 177);
            this.lb_eventname.Name = "lb_eventname";
            this.lb_eventname.Size = new System.Drawing.Size(19, 14);
            this.lb_eventname.TabIndex = 10;
            this.lb_eventname.Text = "...";
            // 
            // lb_racenum
            // 
            this.lb_racenum.AutoSize = true;
            this.lb_racenum.Location = new System.Drawing.Point(93, 204);
            this.lb_racenum.Name = "lb_racenum";
            this.lb_racenum.Size = new System.Drawing.Size(19, 14);
            this.lb_racenum.TabIndex = 11;
            this.lb_racenum.Text = "...";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Location = new System.Drawing.Point(93, 236);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(19, 14);
            this.lb_name.TabIndex = 12;
            this.lb_name.Text = "...";
            // 
            // lb_company
            // 
            this.lb_company.AutoSize = true;
            this.lb_company.Location = new System.Drawing.Point(93, 263);
            this.lb_company.Name = "lb_company";
            this.lb_company.Size = new System.Drawing.Size(19, 14);
            this.lb_company.TabIndex = 13;
            this.lb_company.Text = "...";
            // 
            // lb_begin
            // 
            this.lb_begin.AutoSize = true;
            this.lb_begin.Location = new System.Drawing.Point(93, 287);
            this.lb_begin.Name = "lb_begin";
            this.lb_begin.Size = new System.Drawing.Size(19, 14);
            this.lb_begin.TabIndex = 14;
            this.lb_begin.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 513);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.ribbonStatusBar1);
            this.Controls.Add(this.ribbonControl1);
            this.Name = "Form1";
            this.Ribbon = this.ribbonControl1;
            this.StatusBar = this.ribbonStatusBar1;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemComboBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl1;
        private DevExpress.XtraBars.Ribbon.RibbonPage controlpanel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarStaticItem lb_serve;
        private DevExpress.XtraBars.BarButtonItem btn_Register;
        private DevExpress.XtraBars.BarButtonItem btn_Callout;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label tip_RaceNum;
        private System.Windows.Forms.TextBox txt_RaceNum;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraBars.BarButtonItem btn_Register_Cancel;
        private DevExpress.XtraBars.BarButtonItem btn_Callout_Cancel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.BarEditItem Combox_Status;
        private DevExpress.XtraEditors.Repository.RepositoryItemComboBox repositoryItemComboBox1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraGrid.Columns.GridColumn EventName;
        private DevExpress.XtraGrid.Columns.GridColumn CompetitorName;
        private DevExpress.XtraGrid.Columns.GridColumn RaceNum;
        private DevExpress.XtraGrid.Columns.GridColumn Company;
        private DevExpress.XtraGrid.Columns.GridColumn BeginTime;
        private DevExpress.XtraGrid.Columns.GridColumn EndTime;
        private DevExpress.XtraGrid.Columns.GridColumn Status;
        private DevExpress.XtraBars.BarStaticItem lb_status;
        private DevExpress.XtraGrid.Columns.GridColumn Id;
        private System.Windows.Forms.Label lb_racenum;
        private System.Windows.Forms.Label lb_eventname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_begin;
        private System.Windows.Forms.Label lb_company;
        private System.Windows.Forms.Label lb_name;
    }
}


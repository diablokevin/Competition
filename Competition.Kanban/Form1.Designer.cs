namespace Competition.Kanban
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.KanbanView = new DevExpress.XtraGrid.Views.Layout.LayoutView();
            this.EventName = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_EventName = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Waiting = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.repositoryItemMemoEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit();
            this.layoutViewField_Waiting = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Registered = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_Registered = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.Calling = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_Calling = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.InProgress = new DevExpress.XtraGrid.Columns.LayoutViewColumn();
            this.layoutViewField_InProgress = new DevExpress.XtraGrid.Views.Layout.LayoutViewField();
            this.layoutViewCard1 = new DevExpress.XtraGrid.Views.Layout.LayoutViewCard();
            this.item1 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.item2 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.item3 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.item4 = new DevExpress.XtraLayout.SimpleLabelItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.LastRefressLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.LastRefressTime = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KanbanView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_EventName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Waiting)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Registered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Calling)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_InProgress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.KanbanView;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemMemoEdit1});
            this.gridControl1.Size = new System.Drawing.Size(737, 299);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.KanbanView});
            // 
            // KanbanView
            // 
            this.KanbanView.ActiveFilterEnabled = false;
            this.KanbanView.CardHorzInterval = 0;
            this.KanbanView.CardMinSize = new System.Drawing.Size(176, 40);
            this.KanbanView.CardVertInterval = 0;
            this.KanbanView.Columns.AddRange(new DevExpress.XtraGrid.Columns.LayoutViewColumn[] {
            this.EventName,
            this.Waiting,
            this.Registered,
            this.Calling,
            this.InProgress});
            this.KanbanView.GridControl = this.gridControl1;
            this.KanbanView.Name = "KanbanView";
            this.KanbanView.OptionsBehavior.Editable = false;
            this.KanbanView.OptionsCustomization.AllowFilter = false;
            this.KanbanView.OptionsCustomization.AllowSort = false;
            this.KanbanView.OptionsItemText.AlignMode = DevExpress.XtraGrid.Views.Layout.FieldTextAlignMode.AutoSize;
            this.KanbanView.OptionsItemText.TextToControlDistance = 6;
            this.KanbanView.OptionsView.ShowCardCaption = false;
            this.KanbanView.OptionsView.ShowCardExpandButton = false;
            this.KanbanView.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.KanbanView.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.MultiColumn;
            this.KanbanView.PaintStyleName = "Skin";
            this.KanbanView.TemplateCard = this.layoutViewCard1;
            // 
            // EventName
            // 
            this.EventName.Caption = "项目名称";
            this.EventName.CustomizationCaption = "项目名称";
            this.EventName.FieldName = "Event.Name";
            this.EventName.LayoutViewField = this.layoutViewField_EventName;
            this.EventName.Name = "EventName";
            this.EventName.OptionsColumn.ShowCaption = false;
            // 
            // layoutViewField_EventName
            // 
            this.layoutViewField_EventName.ContentHorzAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.layoutViewField_EventName.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutViewField_EventName.EditorPreferredWidth = 98;
            this.layoutViewField_EventName.Location = new System.Drawing.Point(0, 0);
            this.layoutViewField_EventName.Name = "layoutViewField_EventName";
            this.layoutViewField_EventName.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_EventName.Size = new System.Drawing.Size(100, 38);
            this.layoutViewField_EventName.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_EventName.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_EventName.TextVisible = false;
            // 
            // Waiting
            // 
            this.Waiting.Caption = "等待中";
            this.Waiting.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Waiting.FieldName = "Waiting";
            this.Waiting.LayoutViewField = this.layoutViewField_Waiting;
            this.Waiting.Name = "Waiting";
            this.Waiting.OptionsColumn.AllowEdit = false;
            this.Waiting.OptionsColumn.ShowCaption = false;
            // 
            // repositoryItemMemoEdit1
            // 
            this.repositoryItemMemoEdit1.Name = "repositoryItemMemoEdit1";
            // 
            // layoutViewField_Waiting
            // 
            this.layoutViewField_Waiting.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutViewField_Waiting.EditorPreferredWidth = 126;
            this.layoutViewField_Waiting.Location = new System.Drawing.Point(475, 16);
            this.layoutViewField_Waiting.Name = "layoutViewField_Waiting";
            this.layoutViewField_Waiting.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_Waiting.Size = new System.Drawing.Size(128, 22);
            this.layoutViewField_Waiting.StartNewLine = true;
            this.layoutViewField_Waiting.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_Waiting.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_Waiting.TextVisible = false;
            // 
            // Registered
            // 
            this.Registered.Caption = "已报到";
            this.Registered.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Registered.FieldName = "Registered";
            this.Registered.LayoutViewField = this.layoutViewField_Registered;
            this.Registered.Name = "Registered";
            this.Registered.OptionsColumn.ShowCaption = false;
            // 
            // layoutViewField_Registered
            // 
            this.layoutViewField_Registered.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutViewField_Registered.EditorPreferredWidth = 123;
            this.layoutViewField_Registered.Location = new System.Drawing.Point(350, 16);
            this.layoutViewField_Registered.Name = "layoutViewField_Registered";
            this.layoutViewField_Registered.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_Registered.Size = new System.Drawing.Size(125, 22);
            this.layoutViewField_Registered.StartNewLine = true;
            this.layoutViewField_Registered.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_Registered.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_Registered.TextVisible = false;
            // 
            // Calling
            // 
            this.Calling.Caption = "呼叫中";
            this.Calling.ColumnEdit = this.repositoryItemMemoEdit1;
            this.Calling.FieldName = "Calling";
            this.Calling.LayoutViewField = this.layoutViewField_Calling;
            this.Calling.Name = "Calling";
            this.Calling.OptionsColumn.ShowCaption = false;
            // 
            // layoutViewField_Calling
            // 
            this.layoutViewField_Calling.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutViewField_Calling.EditorPreferredWidth = 123;
            this.layoutViewField_Calling.Location = new System.Drawing.Point(225, 16);
            this.layoutViewField_Calling.Name = "layoutViewField_Calling";
            this.layoutViewField_Calling.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_Calling.Size = new System.Drawing.Size(125, 22);
            this.layoutViewField_Calling.StartNewLine = true;
            this.layoutViewField_Calling.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_Calling.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_Calling.TextVisible = false;
            // 
            // InProgress
            // 
            this.InProgress.Caption = "进行中";
            this.InProgress.FieldName = "InProgress";
            this.InProgress.LayoutViewField = this.layoutViewField_InProgress;
            this.InProgress.Name = "InProgress";
            this.InProgress.OptionsColumn.ShowCaption = false;
            // 
            // layoutViewField_InProgress
            // 
            this.layoutViewField_InProgress.ContentVertAlignment = DevExpress.Utils.VertAlignment.Center;
            this.layoutViewField_InProgress.EditorPreferredWidth = 123;
            this.layoutViewField_InProgress.Location = new System.Drawing.Point(100, 16);
            this.layoutViewField_InProgress.Name = "layoutViewField_InProgress";
            this.layoutViewField_InProgress.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewField_InProgress.Size = new System.Drawing.Size(125, 22);
            this.layoutViewField_InProgress.TextLocation = DevExpress.Utils.Locations.Top;
            this.layoutViewField_InProgress.TextSize = new System.Drawing.Size(0, 0);
            this.layoutViewField_InProgress.TextVisible = false;
            // 
            // layoutViewCard1
            // 
            this.layoutViewCard1.CustomizationFormText = "TemplateCard";
            this.layoutViewCard1.GroupBordersVisible = false;
            this.layoutViewCard1.HeaderButtonsLocation = DevExpress.Utils.GroupElementLocation.AfterText;
            this.layoutViewCard1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutViewField_InProgress,
            this.item1,
            this.layoutViewField_EventName,
            this.item2,
            this.item3,
            this.item4,
            this.layoutViewField_Registered,
            this.layoutViewField_Waiting,
            this.layoutViewField_Calling});
            this.layoutViewCard1.Name = "layoutViewCard1";
            this.layoutViewCard1.OptionsItemText.TextToControlDistance = 6;
            this.layoutViewCard1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.layoutViewCard1.Text = "TemplateCard";
            // 
            // item1
            // 
            this.item1.AllowHotTrack = false;
            this.item1.CustomizationFormText = "进行中";
            this.item1.Location = new System.Drawing.Point(100, 0);
            this.item1.Name = "item1";
            this.item1.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item1.Size = new System.Drawing.Size(125, 16);
            this.item1.Text = "进行中";
            this.item1.TextSize = new System.Drawing.Size(36, 14);
            // 
            // item2
            // 
            this.item2.AllowHotTrack = false;
            this.item2.CustomizationFormText = "呼叫中";
            this.item2.Location = new System.Drawing.Point(225, 0);
            this.item2.Name = "item2";
            this.item2.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item2.Size = new System.Drawing.Size(125, 16);
            this.item2.Text = "呼叫中";
            this.item2.TextSize = new System.Drawing.Size(36, 14);
            // 
            // item3
            // 
            this.item3.AllowHotTrack = false;
            this.item3.CustomizationFormText = "已报到";
            this.item3.Location = new System.Drawing.Point(350, 0);
            this.item3.Name = "item3";
            this.item3.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item3.Size = new System.Drawing.Size(125, 16);
            this.item3.Text = "已报到";
            this.item3.TextSize = new System.Drawing.Size(36, 14);
            // 
            // item4
            // 
            this.item4.AllowHotTrack = false;
            this.item4.CustomizationFormText = "等待中";
            this.item4.Location = new System.Drawing.Point(475, 0);
            this.item4.Name = "item4";
            this.item4.Padding = new DevExpress.XtraLayout.Utils.Padding(1, 1, 1, 1);
            this.item4.Size = new System.Drawing.Size(128, 16);
            this.item4.Text = "等待中";
            this.item4.TextSize = new System.Drawing.Size(36, 14);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LastRefressLabel,
            this.LastRefressTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 277);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(737, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // LastRefressLabel
            // 
            this.LastRefressLabel.Name = "LastRefressLabel";
            this.LastRefressLabel.Size = new System.Drawing.Size(116, 17);
            this.LastRefressLabel.Text = "数据最后刷新时间：";
            // 
            // LastRefressTime
            // 
            this.LastRefressTime.Name = "LastRefressTime";
            this.LastRefressTime.Size = new System.Drawing.Size(56, 17);
            this.LastRefressTime.Text = "00:00:00";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 299);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KanbanView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_EventName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemMemoEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Waiting)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Registered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_Calling)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewField_InProgress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutViewCard1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.item4)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Layout.LayoutView KanbanView;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn EventName;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoEdit repositoryItemMemoEdit1;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Waiting;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Registered;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn Calling;
        private DevExpress.XtraGrid.Columns.LayoutViewColumn InProgress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_EventName;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Waiting;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Registered;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_Calling;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewField layoutViewField_InProgress;
        private DevExpress.XtraGrid.Views.Layout.LayoutViewCard layoutViewCard1;
        private DevExpress.XtraLayout.SimpleLabelItem item1;
        private DevExpress.XtraLayout.SimpleLabelItem item2;
        private DevExpress.XtraLayout.SimpleLabelItem item3;
        private DevExpress.XtraLayout.SimpleLabelItem item4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel LastRefressLabel;
        private System.Windows.Forms.ToolStripStatusLabel LastRefressTime;
    }
}


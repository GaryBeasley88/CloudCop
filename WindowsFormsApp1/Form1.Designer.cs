namespace WindowsFormsApp1
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
            this.navPages = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage1 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.gridSplitContainer1 = new DevExpress.XtraGrid.GridSplitContainer();
            this.gridSplitContainer1Grid = new DevExpress.XtraGrid.GridControl();
            this.gridSplitContainer1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage7 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage6 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navpages2 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage8 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage9 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage10 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.navPages)).BeginInit();
            this.navPages.SuspendLayout();
            this.navigationPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.navigationPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).BeginInit();
            this.gridSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.navpages2)).BeginInit();
            this.navpages2.SuspendLayout();
            this.SuspendLayout();
            // 
            // navPages
            // 
            this.navPages.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.navPages.Appearance.BackColor = System.Drawing.Color.Black;
            this.navPages.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.navPages.Appearance.BorderColor = System.Drawing.Color.Black;
            this.navPages.Appearance.Options.UseBackColor = true;
            this.navPages.Appearance.Options.UseBorderColor = true;
            this.navPages.Controls.Add(this.navigationPage1);
            this.navPages.Controls.Add(this.navigationPage2);
            this.navPages.Controls.Add(this.navigationPage3);
            this.navPages.Controls.Add(this.navigationPage4);
            this.navPages.Controls.Add(this.navigationPage5);
            this.navPages.Location = new System.Drawing.Point(0, 0);
            this.navPages.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.navPages.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navPages.Name = "navPages";
            this.navPages.PageProperties.ShowCollapseButton = false;
            this.navPages.PageProperties.ShowExpandButton = false;
            this.navPages.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage1,
            this.navigationPage2,
            this.navigationPage3,
            this.navigationPage4,
            this.navigationPage5});
            this.navPages.RegularSize = new System.Drawing.Size(763, 611);
            this.navPages.SelectedPage = this.navigationPage1;
            this.navPages.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.navPages.Size = new System.Drawing.Size(763, 611);
            this.navPages.TabIndex = 0;
            this.navPages.StateChanged += new DevExpress.XtraBars.Navigation.StateChangedEventHandler(this.navPages_StateChanged);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "User Info / Login";
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(697, 565);
            this.navigationPage1.ToolTip = "Options to add Citations, Reports, etc...";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Map";
            this.navigationPage2.Controls.Add(this.mapControl1);
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(697, 565);
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(34.060632D, -84.66092D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl1.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl1.Size = new System.Drawing.Size(697, 565);
            this.mapControl1.TabIndex = 0;
            this.mapControl1.ZoomLevel = 12D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AvbC7KZTX5ml29nMdgQJYS8easD6LfhxkEfqiyC5gpoH9spoxqw-aAG2Qqf3oH23";
            this.bingMapDataProvider1.ConnectionProtocol = DevExpress.XtraMap.ConnectionProtocol.Https;
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Activity Log";
            this.navigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage3.ImageOptions.Image")));
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(697, 565);
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "Data View";
            this.navigationPage4.Controls.Add(this.gridSplitContainer1);
            this.navigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage4.ImageOptions.Image")));
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(697, 565);
            // 
            // gridSplitContainer1
            // 
            this.gridSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1.Grid = this.gridSplitContainer1Grid;
            this.gridSplitContainer1.Horizontal = true;
            this.gridSplitContainer1.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1.Name = "gridSplitContainer1";
            this.gridSplitContainer1.Panel1.Controls.Add(this.gridSplitContainer1Grid);
            this.gridSplitContainer1.Panel1.Text = "Panel1";
            this.gridSplitContainer1.Panel2.Text = "Panel2";
            this.gridSplitContainer1.Size = new System.Drawing.Size(697, 565);
            this.gridSplitContainer1.SynchronizeScrolling = DevExpress.Utils.DefaultBoolean.True;
            this.gridSplitContainer1.TabIndex = 0;
            this.gridSplitContainer1.Text = "gridSplitContainer1";
            // 
            // gridSplitContainer1Grid
            // 
            this.gridSplitContainer1Grid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridSplitContainer1Grid.Location = new System.Drawing.Point(0, 0);
            this.gridSplitContainer1Grid.MainView = this.gridSplitContainer1View;
            this.gridSplitContainer1Grid.Name = "gridSplitContainer1Grid";
            this.gridSplitContainer1Grid.Size = new System.Drawing.Size(697, 565);
            this.gridSplitContainer1Grid.TabIndex = 0;
            this.gridSplitContainer1Grid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridSplitContainer1View});
            // 
            // gridSplitContainer1View
            // 
            this.gridSplitContainer1View.GridControl = this.gridSplitContainer1Grid;
            this.gridSplitContainer1View.Name = "gridSplitContainer1View";
            // 
            // navigationPage5
            // 
            this.navigationPage5.Caption = "Chat / Messages";
            this.navigationPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage5.ImageOptions.Image")));
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(697, 565);
            // 
            // navigationPage7
            // 
            this.navigationPage7.Caption = "NCIC Queries";
            this.navigationPage7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage7.ImageOptions.Image")));
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Size = new System.Drawing.Size(182, 551);
            // 
            // navigationPage6
            // 
            this.navigationPage6.Caption = "Options";
            this.navigationPage6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage6.ImageOptions.Image")));
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Size = new System.Drawing.Size(182, 551);
            // 
            // navpages2
            // 
            this.navpages2.Controls.Add(this.navigationPage6);
            this.navpages2.Controls.Add(this.navigationPage7);
            this.navpages2.Controls.Add(this.navigationPage8);
            this.navpages2.Controls.Add(this.navigationPage9);
            this.navpages2.Controls.Add(this.navigationPage10);
            this.navpages2.Dock = System.Windows.Forms.DockStyle.Right;
            this.navpages2.Location = new System.Drawing.Point(760, 0);
            this.navpages2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.navpages2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navpages2.Name = "navpages2";
            this.navpages2.PageProperties.ShowExpandButton = false;
            this.navpages2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage6,
            this.navigationPage7,
            this.navigationPage8,
            this.navigationPage9,
            this.navigationPage10});
            this.navpages2.RegularSize = new System.Drawing.Size(248, 611);
            this.navpages2.SelectedPage = this.navigationPage6;
            this.navpages2.Size = new System.Drawing.Size(248, 611);
            this.navpages2.TabIndex = 1;
            this.navpages2.Text = "navPages2";
            this.navpages2.StateChanged += new DevExpress.XtraBars.Navigation.StateChangedEventHandler(this.navpages2_StateChanged);
            // 
            // navigationPage8
            // 
            this.navigationPage8.Caption = "Search";
            this.navigationPage8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage8.ImageOptions.Image")));
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Size = new System.Drawing.Size(182, 551);
            // 
            // navigationPage9
            // 
            this.navigationPage9.Caption = "Agency Officers";
            this.navigationPage9.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage9.ImageOptions.Image")));
            this.navigationPage9.Name = "navigationPage9";
            this.navigationPage9.Size = new System.Drawing.Size(182, 551);
            // 
            // navigationPage10
            // 
            this.navigationPage10.Caption = "Calendar / Tasks";
            this.navigationPage10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage10.ImageOptions.Image")));
            this.navigationPage10.Name = "navigationPage10";
            this.navigationPage10.Size = new System.Drawing.Size(182, 551);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1008, 611);
            this.Controls.Add(this.navpages2);
            this.Controls.Add(this.navPages);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1024, 650);
            this.Name = "Form1";
            this.Text = "CloudCop";
            ((System.ComponentModel.ISupportInitialize)(this.navPages)).EndInit();
            this.navPages.ResumeLayout(false);
            this.navigationPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.navigationPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1)).EndInit();
            this.gridSplitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1Grid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridSplitContainer1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.navpages2)).EndInit();
            this.navpages2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navPages;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DevExpress.XtraGrid.GridSplitContainer gridSplitContainer1;
        private DevExpress.XtraGrid.GridControl gridSplitContainer1Grid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridSplitContainer1View;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage7;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage6;
        private DevExpress.XtraBars.Navigation.NavigationPane navpages2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage8;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage9;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage10;
    }
}


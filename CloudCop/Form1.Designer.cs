namespace CloudCop
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
            this.navigationPage5 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage4 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage3 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage2 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage10 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage7 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navigationPage6 = new DevExpress.XtraBars.Navigation.NavigationPage();
            this.navpages2 = new DevExpress.XtraBars.Navigation.NavigationPane();
            this.navigationPage8 = new DevExpress.XtraBars.Navigation.NavigationPage();
            ((System.ComponentModel.ISupportInitialize)(this.navPages)).BeginInit();
            this.navPages.SuspendLayout();
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
            this.navPages.Controls.Add(this.navigationPage5);
            this.navPages.Controls.Add(this.navigationPage4);
            this.navPages.Controls.Add(this.navigationPage3);
            this.navPages.Controls.Add(this.navigationPage2);
            this.navPages.Controls.Add(this.navigationPage10);
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
            this.navigationPage5,
            this.navigationPage10});
            this.navPages.RegularSize = new System.Drawing.Size(670, 611);
            this.navPages.SelectedPage = this.navigationPage1;
            this.navPages.ShowToolTips = DevExpress.Utils.DefaultBoolean.True;
            this.navPages.Size = new System.Drawing.Size(670, 611);
            this.navPages.TabIndex = 0;
            this.navPages.StateChanged += new DevExpress.XtraBars.Navigation.StateChangedEventHandler(this.navPages_StateChanged);
            this.navPages.StateChanging += new DevExpress.XtraBars.Navigation.StateChangingEventHandler(this.navPages_StateChanging);
            this.navPages.QueryControl += new DevExpress.XtraBars.Navigation.QueryControlEventHandler(this.navPages_QueryControl);
            // 
            // navigationPage1
            // 
            this.navigationPage1.Caption = "User Info / Login";
            this.navigationPage1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage1.ImageOptions.Image")));
            this.navigationPage1.Name = "navigationPage1";
            this.navigationPage1.Size = new System.Drawing.Size(604, 565);
            this.navigationPage1.ToolTip = "User Information ";
            // 
            // navigationPage5
            // 
            this.navigationPage5.Caption = "Chat / Messages";
            this.navigationPage5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage5.ImageOptions.Image")));
            this.navigationPage5.Name = "navigationPage5";
            this.navigationPage5.Size = new System.Drawing.Size(697, 565);
            this.navigationPage5.ToolTip = "Chat and Messaging";
            // 
            // navigationPage4
            // 
            this.navigationPage4.Caption = "Data View";
            this.navigationPage4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage4.ImageOptions.Image")));
            this.navigationPage4.Name = "navigationPage4";
            this.navigationPage4.Size = new System.Drawing.Size(697, 565);
            this.navigationPage4.ToolTip = "Data View";
            // 
            // navigationPage3
            // 
            this.navigationPage3.Caption = "Activity Log";
            this.navigationPage3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage3.ImageOptions.Image")));
            this.navigationPage3.Name = "navigationPage3";
            this.navigationPage3.Size = new System.Drawing.Size(697, 565);
            this.navigationPage3.ToolTip = "Daily Activity Log";
            // 
            // navigationPage2
            // 
            this.navigationPage2.Caption = "Map";
            this.navigationPage2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage2.ImageOptions.Image")));
            this.navigationPage2.Name = "navigationPage2";
            this.navigationPage2.Size = new System.Drawing.Size(697, 565);
            this.navigationPage2.ToolTip = "Agency Map";
            // 
            // navigationPage10
            // 
            this.navigationPage10.Caption = "Calendar Items";
            this.navigationPage10.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage10.ImageOptions.Image")));
            this.navigationPage10.Name = "navigationPage10";
            this.navigationPage10.Size = new System.Drawing.Size(697, 565);
            this.navigationPage10.ToolTip = "Calendar Events";
            // 
            // navigationPage7
            // 
            this.navigationPage7.Caption = "Patrol View";
            this.navigationPage7.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage7.ImageOptions.Image")));
            this.navigationPage7.Name = "navigationPage7";
            this.navigationPage7.Size = new System.Drawing.Size(272, 551);
            this.navigationPage7.ToolTip = "Patrol View";
            // 
            // navigationPage6
            // 
            this.navigationPage6.Caption = "Options";
            this.navigationPage6.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage6.ImageOptions.Image")));
            this.navigationPage6.Name = "navigationPage6";
            this.navigationPage6.Size = new System.Drawing.Size(272, 551);
            this.navigationPage6.ToolTip = "Available Options";
            // 
            // navpages2
            // 
            this.navpages2.Controls.Add(this.navigationPage6);
            this.navpages2.Controls.Add(this.navigationPage8);
            this.navpages2.Controls.Add(this.navigationPage7);
            this.navpages2.Dock = System.Windows.Forms.DockStyle.Right;
            this.navpages2.Location = new System.Drawing.Point(670, 0);
            this.navpages2.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.navpages2.LookAndFeel.UseDefaultLookAndFeel = false;
            this.navpages2.Name = "navpages2";
            this.navpages2.PageProperties.ShowExpandButton = false;
            this.navpages2.Pages.AddRange(new DevExpress.XtraBars.Navigation.NavigationPageBase[] {
            this.navigationPage6,
            this.navigationPage7,
            this.navigationPage8});
            this.navpages2.RegularSize = new System.Drawing.Size(338, 611);
            this.navpages2.SelectedPage = this.navigationPage6;
            this.navpages2.Size = new System.Drawing.Size(338, 611);
            this.navpages2.TabIndex = 1;
            this.navpages2.Text = "navPages2";
            this.navpages2.StateChanged += new DevExpress.XtraBars.Navigation.StateChangedEventHandler(this.navpages2_StateChanged);
            this.navpages2.QueryControl += new DevExpress.XtraBars.Navigation.QueryControlEventHandler(this.navpages2_QueryControl);
            // 
            // navigationPage8
            // 
            this.navigationPage8.Appearance.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.navigationPage8.Appearance.Options.UseBackColor = true;
            this.navigationPage8.Caption = "Search";
            this.navigationPage8.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("navigationPage8.ImageOptions.Image")));
            this.navigationPage8.Name = "navigationPage8";
            this.navigationPage8.Size = new System.Drawing.Size(272, 551);
            this.navigationPage8.ToolTip = "Search Options";
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
            ((System.ComponentModel.ISupportInitialize)(this.navpages2)).EndInit();
            this.navpages2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.NavigationPane navPages;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage1;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage3;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage4;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage5;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage7;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage6;
        private DevExpress.XtraBars.Navigation.NavigationPane navpages2;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage8;
        private DevExpress.XtraBars.Navigation.NavigationPage navigationPage10;
    }
}


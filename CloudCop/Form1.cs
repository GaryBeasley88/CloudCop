using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CloudCop.Controls;

namespace CloudCop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void navPages_StateChanged(object sender, DevExpress.XtraBars.Navigation.StateChangedEventArgs e)
        {
 
        }

        private void navpages2_StateChanged(object sender, DevExpress.XtraBars.Navigation.StateChangedEventArgs e)
        {
            switch (e.State)
            {
                case DevExpress.XtraBars.Navigation.NavigationPaneState.Collapsed:
                    this.navPages.Width = this.Width - 48;
                    break;
                case DevExpress.XtraBars.Navigation.NavigationPaneState.Regular:
                    this.navPages.Width = this.Width - this.navpages2.Width;
                    break;

            }

        }

        private void navPages_StateChanging(object sender, DevExpress.XtraBars.Navigation.StateChangingEventArgs e)
        {
            e.Cancel = true;
        }

        private void navPages_QueryControl(object sender, DevExpress.XtraBars.Navigation.QueryControlEventArgs e)
        {

            switch (e.Page.Caption)
            {
                case "User Info / Login":
                    navigationPage1.Controls.Add(new UserInfo() { Dock = DockStyle.Fill });
                    break;
                case "Map":
                    navigationPage2.Controls.Add(new AgencyMap() { Dock = DockStyle.Fill });
                    break;
                case "Activity Log":
                    navigationPage3.Controls.Add(new ActivityLog() { Dock = DockStyle.Fill });
                    break;
                case "Data View":
                    navigationPage4.Controls.Add(new RMSDataView() { Dock = DockStyle.Fill });
                    break;
                case "Chat / Messages":
                    navigationPage5.Controls.Add(new ChatMessages() { Dock = DockStyle.Fill });
                    break;
                case "Calendar Items":
                    navigationPage10.Controls.Add(new CalendarEvents() { Dock = DockStyle.Fill });
                    break;
            }

        }

        private void navpages2_QueryControl(object sender, DevExpress.XtraBars.Navigation.QueryControlEventArgs e)
        {
            switch (e.Page.Caption)
            {
                case "Options":
                    navigationPage6.Controls.Add(new Options() { Dock = DockStyle.Fill });
                    break;
                case "Patrol View":
                    navigationPage7.Controls.Add(new PatrolView() { Dock = DockStyle.Fill });
                    break;
                case "Search":
                    navigationPage8.Controls.Add(new UniversalSearch() { Dock = DockStyle.Fill });
                    break;
            }

        }
    }
}

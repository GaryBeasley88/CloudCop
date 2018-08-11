using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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
    }
}

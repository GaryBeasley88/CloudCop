using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace CloudCop.Controls
{
    public partial class USearch_Case : DevExpress.XtraEditors.XtraUserControl
    {
        public USearch_Case()
        {
            InitializeComponent();
        }

        private void USearch_Case_Load(object sender, EventArgs e)
        {
            this.textEdit1.Focus();
        }
    }
}

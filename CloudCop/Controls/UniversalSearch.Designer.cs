namespace CloudCop.Controls
{
    partial class UniversalSearch
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.accordionControl = new DevExpress.XtraBars.Navigation.AccordionControl();
            this.searchType = new DevExpress.XtraEditors.RadioGroup();
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchType.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // accordionControl
            // 
            this.accordionControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accordionControl.Location = new System.Drawing.Point(1, 142);
            this.accordionControl.Name = "accordionControl";
            this.accordionControl.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Auto;
            this.accordionControl.Size = new System.Drawing.Size(247, 469);
            this.accordionControl.TabIndex = 0;
            this.accordionControl.Text = "accordionControl";
            // 
            // searchType
            // 
            this.searchType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchType.Location = new System.Drawing.Point(1, 0);
            this.searchType.Name = "searchType";
            this.searchType.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 10F);
            this.searchType.Properties.Appearance.Options.UseFont = true;
            this.searchType.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.searchType.Size = new System.Drawing.Size(247, 142);
            this.searchType.TabIndex = 1;
            this.searchType.EditValueChanged += new System.EventHandler(this.searchType_EditValueChanged);
            // 
            // UniversalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.searchType);
            this.Controls.Add(this.accordionControl);
            this.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.LookAndFeel.UseDefaultLookAndFeel = false;
            this.Name = "UniversalSearch";
            this.Size = new System.Drawing.Size(248, 611);
            this.Load += new System.EventHandler(this.UniversalSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.accordionControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchType.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl;
        private DevExpress.XtraEditors.RadioGroup searchType;
    }
}

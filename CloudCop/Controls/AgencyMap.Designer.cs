namespace CloudCop.Controls
{
    partial class AgencyMap
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
            this.mapControl1 = new DevExpress.XtraMap.MapControl();
            this.imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            this.bingMapDataProvider1 = new DevExpress.XtraMap.BingMapDataProvider();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl1
            // 
            this.mapControl1.CenterPoint = new DevExpress.XtraMap.GeoPoint(34.060632D, -84.66092D);
            this.mapControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mapControl1.Layers.Add(this.imageLayer1);
            this.mapControl1.Location = new System.Drawing.Point(0, 0);
            this.mapControl1.LookAndFeel.SkinName = "DevExpress Dark Style";
            this.mapControl1.LookAndFeel.UseDefaultLookAndFeel = false;
            this.mapControl1.Name = "mapControl1";
            this.mapControl1.NavigationPanelOptions.ShowCoordinates = false;
            this.mapControl1.NavigationPanelOptions.ShowKilometersScale = false;
            this.mapControl1.Size = new System.Drawing.Size(763, 611);
            this.mapControl1.TabIndex = 1;
            this.mapControl1.ZoomLevel = 12D;
            this.imageLayer1.DataProvider = this.bingMapDataProvider1;
            this.bingMapDataProvider1.BingKey = "AvbC7KZTX5ml29nMdgQJYS8easD6LfhxkEfqiyC5gpoH9spoxqw-aAG2Qqf3oH23";
            this.bingMapDataProvider1.ConnectionProtocol = DevExpress.XtraMap.ConnectionProtocol.Https;
            // 
            // AgencyMap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mapControl1);
            this.Name = "AgencyMap";
            this.Size = new System.Drawing.Size(763, 611);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl1;
        private DevExpress.XtraMap.ImageLayer imageLayer1;
        private DevExpress.XtraMap.BingMapDataProvider bingMapDataProvider1;
    }
}

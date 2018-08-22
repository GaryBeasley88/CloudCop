namespace CloudCop.Controls
{
    partial class RMSSearch_Date
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
            this.monthEdit1 = new DevExpress.XtraScheduler.UI.MonthEdit();
            this.weekOfMonthEdit1 = new DevExpress.XtraScheduler.UI.WeekOfMonthEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.monthEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekOfMonthEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // monthEdit1
            // 
            this.monthEdit1.Location = new System.Drawing.Point(13, 22);
            this.monthEdit1.Name = "monthEdit1";
            this.monthEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.monthEdit1.Size = new System.Drawing.Size(100, 20);
            this.monthEdit1.TabIndex = 0;
            // 
            // weekOfMonthEdit1
            // 
            this.weekOfMonthEdit1.Location = new System.Drawing.Point(132, 22);
            this.weekOfMonthEdit1.Name = "weekOfMonthEdit1";
            this.weekOfMonthEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.weekOfMonthEdit1.Size = new System.Drawing.Size(100, 20);
            this.weekOfMonthEdit1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Monthly Range";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Weekly Range";
            // 
            // USearch_DateRange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.weekOfMonthEdit1);
            this.Controls.Add(this.monthEdit1);
            this.Name = "USearch_DateRange";
            this.Size = new System.Drawing.Size(248, 223);
            ((System.ComponentModel.ISupportInitialize)(this.monthEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weekOfMonthEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraScheduler.UI.MonthEdit monthEdit1;
        private DevExpress.XtraScheduler.UI.WeekOfMonthEdit weekOfMonthEdit1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

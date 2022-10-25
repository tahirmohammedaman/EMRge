namespace EMRge.UserControls
{
    partial class UCBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCBill));
            this.LblBillNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblServiceType = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblServicePrice = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // LblBillNo
            // 
            this.LblBillNo.AllowParentOverrides = false;
            this.LblBillNo.AutoEllipsis = false;
            this.LblBillNo.CursorType = null;
            this.LblBillNo.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.LblBillNo.IsSelectionEnabled = true;
            this.LblBillNo.Location = new System.Drawing.Point(21, 5);
            this.LblBillNo.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblBillNo.Name = "LblBillNo";
            this.LblBillNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblBillNo.Size = new System.Drawing.Size(10, 19);
            this.LblBillNo.TabIndex = 81;
            this.LblBillNo.Text = "1. ";
            this.LblBillNo.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblBillNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblServiceType
            // 
            this.LblServiceType.AllowParentOverrides = false;
            this.LblServiceType.AutoEllipsis = false;
            this.LblServiceType.CursorType = null;
            this.LblServiceType.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.LblServiceType.IsSelectionEnabled = true;
            this.LblServiceType.Location = new System.Drawing.Point(121, 5);
            this.LblServiceType.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblServiceType.Name = "LblServiceType";
            this.LblServiceType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblServiceType.Size = new System.Drawing.Size(56, 19);
            this.LblServiceType.TabIndex = 82;
            this.LblServiceType.Text = "Test XYZ";
            this.LblServiceType.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblServiceType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblServicePrice
            // 
            this.LblServicePrice.AllowParentOverrides = false;
            this.LblServicePrice.AutoEllipsis = false;
            this.LblServicePrice.CursorType = null;
            this.LblServicePrice.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.LblServicePrice.IsSelectionEnabled = true;
            this.LblServicePrice.Location = new System.Drawing.Point(392, 5);
            this.LblServicePrice.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblServicePrice.Name = "LblServicePrice";
            this.LblServicePrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblServicePrice.Size = new System.Drawing.Size(34, 19);
            this.LblServicePrice.TabIndex = 83;
            this.LblServicePrice.Text = "1,650";
            this.LblServicePrice.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblServicePrice.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UCBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.LblServicePrice);
            this.Controls.Add(this.LblServiceType);
            this.Controls.Add(this.LblBillNo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UCBill";
            this.Size = new System.Drawing.Size(518, 33);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel LblBillNo;
        private Bunifu.UI.WinForms.BunifuLabel LblServiceType;
        private Bunifu.UI.WinForms.BunifuLabel LblServicePrice;
    }
}

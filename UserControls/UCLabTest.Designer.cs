namespace EMRge.UserControls
{
    partial class UCLabTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCLabTest));
            this.LblTestType = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblTestNo = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblTestResult = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // LblTestType
            // 
            this.LblTestType.AllowParentOverrides = false;
            this.LblTestType.AutoEllipsis = true;
            this.LblTestType.CursorType = null;
            this.LblTestType.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestType.IsSelectionEnabled = true;
            this.LblTestType.Location = new System.Drawing.Point(60, 5);
            this.LblTestType.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblTestType.Name = "LblTestType";
            this.LblTestType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTestType.Size = new System.Drawing.Size(54, 19);
            this.LblTestType.TabIndex = 84;
            this.LblTestType.Text = "Med XYZ";
            this.LblTestType.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblTestType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblTestNo
            // 
            this.LblTestNo.AllowParentOverrides = false;
            this.LblTestNo.AutoEllipsis = true;
            this.LblTestNo.CursorType = null;
            this.LblTestNo.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestNo.IsSelectionEnabled = true;
            this.LblTestNo.Location = new System.Drawing.Point(23, 20);
            this.LblTestNo.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblTestNo.Name = "LblTestNo";
            this.LblTestNo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTestNo.Size = new System.Drawing.Size(10, 20);
            this.LblTestNo.TabIndex = 85;
            this.LblTestNo.Text = "1.";
            this.LblTestNo.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTestNo.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblTestResult
            // 
            this.LblTestResult.AllowParentOverrides = false;
            this.LblTestResult.AutoEllipsis = true;
            this.LblTestResult.CursorType = null;
            this.LblTestResult.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestResult.IsSelectionEnabled = true;
            this.LblTestResult.Location = new System.Drawing.Point(60, 34);
            this.LblTestResult.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.LblTestResult.Name = "LblTestResult";
            this.LblTestResult.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTestResult.Size = new System.Drawing.Size(154, 19);
            this.LblTestResult.TabIndex = 86;
            this.LblTestResult.Text = "Test ordered! (In Queue)";
            this.LblTestResult.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.LblTestResult.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // UCLabTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.LblTestResult);
            this.Controls.Add(this.LblTestNo);
            this.Controls.Add(this.LblTestType);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "UCLabTest";
            this.Size = new System.Drawing.Size(286, 76);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel LblTestType;
        private Bunifu.UI.WinForms.BunifuLabel LblTestNo;
        private Bunifu.UI.WinForms.BunifuLabel LblTestResult;
    }
}

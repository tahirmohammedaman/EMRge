namespace EMRge.Forms
{
    partial class FormLaboratory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLaboratory));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblDate = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblLabPhysicianID = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblPatientID = new Bunifu.UI.WinForms.BunifuLabel();
            this.TbResults = new Bunifu.UI.WinForms.BunifuTextBox();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblTestType = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel10 = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblExaminationID = new Bunifu.UI.WinForms.BunifuLabel();
            this.BtnSubmitResults = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DGVLaboratoryQueue = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.BtnRefresh = new Bunifu.Framework.UI.BunifuThinButton2();
            this.BtnPatientInfo = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLaboratoryQueue)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(109, 28);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(50, 23);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Queue";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.AutoSize = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(735, 94);
            this.bunifuLabel4.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(111, 25);
            this.bunifuLabel4.TabIndex = 78;
            this.bunifuLabel4.Text = "Date";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblDate
            // 
            this.LblDate.AllowParentOverrides = false;
            this.LblDate.AutoEllipsis = false;
            this.LblDate.AutoSize = false;
            this.LblDate.CursorType = null;
            this.LblDate.Font = new System.Drawing.Font("Space Grotesk", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.IsSelectionEnabled = true;
            this.LblDate.Location = new System.Drawing.Point(855, 94);
            this.LblDate.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LblDate.Name = "LblDate";
            this.LblDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblDate.Size = new System.Drawing.Size(222, 25);
            this.LblDate.TabIndex = 79;
            this.LblDate.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblDate.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.AutoSize = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(735, 127);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(111, 25);
            this.bunifuLabel1.TabIndex = 80;
            this.bunifuLabel1.Text = "Patient ID";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AllowParentOverrides = false;
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.AutoSize = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(735, 193);
            this.bunifuLabel5.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(111, 25);
            this.bunifuLabel5.TabIndex = 82;
            this.bunifuLabel5.Text = "Test Type";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel5.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblLabPhysicianID
            // 
            this.LblLabPhysicianID.AllowParentOverrides = false;
            this.LblLabPhysicianID.AutoEllipsis = false;
            this.LblLabPhysicianID.AutoSize = false;
            this.LblLabPhysicianID.CursorType = null;
            this.LblLabPhysicianID.Font = new System.Drawing.Font("Space Grotesk", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLabPhysicianID.IsSelectionEnabled = true;
            this.LblLabPhysicianID.Location = new System.Drawing.Point(855, 160);
            this.LblLabPhysicianID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LblLabPhysicianID.Name = "LblLabPhysicianID";
            this.LblLabPhysicianID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblLabPhysicianID.Size = new System.Drawing.Size(222, 25);
            this.LblLabPhysicianID.TabIndex = 84;
            this.LblLabPhysicianID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblLabPhysicianID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblPatientID
            // 
            this.LblPatientID.AllowParentOverrides = false;
            this.LblPatientID.AutoEllipsis = false;
            this.LblPatientID.AutoSize = false;
            this.LblPatientID.CursorType = null;
            this.LblPatientID.Font = new System.Drawing.Font("Space Grotesk", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPatientID.IsSelectionEnabled = true;
            this.LblPatientID.Location = new System.Drawing.Point(855, 127);
            this.LblPatientID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LblPatientID.Name = "LblPatientID";
            this.LblPatientID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblPatientID.Size = new System.Drawing.Size(222, 25);
            this.LblPatientID.TabIndex = 85;
            this.LblPatientID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblPatientID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // TbResults
            // 
            this.TbResults.AcceptsReturn = false;
            this.TbResults.AcceptsTab = false;
            this.TbResults.AnimationSpeed = 200;
            this.TbResults.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.TbResults.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.TbResults.BackColor = System.Drawing.Color.Transparent;
            this.TbResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TbResults.BackgroundImage")));
            this.TbResults.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.TbResults.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.TbResults.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.TbResults.BorderColorIdle = System.Drawing.Color.Silver;
            this.TbResults.BorderRadius = 10;
            this.TbResults.BorderThickness = 1;
            this.TbResults.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.TbResults.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TbResults.DefaultFont = new System.Drawing.Font("Space Grotesk", 9.75F, System.Drawing.FontStyle.Bold);
            this.TbResults.DefaultText = "";
            this.TbResults.FillColor = System.Drawing.Color.White;
            this.TbResults.HideSelection = true;
            this.TbResults.IconLeft = null;
            this.TbResults.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.TbResults.IconPadding = 10;
            this.TbResults.IconRight = null;
            this.TbResults.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.TbResults.Lines = new string[0];
            this.TbResults.Location = new System.Drawing.Point(786, 318);
            this.TbResults.MaxLength = 32767;
            this.TbResults.MinimumSize = new System.Drawing.Size(1, 1);
            this.TbResults.Modified = false;
            this.TbResults.Multiline = true;
            this.TbResults.Name = "TbResults";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TbResults.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.TbResults.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TbResults.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.TbResults.OnIdleState = stateProperties4;
            this.TbResults.Padding = new System.Windows.Forms.Padding(3);
            this.TbResults.PasswordChar = '\0';
            this.TbResults.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.TbResults.PlaceholderText = "[Enter Test Results]";
            this.TbResults.ReadOnly = false;
            this.TbResults.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TbResults.SelectedText = "";
            this.TbResults.SelectionLength = 0;
            this.TbResults.SelectionStart = 0;
            this.TbResults.ShortcutsEnabled = true;
            this.TbResults.Size = new System.Drawing.Size(291, 176);
            this.TbResults.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.TbResults.TabIndex = 86;
            this.TbResults.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TbResults.TextMarginBottom = 0;
            this.TbResults.TextMarginLeft = 3;
            this.TbResults.TextMarginTop = 0;
            this.TbResults.TextPlaceholder = "[Enter Test Results]";
            this.TbResults.UseSystemPasswordChar = false;
            this.TbResults.WordWrap = true;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel2.Location = new System.Drawing.Point(902, 281);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(49, 20);
            this.bunifuLabel2.TabIndex = 87;
            this.bunifuLabel2.Text = "Results";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AllowParentOverrides = false;
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.AutoSize = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(735, 160);
            this.bunifuLabel6.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(111, 25);
            this.bunifuLabel6.TabIndex = 89;
            this.bunifuLabel6.Text = "Lab Physician ID";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel6.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblTestType
            // 
            this.LblTestType.AllowParentOverrides = false;
            this.LblTestType.AutoEllipsis = false;
            this.LblTestType.AutoSize = false;
            this.LblTestType.CursorType = null;
            this.LblTestType.Font = new System.Drawing.Font("Space Grotesk", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTestType.IsSelectionEnabled = true;
            this.LblTestType.Location = new System.Drawing.Point(855, 193);
            this.LblTestType.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LblTestType.Name = "LblTestType";
            this.LblTestType.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTestType.Size = new System.Drawing.Size(222, 25);
            this.LblTestType.TabIndex = 90;
            this.LblTestType.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblTestType.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel10
            // 
            this.bunifuLabel10.AllowParentOverrides = false;
            this.bunifuLabel10.AutoEllipsis = false;
            this.bunifuLabel10.AutoSize = false;
            this.bunifuLabel10.CursorType = null;
            this.bunifuLabel10.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel10.Location = new System.Drawing.Point(735, 61);
            this.bunifuLabel10.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuLabel10.Name = "bunifuLabel10";
            this.bunifuLabel10.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel10.Size = new System.Drawing.Size(111, 25);
            this.bunifuLabel10.TabIndex = 91;
            this.bunifuLabel10.Text = "Examination ID";
            this.bunifuLabel10.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel10.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // LblExaminationID
            // 
            this.LblExaminationID.AllowParentOverrides = false;
            this.LblExaminationID.AutoEllipsis = false;
            this.LblExaminationID.AutoSize = false;
            this.LblExaminationID.CursorType = null;
            this.LblExaminationID.Font = new System.Drawing.Font("Space Grotesk", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblExaminationID.IsSelectionEnabled = true;
            this.LblExaminationID.Location = new System.Drawing.Point(855, 61);
            this.LblExaminationID.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LblExaminationID.Name = "LblExaminationID";
            this.LblExaminationID.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblExaminationID.Size = new System.Drawing.Size(222, 25);
            this.LblExaminationID.TabIndex = 92;
            this.LblExaminationID.TextAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.LblExaminationID.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BtnSubmitResults
            // 
            this.BtnSubmitResults.AllowAnimations = true;
            this.BtnSubmitResults.AllowMouseEffects = true;
            this.BtnSubmitResults.AllowToggling = false;
            this.BtnSubmitResults.AnimationSpeed = 200;
            this.BtnSubmitResults.AutoGenerateColors = false;
            this.BtnSubmitResults.AutoRoundBorders = false;
            this.BtnSubmitResults.AutoSizeLeftIcon = true;
            this.BtnSubmitResults.AutoSizeRightIcon = true;
            this.BtnSubmitResults.BackColor = System.Drawing.Color.Transparent;
            this.BtnSubmitResults.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnSubmitResults.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSubmitResults.BackgroundImage")));
            this.BtnSubmitResults.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmitResults.ButtonText = "Submit Results";
            this.BtnSubmitResults.ButtonTextMarginLeft = 0;
            this.BtnSubmitResults.ColorContrastOnClick = 45;
            this.BtnSubmitResults.ColorContrastOnHover = 45;
            this.BtnSubmitResults.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnSubmitResults.CustomizableEdges = borderEdges1;
            this.BtnSubmitResults.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnSubmitResults.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSubmitResults.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSubmitResults.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSubmitResults.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnSubmitResults.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSubmitResults.ForeColor = System.Drawing.Color.Black;
            this.BtnSubmitResults.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSubmitResults.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSubmitResults.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnSubmitResults.IconMarginLeft = 11;
            this.BtnSubmitResults.IconPadding = 10;
            this.BtnSubmitResults.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnSubmitResults.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnSubmitResults.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnSubmitResults.IconSize = 25;
            this.BtnSubmitResults.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnSubmitResults.IdleBorderRadius = 5;
            this.BtnSubmitResults.IdleBorderThickness = 1;
            this.BtnSubmitResults.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnSubmitResults.IdleIconLeftImage = null;
            this.BtnSubmitResults.IdleIconRightImage = null;
            this.BtnSubmitResults.IndicateFocus = false;
            this.BtnSubmitResults.Location = new System.Drawing.Point(867, 516);
            this.BtnSubmitResults.Margin = new System.Windows.Forms.Padding(4);
            this.BtnSubmitResults.Name = "BtnSubmitResults";
            this.BtnSubmitResults.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnSubmitResults.OnDisabledState.BorderRadius = 5;
            this.BtnSubmitResults.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmitResults.OnDisabledState.BorderThickness = 1;
            this.BtnSubmitResults.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnSubmitResults.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnSubmitResults.OnDisabledState.IconLeftImage = null;
            this.BtnSubmitResults.OnDisabledState.IconRightImage = null;
            this.BtnSubmitResults.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(140)))));
            this.BtnSubmitResults.onHoverState.BorderRadius = 5;
            this.BtnSubmitResults.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmitResults.onHoverState.BorderThickness = 1;
            this.BtnSubmitResults.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(140)))));
            this.BtnSubmitResults.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmitResults.onHoverState.IconLeftImage = null;
            this.BtnSubmitResults.onHoverState.IconRightImage = null;
            this.BtnSubmitResults.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnSubmitResults.OnIdleState.BorderRadius = 5;
            this.BtnSubmitResults.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmitResults.OnIdleState.BorderThickness = 1;
            this.BtnSubmitResults.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnSubmitResults.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnSubmitResults.OnIdleState.IconLeftImage = null;
            this.BtnSubmitResults.OnIdleState.IconRightImage = null;
            this.BtnSubmitResults.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(100)))));
            this.BtnSubmitResults.OnPressedState.BorderRadius = 5;
            this.BtnSubmitResults.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnSubmitResults.OnPressedState.BorderThickness = 1;
            this.BtnSubmitResults.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(100)))));
            this.BtnSubmitResults.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnSubmitResults.OnPressedState.IconLeftImage = null;
            this.BtnSubmitResults.OnPressedState.IconRightImage = null;
            this.BtnSubmitResults.Size = new System.Drawing.Size(132, 46);
            this.BtnSubmitResults.TabIndex = 106;
            this.BtnSubmitResults.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnSubmitResults.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnSubmitResults.TextMarginLeft = 0;
            this.BtnSubmitResults.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnSubmitResults.UseDefaultRadiusAndThickness = true;
            this.BtnSubmitResults.Click += new System.EventHandler(this.BtnSubmitResults_Click);
            // 
            // DGVLaboratoryQueue
            // 
            this.DGVLaboratoryQueue.AllowCustomTheming = true;
            this.DGVLaboratoryQueue.AllowUserToAddRows = false;
            this.DGVLaboratoryQueue.AllowUserToDeleteRows = false;
            this.DGVLaboratoryQueue.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.DGVLaboratoryQueue.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVLaboratoryQueue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVLaboratoryQueue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DGVLaboratoryQueue.BackgroundColor = System.Drawing.Color.White;
            this.DGVLaboratoryQueue.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLaboratoryQueue.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLaboratoryQueue.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLaboratoryQueue.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVLaboratoryQueue.ColumnHeadersHeight = 40;
            this.DGVLaboratoryQueue.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.DGVLaboratoryQueue.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold);
            this.DGVLaboratoryQueue.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVLaboratoryQueue.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGVLaboratoryQueue.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVLaboratoryQueue.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.DGVLaboratoryQueue.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGVLaboratoryQueue.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.DGVLaboratoryQueue.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLaboratoryQueue.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVLaboratoryQueue.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.DGVLaboratoryQueue.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.DGVLaboratoryQueue.CurrentTheme.Name = null;
            this.DGVLaboratoryQueue.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.DGVLaboratoryQueue.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLaboratoryQueue.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVLaboratoryQueue.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.DGVLaboratoryQueue.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVLaboratoryQueue.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Space Grotesk Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLaboratoryQueue.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVLaboratoryQueue.EnableHeadersVisualStyles = false;
            this.DGVLaboratoryQueue.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.DGVLaboratoryQueue.HeaderBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(166)))), ((int)(((byte)(247)))));
            this.DGVLaboratoryQueue.HeaderBgColor = System.Drawing.Color.Empty;
            this.DGVLaboratoryQueue.HeaderForeColor = System.Drawing.Color.White;
            this.DGVLaboratoryQueue.Location = new System.Drawing.Point(28, 79);
            this.DGVLaboratoryQueue.MultiSelect = false;
            this.DGVLaboratoryQueue.Name = "DGVLaboratoryQueue";
            this.DGVLaboratoryQueue.ReadOnly = true;
            this.DGVLaboratoryQueue.RowHeadersVisible = false;
            this.DGVLaboratoryQueue.RowHeadersWidth = 51;
            this.DGVLaboratoryQueue.RowTemplate.Height = 40;
            this.DGVLaboratoryQueue.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLaboratoryQueue.Size = new System.Drawing.Size(700, 398);
            this.DGVLaboratoryQueue.TabIndex = 108;
            this.DGVLaboratoryQueue.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Teal;
            this.DGVLaboratoryQueue.DoubleClick += new System.EventHandler(this.DGVLaboratoryQueue_DoubleClick);
            // 
            // BtnRefresh
            // 
            this.BtnRefresh.ActiveBorderThickness = 1;
            this.BtnRefresh.ActiveCornerRadius = 20;
            this.BtnRefresh.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresh.ActiveForecolor = System.Drawing.Color.White;
            this.BtnRefresh.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresh.BackColor = System.Drawing.Color.White;
            this.BtnRefresh.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnRefresh.BackgroundImage")));
            this.BtnRefresh.ButtonText = "Refresh DGV";
            this.BtnRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRefresh.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnRefresh.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresh.IdleBorderThickness = 1;
            this.BtnRefresh.IdleCornerRadius = 20;
            this.BtnRefresh.IdleFillColor = System.Drawing.Color.White;
            this.BtnRefresh.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnRefresh.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnRefresh.Location = new System.Drawing.Point(330, 484);
            this.BtnRefresh.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnRefresh.Name = "BtnRefresh";
            this.BtnRefresh.Size = new System.Drawing.Size(116, 49);
            this.BtnRefresh.TabIndex = 109;
            this.BtnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnRefresh.Click += new System.EventHandler(this.BtnRefresh_Click);
            // 
            // BtnPatientInfo
            // 
            this.BtnPatientInfo.ActiveBorderThickness = 1;
            this.BtnPatientInfo.ActiveCornerRadius = 20;
            this.BtnPatientInfo.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientInfo.ActiveForecolor = System.Drawing.Color.White;
            this.BtnPatientInfo.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientInfo.BackColor = System.Drawing.Color.White;
            this.BtnPatientInfo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPatientInfo.BackgroundImage")));
            this.BtnPatientInfo.ButtonText = "Show Patient Information";
            this.BtnPatientInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnPatientInfo.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold);
            this.BtnPatientInfo.ForeColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientInfo.IdleBorderThickness = 1;
            this.BtnPatientInfo.IdleCornerRadius = 20;
            this.BtnPatientInfo.IdleFillColor = System.Drawing.Color.White;
            this.BtnPatientInfo.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.BtnPatientInfo.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.BtnPatientInfo.Location = new System.Drawing.Point(121, 546);
            this.BtnPatientInfo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnPatientInfo.Name = "BtnPatientInfo";
            this.BtnPatientInfo.Size = new System.Drawing.Size(136, 73);
            this.BtnPatientInfo.TabIndex = 105;
            this.BtnPatientInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnPatientInfo.Click += new System.EventHandler(this.BtnPatientInfo_Click);
            // 
            // FormLaboratory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1117, 753);
            this.Controls.Add(this.BtnRefresh);
            this.Controls.Add(this.DGVLaboratoryQueue);
            this.Controls.Add(this.BtnSubmitResults);
            this.Controls.Add(this.BtnPatientInfo);
            this.Controls.Add(this.LblExaminationID);
            this.Controls.Add(this.bunifuLabel10);
            this.Controls.Add(this.LblTestType);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.TbResults);
            this.Controls.Add(this.LblPatientID);
            this.Controls.Add(this.LblLabPhysicianID);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.bunifuLabel3);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormLaboratory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLaboratory";
            this.Load += new System.EventHandler(this.FormLaboratory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLaboratoryQueue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel LblDate;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel LblLabPhysicianID;
        private Bunifu.UI.WinForms.BunifuLabel LblPatientID;
        private Bunifu.UI.WinForms.BunifuTextBox TbResults;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel LblTestType;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel10;
        private Bunifu.UI.WinForms.BunifuLabel LblExaminationID;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnSubmitResults;
        private Bunifu.UI.WinForms.BunifuDataGridView DGVLaboratoryQueue;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnRefresh;
        private Bunifu.Framework.UI.BunifuThinButton2 BtnPatientInfo;
    }
}
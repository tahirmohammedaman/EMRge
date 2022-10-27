namespace EMRge.Forms
{
    partial class FormBilling
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBilling));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.PanelBills = new System.Windows.Forms.FlowLayoutPanel();
            this.bunifuSeparator1 = new Bunifu.UI.WinForms.BunifuSeparator();
            this.tbSearchByID = new Bunifu.UI.WinForms.BunifuTextBox();
            this.tbSearchByPhoneNo = new Bunifu.UI.WinForms.BunifuTextBox();
            this.BtnViewBills = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BtnMarkAsPaid = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.lblTextTotalStanding = new Bunifu.UI.WinForms.BunifuLabel();
            this.LblTotalBill = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SuspendLayout();
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AllowParentOverrides = false;
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.ForeColor = System.Drawing.Color.Black;
            this.bunifuLabel3.Location = new System.Drawing.Point(54, 42);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(101, 23);
            this.bunifuLabel3.TabIndex = 4;
            this.bunifuLabel3.Text = "Standing Bills";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel3.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // PanelBills
            // 
            this.PanelBills.AutoScroll = true;
            this.PanelBills.Location = new System.Drawing.Point(54, 85);
            this.PanelBills.Name = "PanelBills";
            this.PanelBills.Size = new System.Drawing.Size(512, 375);
            this.PanelBills.TabIndex = 5;
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuSeparator1.BackgroundImage")));
            this.bunifuSeparator1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuSeparator1.DashCap = Bunifu.UI.WinForms.BunifuSeparator.CapStyles.Flat;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.Black;
            this.bunifuSeparator1.LineStyle = Bunifu.UI.WinForms.BunifuSeparator.LineStyles.Solid;
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(573, 85);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Orientation = Bunifu.UI.WinForms.BunifuSeparator.LineOrientation.Vertical;
            this.bunifuSeparator1.Size = new System.Drawing.Size(18, 576);
            this.bunifuSeparator1.TabIndex = 6;
            // 
            // tbSearchByID
            // 
            this.tbSearchByID.AcceptsReturn = false;
            this.tbSearchByID.AcceptsTab = false;
            this.tbSearchByID.AnimationSpeed = 200;
            this.tbSearchByID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearchByID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearchByID.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchByID.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearchByID.BackgroundImage")));
            this.tbSearchByID.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSearchByID.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSearchByID.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSearchByID.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearchByID.BorderRadius = 5;
            this.tbSearchByID.BorderThickness = 1;
            this.tbSearchByID.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearchByID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByID.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchByID.DefaultText = "";
            this.tbSearchByID.FillColor = System.Drawing.Color.White;
            this.tbSearchByID.HideSelection = true;
            this.tbSearchByID.IconLeft = null;
            this.tbSearchByID.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByID.IconPadding = 10;
            this.tbSearchByID.IconRight = null;
            this.tbSearchByID.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByID.Lines = new string[0];
            this.tbSearchByID.Location = new System.Drawing.Point(657, 100);
            this.tbSearchByID.MaxLength = 32767;
            this.tbSearchByID.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearchByID.Modified = false;
            this.tbSearchByID.Multiline = false;
            this.tbSearchByID.Name = "tbSearchByID";
            stateProperties1.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchByID.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSearchByID.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchByID.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.Silver;
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.Empty;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchByID.OnIdleState = stateProperties4;
            this.tbSearchByID.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearchByID.PasswordChar = '\0';
            this.tbSearchByID.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchByID.PlaceholderText = "Patient ID";
            this.tbSearchByID.ReadOnly = false;
            this.tbSearchByID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchByID.SelectedText = "";
            this.tbSearchByID.SelectionLength = 0;
            this.tbSearchByID.SelectionStart = 0;
            this.tbSearchByID.ShortcutsEnabled = true;
            this.tbSearchByID.Size = new System.Drawing.Size(210, 38);
            this.tbSearchByID.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearchByID.TabIndex = 17;
            this.tbSearchByID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchByID.TextMarginBottom = 0;
            this.tbSearchByID.TextMarginLeft = 3;
            this.tbSearchByID.TextMarginTop = 0;
            this.tbSearchByID.TextPlaceholder = "Patient ID";
            this.tbSearchByID.UseSystemPasswordChar = false;
            this.tbSearchByID.WordWrap = true;
            // 
            // tbSearchByPhoneNo
            // 
            this.tbSearchByPhoneNo.AcceptsReturn = false;
            this.tbSearchByPhoneNo.AcceptsTab = false;
            this.tbSearchByPhoneNo.AnimationSpeed = 200;
            this.tbSearchByPhoneNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.tbSearchByPhoneNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.tbSearchByPhoneNo.BackColor = System.Drawing.Color.Transparent;
            this.tbSearchByPhoneNo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tbSearchByPhoneNo.BackgroundImage")));
            this.tbSearchByPhoneNo.BorderColorActive = System.Drawing.Color.DodgerBlue;
            this.tbSearchByPhoneNo.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.tbSearchByPhoneNo.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            this.tbSearchByPhoneNo.BorderColorIdle = System.Drawing.Color.Silver;
            this.tbSearchByPhoneNo.BorderRadius = 5;
            this.tbSearchByPhoneNo.BorderThickness = 1;
            this.tbSearchByPhoneNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.tbSearchByPhoneNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByPhoneNo.DefaultFont = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchByPhoneNo.DefaultText = "";
            this.tbSearchByPhoneNo.FillColor = System.Drawing.Color.White;
            this.tbSearchByPhoneNo.HideSelection = true;
            this.tbSearchByPhoneNo.IconLeft = null;
            this.tbSearchByPhoneNo.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByPhoneNo.IconPadding = 10;
            this.tbSearchByPhoneNo.IconRight = null;
            this.tbSearchByPhoneNo.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.tbSearchByPhoneNo.Lines = new string[0];
            this.tbSearchByPhoneNo.Location = new System.Drawing.Point(657, 169);
            this.tbSearchByPhoneNo.MaxLength = 32767;
            this.tbSearchByPhoneNo.MinimumSize = new System.Drawing.Size(1, 1);
            this.tbSearchByPhoneNo.Modified = false;
            this.tbSearchByPhoneNo.Multiline = false;
            this.tbSearchByPhoneNo.Name = "tbSearchByPhoneNo";
            stateProperties5.BorderColor = System.Drawing.Color.DodgerBlue;
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchByPhoneNo.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.tbSearchByPhoneNo.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(181)))), ((int)(((byte)(255)))));
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchByPhoneNo.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.Silver;
            stateProperties8.FillColor = System.Drawing.Color.White;
            stateProperties8.ForeColor = System.Drawing.Color.Empty;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.tbSearchByPhoneNo.OnIdleState = stateProperties8;
            this.tbSearchByPhoneNo.Padding = new System.Windows.Forms.Padding(3);
            this.tbSearchByPhoneNo.PasswordChar = '\0';
            this.tbSearchByPhoneNo.PlaceholderForeColor = System.Drawing.Color.Silver;
            this.tbSearchByPhoneNo.PlaceholderText = "Patient Phone No";
            this.tbSearchByPhoneNo.ReadOnly = false;
            this.tbSearchByPhoneNo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbSearchByPhoneNo.SelectedText = "";
            this.tbSearchByPhoneNo.SelectionLength = 0;
            this.tbSearchByPhoneNo.SelectionStart = 0;
            this.tbSearchByPhoneNo.ShortcutsEnabled = true;
            this.tbSearchByPhoneNo.Size = new System.Drawing.Size(210, 38);
            this.tbSearchByPhoneNo.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.tbSearchByPhoneNo.TabIndex = 18;
            this.tbSearchByPhoneNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tbSearchByPhoneNo.TextMarginBottom = 0;
            this.tbSearchByPhoneNo.TextMarginLeft = 3;
            this.tbSearchByPhoneNo.TextMarginTop = 0;
            this.tbSearchByPhoneNo.TextPlaceholder = "Patient Phone No";
            this.tbSearchByPhoneNo.UseSystemPasswordChar = false;
            this.tbSearchByPhoneNo.WordWrap = true;
            // 
            // BtnViewBills
            // 
            this.BtnViewBills.AllowAnimations = true;
            this.BtnViewBills.AllowMouseEffects = true;
            this.BtnViewBills.AllowToggling = false;
            this.BtnViewBills.AnimationSpeed = 200;
            this.BtnViewBills.AutoGenerateColors = false;
            this.BtnViewBills.AutoRoundBorders = false;
            this.BtnViewBills.AutoSizeLeftIcon = true;
            this.BtnViewBills.AutoSizeRightIcon = true;
            this.BtnViewBills.BackColor = System.Drawing.Color.Transparent;
            this.BtnViewBills.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnViewBills.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnViewBills.BackgroundImage")));
            this.BtnViewBills.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnViewBills.ButtonText = "View Bills";
            this.BtnViewBills.ButtonTextMarginLeft = 0;
            this.BtnViewBills.ColorContrastOnClick = 45;
            this.BtnViewBills.ColorContrastOnHover = 45;
            this.BtnViewBills.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BtnViewBills.CustomizableEdges = borderEdges1;
            this.BtnViewBills.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnViewBills.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnViewBills.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnViewBills.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnViewBills.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnViewBills.Font = new System.Drawing.Font("Open Sans SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewBills.ForeColor = System.Drawing.Color.Black;
            this.BtnViewBills.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnViewBills.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnViewBills.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnViewBills.IconMarginLeft = 11;
            this.BtnViewBills.IconPadding = 10;
            this.BtnViewBills.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnViewBills.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnViewBills.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnViewBills.IconSize = 25;
            this.BtnViewBills.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnViewBills.IdleBorderRadius = 5;
            this.BtnViewBills.IdleBorderThickness = 1;
            this.BtnViewBills.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnViewBills.IdleIconLeftImage = null;
            this.BtnViewBills.IdleIconRightImage = null;
            this.BtnViewBills.IndicateFocus = false;
            this.BtnViewBills.Location = new System.Drawing.Point(698, 214);
            this.BtnViewBills.Margin = new System.Windows.Forms.Padding(4);
            this.BtnViewBills.Name = "BtnViewBills";
            this.BtnViewBills.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnViewBills.OnDisabledState.BorderRadius = 5;
            this.BtnViewBills.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnViewBills.OnDisabledState.BorderThickness = 1;
            this.BtnViewBills.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnViewBills.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnViewBills.OnDisabledState.IconLeftImage = null;
            this.BtnViewBills.OnDisabledState.IconRightImage = null;
            this.BtnViewBills.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(140)))));
            this.BtnViewBills.onHoverState.BorderRadius = 5;
            this.BtnViewBills.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnViewBills.onHoverState.BorderThickness = 1;
            this.BtnViewBills.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(168)))), ((int)(((byte)(140)))));
            this.BtnViewBills.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnViewBills.onHoverState.IconLeftImage = null;
            this.BtnViewBills.onHoverState.IconRightImage = null;
            this.BtnViewBills.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnViewBills.OnIdleState.BorderRadius = 5;
            this.BtnViewBills.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnViewBills.OnIdleState.BorderThickness = 1;
            this.BtnViewBills.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(188)))));
            this.BtnViewBills.OnIdleState.ForeColor = System.Drawing.Color.Black;
            this.BtnViewBills.OnIdleState.IconLeftImage = null;
            this.BtnViewBills.OnIdleState.IconRightImage = null;
            this.BtnViewBills.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(100)))));
            this.BtnViewBills.OnPressedState.BorderRadius = 5;
            this.BtnViewBills.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnViewBills.OnPressedState.BorderThickness = 1;
            this.BtnViewBills.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(100)))));
            this.BtnViewBills.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnViewBills.OnPressedState.IconLeftImage = null;
            this.BtnViewBills.OnPressedState.IconRightImage = null;
            this.BtnViewBills.Size = new System.Drawing.Size(130, 40);
            this.BtnViewBills.TabIndex = 19;
            this.BtnViewBills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnViewBills.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnViewBills.TextMarginLeft = 0;
            this.BtnViewBills.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnViewBills.UseDefaultRadiusAndThickness = true;
            this.BtnViewBills.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // BtnMarkAsPaid
            // 
            this.BtnMarkAsPaid.AllowAnimations = true;
            this.BtnMarkAsPaid.AllowMouseEffects = true;
            this.BtnMarkAsPaid.AllowToggling = false;
            this.BtnMarkAsPaid.AnimationSpeed = 200;
            this.BtnMarkAsPaid.AutoGenerateColors = false;
            this.BtnMarkAsPaid.AutoRoundBorders = false;
            this.BtnMarkAsPaid.AutoSizeLeftIcon = true;
            this.BtnMarkAsPaid.AutoSizeRightIcon = true;
            this.BtnMarkAsPaid.BackColor = System.Drawing.Color.Transparent;
            this.BtnMarkAsPaid.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.BtnMarkAsPaid.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMarkAsPaid.BackgroundImage")));
            this.BtnMarkAsPaid.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMarkAsPaid.ButtonText = "Mark As Paid";
            this.BtnMarkAsPaid.ButtonTextMarginLeft = 0;
            this.BtnMarkAsPaid.ColorContrastOnClick = 45;
            this.BtnMarkAsPaid.ColorContrastOnHover = 45;
            this.BtnMarkAsPaid.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BtnMarkAsPaid.CustomizableEdges = borderEdges2;
            this.BtnMarkAsPaid.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BtnMarkAsPaid.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMarkAsPaid.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnMarkAsPaid.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnMarkAsPaid.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BtnMarkAsPaid.Font = new System.Drawing.Font("Open Sans SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMarkAsPaid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnMarkAsPaid.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnMarkAsPaid.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BtnMarkAsPaid.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BtnMarkAsPaid.IconMarginLeft = 11;
            this.BtnMarkAsPaid.IconPadding = 10;
            this.BtnMarkAsPaid.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnMarkAsPaid.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BtnMarkAsPaid.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BtnMarkAsPaid.IconSize = 25;
            this.BtnMarkAsPaid.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.BtnMarkAsPaid.IdleBorderRadius = 5;
            this.BtnMarkAsPaid.IdleBorderThickness = 1;
            this.BtnMarkAsPaid.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.BtnMarkAsPaid.IdleIconLeftImage = null;
            this.BtnMarkAsPaid.IdleIconRightImage = null;
            this.BtnMarkAsPaid.IndicateFocus = false;
            this.BtnMarkAsPaid.Location = new System.Drawing.Point(216, 572);
            this.BtnMarkAsPaid.Margin = new System.Windows.Forms.Padding(4);
            this.BtnMarkAsPaid.Name = "BtnMarkAsPaid";
            this.BtnMarkAsPaid.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BtnMarkAsPaid.OnDisabledState.BorderRadius = 5;
            this.BtnMarkAsPaid.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMarkAsPaid.OnDisabledState.BorderThickness = 1;
            this.BtnMarkAsPaid.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BtnMarkAsPaid.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BtnMarkAsPaid.OnDisabledState.IconLeftImage = null;
            this.BtnMarkAsPaid.OnDisabledState.IconRightImage = null;
            this.BtnMarkAsPaid.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(94)))));
            this.BtnMarkAsPaid.onHoverState.BorderRadius = 5;
            this.BtnMarkAsPaid.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMarkAsPaid.onHoverState.BorderThickness = 1;
            this.BtnMarkAsPaid.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(104)))), ((int)(((byte)(94)))));
            this.BtnMarkAsPaid.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BtnMarkAsPaid.onHoverState.IconLeftImage = null;
            this.BtnMarkAsPaid.onHoverState.IconRightImage = null;
            this.BtnMarkAsPaid.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.BtnMarkAsPaid.OnIdleState.BorderRadius = 5;
            this.BtnMarkAsPaid.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMarkAsPaid.OnIdleState.BorderThickness = 1;
            this.BtnMarkAsPaid.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(136)))), ((int)(((byte)(122)))));
            this.BtnMarkAsPaid.OnIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.BtnMarkAsPaid.OnIdleState.IconLeftImage = null;
            this.BtnMarkAsPaid.OnIdleState.IconRightImage = null;
            this.BtnMarkAsPaid.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.BtnMarkAsPaid.OnPressedState.BorderRadius = 5;
            this.BtnMarkAsPaid.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BtnMarkAsPaid.OnPressedState.BorderThickness = 1;
            this.BtnMarkAsPaid.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(68)))), ((int)(((byte)(60)))));
            this.BtnMarkAsPaid.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BtnMarkAsPaid.OnPressedState.IconLeftImage = null;
            this.BtnMarkAsPaid.OnPressedState.IconRightImage = null;
            this.BtnMarkAsPaid.Size = new System.Drawing.Size(152, 42);
            this.BtnMarkAsPaid.TabIndex = 77;
            this.BtnMarkAsPaid.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnMarkAsPaid.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnMarkAsPaid.TextMarginLeft = 0;
            this.BtnMarkAsPaid.TextPadding = new System.Windows.Forms.Padding(0);
            this.BtnMarkAsPaid.UseDefaultRadiusAndThickness = true;
            this.BtnMarkAsPaid.Click += new System.EventHandler(this.BtnMarkAsPaid_Click);
            // 
            // lblTextTotalStanding
            // 
            this.lblTextTotalStanding.AllowParentOverrides = false;
            this.lblTextTotalStanding.AutoEllipsis = false;
            this.lblTextTotalStanding.AutoSize = false;
            this.lblTextTotalStanding.CursorType = null;
            this.lblTextTotalStanding.Font = new System.Drawing.Font("Open Sans SemiBold", 10F, System.Drawing.FontStyle.Bold);
            this.lblTextTotalStanding.Location = new System.Drawing.Point(132, 483);
            this.lblTextTotalStanding.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.lblTextTotalStanding.Name = "lblTextTotalStanding";
            this.lblTextTotalStanding.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTextTotalStanding.Size = new System.Drawing.Size(76, 50);
            this.lblTextTotalStanding.TabIndex = 78;
            this.lblTextTotalStanding.Text = "Total\r\nStanding\r\n";
            this.lblTextTotalStanding.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTextTotalStanding.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.lblTextTotalStanding.Visible = false;
            // 
            // LblTotalBill
            // 
            this.LblTotalBill.AllowParentOverrides = false;
            this.LblTotalBill.AutoEllipsis = false;
            this.LblTotalBill.AutoSize = false;
            this.LblTotalBill.CursorType = null;
            this.LblTotalBill.Font = new System.Drawing.Font("Space Grotesk", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotalBill.IsSelectionEnabled = true;
            this.LblTotalBill.Location = new System.Drawing.Point(374, 483);
            this.LblTotalBill.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.LblTotalBill.Name = "LblTotalBill";
            this.LblTotalBill.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.LblTotalBill.Size = new System.Drawing.Size(76, 50);
            this.LblTotalBill.TabIndex = 79;
            this.LblTotalBill.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.LblTotalBill.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Open Sans", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(752, 145);
            this.bunifuLabel1.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(16, 17);
            this.bunifuLabel1.TabIndex = 80;
            this.bunifuLabel1.Text = "OR";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // FormBilling
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1284, 1031);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.LblTotalBill);
            this.Controls.Add(this.lblTextTotalStanding);
            this.Controls.Add(this.BtnMarkAsPaid);
            this.Controls.Add(this.BtnViewBills);
            this.Controls.Add(this.tbSearchByPhoneNo);
            this.Controls.Add(this.tbSearchByID);
            this.Controls.Add(this.bunifuSeparator1);
            this.Controls.Add(this.PanelBills);
            this.Controls.Add(this.bunifuLabel3);
            this.Font = new System.Drawing.Font("Open Sans", 9.75F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormBilling";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBilling";
            this.Load += new System.EventHandler(this.FormBilling_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private System.Windows.Forms.FlowLayoutPanel PanelBills;
        private Bunifu.UI.WinForms.BunifuSeparator bunifuSeparator1;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearchByID;
        private Bunifu.UI.WinForms.BunifuTextBox tbSearchByPhoneNo;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnViewBills;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BtnMarkAsPaid;
        private Bunifu.UI.WinForms.BunifuLabel lblTextTotalStanding;
        private Bunifu.UI.WinForms.BunifuLabel LblTotalBill;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}
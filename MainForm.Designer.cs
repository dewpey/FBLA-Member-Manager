namespace Inforum
{
    public partial class MainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.membershipNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.school = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearJoined = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gradYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.active = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.amountOwed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Notes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataTablePanel = new System.Windows.Forms.Panel();
            this.ribbon1 = new System.Windows.Forms.Ribbon();
            this.ribbonOrbMenuItem3 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbMenuItem4 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbOptionButton2 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonButton6 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton2 = new System.Windows.Forms.RibbonButton();
            this.ribbonSeparator1 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonTab3 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel6 = new System.Windows.Forms.RibbonPanel();
            this.createReportButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel2 = new System.Windows.Forms.RibbonPanel();
            this.backToSpreadsheet = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel3 = new System.Windows.Forms.RibbonPanel();
            this.openFileButton = new System.Windows.Forms.RibbonButton();
            this.ribbonPanel7 = new System.Windows.Forms.RibbonPanel();
            this.deleteRowButton = new System.Windows.Forms.RibbonButton();
            this.ribbonTab4 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel5 = new System.Windows.Forms.RibbonPanel();
            this.documentationButton = new System.Windows.Forms.RibbonButton();
            this.chartPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lastNameBox = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AmountBox = new System.Windows.Forms.CheckBox();
            this.currentActiveBox = new System.Windows.Forms.CheckBox();
            this.emailBox = new System.Windows.Forms.CheckBox();
            this.stateBox = new System.Windows.Forms.CheckBox();
            this.schoolBox = new System.Windows.Forms.CheckBox();
            this.firstNameBox = new System.Windows.Forms.CheckBox();
            this.memberNumberBox = new System.Windows.Forms.CheckBox();
            this.yearJoinedBox = new System.Windows.Forms.CheckBox();
            this.graduationYearBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.noBalanceBox = new System.Windows.Forms.CheckBox();
            this.balanceBox = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nonActiveBox = new System.Windows.Forms.CheckBox();
            this.activeBox = new System.Windows.Forms.CheckBox();
            this.seniorBox = new System.Windows.Forms.CheckBox();
            this.juniorBox = new System.Windows.Forms.CheckBox();
            this.sophmoreBox = new System.Windows.Forms.CheckBox();
            this.freshmenBox = new System.Windows.Forms.CheckBox();
            this.ribbonSeparator2 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator3 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator4 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonSeparator5 = new System.Windows.Forms.RibbonSeparator();
            this.ribbonPanel4 = new System.Windows.Forms.RibbonPanel();
            this.ribbonTab1 = new System.Windows.Forms.RibbonTab();
            this.ribbonPanel1 = new System.Windows.Forms.RibbonPanel();
            this.ribbonOrbOptionButton1 = new System.Windows.Forms.RibbonOrbOptionButton();
            this.ribbonOrbMenuItem1 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonOrbRecentItem1 = new System.Windows.Forms.RibbonOrbRecentItem();
            this.ribbonOrbMenuItem2 = new System.Windows.Forms.RibbonOrbMenuItem();
            this.ribbonButton3 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton4 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton10 = new System.Windows.Forms.RibbonButton();
            this.ribbonButton5 = new System.Windows.Forms.RibbonButton();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.dataTablePanel.SuspendLayout();
            this.chartPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.membershipNumber,
            this.firstName,
            this.lastName,
            this.school,
            this.state,
            this.email,
            this.yearJoined,
            this.gradYear,
            this.active,
            this.amountOwed,
            this.Notes});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.AppWorkspace;
            this.dataGridView1.Location = new System.Drawing.Point(0, 153);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.RowHeadersWidth = 40;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 348);
            this.dataGridView1.TabIndex = 0;
            // 
            // membershipNumber
            // 
            this.membershipNumber.FillWeight = 106.2802F;
            this.membershipNumber.HeaderText = "Member Num";
            this.membershipNumber.Name = "membershipNumber";
            // 
            // firstName
            // 
            this.firstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.firstName.HeaderText = "First Name";
            this.firstName.Name = "firstName";
            this.firstName.Width = 76;
            // 
            // lastName
            // 
            this.lastName.FillWeight = 106.2802F;
            this.lastName.HeaderText = "Last Name";
            this.lastName.Name = "lastName";
            // 
            // school
            // 
            this.school.FillWeight = 106.2802F;
            this.school.HeaderText = "School";
            this.school.Name = "school";
            // 
            // state
            // 
            this.state.FillWeight = 106.2802F;
            this.state.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.state.HeaderText = "State";
            this.state.Items.AddRange(new object[] {
            "Alabama",
            "Alaska",
            "Arizona",
            "Arkansas",
            "California",
            "Colorado",
            "Connecticut",
            "Delaware",
            "Florida",
            "Georgia",
            "Hawaii",
            "Idaho",
            "Illinois",
            "Indiana",
            "Iowa",
            "Kansas",
            "Kentucky",
            "Louisiana",
            "Maine",
            "Maryland",
            "Massachusetts",
            "Michigan",
            "Minnesota",
            "Mississippi",
            "Missouri",
            "Montana",
            "Nebraska",
            "Nevada",
            "New Hampshire",
            "New Jersey",
            "New Mexico",
            "New York",
            "North Carolina",
            "North Dakota",
            "Ohio",
            "Oklahoma",
            "Oregon",
            "Pennsylvania",
            "Rhode Island",
            "South Carolina",
            "South Dakota",
            "Tennessee",
            "Texas",
            "Utah",
            "Vermont",
            "Virginia",
            "Washington",
            "West Virginia",
            "Wisconsin",
            "Wyoming"});
            this.state.Name = "state";
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // email
            // 
            this.email.FillWeight = 106.2802F;
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            // 
            // yearJoined
            // 
            this.yearJoined.FillWeight = 106.2802F;
            this.yearJoined.HeaderText = "Year Joined";
            this.yearJoined.Name = "yearJoined";
            // 
            // gradYear
            // 
            this.gradYear.FillWeight = 106.2802F;
            this.gradYear.HeaderText = "Graduation Year";
            this.gradYear.Name = "gradYear";
            // 
            // active
            // 
            this.active.FillWeight = 106.2802F;
            this.active.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.active.HeaderText = "Active?";
            this.active.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.active.Name = "active";
            // 
            // amountOwed
            // 
            this.amountOwed.FillWeight = 106.2802F;
            this.amountOwed.HeaderText = "Amount Owed";
            this.amountOwed.Name = "amountOwed";
            this.amountOwed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Notes
            // 
            this.Notes.HeaderText = "Notes";
            this.Notes.Name = "Notes";
            // 
            // dataTablePanel
            // 
            this.dataTablePanel.Controls.Add(this.ribbon1);
            this.dataTablePanel.Controls.Add(this.chartPanel);
            this.dataTablePanel.Location = new System.Drawing.Point(0, 0);
            this.dataTablePanel.Name = "dataTablePanel";
            this.dataTablePanel.Size = new System.Drawing.Size(1164, 525);
            this.dataTablePanel.TabIndex = 2;
            // 
            // ribbon1
            // 
            this.ribbon1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ribbon1.BorderMode = System.Windows.Forms.RibbonWindowMode.InsideWindow;
            this.ribbon1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ribbon1.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.Margin = new System.Windows.Forms.Padding(0);
            this.ribbon1.Minimized = false;
            this.ribbon1.Name = "ribbon1";
            // 
            // 
            // 
            this.ribbon1.OrbDropDown.BackColor = System.Drawing.SystemColors.MenuText;
            this.ribbon1.OrbDropDown.BorderRoundness = 8;
            this.ribbon1.OrbDropDown.Location = new System.Drawing.Point(0, 0);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem3);
            this.ribbon1.OrbDropDown.MenuItems.Add(this.ribbonOrbMenuItem4);
            this.ribbon1.OrbDropDown.Name = "";
            this.ribbon1.OrbDropDown.OptionItems.Add(this.ribbonOrbOptionButton2);
            this.ribbon1.OrbDropDown.Size = new System.Drawing.Size(527, 160);
            this.ribbon1.OrbDropDown.TabIndex = 0;
            this.ribbon1.OrbImage = null;
            this.ribbon1.OrbStyle = System.Windows.Forms.RibbonOrbStyle.Office_2013;
            this.ribbon1.OrbText = "File";
            // 
            // 
            // 
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton6);
            this.ribbon1.QuickAcessToolbar.Items.Add(this.ribbonButton2);
            this.ribbon1.RibbonTabFont = new System.Drawing.Font("Trebuchet MS", 9F);
            this.ribbon1.Size = new System.Drawing.Size(1119, 156);
            this.ribbon1.TabIndex = 2;
            this.ribbon1.Tabs.Add(this.ribbonTab3);
            this.ribbon1.Tabs.Add(this.ribbonTab4);
            this.ribbon1.TabsMargin = new System.Windows.Forms.Padding(12, 26, 20, 0);
            this.ribbon1.Text = "ribbon1";
            this.ribbon1.ThemeColor = System.Windows.Forms.RibbonTheme.Green;
            // 
            // ribbonOrbMenuItem3
            // 
            this.ribbonOrbMenuItem3.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.Image")));
            this.ribbonOrbMenuItem3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem3.SmallImage")));
            this.ribbonOrbMenuItem3.Text = "New";
            // 
            // ribbonOrbMenuItem4
            // 
            this.ribbonOrbMenuItem4.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem4.Image")));
            this.ribbonOrbMenuItem4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem4.SmallImage")));
            this.ribbonOrbMenuItem4.Text = "Save As";
            this.ribbonOrbMenuItem4.Click += new System.EventHandler(this.ribbonOrbMenuItem4_Click);
            // 
            // ribbonOrbOptionButton2
            // 
            this.ribbonOrbOptionButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.Image")));
            this.ribbonOrbOptionButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton2.SmallImage")));
            this.ribbonOrbOptionButton2.Text = "Settings";
            // 
            // ribbonButton6
            // 
            this.ribbonButton6.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.Image")));
            this.ribbonButton6.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton6.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton6.SmallImage")));
            this.ribbonButton6.Text = "ribbonButton6";
            // 
            // ribbonButton2
            // 
            this.ribbonButton2.DropDownItems.Add(this.ribbonSeparator1);
            this.ribbonButton2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.Image")));
            this.ribbonButton2.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton2.SmallImage")));
            this.ribbonButton2.Text = "ribbonButton2";
            this.ribbonButton2.Value = "X";
            // 
            // ribbonTab3
            // 
            this.ribbonTab3.Panels.Add(this.ribbonPanel6);
            this.ribbonTab3.Panels.Add(this.ribbonPanel2);
            this.ribbonTab3.Panels.Add(this.ribbonPanel3);
            this.ribbonTab3.Panels.Add(this.ribbonPanel7);
            this.ribbonTab3.Text = "Main";
            // 
            // ribbonPanel6
            // 
            this.ribbonPanel6.Items.Add(this.createReportButton);
            this.ribbonPanel6.Text = "Export";
            // 
            // createReportButton
            // 
            this.createReportButton.Image = ((System.Drawing.Image)(resources.GetObject("createReportButton.Image")));
            this.createReportButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("createReportButton.SmallImage")));
            this.createReportButton.Text = "Create Report";
            this.createReportButton.Click += new System.EventHandler(this.ribbonButton11_Click);
            // 
            // ribbonPanel2
            // 
            this.ribbonPanel2.Items.Add(this.backToSpreadsheet);
            this.ribbonPanel2.Text = "Back";
            // 
            // backToSpreadsheet
            // 
            this.backToSpreadsheet.Enabled = false;
            this.backToSpreadsheet.Image = global::Inforum.Properties.Resources.ic_spreadsheet;
            this.backToSpreadsheet.SmallImage = global::Inforum.Properties.Resources.ic_spreadsheet;
            this.backToSpreadsheet.Text = "Back to spreadsheet";
            this.backToSpreadsheet.Click += new System.EventHandler(this.ribbonButton7_Click_1);
            // 
            // ribbonPanel3
            // 
            this.ribbonPanel3.Items.Add(this.openFileButton);
            this.ribbonPanel3.Text = "Open File";
            // 
            // openFileButton
            // 
            this.openFileButton.Image = ((System.Drawing.Image)(resources.GetObject("openFileButton.Image")));
            this.openFileButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("openFileButton.SmallImage")));
            this.openFileButton.Text = "Open";
            this.openFileButton.Click += new System.EventHandler(this.ribbonButton8_Click);
            // 
            // ribbonPanel7
            // 
            this.ribbonPanel7.Items.Add(this.deleteRowButton);
            this.ribbonPanel7.Text = "Modify";
            // 
            // deleteRowButton
            // 
            this.deleteRowButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteRowButton.Image")));
            this.deleteRowButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("deleteRowButton.SmallImage")));
            this.deleteRowButton.Text = "Delete Row";
            this.deleteRowButton.Click += new System.EventHandler(this.deleteRowButton_Click);
            // 
            // ribbonTab4
            // 
            this.ribbonTab4.Panels.Add(this.ribbonPanel5);
            this.ribbonTab4.Text = "Documentation";
            // 
            // ribbonPanel5
            // 
            this.ribbonPanel5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonPanel5.Image")));
            this.ribbonPanel5.Items.Add(this.documentationButton);
            this.ribbonPanel5.Text = "Help & Documentation";
            // 
            // documentationButton
            // 
            this.documentationButton.Image = ((System.Drawing.Image)(resources.GetObject("documentationButton.Image")));
            this.documentationButton.SmallImage = ((System.Drawing.Image)(resources.GetObject("documentationButton.SmallImage")));
            this.documentationButton.Text = "Documentation";
            this.documentationButton.Click += new System.EventHandler(this.documentationButton_Click);
            // 
            // chartPanel
            // 
            this.chartPanel.Controls.Add(this.panel1);
            this.chartPanel.Controls.Add(this.dataGridView1);
            this.chartPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartPanel.Location = new System.Drawing.Point(0, 0);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(1164, 525);
            this.chartPanel.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.checkedListBox1);
            this.panel1.Controls.Add(this.lastNameBox);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AmountBox);
            this.panel1.Controls.Add(this.currentActiveBox);
            this.panel1.Controls.Add(this.emailBox);
            this.panel1.Controls.Add(this.stateBox);
            this.panel1.Controls.Add(this.schoolBox);
            this.panel1.Controls.Add(this.firstNameBox);
            this.panel1.Controls.Add(this.memberNumberBox);
            this.panel1.Controls.Add(this.yearJoinedBox);
            this.panel1.Controls.Add(this.graduationYearBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.noBalanceBox);
            this.panel1.Controls.Add(this.balanceBox);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.nonActiveBox);
            this.panel1.Controls.Add(this.activeBox);
            this.panel1.Controls.Add(this.seniorBox);
            this.panel1.Controls.Add(this.juniorBox);
            this.panel1.Controls.Add(this.sophmoreBox);
            this.panel1.Controls.Add(this.freshmenBox);
            this.panel1.Location = new System.Drawing.Point(0, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1112, 351);
            this.panel1.TabIndex = 1;
            // 
            // lastNameBox
            // 
            this.lastNameBox.AutoSize = true;
            this.lastNameBox.Location = new System.Drawing.Point(10, 171);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(77, 17);
            this.lastNameBox.TabIndex = 57;
            this.lastNameBox.Text = "Last Name";
            this.lastNameBox.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(330, 198);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(171, 38);
            this.button5.TabIndex = 56;
            this.button5.Text = "Save as Excel";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Green;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(330, 14);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 51);
            this.button1.TabIndex = 55;
            this.button1.Text = "Back to Data Table";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(330, 244);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 38);
            this.button3.TabIndex = 53;
            this.button3.Text = "Print";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(330, 154);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(171, 38);
            this.button2.TabIndex = 52;
            this.button2.Text = "Save and Open in Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // AmountBox
            // 
            this.AmountBox.AutoSize = true;
            this.AmountBox.Location = new System.Drawing.Point(10, 318);
            this.AmountBox.Name = "AmountBox";
            this.AmountBox.Size = new System.Drawing.Size(93, 17);
            this.AmountBox.TabIndex = 51;
            this.AmountBox.Text = "Amount Owed";
            this.AmountBox.UseVisualStyleBackColor = true;
            // 
            // currentActiveBox
            // 
            this.currentActiveBox.AutoSize = true;
            this.currentActiveBox.Location = new System.Drawing.Point(10, 297);
            this.currentActiveBox.Name = "currentActiveBox";
            this.currentActiveBox.Size = new System.Drawing.Size(114, 17);
            this.currentActiveBox.TabIndex = 50;
            this.currentActiveBox.Text = "Active/Non-Active";
            this.currentActiveBox.UseVisualStyleBackColor = true;
            // 
            // emailBox
            // 
            this.emailBox.AutoSize = true;
            this.emailBox.Location = new System.Drawing.Point(10, 234);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(51, 17);
            this.emailBox.TabIndex = 49;
            this.emailBox.Text = "Email";
            this.emailBox.UseVisualStyleBackColor = true;
            // 
            // stateBox
            // 
            this.stateBox.AutoSize = true;
            this.stateBox.Location = new System.Drawing.Point(10, 213);
            this.stateBox.Name = "stateBox";
            this.stateBox.Size = new System.Drawing.Size(51, 17);
            this.stateBox.TabIndex = 48;
            this.stateBox.Text = "State";
            this.stateBox.UseVisualStyleBackColor = true;
            // 
            // schoolBox
            // 
            this.schoolBox.AutoSize = true;
            this.schoolBox.Location = new System.Drawing.Point(10, 192);
            this.schoolBox.Name = "schoolBox";
            this.schoolBox.Size = new System.Drawing.Size(59, 17);
            this.schoolBox.TabIndex = 47;
            this.schoolBox.Text = "School";
            this.schoolBox.UseVisualStyleBackColor = true;
            // 
            // firstNameBox
            // 
            this.firstNameBox.AutoSize = true;
            this.firstNameBox.Location = new System.Drawing.Point(10, 150);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(76, 17);
            this.firstNameBox.TabIndex = 46;
            this.firstNameBox.Text = "First Name";
            this.firstNameBox.UseVisualStyleBackColor = true;
            // 
            // memberNumberBox
            // 
            this.memberNumberBox.AutoSize = true;
            this.memberNumberBox.Location = new System.Drawing.Point(10, 129);
            this.memberNumberBox.Name = "memberNumberBox";
            this.memberNumberBox.Size = new System.Drawing.Size(104, 17);
            this.memberNumberBox.TabIndex = 45;
            this.memberNumberBox.Text = "Member Number";
            this.memberNumberBox.UseVisualStyleBackColor = true;
            // 
            // yearJoinedBox
            // 
            this.yearJoinedBox.AutoSize = true;
            this.yearJoinedBox.Location = new System.Drawing.Point(10, 255);
            this.yearJoinedBox.Name = "yearJoinedBox";
            this.yearJoinedBox.Size = new System.Drawing.Size(82, 17);
            this.yearJoinedBox.TabIndex = 44;
            this.yearJoinedBox.Text = "Year Joined";
            this.yearJoinedBox.UseVisualStyleBackColor = true;
            // 
            // graduationYearBox
            // 
            this.graduationYearBox.AutoSize = true;
            this.graduationYearBox.Location = new System.Drawing.Point(10, 276);
            this.graduationYearBox.Name = "graduationYearBox";
            this.graduationYearBox.Size = new System.Drawing.Size(103, 17);
            this.graduationYearBox.TabIndex = 43;
            this.graduationYearBox.Text = "Graduation Year";
            this.graduationYearBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 42;
            this.label1.Text = "Export Options";
            // 
            // noBalanceBox
            // 
            this.noBalanceBox.AutoSize = true;
            this.noBalanceBox.Location = new System.Drawing.Point(163, 78);
            this.noBalanceBox.Name = "noBalanceBox";
            this.noBalanceBox.Size = new System.Drawing.Size(82, 17);
            this.noBalanceBox.TabIndex = 40;
            this.noBalanceBox.Text = "No Balance";
            this.noBalanceBox.UseVisualStyleBackColor = true;
            // 
            // balanceBox
            // 
            this.balanceBox.AutoSize = true;
            this.balanceBox.Location = new System.Drawing.Point(57, 78);
            this.balanceBox.Name = "balanceBox";
            this.balanceBox.Size = new System.Drawing.Size(65, 17);
            this.balanceBox.TabIndex = 39;
            this.balanceBox.Text = "Balance";
            this.balanceBox.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel3.Location = new System.Drawing.Point(11, 101);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(289, 1);
            this.panel3.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(11, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(289, 1);
            this.panel2.TabIndex = 38;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel4.Location = new System.Drawing.Point(11, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(289, 1);
            this.panel4.TabIndex = 37;
            // 
            // nonActiveBox
            // 
            this.nonActiveBox.AutoSize = true;
            this.nonActiveBox.Location = new System.Drawing.Point(163, 48);
            this.nonActiveBox.Name = "nonActiveBox";
            this.nonActiveBox.Size = new System.Drawing.Size(79, 17);
            this.nonActiveBox.TabIndex = 36;
            this.nonActiveBox.Text = "Non-Active";
            this.nonActiveBox.UseVisualStyleBackColor = true;
            // 
            // activeBox
            // 
            this.activeBox.AutoSize = true;
            this.activeBox.Location = new System.Drawing.Point(57, 48);
            this.activeBox.Name = "activeBox";
            this.activeBox.Size = new System.Drawing.Size(56, 17);
            this.activeBox.TabIndex = 35;
            this.activeBox.Text = "Active";
            this.activeBox.UseVisualStyleBackColor = true;
            // 
            // seniorBox
            // 
            this.seniorBox.AutoSize = true;
            this.seniorBox.Location = new System.Drawing.Point(239, 18);
            this.seniorBox.Name = "seniorBox";
            this.seniorBox.Size = new System.Drawing.Size(61, 17);
            this.seniorBox.TabIndex = 34;
            this.seniorBox.Text = "Seniors";
            this.seniorBox.UseVisualStyleBackColor = true;
            // 
            // juniorBox
            // 
            this.juniorBox.AutoSize = true;
            this.juniorBox.Location = new System.Drawing.Point(174, 18);
            this.juniorBox.Name = "juniorBox";
            this.juniorBox.Size = new System.Drawing.Size(59, 17);
            this.juniorBox.TabIndex = 31;
            this.juniorBox.Text = "Juniors";
            this.juniorBox.UseVisualStyleBackColor = true;
            // 
            // sophmoreBox
            // 
            this.sophmoreBox.AutoSize = true;
            this.sophmoreBox.Location = new System.Drawing.Point(89, 18);
            this.sophmoreBox.Name = "sophmoreBox";
            this.sophmoreBox.Size = new System.Drawing.Size(79, 17);
            this.sophmoreBox.TabIndex = 30;
            this.sophmoreBox.Text = "Sophmores";
            this.sophmoreBox.UseVisualStyleBackColor = true;
            // 
            // freshmenBox
            // 
            this.freshmenBox.AutoSize = true;
            this.freshmenBox.Location = new System.Drawing.Point(11, 18);
            this.freshmenBox.Name = "freshmenBox";
            this.freshmenBox.Size = new System.Drawing.Size(72, 17);
            this.freshmenBox.TabIndex = 29;
            this.freshmenBox.Text = "Freshmen";
            this.freshmenBox.UseVisualStyleBackColor = true;
            // 
            // ribbonPanel4
            // 
            this.ribbonPanel4.Text = "ribbonPanel4";
            // 
            // ribbonTab1
            // 
            this.ribbonTab1.Panels.Add(this.ribbonPanel4);
            this.ribbonTab1.Text = "Home";
            // 
            // ribbonPanel1
            // 
            this.ribbonPanel1.Text = "ribbonPanel1";
            // 
            // ribbonOrbOptionButton1
            // 
            this.ribbonOrbOptionButton1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.Image")));
            this.ribbonOrbOptionButton1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbOptionButton1.SmallImage")));
            this.ribbonOrbOptionButton1.Text = "Settings";
            // 
            // ribbonOrbMenuItem1
            // 
            this.ribbonOrbMenuItem1.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.Image")));
            this.ribbonOrbMenuItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem1.SmallImage")));
            this.ribbonOrbMenuItem1.Text = "New";
            // 
            // ribbonOrbRecentItem1
            // 
            this.ribbonOrbRecentItem1.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.Image")));
            this.ribbonOrbRecentItem1.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbRecentItem1.SmallImage")));
            this.ribbonOrbRecentItem1.Text = "ribbonOrbRecentItem1";
            // 
            // ribbonOrbMenuItem2
            // 
            this.ribbonOrbMenuItem2.DropDownArrowDirection = System.Windows.Forms.RibbonArrowDirection.Left;
            this.ribbonOrbMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.Image")));
            this.ribbonOrbMenuItem2.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonOrbMenuItem2.SmallImage")));
            this.ribbonOrbMenuItem2.Text = "ribbonOrbMenuItem2";
            // 
            // ribbonButton3
            // 
            this.ribbonButton3.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.Image")));
            this.ribbonButton3.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton3.SmallImage")));
            // 
            // ribbonButton4
            // 
            this.ribbonButton4.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.Image")));
            this.ribbonButton4.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton4.SmallImage")));
            // 
            // ribbonButton10
            // 
            this.ribbonButton10.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.Image")));
            this.ribbonButton10.MaxSizeMode = System.Windows.Forms.RibbonElementSizeMode.Compact;
            this.ribbonButton10.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton10.SmallImage")));
            this.ribbonButton10.Text = "ribbonButton10";
            // 
            // ribbonButton5
            // 
            this.ribbonButton5.Image = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.Image")));
            this.ribbonButton5.SmallImage = ((System.Drawing.Image)(resources.GetObject("ribbonButton5.SmallImage")));
            this.ribbonButton5.Text = "Data Table";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Member Number",
            "First Name",
            "Last Name",
            "School",
            "State",
            "Email",
            "Year Joined",
            "Graduation Year",
            "Active/Non-Active",
            "Amount Owed"});
            this.checkedListBox1.Location = new System.Drawing.Point(556, 129);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(120, 214);
            this.checkedListBox1.TabIndex = 58;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1110, 502);
            this.Controls.Add(this.dataTablePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inforum";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.dataTablePanel.ResumeLayout(false);
            this.chartPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel dataTablePanel;
        private System.Windows.Forms.Panel chartPanel;
        private System.Windows.Forms.Ribbon ribbon1;
        private System.Windows.Forms.RibbonTab ribbonTab3;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem1;
        private System.Windows.Forms.RibbonOrbRecentItem ribbonOrbRecentItem1;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem2;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator1;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator2;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator3;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator4;
        private System.Windows.Forms.RibbonSeparator ribbonSeparator5;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem3;
        private System.Windows.Forms.RibbonButton ribbonButton6;
        private System.Windows.Forms.RibbonButton ribbonButton3;
        private System.Windows.Forms.RibbonButton ribbonButton4;
        private System.Windows.Forms.RibbonButton ribbonButton2;
        private System.Windows.Forms.RibbonButton ribbonButton10;
        private System.Windows.Forms.RibbonOrbMenuItem ribbonOrbMenuItem4;
        private System.Windows.Forms.RibbonOrbOptionButton ribbonOrbOptionButton2;
        private System.Windows.Forms.RibbonTab ribbonTab4;
        private System.Windows.Forms.RibbonPanel ribbonPanel5;
        private System.Windows.Forms.RibbonButton documentationButton;
        private System.Windows.Forms.RibbonPanel ribbonPanel6;
        private System.Windows.Forms.RibbonButton createReportButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.CheckBox AmountBox;
        private System.Windows.Forms.CheckBox currentActiveBox;
        private System.Windows.Forms.CheckBox emailBox;
        private System.Windows.Forms.CheckBox stateBox;
        private System.Windows.Forms.CheckBox schoolBox;
        private System.Windows.Forms.CheckBox firstNameBox;
        private System.Windows.Forms.CheckBox memberNumberBox;
        private System.Windows.Forms.CheckBox yearJoinedBox;
        private System.Windows.Forms.CheckBox graduationYearBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox noBalanceBox;
        private System.Windows.Forms.CheckBox balanceBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox nonActiveBox;
        private System.Windows.Forms.CheckBox activeBox;
        private System.Windows.Forms.CheckBox seniorBox;
        private System.Windows.Forms.CheckBox juniorBox;
        private System.Windows.Forms.CheckBox sophmoreBox;
        private System.Windows.Forms.CheckBox freshmenBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RibbonPanel ribbonPanel2;
        private System.Windows.Forms.RibbonButton ribbonButton5;
        private System.Windows.Forms.RibbonButton backToSpreadsheet;
        private System.Windows.Forms.RibbonPanel ribbonPanel4;
        private System.Windows.Forms.RibbonTab ribbonTab1;
        private System.Windows.Forms.RibbonPanel ribbonPanel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn membershipNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn school;
        private System.Windows.Forms.DataGridViewComboBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearJoined;
        private System.Windows.Forms.DataGridViewTextBoxColumn gradYear;
        private System.Windows.Forms.DataGridViewComboBoxColumn active;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountOwed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Notes;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.RibbonPanel ribbonPanel3;
        private System.Windows.Forms.RibbonButton openFileButton;
        private System.Windows.Forms.CheckBox lastNameBox;
        private System.Windows.Forms.RibbonPanel ribbonPanel7;
        private System.Windows.Forms.RibbonButton deleteRowButton;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}


namespace Scorchy.GUI.Forms
{
    partial class Main
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.mainTabs = new MetroFramework.Controls.MetroTabControl();
            this.tabManual = new System.Windows.Forms.TabPage();
            this.splitManualContainer = new System.Windows.Forms.SplitContainer();
            this.treeRunbooks = new System.Windows.Forms.TreeView();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelRunbookParameters = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.buttonMassExecute = new MetroFramework.Controls.MetroButton();
            this.buttonExecute = new MetroFramework.Controls.MetroButton();
            this.buttonCancel = new MetroFramework.Controls.MetroButton();
            this.tabEvents = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.panelEvents = new System.Windows.Forms.Panel();
            this.buttonRefreshEvents = new MetroFramework.Controls.MetroButton();
            this.buttonNextEvents = new MetroFramework.Controls.MetroButton();
            this.buttonPrevEvents = new MetroFramework.Controls.MetroButton();
            this.gridEvents = new MetroFramework.Controls.MetroGrid();
            this.tabJobs = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panelJobs = new System.Windows.Forms.Panel();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.buttonRefreshJobs = new MetroFramework.Controls.MetroButton();
            this.buttonNextJobs = new MetroFramework.Controls.MetroButton();
            this.buttonPrevJobs = new MetroFramework.Controls.MetroButton();
            this.gridJobs = new MetroFramework.Controls.MetroGrid();
            this.menuUser = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.toolstripLoggedUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstripLogout = new System.Windows.Forms.ToolStripMenuItem();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.userMenu = new MetroFramework.Controls.MetroLink();
            this.labelCaption = new MetroFramework.Controls.MetroLabel();
            this.labelDescription = new MetroFramework.Controls.MetroLabel();
            this.mainTabs.SuspendLayout();
            this.tabManual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitManualContainer)).BeginInit();
            this.splitManualContainer.Panel1.SuspendLayout();
            this.splitManualContainer.Panel2.SuspendLayout();
            this.splitManualContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.tabEvents.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.panelEvents.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).BeginInit();
            this.tabJobs.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.panelJobs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).BeginInit();
            this.menuUser.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainTabs
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.mainTabs, 3);
            this.mainTabs.Controls.Add(this.tabManual);
            this.mainTabs.Controls.Add(this.tabEvents);
            this.mainTabs.Controls.Add(this.tabJobs);
            this.mainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTabs.Location = new System.Drawing.Point(3, 49);
            this.mainTabs.Name = "mainTabs";
            this.tableLayoutPanel1.SetRowSpan(this.mainTabs, 2);
            this.mainTabs.SelectedIndex = 2;
            this.mainTabs.Size = new System.Drawing.Size(574, 313);
            this.mainTabs.TabIndex = 0;
            this.mainTabs.UseSelectable = true;
            // 
            // tabManual
            // 
            this.tabManual.BackColor = System.Drawing.SystemColors.Window;
            this.tabManual.Controls.Add(this.splitManualContainer);
            this.tabManual.Location = new System.Drawing.Point(4, 38);
            this.tabManual.Name = "tabManual";
            this.tabManual.Size = new System.Drawing.Size(566, 277);
            this.tabManual.TabIndex = 0;
            this.tabManual.Text = "Manual Start";
            // 
            // splitManualContainer
            // 
            this.splitManualContainer.BackColor = System.Drawing.SystemColors.Window;
            this.splitManualContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitManualContainer.Location = new System.Drawing.Point(0, 0);
            this.splitManualContainer.Name = "splitManualContainer";
            // 
            // splitManualContainer.Panel1
            // 
            this.splitManualContainer.Panel1.Controls.Add(this.treeRunbooks);
            // 
            // splitManualContainer.Panel2
            // 
            this.splitManualContainer.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitManualContainer.Panel2.Controls.Add(this.flowLayoutPanel1);
            this.splitManualContainer.Size = new System.Drawing.Size(566, 277);
            this.splitManualContainer.SplitterDistance = 188;
            this.splitManualContainer.TabIndex = 0;
            // 
            // treeRunbooks
            // 
            this.treeRunbooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeRunbooks.Location = new System.Drawing.Point(0, 0);
            this.treeRunbooks.Name = "treeRunbooks";
            this.treeRunbooks.Size = new System.Drawing.Size(188, 277);
            this.treeRunbooks.TabIndex = 0;
            this.treeRunbooks.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.treeRunbooks_KeyPress);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelRunbookParameters);
            this.flowLayoutPanel1.Controls.Add(this.metroPanel1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(374, 277);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // panelRunbookParameters
            // 
            this.panelRunbookParameters.AutoSize = true;
            this.panelRunbookParameters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelRunbookParameters.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRunbookParameters.HorizontalScrollbarBarColor = true;
            this.panelRunbookParameters.HorizontalScrollbarHighlightOnWheel = false;
            this.panelRunbookParameters.HorizontalScrollbarSize = 10;
            this.panelRunbookParameters.Location = new System.Drawing.Point(3, 3);
            this.panelRunbookParameters.Name = "panelRunbookParameters";
            this.panelRunbookParameters.Size = new System.Drawing.Size(0, 0);
            this.panelRunbookParameters.TabIndex = 0;
            this.panelRunbookParameters.VerticalScrollbar = true;
            this.panelRunbookParameters.VerticalScrollbarBarColor = true;
            this.panelRunbookParameters.VerticalScrollbarHighlightOnWheel = false;
            this.panelRunbookParameters.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.buttonMassExecute);
            this.metroPanel1.Controls.Add(this.buttonExecute);
            this.metroPanel1.Controls.Add(this.buttonCancel);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(3, 9);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(0, 109);
            this.metroPanel1.TabIndex = 1;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // buttonMassExecute
            // 
            this.buttonMassExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMassExecute.Location = new System.Drawing.Point(-182, 3);
            this.buttonMassExecute.Name = "buttonMassExecute";
            this.buttonMassExecute.Size = new System.Drawing.Size(84, 23);
            this.buttonMassExecute.TabIndex = 3;
            this.buttonMassExecute.Text = "Mass Execute";
            this.buttonMassExecute.UseSelectable = true;
            this.buttonMassExecute.Click += new System.EventHandler(this.buttonMassExecute_Click);
            // 
            // buttonExecute
            // 
            this.buttonExecute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExecute.Location = new System.Drawing.Point(-273, 3);
            this.buttonExecute.Name = "buttonExecute";
            this.buttonExecute.Size = new System.Drawing.Size(84, 23);
            this.buttonExecute.TabIndex = 2;
            this.buttonExecute.Text = "Execute";
            this.buttonExecute.UseSelectable = true;
            this.buttonExecute.Click += new System.EventHandler(this.buttonExecute_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancel.Location = new System.Drawing.Point(-91, 3);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(84, 23);
            this.buttonCancel.TabIndex = 4;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseSelectable = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // tabEvents
            // 
            this.tabEvents.Controls.Add(this.tableLayoutPanel2);
            this.tabEvents.Location = new System.Drawing.Point(4, 38);
            this.tabEvents.Name = "tabEvents";
            this.tabEvents.Size = new System.Drawing.Size(566, 277);
            this.tabEvents.TabIndex = 1;
            this.tabEvents.Text = "Events";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.panelEvents, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.gridEvents, 0, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(566, 277);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // panelEvents
            // 
            this.panelEvents.Controls.Add(this.buttonRefreshEvents);
            this.panelEvents.Controls.Add(this.buttonNextEvents);
            this.panelEvents.Controls.Add(this.buttonPrevEvents);
            this.panelEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvents.Location = new System.Drawing.Point(3, 3);
            this.panelEvents.Name = "panelEvents";
            this.panelEvents.Size = new System.Drawing.Size(560, 34);
            this.panelEvents.TabIndex = 0;
            // 
            // buttonRefreshEvents
            // 
            this.buttonRefreshEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshEvents.Location = new System.Drawing.Point(470, 3);
            this.buttonRefreshEvents.Name = "buttonRefreshEvents";
            this.buttonRefreshEvents.Size = new System.Drawing.Size(52, 23);
            this.buttonRefreshEvents.TabIndex = 0;
            this.buttonRefreshEvents.Text = "Refresh";
            this.buttonRefreshEvents.UseSelectable = true;
            this.buttonRefreshEvents.Click += new System.EventHandler(this.buttonRefreshEvents_Click);
            // 
            // buttonNextEvents
            // 
            this.buttonNextEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextEvents.Location = new System.Drawing.Point(528, 3);
            this.buttonNextEvents.Name = "buttonNextEvents";
            this.buttonNextEvents.Size = new System.Drawing.Size(29, 23);
            this.buttonNextEvents.TabIndex = 0;
            this.buttonNextEvents.Text = ">>";
            this.buttonNextEvents.UseSelectable = true;
            // 
            // buttonPrevEvents
            // 
            this.buttonPrevEvents.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevEvents.Location = new System.Drawing.Point(435, 3);
            this.buttonPrevEvents.Name = "buttonPrevEvents";
            this.buttonPrevEvents.Size = new System.Drawing.Size(29, 23);
            this.buttonPrevEvents.TabIndex = 0;
            this.buttonPrevEvents.Text = "<<";
            this.buttonPrevEvents.UseSelectable = true;
            // 
            // gridEvents
            // 
            this.gridEvents.AllowUserToAddRows = false;
            this.gridEvents.AllowUserToDeleteRows = false;
            this.gridEvents.AllowUserToResizeRows = false;
            this.gridEvents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridEvents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridEvents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEvents.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridEvents.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridEvents.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEvents.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridEvents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEvents.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridEvents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridEvents.EnableHeadersVisualStyles = false;
            this.gridEvents.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridEvents.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridEvents.Location = new System.Drawing.Point(3, 43);
            this.gridEvents.Name = "gridEvents";
            this.gridEvents.ReadOnly = true;
            this.gridEvents.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridEvents.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridEvents.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridEvents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridEvents.Size = new System.Drawing.Size(560, 231);
            this.gridEvents.TabIndex = 1;
            // 
            // tabJobs
            // 
            this.tabJobs.Controls.Add(this.tableLayoutPanel3);
            this.tabJobs.Location = new System.Drawing.Point(4, 38);
            this.tabJobs.Name = "tabJobs";
            this.tabJobs.Size = new System.Drawing.Size(566, 271);
            this.tabJobs.TabIndex = 2;
            this.tabJobs.Text = "Jobs";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.panelJobs, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.gridJobs, 0, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(566, 271);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panelJobs
            // 
            this.panelJobs.Controls.Add(this.metroTextBox1);
            this.panelJobs.Controls.Add(this.buttonRefreshJobs);
            this.panelJobs.Controls.Add(this.buttonNextJobs);
            this.panelJobs.Controls.Add(this.buttonPrevJobs);
            this.panelJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelJobs.Location = new System.Drawing.Point(3, 3);
            this.panelJobs.Name = "panelJobs";
            this.panelJobs.Size = new System.Drawing.Size(560, 34);
            this.panelJobs.TabIndex = 0;
            // 
            // metroTextBox1
            // 
            this.metroTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(116, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.White;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Text = "🔍";
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(291, 3);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Search";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.ShowButton = true;
            this.metroTextBox1.ShowClearButton = true;
            this.metroTextBox1.Size = new System.Drawing.Size(138, 23);
            this.metroTextBox1.TabIndex = 1;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Search";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.metroTextBox1.ButtonClick += new MetroFramework.Controls.MetroTextBox.ButClick(this.metroTextBox1_ButtonClick);
            // 
            // buttonRefreshJobs
            // 
            this.buttonRefreshJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRefreshJobs.Location = new System.Drawing.Point(470, 3);
            this.buttonRefreshJobs.Name = "buttonRefreshJobs";
            this.buttonRefreshJobs.Size = new System.Drawing.Size(52, 23);
            this.buttonRefreshJobs.TabIndex = 0;
            this.buttonRefreshJobs.Text = "Refresh";
            this.buttonRefreshJobs.UseSelectable = true;
            this.buttonRefreshJobs.Click += new System.EventHandler(this.buttonRefreshJobs_Click);
            // 
            // buttonNextJobs
            // 
            this.buttonNextJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonNextJobs.Location = new System.Drawing.Point(528, 3);
            this.buttonNextJobs.Name = "buttonNextJobs";
            this.buttonNextJobs.Size = new System.Drawing.Size(29, 23);
            this.buttonNextJobs.TabIndex = 0;
            this.buttonNextJobs.Text = ">>";
            this.buttonNextJobs.UseSelectable = true;
            this.buttonNextJobs.Click += new System.EventHandler(this.buttonNextJobs_Click);
            // 
            // buttonPrevJobs
            // 
            this.buttonPrevJobs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPrevJobs.Location = new System.Drawing.Point(435, 3);
            this.buttonPrevJobs.Name = "buttonPrevJobs";
            this.buttonPrevJobs.Size = new System.Drawing.Size(29, 23);
            this.buttonPrevJobs.TabIndex = 0;
            this.buttonPrevJobs.Text = "<<";
            this.buttonPrevJobs.UseSelectable = true;
            this.buttonPrevJobs.Click += new System.EventHandler(this.buttonPrevJobs_Click);
            // 
            // gridJobs
            // 
            this.gridJobs.AllowUserToAddRows = false;
            this.gridJobs.AllowUserToDeleteRows = false;
            this.gridJobs.AllowUserToResizeRows = false;
            this.gridJobs.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.gridJobs.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.gridJobs.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridJobs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridJobs.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridJobs.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridJobs.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.gridJobs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridJobs.DefaultCellStyle = dataGridViewCellStyle5;
            this.gridJobs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridJobs.EnableHeadersVisualStyles = false;
            this.gridJobs.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridJobs.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridJobs.Location = new System.Drawing.Point(3, 43);
            this.gridJobs.Name = "gridJobs";
            this.gridJobs.ReadOnly = true;
            this.gridJobs.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridJobs.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.gridJobs.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridJobs.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridJobs.Size = new System.Drawing.Size(560, 231);
            this.gridJobs.TabIndex = 1;
            // 
            // menuUser
            // 
            this.menuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstripLoggedUser,
            this.toolstripSettings,
            this.toolstripLogout});
            this.menuUser.Name = "metroContextMenu1";
            this.menuUser.ShowItemToolTips = false;
            this.menuUser.Size = new System.Drawing.Size(117, 70);
            // 
            // toolstripLoggedUser
            // 
            this.toolstripLoggedUser.Name = "toolstripLoggedUser";
            this.toolstripLoggedUser.Size = new System.Drawing.Size(116, 22);
            this.toolstripLoggedUser.Text = "123";
            // 
            // toolstripSettings
            // 
            this.toolstripSettings.Name = "toolstripSettings";
            this.toolstripSettings.Size = new System.Drawing.Size(116, 22);
            this.toolstripSettings.Text = "&Settings";
            this.toolstripSettings.Click += new System.EventHandler(this.toolstripSettings_Click);
            // 
            // toolstripLogout
            // 
            this.toolstripLogout.Name = "toolstripLogout";
            this.toolstripLogout.Size = new System.Drawing.Size(116, 22);
            this.toolstripLogout.Text = "&Logout";
            this.toolstripLogout.Click += new System.EventHandler(this.toolstripLogout_Click);
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.tableLayoutPanel1);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(20, 30);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(580, 365);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.23077F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.76923F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.Controls.Add(this.labelDescription, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.mainTabs, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.userMenu, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.labelCaption, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 21F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(580, 365);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // userMenu
            // 
            this.userMenu.Image = global::Scorchy.GUI.Properties.Resources.icon;
            this.userMenu.ImageSize = 32;
            this.userMenu.Location = new System.Drawing.Point(523, 3);
            this.userMenu.Name = "userMenu";
            this.tableLayoutPanel1.SetRowSpan(this.userMenu, 2);
            this.userMenu.Size = new System.Drawing.Size(38, 34);
            this.userMenu.TabIndex = 4;
            this.userMenu.UseSelectable = true;
            this.userMenu.Click += new System.EventHandler(this.userMenu_Click);
            // 
            // labelCaption
            // 
            this.labelCaption.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.labelCaption, 2);
            this.labelCaption.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelCaption.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.labelCaption.Location = new System.Drawing.Point(3, 0);
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.Size = new System.Drawing.Size(79, 25);
            this.labelCaption.TabIndex = 5;
            this.labelCaption.Text = "Scorchy";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.FontSize = MetroFramework.MetroLabelSize.Small;
            this.labelDescription.Location = new System.Drawing.Point(3, 25);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(327, 15);
            this.labelDescription.TabIndex = 8;
            this.labelDescription.Text = "(graphical user interface for System Center Orchestrator 2012 R2)";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 415);
            this.Controls.Add(this.metroPanel2);
            this.DisplayHeader = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(620, 415);
            this.Name = "Main";
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Text = "System Center Orchestrator 2012 GUI";
            this.mainTabs.ResumeLayout(false);
            this.tabManual.ResumeLayout(false);
            this.splitManualContainer.Panel1.ResumeLayout(false);
            this.splitManualContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitManualContainer)).EndInit();
            this.splitManualContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.metroPanel1.ResumeLayout(false);
            this.tabEvents.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.panelEvents.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEvents)).EndInit();
            this.tabJobs.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.panelJobs.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridJobs)).EndInit();
            this.menuUser.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl mainTabs;
        private System.Windows.Forms.TabPage tabManual;
        private System.Windows.Forms.TabPage tabEvents;
        private System.Windows.Forms.TabPage tabJobs;
        private MetroFramework.Controls.MetroLink userMenu;
        private MetroFramework.Controls.MetroContextMenu menuUser;
        private System.Windows.Forms.ToolStripMenuItem toolstripLoggedUser;
        private System.Windows.Forms.ToolStripMenuItem toolstripLogout;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel labelCaption;
        private System.Windows.Forms.SplitContainer splitManualContainer;
        private System.Windows.Forms.TreeView treeRunbooks;
        private MetroFramework.Controls.MetroPanel panelRunbookParameters;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton buttonExecute;
        private MetroFramework.Controls.MetroButton buttonCancel;
        private MetroFramework.Controls.MetroButton buttonMassExecute;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Panel panelEvents;
        private MetroFramework.Controls.MetroButton buttonRefreshEvents;
        private MetroFramework.Controls.MetroButton buttonNextEvents;
        private MetroFramework.Controls.MetroButton buttonPrevEvents;
        private MetroFramework.Controls.MetroGrid gridEvents;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panelJobs;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private MetroFramework.Controls.MetroButton buttonRefreshJobs;
        private MetroFramework.Controls.MetroButton buttonNextJobs;
        private MetroFramework.Controls.MetroButton buttonPrevJobs;
        private MetroFramework.Controls.MetroGrid gridJobs;
        private System.Windows.Forms.ToolStripMenuItem toolstripSettings;
        private MetroFramework.Controls.MetroLabel labelDescription;
    }
}
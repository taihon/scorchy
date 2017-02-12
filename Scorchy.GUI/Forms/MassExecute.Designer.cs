namespace Scorchy.GUI.Forms
{
    partial class MassExecute
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MassExecute));
            this.tableLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panelButtons = new MetroFramework.Controls.MetroPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Exit = new MetroFramework.Controls.MetroButton();
            this.Execute = new MetroFramework.Controls.MetroButton();
            this.executeProgressbar = new MetroFramework.Controls.MetroProgressBar();
            this.gridParameters = new MetroFramework.Controls.MetroGrid();
            this.labelRunbookName = new MetroFramework.Controls.MetroLabel();
            this.tableLayout.SuspendLayout();
            this.panelButtons.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayout
            // 
            this.tableLayout.ColumnCount = 1;
            this.tableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.Controls.Add(this.panelButtons, 0, 2);
            this.tableLayout.Controls.Add(this.gridParameters, 0, 1);
            this.tableLayout.Controls.Add(this.labelRunbookName, 0, 0);
            this.tableLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayout.Location = new System.Drawing.Point(20, 60);
            this.tableLayout.Name = "tableLayout";
            this.tableLayout.RowCount = 4;
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayout.Size = new System.Drawing.Size(710, 520);
            this.tableLayout.TabIndex = 0;
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.tableLayoutPanel1);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelButtons.HorizontalScrollbarBarColor = true;
            this.panelButtons.HorizontalScrollbarHighlightOnWheel = false;
            this.panelButtons.HorizontalScrollbarSize = 10;
            this.panelButtons.Location = new System.Drawing.Point(3, 463);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(704, 34);
            this.panelButtons.TabIndex = 0;
            this.panelButtons.VerticalScrollbarBarColor = true;
            this.panelButtons.VerticalScrollbarHighlightOnWheel = false;
            this.panelButtons.VerticalScrollbarSize = 10;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80F));
            this.tableLayoutPanel1.Controls.Add(this.Exit, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.Execute, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.executeProgressbar, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(704, 34);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // Exit
            // 
            this.Exit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Exit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit.Location = new System.Drawing.Point(627, 3);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(74, 28);
            this.Exit.TabIndex = 2;
            this.Exit.Text = "Exit";
            this.Exit.UseSelectable = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // Execute
            // 
            this.Execute.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Execute.Location = new System.Drawing.Point(547, 3);
            this.Execute.Name = "Execute";
            this.Execute.Size = new System.Drawing.Size(74, 28);
            this.Execute.TabIndex = 2;
            this.Execute.Text = "Execute";
            this.Execute.UseSelectable = true;
            this.Execute.Click += new System.EventHandler(this.Execute_Click);
            // 
            // executeProgressbar
            // 
            this.executeProgressbar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.executeProgressbar.Location = new System.Drawing.Point(3, 3);
            this.executeProgressbar.Name = "executeProgressbar";
            this.executeProgressbar.Size = new System.Drawing.Size(538, 28);
            this.executeProgressbar.TabIndex = 3;
            this.executeProgressbar.Visible = false;
            // 
            // gridParameters
            // 
            this.gridParameters.AllowUserToResizeRows = false;
            this.gridParameters.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridParameters.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gridParameters.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.gridParameters.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParameters.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridParameters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridParameters.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridParameters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridParameters.EnableHeadersVisualStyles = false;
            this.gridParameters.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.gridParameters.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.gridParameters.Location = new System.Drawing.Point(3, 43);
            this.gridParameters.Name = "gridParameters";
            this.gridParameters.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridParameters.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridParameters.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridParameters.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridParameters.Size = new System.Drawing.Size(704, 414);
            this.gridParameters.TabIndex = 1;
            this.gridParameters.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gridParameters_KeyUp);
            // 
            // labelRunbookName
            // 
            this.labelRunbookName.AutoSize = true;
            this.labelRunbookName.Location = new System.Drawing.Point(3, 0);
            this.labelRunbookName.Name = "labelRunbookName";
            this.labelRunbookName.Size = new System.Drawing.Size(97, 19);
            this.labelRunbookName.TabIndex = 2;
            this.labelRunbookName.Text = "RunbookName";
            // 
            // MassExecute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Exit;
            this.ClientSize = new System.Drawing.Size(750, 600);
            this.Controls.Add(this.tableLayout);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MassExecute";
            this.tableLayout.ResumeLayout(false);
            this.tableLayout.PerformLayout();
            this.panelButtons.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridParameters)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayout;
        private MetroFramework.Controls.MetroPanel panelButtons;
        private MetroFramework.Controls.MetroButton Execute;
        private MetroFramework.Controls.MetroButton Exit;
        private MetroFramework.Controls.MetroGrid gridParameters;
        private MetroFramework.Controls.MetroLabel labelRunbookName;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroProgressBar executeProgressbar;
    }
}
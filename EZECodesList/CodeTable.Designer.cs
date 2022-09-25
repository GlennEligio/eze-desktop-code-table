namespace EZECodesList
{
    partial class CodeTable
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
            this.codeGrid = new MetroFramework.Controls.MetroGrid();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.dtSearch = new MetroFramework.Controls.MetroDateTime();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cboProf = new MetroFramework.Controls.MetroComboBox();
            this.btnSearchCode = new MetroFramework.Controls.MetroButton();
            this.btnPollCode = new MetroFramework.Controls.MetroButton();
            this.timerCodePoll = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.codeGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // codeGrid
            // 
            this.codeGrid.AllowUserToResizeRows = false;
            this.codeGrid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codeGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.codeGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.codeGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.codeGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.codeGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.codeGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.codeGrid.DefaultCellStyle = dataGridViewCellStyle2;
            this.codeGrid.EnableHeadersVisualStyles = false;
            this.codeGrid.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.codeGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.codeGrid.Location = new System.Drawing.Point(23, 160);
            this.codeGrid.Name = "codeGrid";
            this.codeGrid.ReadOnly = true;
            this.codeGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.codeGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.codeGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.codeGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.codeGrid.Size = new System.Drawing.Size(387, 363);
            this.codeGrid.TabIndex = 0;
            this.codeGrid.SelectionChanged += new System.EventHandler(this.codeGrid_SelectionChanged);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(23, 67);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(47, 25);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Date";
            // 
            // dtSearch
            // 
            this.dtSearch.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtSearch.Location = new System.Drawing.Point(111, 63);
            this.dtSearch.MinimumSize = new System.Drawing.Size(0, 29);
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.Size = new System.Drawing.Size(124, 29);
            this.dtSearch.TabIndex = 2;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(23, 111);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(82, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Professor";
            // 
            // cboProf
            // 
            this.cboProf.FormattingEnabled = true;
            this.cboProf.ItemHeight = 23;
            this.cboProf.Location = new System.Drawing.Point(111, 107);
            this.cboProf.Name = "cboProf";
            this.cboProf.Size = new System.Drawing.Size(124, 29);
            this.cboProf.TabIndex = 4;
            this.cboProf.UseSelectable = true;
            // 
            // btnSearchCode
            // 
            this.btnSearchCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnSearchCode.Location = new System.Drawing.Point(277, 63);
            this.btnSearchCode.Name = "btnSearchCode";
            this.btnSearchCode.Size = new System.Drawing.Size(133, 29);
            this.btnSearchCode.TabIndex = 5;
            this.btnSearchCode.Text = "Search Codes";
            this.btnSearchCode.UseSelectable = true;
            this.btnSearchCode.Click += new System.EventHandler(this.btnSearchCode_Click);
            // 
            // btnPollCode
            // 
            this.btnPollCode.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnPollCode.Location = new System.Drawing.Point(277, 111);
            this.btnPollCode.Name = "btnPollCode";
            this.btnPollCode.Size = new System.Drawing.Size(133, 29);
            this.btnPollCode.TabIndex = 6;
            this.btnPollCode.Text = "Poll Today\'s Code";
            this.btnPollCode.UseSelectable = true;
            this.btnPollCode.Click += new System.EventHandler(this.btnPollCode_Click);
            // 
            // timerCodePoll
            // 
            this.timerCodePoll.Interval = 5000;
            this.timerCodePoll.Tick += new System.EventHandler(this.timerCodePoll_Tick);
            // 
            // CodeTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 546);
            this.Controls.Add(this.btnPollCode);
            this.Controls.Add(this.btnSearchCode);
            this.Controls.Add(this.cboProf);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.codeGrid);
            this.Name = "CodeTable";
            this.Text = "Codes";
            this.Load += new System.EventHandler(this.CodeTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.codeGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroGrid codeGrid;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroDateTime dtSearch;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cboProf;
        private MetroFramework.Controls.MetroButton btnSearchCode;
        private MetroFramework.Controls.MetroButton btnPollCode;
        private System.Windows.Forms.Timer timerCodePoll;
    }
}


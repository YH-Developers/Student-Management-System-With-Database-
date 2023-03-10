namespace SSM.Forms
{
    partial class UC_Evaluation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Evaluation));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.SaveBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DatePicker = new Bunifu.UI.WinForms.BunifuDatePicker();
            this.SelectAssesmentComponenetIDComboBox = new MaterialSkin.Controls.MaterialComboBox();
            this.SelectMeasurementID = new MaterialSkin.Controls.MaterialComboBox();
            this.AssesmentComponentRefresh = new System.Windows.Forms.LinkLabel();
            this.RubricMeasurementRefresh = new System.Windows.Forms.LinkLabel();
            this.StartEvaluation = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuDataGridView1 = new Bunifu.UI.WinForms.BunifuDataGridView();
            this.SelectStudentId = new MaterialSkin.Controls.MaterialComboBox();
            this.StudentIDRefresh = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Evaluation";
            // 
            // SaveBtn
            // 
            this.SaveBtn.ActiveBorderThickness = 1;
            this.SaveBtn.ActiveCornerRadius = 20;
            this.SaveBtn.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.ActiveForecolor = System.Drawing.Color.White;
            this.SaveBtn.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveBtn.BackColor = System.Drawing.SystemColors.Control;
            this.SaveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveBtn.BackgroundImage")));
            this.SaveBtn.ButtonText = "Save";
            this.SaveBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleBorderThickness = 1;
            this.SaveBtn.IdleCornerRadius = 20;
            this.SaveBtn.IdleFillColor = System.Drawing.Color.White;
            this.SaveBtn.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.SaveBtn.Location = new System.Drawing.Point(542, 471);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(5);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(181, 41);
            this.SaveBtn.TabIndex = 6;
            this.SaveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // DatePicker
            // 
            this.DatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatePicker.BackColor = System.Drawing.Color.Transparent;
            this.DatePicker.BorderRadius = 1;
            this.DatePicker.Color = System.Drawing.Color.Silver;
            this.DatePicker.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thin;
            this.DatePicker.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.DatePicker.DisabledColor = System.Drawing.Color.Gray;
            this.DatePicker.DisplayWeekNumbers = false;
            this.DatePicker.DPHeight = 0;
            this.DatePicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.DatePicker.FillDatePicker = false;
            this.DatePicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DatePicker.ForeColor = System.Drawing.Color.Black;
            this.DatePicker.Icon = ((System.Drawing.Image)(resources.GetObject("DatePicker.Icon")));
            this.DatePicker.IconColor = System.Drawing.Color.Gray;
            this.DatePicker.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.DatePicker.LeftTextMargin = 5;
            this.DatePicker.Location = new System.Drawing.Point(448, 81);
            this.DatePicker.MinimumSize = new System.Drawing.Size(4, 32);
            this.DatePicker.Name = "DatePicker";
            this.DatePicker.Size = new System.Drawing.Size(275, 32);
            this.DatePicker.TabIndex = 9;
            // 
            // SelectAssesmentComponenetIDComboBox
            // 
            this.SelectAssesmentComponenetIDComboBox.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.SelectAssesmentComponenetIDComboBox.AutoResize = false;
            this.SelectAssesmentComponenetIDComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectAssesmentComponenetIDComboBox.Depth = 0;
            this.SelectAssesmentComponenetIDComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectAssesmentComponenetIDComboBox.DropDownHeight = 174;
            this.SelectAssesmentComponenetIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectAssesmentComponenetIDComboBox.DropDownWidth = 121;
            this.SelectAssesmentComponenetIDComboBox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectAssesmentComponenetIDComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectAssesmentComponenetIDComboBox.FormattingEnabled = true;
            this.SelectAssesmentComponenetIDComboBox.Hint = "Assesment Component ID";
            this.SelectAssesmentComponenetIDComboBox.IntegralHeight = false;
            this.SelectAssesmentComponenetIDComboBox.ItemHeight = 43;
            this.SelectAssesmentComponenetIDComboBox.Location = new System.Drawing.Point(70, 381);
            this.SelectAssesmentComponenetIDComboBox.MaxDropDownItems = 4;
            this.SelectAssesmentComponenetIDComboBox.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectAssesmentComponenetIDComboBox.Name = "SelectAssesmentComponenetIDComboBox";
            this.SelectAssesmentComponenetIDComboBox.Size = new System.Drawing.Size(286, 49);
            this.SelectAssesmentComponenetIDComboBox.StartIndex = 0;
            this.SelectAssesmentComponenetIDComboBox.TabIndex = 11;
            // 
            // SelectMeasurementID
            // 
            this.SelectMeasurementID.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.SelectMeasurementID.AutoResize = false;
            this.SelectMeasurementID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectMeasurementID.Depth = 0;
            this.SelectMeasurementID.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectMeasurementID.DropDownHeight = 174;
            this.SelectMeasurementID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectMeasurementID.DropDownWidth = 121;
            this.SelectMeasurementID.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectMeasurementID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectMeasurementID.FormattingEnabled = true;
            this.SelectMeasurementID.Hint = "Rubric Measurement ID";
            this.SelectMeasurementID.IntegralHeight = false;
            this.SelectMeasurementID.ItemHeight = 43;
            this.SelectMeasurementID.Location = new System.Drawing.Point(448, 381);
            this.SelectMeasurementID.MaxDropDownItems = 4;
            this.SelectMeasurementID.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectMeasurementID.Name = "SelectMeasurementID";
            this.SelectMeasurementID.Size = new System.Drawing.Size(275, 49);
            this.SelectMeasurementID.StartIndex = 0;
            this.SelectMeasurementID.TabIndex = 12;
            // 
            // AssesmentComponentRefresh
            // 
            this.AssesmentComponentRefresh.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.AssesmentComponentRefresh.AutoSize = true;
            this.AssesmentComponentRefresh.LinkColor = System.Drawing.Color.Black;
            this.AssesmentComponentRefresh.Location = new System.Drawing.Point(312, 365);
            this.AssesmentComponentRefresh.Name = "AssesmentComponentRefresh";
            this.AssesmentComponentRefresh.Size = new System.Drawing.Size(44, 13);
            this.AssesmentComponentRefresh.TabIndex = 13;
            this.AssesmentComponentRefresh.TabStop = true;
            this.AssesmentComponentRefresh.Text = "Refresh";
            this.AssesmentComponentRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel3_LinkClicked);
            // 
            // RubricMeasurementRefresh
            // 
            this.RubricMeasurementRefresh.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.RubricMeasurementRefresh.AutoSize = true;
            this.RubricMeasurementRefresh.LinkColor = System.Drawing.Color.Black;
            this.RubricMeasurementRefresh.Location = new System.Drawing.Point(679, 365);
            this.RubricMeasurementRefresh.Name = "RubricMeasurementRefresh";
            this.RubricMeasurementRefresh.Size = new System.Drawing.Size(44, 13);
            this.RubricMeasurementRefresh.TabIndex = 14;
            this.RubricMeasurementRefresh.TabStop = true;
            this.RubricMeasurementRefresh.Text = "Refresh";
            this.RubricMeasurementRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabel1_LinkClicked);
            // 
            // StartEvaluation
            // 
            this.StartEvaluation.ActiveBorderThickness = 1;
            this.StartEvaluation.ActiveCornerRadius = 20;
            this.StartEvaluation.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.StartEvaluation.ActiveForecolor = System.Drawing.Color.White;
            this.StartEvaluation.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.StartEvaluation.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.StartEvaluation.BackColor = System.Drawing.SystemColors.Control;
            this.StartEvaluation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("StartEvaluation.BackgroundImage")));
            this.StartEvaluation.ButtonText = "Start Evaluation";
            this.StartEvaluation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StartEvaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartEvaluation.ForeColor = System.Drawing.Color.SeaGreen;
            this.StartEvaluation.IdleBorderThickness = 1;
            this.StartEvaluation.IdleCornerRadius = 20;
            this.StartEvaluation.IdleFillColor = System.Drawing.Color.White;
            this.StartEvaluation.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.StartEvaluation.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.StartEvaluation.Location = new System.Drawing.Point(542, 303);
            this.StartEvaluation.Margin = new System.Windows.Forms.Padding(5);
            this.StartEvaluation.Name = "StartEvaluation";
            this.StartEvaluation.Size = new System.Drawing.Size(181, 41);
            this.StartEvaluation.TabIndex = 15;
            this.StartEvaluation.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bunifuDataGridView1
            // 
            this.bunifuDataGridView1.AllowCustomTheming = false;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.bunifuDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.bunifuDataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bunifuDataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.bunifuDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.DodgerBlue;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.bunifuDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.bunifuDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(251)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.BackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 11.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(115)))), ((int)(((byte)(204)))));
            this.bunifuDataGridView1.CurrentTheme.HeaderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.Name = null;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.BackColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.CurrentTheme.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(232)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.bunifuDataGridView1.DefaultCellStyle = dataGridViewCellStyle12;
            this.bunifuDataGridView1.EnableHeadersVisualStyles = false;
            this.bunifuDataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.DodgerBlue;
            this.bunifuDataGridView1.HeaderBackColor = System.Drawing.Color.Empty;
            this.bunifuDataGridView1.HeaderForeColor = System.Drawing.Color.White;
            this.bunifuDataGridView1.Location = new System.Drawing.Point(59, 160);
            this.bunifuDataGridView1.Name = "bunifuDataGridView1";
            this.bunifuDataGridView1.RowHeadersVisible = false;
            this.bunifuDataGridView1.RowTemplate.Height = 40;
            this.bunifuDataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bunifuDataGridView1.Size = new System.Drawing.Size(664, 135);
            this.bunifuDataGridView1.TabIndex = 16;
            this.bunifuDataGridView1.Theme = Bunifu.UI.WinForms.BunifuDataGridView.PresetThemes.Light;
            // 
            // SelectStudentId
            // 
            this.SelectStudentId.AutoResize = false;
            this.SelectStudentId.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.SelectStudentId.Depth = 0;
            this.SelectStudentId.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.SelectStudentId.DropDownHeight = 174;
            this.SelectStudentId.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SelectStudentId.DropDownWidth = 121;
            this.SelectStudentId.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.SelectStudentId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SelectStudentId.FormattingEnabled = true;
            this.SelectStudentId.Hint = "Select Student Id";
            this.SelectStudentId.IntegralHeight = false;
            this.SelectStudentId.ItemHeight = 43;
            this.SelectStudentId.Location = new System.Drawing.Point(59, 64);
            this.SelectStudentId.MaxDropDownItems = 4;
            this.SelectStudentId.MouseState = MaterialSkin.MouseState.OUT;
            this.SelectStudentId.Name = "SelectStudentId";
            this.SelectStudentId.Size = new System.Drawing.Size(286, 49);
            this.SelectStudentId.StartIndex = 0;
            this.SelectStudentId.TabIndex = 17;
            this.SelectStudentId.SelectedIndexChanged += new System.EventHandler(this.SelectStudentId_SelectedIndexChanged);
            this.SelectStudentId.SelectedValueChanged += new System.EventHandler(this.SelectStudentId_SelectedValueChanged);
            this.SelectStudentId.Enter += new System.EventHandler(this.SelectStudentId_Enter);
            // 
            // StudentIDRefresh
            // 
            this.StudentIDRefresh.AutoSize = true;
            this.StudentIDRefresh.LinkColor = System.Drawing.Color.Black;
            this.StudentIDRefresh.Location = new System.Drawing.Point(301, 48);
            this.StudentIDRefresh.Name = "StudentIDRefresh";
            this.StudentIDRefresh.Size = new System.Drawing.Size(44, 13);
            this.StudentIDRefresh.TabIndex = 18;
            this.StudentIDRefresh.TabStop = true;
            this.StudentIDRefresh.Text = "Refresh";
            this.StudentIDRefresh.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.StudentIDRefresh_LinkClicked);
            // 
            // UC_Evaluation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StudentIDRefresh);
            this.Controls.Add(this.SelectStudentId);
            this.Controls.Add(this.bunifuDataGridView1);
            this.Controls.Add(this.StartEvaluation);
            this.Controls.Add(this.RubricMeasurementRefresh);
            this.Controls.Add(this.AssesmentComponentRefresh);
            this.Controls.Add(this.SelectMeasurementID);
            this.Controls.Add(this.SelectAssesmentComponenetIDComboBox);
            this.Controls.Add(this.DatePicker);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.label1);
            this.MinimumSize = new System.Drawing.Size(787, 549);
            this.Name = "UC_Evaluation";
            this.Size = new System.Drawing.Size(787, 549);
            this.Load += new System.EventHandler(this.UC_Evaluation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuDataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 SaveBtn;
        private Bunifu.UI.WinForms.BunifuDatePicker DatePicker;
        private MaterialSkin.Controls.MaterialComboBox SelectAssesmentComponenetIDComboBox;
        private MaterialSkin.Controls.MaterialComboBox SelectMeasurementID;
        private System.Windows.Forms.LinkLabel AssesmentComponentRefresh;
        private System.Windows.Forms.LinkLabel RubricMeasurementRefresh;
        private Bunifu.Framework.UI.BunifuThinButton2 StartEvaluation;
        private Bunifu.UI.WinForms.BunifuDataGridView bunifuDataGridView1;
        private MaterialSkin.Controls.MaterialComboBox SelectStudentId;
        private System.Windows.Forms.LinkLabel StudentIDRefresh;
    }
}

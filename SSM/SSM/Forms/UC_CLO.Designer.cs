namespace SSM.Forms
{
    partial class UC_CLO
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_CLO));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialTextBox1 = new MaterialSkin.Controls.MaterialTextBox();
            this.CloName = new MaterialSkin.Controls.MaterialTextBox2();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.RubricName = new MaterialSkin.Controls.MaterialTextBox2();
            this.RubricLeveltxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.MeasurmentLeveltxt = new MaterialSkin.Controls.MaterialTextBox2();
            this.cloError = new System.Windows.Forms.Label();
            this.RubricError = new System.Windows.Forms.Label();
            this.RubricLevelError = new System.Windows.Forms.Label();
            this.MeasurementLevelError = new System.Windows.Forms.Label();
            this.bunifuThinButton24 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton22 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.bunifuThinButton23 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Updateclocombobox = new MaterialSkin.Controls.MaterialComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 81);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(689, 448);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mannage Clos\'s";
            // 
            // materialTextBox1
            // 
            this.materialTextBox1.AnimateReadOnly = false;
            this.materialTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialTextBox1.Depth = 0;
            this.materialTextBox1.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialTextBox1.LeadingIcon = null;
            this.materialTextBox1.Location = new System.Drawing.Point(3, 430);
            this.materialTextBox1.MaxLength = 50;
            this.materialTextBox1.MouseState = MaterialSkin.MouseState.OUT;
            this.materialTextBox1.Multiline = false;
            this.materialTextBox1.Name = "materialTextBox1";
            this.materialTextBox1.Size = new System.Drawing.Size(221, 50);
            this.materialTextBox1.TabIndex = 0;
            this.materialTextBox1.Text = "";
            this.materialTextBox1.TrailingIcon = null;
            // 
            // CloName
            // 
            this.CloName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CloName.AnimateReadOnly = false;
            this.CloName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CloName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.CloName.Depth = 0;
            this.CloName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.CloName.HideSelection = true;
            this.CloName.Hint = "Enter Clo Name";
            this.CloName.LeadingIcon = null;
            this.CloName.Location = new System.Drawing.Point(3, 49);
            this.CloName.MaxLength = 32767;
            this.CloName.MouseState = MaterialSkin.MouseState.OUT;
            this.CloName.Name = "CloName";
            this.CloName.PasswordChar = '\0';
            this.CloName.PrefixSuffixText = null;
            this.CloName.ReadOnly = false;
            this.CloName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CloName.SelectedText = "";
            this.CloName.SelectionLength = 0;
            this.CloName.SelectionStart = 0;
            this.CloName.ShortcutsEnabled = true;
            this.CloName.Size = new System.Drawing.Size(218, 48);
            this.CloName.TabIndex = 1;
            this.CloName.TabStop = false;
            this.CloName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CloName.TrailingIcon = null;
            this.CloName.UseSystemPasswordChar = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.RubricError);
            this.panel1.Controls.Add(this.RubricName);
            this.panel1.Controls.Add(this.bunifuThinButton22);
            this.panel1.Location = new System.Drawing.Point(231, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 386);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 53);
            this.label2.TabIndex = 3;
            this.label2.Text = "Add CLO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 53);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Rubric";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(458, 1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(227, 53);
            this.label4.TabIndex = 5;
            this.label4.Text = "Add Rubric Level";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.MeasurementLevelError);
            this.panel2.Controls.Add(this.RubricLevelError);
            this.panel2.Controls.Add(this.MeasurmentLeveltxt);
            this.panel2.Controls.Add(this.RubricLeveltxt);
            this.panel2.Controls.Add(this.bunifuThinButton23);
            this.panel2.Location = new System.Drawing.Point(458, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 386);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.Updateclocombobox);
            this.panel3.Controls.Add(this.bunifuThinButton24);
            this.panel3.Controls.Add(this.cloError);
            this.panel3.Controls.Add(this.bunifuThinButton21);
            this.panel3.Controls.Add(this.CloName);
            this.panel3.Location = new System.Drawing.Point(4, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(220, 386);
            this.panel3.TabIndex = 7;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel3_Paint);
            // 
            // RubricName
            // 
            this.RubricName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricName.AnimateReadOnly = false;
            this.RubricName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RubricName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RubricName.Depth = 0;
            this.RubricName.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RubricName.HideSelection = true;
            this.RubricName.Hint = "Enter Rubric Name";
            this.RubricName.LeadingIcon = null;
            this.RubricName.Location = new System.Drawing.Point(3, 49);
            this.RubricName.MaxLength = 32767;
            this.RubricName.MouseState = MaterialSkin.MouseState.OUT;
            this.RubricName.Name = "RubricName";
            this.RubricName.PasswordChar = '\0';
            this.RubricName.PrefixSuffixText = null;
            this.RubricName.ReadOnly = false;
            this.RubricName.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RubricName.SelectedText = "";
            this.RubricName.SelectionLength = 0;
            this.RubricName.SelectionStart = 0;
            this.RubricName.ShortcutsEnabled = true;
            this.RubricName.Size = new System.Drawing.Size(218, 48);
            this.RubricName.TabIndex = 4;
            this.RubricName.TabStop = false;
            this.RubricName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RubricName.TrailingIcon = null;
            this.RubricName.UseSystemPasswordChar = false;
            // 
            // RubricLeveltxt
            // 
            this.RubricLeveltxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricLeveltxt.AnimateReadOnly = false;
            this.RubricLeveltxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.RubricLeveltxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RubricLeveltxt.Depth = 0;
            this.RubricLeveltxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.RubricLeveltxt.HideSelection = true;
            this.RubricLeveltxt.Hint = "Enter Rubriic Level";
            this.RubricLeveltxt.LeadingIcon = null;
            this.RubricLeveltxt.Location = new System.Drawing.Point(-2, 49);
            this.RubricLeveltxt.MaxLength = 32767;
            this.RubricLeveltxt.MouseState = MaterialSkin.MouseState.OUT;
            this.RubricLeveltxt.Name = "RubricLeveltxt";
            this.RubricLeveltxt.PasswordChar = '\0';
            this.RubricLeveltxt.PrefixSuffixText = null;
            this.RubricLeveltxt.ReadOnly = false;
            this.RubricLeveltxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RubricLeveltxt.SelectedText = "";
            this.RubricLeveltxt.SelectionLength = 0;
            this.RubricLeveltxt.SelectionStart = 0;
            this.RubricLeveltxt.ShortcutsEnabled = true;
            this.RubricLeveltxt.Size = new System.Drawing.Size(218, 48);
            this.RubricLeveltxt.TabIndex = 4;
            this.RubricLeveltxt.TabStop = false;
            this.RubricLeveltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RubricLeveltxt.TrailingIcon = null;
            this.RubricLeveltxt.UseSystemPasswordChar = false;
            // 
            // MeasurmentLeveltxt
            // 
            this.MeasurmentLeveltxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasurmentLeveltxt.AnimateReadOnly = false;
            this.MeasurmentLeveltxt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.MeasurmentLeveltxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.MeasurmentLeveltxt.Depth = 0;
            this.MeasurmentLeveltxt.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.MeasurmentLeveltxt.HideSelection = true;
            this.MeasurmentLeveltxt.Hint = "Enter Measurement Level";
            this.MeasurmentLeveltxt.LeadingIcon = null;
            this.MeasurmentLeveltxt.Location = new System.Drawing.Point(3, 143);
            this.MeasurmentLeveltxt.MaxLength = 32767;
            this.MeasurmentLeveltxt.MouseState = MaterialSkin.MouseState.OUT;
            this.MeasurmentLeveltxt.Name = "MeasurmentLeveltxt";
            this.MeasurmentLeveltxt.PasswordChar = '\0';
            this.MeasurmentLeveltxt.PrefixSuffixText = null;
            this.MeasurmentLeveltxt.ReadOnly = false;
            this.MeasurmentLeveltxt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MeasurmentLeveltxt.SelectedText = "";
            this.MeasurmentLeveltxt.SelectionLength = 0;
            this.MeasurmentLeveltxt.SelectionStart = 0;
            this.MeasurmentLeveltxt.ShortcutsEnabled = true;
            this.MeasurmentLeveltxt.Size = new System.Drawing.Size(218, 48);
            this.MeasurmentLeveltxt.TabIndex = 5;
            this.MeasurmentLeveltxt.TabStop = false;
            this.MeasurmentLeveltxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.MeasurmentLeveltxt.TrailingIcon = null;
            this.MeasurmentLeveltxt.UseSystemPasswordChar = false;
            // 
            // cloError
            // 
            this.cloError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cloError.AutoSize = true;
            this.cloError.ForeColor = System.Drawing.Color.Red;
            this.cloError.Location = new System.Drawing.Point(63, 104);
            this.cloError.Name = "cloError";
            this.cloError.Size = new System.Drawing.Size(0, 13);
            this.cloError.TabIndex = 3;
            // 
            // RubricError
            // 
            this.RubricError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricError.AutoSize = true;
            this.RubricError.BackColor = System.Drawing.Color.White;
            this.RubricError.ForeColor = System.Drawing.Color.Red;
            this.RubricError.Location = new System.Drawing.Point(61, 104);
            this.RubricError.Name = "RubricError";
            this.RubricError.Size = new System.Drawing.Size(0, 13);
            this.RubricError.TabIndex = 4;
            this.RubricError.Click += new System.EventHandler(this.Label6_Click);
            // 
            // RubricLevelError
            // 
            this.RubricLevelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RubricLevelError.AutoSize = true;
            this.RubricLevelError.ForeColor = System.Drawing.Color.Red;
            this.RubricLevelError.Location = new System.Drawing.Point(67, 104);
            this.RubricLevelError.Name = "RubricLevelError";
            this.RubricLevelError.Size = new System.Drawing.Size(0, 13);
            this.RubricLevelError.TabIndex = 6;
            // 
            // MeasurementLevelError
            // 
            this.MeasurementLevelError.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MeasurementLevelError.AutoSize = true;
            this.MeasurementLevelError.ForeColor = System.Drawing.Color.Red;
            this.MeasurementLevelError.Location = new System.Drawing.Point(67, 194);
            this.MeasurementLevelError.Name = "MeasurementLevelError";
            this.MeasurementLevelError.Size = new System.Drawing.Size(0, 13);
            this.MeasurementLevelError.TabIndex = 7;
            // 
            // bunifuThinButton24
            // 
            this.bunifuThinButton24.ActiveBorderThickness = 1;
            this.bunifuThinButton24.ActiveCornerRadius = 20;
            this.bunifuThinButton24.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton24.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton24.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton24.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton24.BackgroundImage")));
            this.bunifuThinButton24.ButtonText = "Update";
            this.bunifuThinButton24.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton24.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton24.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleBorderThickness = 1;
            this.bunifuThinButton24.IdleCornerRadius = 20;
            this.bunifuThinButton24.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton24.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton24.Location = new System.Drawing.Point(5, 331);
            this.bunifuThinButton24.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton24.Name = "bunifuThinButton24";
            this.bunifuThinButton24.Size = new System.Drawing.Size(190, 41);
            this.bunifuThinButton24.TabIndex = 4;
            this.bunifuThinButton24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton24.Click += new System.EventHandler(this.BunifuThinButton24_Click);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 1;
            this.bunifuThinButton21.ActiveCornerRadius = 20;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton21.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Save";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 20;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.Location = new System.Drawing.Point(5, 280);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(190, 41);
            this.bunifuThinButton21.TabIndex = 2;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.BunifuThinButton21_Click);
            // 
            // bunifuThinButton22
            // 
            this.bunifuThinButton22.ActiveBorderThickness = 1;
            this.bunifuThinButton22.ActiveCornerRadius = 20;
            this.bunifuThinButton22.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton22.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton22.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton22.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton22.BackgroundImage")));
            this.bunifuThinButton22.ButtonText = "Save";
            this.bunifuThinButton22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton22.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton22.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleBorderThickness = 1;
            this.bunifuThinButton22.IdleCornerRadius = 20;
            this.bunifuThinButton22.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton22.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton22.Location = new System.Drawing.Point(5, 280);
            this.bunifuThinButton22.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton22.Name = "bunifuThinButton22";
            this.bunifuThinButton22.Size = new System.Drawing.Size(190, 41);
            this.bunifuThinButton22.TabIndex = 3;
            this.bunifuThinButton22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton22.Click += new System.EventHandler(this.BunifuThinButton22_Click);
            // 
            // bunifuThinButton23
            // 
            this.bunifuThinButton23.ActiveBorderThickness = 1;
            this.bunifuThinButton23.ActiveCornerRadius = 20;
            this.bunifuThinButton23.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton23.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuThinButton23.BackColor = System.Drawing.SystemColors.Control;
            this.bunifuThinButton23.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton23.BackgroundImage")));
            this.bunifuThinButton23.ButtonText = "Save";
            this.bunifuThinButton23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton23.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton23.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleBorderThickness = 1;
            this.bunifuThinButton23.IdleCornerRadius = 20;
            this.bunifuThinButton23.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton23.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton23.Location = new System.Drawing.Point(16, 280);
            this.bunifuThinButton23.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton23.Name = "bunifuThinButton23";
            this.bunifuThinButton23.Size = new System.Drawing.Size(190, 41);
            this.bunifuThinButton23.TabIndex = 3;
            this.bunifuThinButton23.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton23.Click += new System.EventHandler(this.BunifuThinButton23_Click);
            // 
            // Updateclocombobox
            // 
            this.Updateclocombobox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Updateclocombobox.AutoResize = false;
            this.Updateclocombobox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Updateclocombobox.Depth = 0;
            this.Updateclocombobox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.Updateclocombobox.DropDownHeight = 174;
            this.Updateclocombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Updateclocombobox.DropDownWidth = 121;
            this.Updateclocombobox.Font = new System.Drawing.Font("Roboto Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.Updateclocombobox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Updateclocombobox.FormattingEnabled = true;
            this.Updateclocombobox.Hint = "Select CLO to Update";
            this.Updateclocombobox.IntegralHeight = false;
            this.Updateclocombobox.ItemHeight = 43;
            this.Updateclocombobox.Location = new System.Drawing.Point(5, 143);
            this.Updateclocombobox.MaxDropDownItems = 4;
            this.Updateclocombobox.MouseState = MaterialSkin.MouseState.OUT;
            this.Updateclocombobox.Name = "Updateclocombobox";
            this.Updateclocombobox.Size = new System.Drawing.Size(214, 49);
            this.Updateclocombobox.StartIndex = 0;
            this.Updateclocombobox.TabIndex = 5;
            this.Updateclocombobox.Visible = false;
            // 
            // UC_CLO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(741, 560);
            this.Name = "UC_CLO";
            this.Size = new System.Drawing.Size(741, 560);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private MaterialSkin.Controls.MaterialTextBox2 CloName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private MaterialSkin.Controls.MaterialTextBox2 RubricName;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton22;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialTextBox2 MeasurmentLeveltxt;
        private MaterialSkin.Controls.MaterialTextBox2 RubricLeveltxt;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton23;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialTextBox materialTextBox1;
        private System.Windows.Forms.Label cloError;
        private System.Windows.Forms.Label RubricError;
        private System.Windows.Forms.Label MeasurementLevelError;
        private System.Windows.Forms.Label RubricLevelError;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton24;
        private MaterialSkin.Controls.MaterialComboBox Updateclocombobox;
    }
}

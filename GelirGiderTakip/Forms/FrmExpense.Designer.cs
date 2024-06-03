namespace GelirGiderTakip.Forms
{
    partial class FrmExpense
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
            btnDelete = new Button();
            btnUpdate = new Button();
            btnSave = new Button();
            dgExpense = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            cbType = new ComboBox();
            label6 = new Label();
            label5 = new Label();
            cbCategory = new ComboBox();
            txtDescription = new TextBox();
            txtAmount = new TextBox();
            dtDate = new DateTimePicker();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label7 = new Label();
            txtId = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgExpense).BeginInit();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Location = new Point(137, 544);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(86, 31);
            btnDelete.TabIndex = 31;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Location = new Point(240, 487);
            btnUpdate.Margin = new Padding(3, 4, 3, 4);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(86, 31);
            btnUpdate.TabIndex = 30;
            btnUpdate.Text = "Güncelle";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnSave
            // 
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Location = new Point(50, 487);
            btnSave.Margin = new Padding(3, 4, 3, 4);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(86, 31);
            btnSave.TabIndex = 29;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dgExpense
            // 
            dgExpense.AllowUserToAddRows = false;
            dgExpense.AllowUserToDeleteRows = false;
            dgExpense.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgExpense.Columns.AddRange(new DataGridViewColumn[] { Column1, Column3, Column4, Column5, Column7, Column2 });
            dgExpense.Location = new Point(399, 56);
            dgExpense.Margin = new Padding(3, 4, 3, 4);
            dgExpense.Name = "dgExpense";
            dgExpense.ReadOnly = true;
            dgExpense.RowHeadersWidth = 51;
            dgExpense.RowTemplate.Height = 25;
            dgExpense.Size = new Size(665, 337);
            dgExpense.TabIndex = 28;
            dgExpense.CellDoubleClick += dgExpense_CellDoubleClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Id";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Visible = false;
            Column1.Width = 125;
            // 
            // Column3
            // 
            Column3.HeaderText = "Tarih";
            Column3.MinimumWidth = 6;
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 125;
            // 
            // Column4
            // 
            Column4.HeaderText = "Miktar";
            Column4.MinimumWidth = 6;
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 125;
            // 
            // Column5
            // 
            Column5.HeaderText = "Açıklama";
            Column5.MinimumWidth = 6;
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 125;
            // 
            // Column7
            // 
            Column7.HeaderText = "Kategori Adı";
            Column7.MinimumWidth = 6;
            Column7.Name = "Column7";
            Column7.ReadOnly = true;
            Column7.Width = 125;
            // 
            // Column2
            // 
            Column2.HeaderText = "Kategori No";
            Column2.MinimumWidth = 6;
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            Column2.Visible = false;
            Column2.Width = 125;
            // 
            // cbType
            // 
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbType.Enabled = false;
            cbType.FormattingEnabled = true;
            cbType.Location = new Point(165, 429);
            cbType.Margin = new Padding(3, 4, 3, 4);
            cbType.Name = "cbType";
            cbType.Size = new Size(134, 28);
            cbType.TabIndex = 27;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(32, 433);
            label6.Name = "label6";
            label6.Size = new Size(31, 18);
            label6.TabIndex = 26;
            label6.Text = "Adı";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(32, 367);
            label5.Name = "label5";
            label5.Size = new Size(98, 18);
            label5.TabIndex = 25;
            label5.Text = "Kategori No";
            // 
            // cbCategory
            // 
            cbCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbCategory.FormattingEnabled = true;
            cbCategory.Location = new Point(165, 363);
            cbCategory.Margin = new Padding(3, 4, 3, 4);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(134, 28);
            cbCategory.TabIndex = 24;
            cbCategory.SelectedIndexChanged += cbCategory_SelectedIndexChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(165, 295);
            txtDescription.Margin = new Padding(3, 4, 3, 4);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(134, 27);
            txtDescription.TabIndex = 23;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(165, 221);
            txtAmount.Margin = new Padding(3, 4, 3, 4);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(134, 27);
            txtAmount.TabIndex = 22;
            // 
            // dtDate
            // 
            dtDate.Location = new Point(165, 143);
            dtDate.Margin = new Padding(3, 4, 3, 4);
            dtDate.Name = "dtDate";
            dtDate.Size = new Size(207, 27);
            dtDate.TabIndex = 21;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(32, 299);
            label4.Name = "label4";
            label4.Size = new Size(76, 18);
            label4.TabIndex = 19;
            label4.Text = "Açıklama";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(32, 225);
            label3.Name = "label3";
            label3.Size = new Size(55, 18);
            label3.TabIndex = 18;
            label3.Text = "Miktar";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(32, 151);
            label2.Name = "label2";
            label2.Size = new Size(46, 18);
            label2.TabIndex = 17;
            label2.Text = "Tarih";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(32, 64);
            label7.Name = "label7";
            label7.Size = new Size(76, 18);
            label7.TabIndex = 33;
            label7.Text = "Gider No";
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 60);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.ReadOnly = true;
            txtId.Size = new Size(134, 27);
            txtId.TabIndex = 32;
            // 
            // FrmExpense
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 612);
            Controls.Add(label7);
            Controls.Add(txtId);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnSave);
            Controls.Add(dgExpense);
            Controls.Add(cbType);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(cbCategory);
            Controls.Add(txtDescription);
            Controls.Add(txtAmount);
            Controls.Add(dtDate);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmExpense";
            Text = "FrmExpense";
            Load += FrmExpense_Load_1;
            ((System.ComponentModel.ISupportInitialize)dgExpense).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private Button btnUpdate;
        private Button btnSave;
        private DataGridView dgExpense;
        private ComboBox cbType;
        private Label label6;
        private Label label5;
        private ComboBox cbCategory;
        private TextBox txtDescription;
        private TextBox txtAmount;
        private DateTimePicker dtDate;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label7;
        private TextBox txtId;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column2;
    }
}
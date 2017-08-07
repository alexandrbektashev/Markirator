namespace Markirator
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1OK = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4FurType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5FurColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7Painted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteRows = new System.Windows.Forms.Button();
            this.btnAddRow = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnCreateMkr = new System.Windows.Forms.Button();
            this.btnOpenMkr = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnAcceptChanges = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(667, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 639);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(667, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(643, 608);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnAcceptChanges);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.btnDeleteRows);
            this.tabPage1.Controls.Add(this.btnAddRow);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.btnCreateMkr);
            this.tabPage1.Controls.Add(this.btnOpenMkr);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(635, 582);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Start";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(294, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Модель, тип изделия, тип меха, цвет, крашеная, размер";
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(168, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Сохранить";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1OK,
            this.Column2Num,
            this.Column6Model,
            this.Column3Description,
            this.Column4FurType,
            this.Column5FurColor,
            this.Column7Painted,
            this.Column8Size});
            this.dataGridView1.Enabled = false;
            this.dataGridView1.Location = new System.Drawing.Point(6, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 486);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridView1_RowsRemoved);
            // 
            // Column1OK
            // 
            this.Column1OK.FillWeight = 30F;
            this.Column1OK.HeaderText = "OK";
            this.Column1OK.Name = "Column1OK";
            this.Column1OK.ReadOnly = true;
            this.Column1OK.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1OK.Width = 30;
            // 
            // Column2Num
            // 
            this.Column2Num.HeaderText = "№";
            this.Column2Num.Name = "Column2Num";
            this.Column2Num.ReadOnly = true;
            this.Column2Num.Width = 30;
            // 
            // Column6Model
            // 
            this.Column6Model.HeaderText = "Модель";
            this.Column6Model.Name = "Column6Model";
            this.Column6Model.Width = 50;
            // 
            // Column3Description
            // 
            this.Column3Description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3Description.HeaderText = "Описание";
            this.Column3Description.Name = "Column3Description";
            // 
            // Column4FurType
            // 
            this.Column4FurType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4FurType.HeaderText = "Мех";
            this.Column4FurType.Name = "Column4FurType";
            // 
            // Column5FurColor
            // 
            this.Column5FurColor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5FurColor.HeaderText = "Цвет";
            this.Column5FurColor.Name = "Column5FurColor";
            // 
            // Column7Painted
            // 
            this.Column7Painted.HeaderText = "Крашенный";
            this.Column7Painted.Name = "Column7Painted";
            this.Column7Painted.Width = 30;
            // 
            // Column8Size
            // 
            this.Column8Size.HeaderText = "Размер";
            this.Column8Size.Name = "Column8Size";
            this.Column8Size.Width = 50;
            // 
            // btnDeleteRows
            // 
            this.btnDeleteRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteRows.Enabled = false;
            this.btnDeleteRows.Location = new System.Drawing.Point(495, 61);
            this.btnDeleteRows.Name = "btnDeleteRows";
            this.btnDeleteRows.Size = new System.Drawing.Size(137, 23);
            this.btnDeleteRows.TabIndex = 5;
            this.btnDeleteRows.Text = "Удалить выбранные";
            this.btnDeleteRows.UseVisualStyleBackColor = true;
            // 
            // btnAddRow
            // 
            this.btnAddRow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddRow.Enabled = false;
            this.btnAddRow.Location = new System.Drawing.Point(557, 33);
            this.btnAddRow.Name = "btnAddRow";
            this.btnAddRow.Size = new System.Drawing.Size(75, 23);
            this.btnAddRow.TabIndex = 0;
            this.btnAddRow.Text = "Добавить";
            this.btnAddRow.UseVisualStyleBackColor = true;
            this.btnAddRow.Click += new System.EventHandler(this.btnAddRow_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsTab = true;
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // btnCreateMkr
            // 
            this.btnCreateMkr.Location = new System.Drawing.Point(87, 6);
            this.btnCreateMkr.Name = "btnCreateMkr";
            this.btnCreateMkr.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMkr.TabIndex = 4;
            this.btnCreateMkr.Text = "Создать";
            this.btnCreateMkr.UseVisualStyleBackColor = true;
            this.btnCreateMkr.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnOpenMkr
            // 
            this.btnOpenMkr.Location = new System.Drawing.Point(6, 6);
            this.btnOpenMkr.Name = "btnOpenMkr";
            this.btnOpenMkr.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMkr.TabIndex = 1;
            this.btnOpenMkr.Text = "Открыть";
            this.btnOpenMkr.UseVisualStyleBackColor = true;
            this.btnOpenMkr.Click += new System.EventHandler(this.btnOpenMkr_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(635, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAcceptChanges
            // 
            this.btnAcceptChanges.Location = new System.Drawing.Point(342, 61);
            this.btnAcceptChanges.Name = "btnAcceptChanges";
            this.btnAcceptChanges.Size = new System.Drawing.Size(147, 23);
            this.btnAcceptChanges.TabIndex = 9;
            this.btnAcceptChanges.Text = "Применить изменения";
            this.btnAcceptChanges.UseVisualStyleBackColor = true;
            this.btnAcceptChanges.Click += new System.EventHandler(this.btnAcceptChanges_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(667, 661);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "Form1";
            this.Text = "Markirator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnDeleteRows;
        private System.Windows.Forms.Button btnAddRow;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateMkr;
        private System.Windows.Forms.Button btnOpenMkr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewImageColumn Column1OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4FurType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5FurColor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7Painted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8Size;
        private System.Windows.Forms.Button btnAcceptChanges;
    }
}


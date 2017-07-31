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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnOpenMkr = new System.Windows.Forms.Button();
            this.btnCreateMkr = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1OK = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column6Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4FurType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5FurColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7Painted = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column8Size = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.button3);
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
            // btnOpenMkr
            // 
            this.btnOpenMkr.Location = new System.Drawing.Point(6, 6);
            this.btnOpenMkr.Name = "btnOpenMkr";
            this.btnOpenMkr.Size = new System.Drawing.Size(75, 23);
            this.btnOpenMkr.TabIndex = 0;
            this.btnOpenMkr.Text = "Открыть";
            this.btnOpenMkr.UseVisualStyleBackColor = true;
            this.btnOpenMkr.Click += new System.EventHandler(this.btnOpenMkr_Click);
            // 
            // btnCreateMkr
            // 
            this.btnCreateMkr.Location = new System.Drawing.Point(88, 5);
            this.btnCreateMkr.Name = "btnCreateMkr";
            this.btnCreateMkr.Size = new System.Drawing.Size(75, 23);
            this.btnCreateMkr.TabIndex = 1;
            this.btnCreateMkr.Text = "Создать";
            this.btnCreateMkr.UseVisualStyleBackColor = true;
            this.btnCreateMkr.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(6, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(545, 20);
            this.textBox1.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(557, 33);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.Location = new System.Drawing.Point(495, 61);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(137, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "Удалить выбранные";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2Num,
            this.Column1OK,
            this.Column6Model,
            this.Column3Description,
            this.Column4FurType,
            this.Column5FurColor,
            this.Column7Painted,
            this.Column8Size});
            this.dataGridView1.Location = new System.Drawing.Point(6, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 486);
            this.dataGridView1.TabIndex = 6;
            // 
            // Column2Num
            // 
            this.Column2Num.HeaderText = "№";
            this.Column2Num.Name = "Column2Num";
            this.Column2Num.Width = 30;
            // 
            // Column1OK
            // 
            this.Column1OK.FillWeight = 30F;
            this.Column1OK.HeaderText = "OK";
            this.Column1OK.Name = "Column1OK";
            this.Column1OK.Width = 30;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreateMkr;
        private System.Windows.Forms.Button btnOpenMkr;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2Num;
        private System.Windows.Forms.DataGridViewImageColumn Column1OK;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4FurType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5FurColor;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7Painted;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8Size;
    }
}


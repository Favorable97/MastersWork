namespace MastersWork {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CodeAnalysis = new System.Windows.Forms.Button();
            this.ToChooseFile = new System.Windows.Forms.Button();
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.CalculationWin = new System.Windows.Forms.GroupBox();
            this.flagAllSolution = new System.Windows.Forms.CheckBox();
            this.SCompareText = new System.Windows.Forms.TextBox();
            this.SMapText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CountIteration = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.AutoCalcWinButton = new System.Windows.Forms.Button();
            this.labelAWithWin = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.LimitMemory = new System.Windows.Forms.TextBox();
            this.MyTable = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AllSolutionsTxtBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.CalculationWin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(8, 10);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(494, 494);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Код программы C++";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(6, 23);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(478, 467);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // CodeAnalysis
            // 
            this.CodeAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CodeAnalysis.Location = new System.Drawing.Point(512, 81);
            this.CodeAnalysis.Name = "CodeAnalysis";
            this.CodeAnalysis.Size = new System.Drawing.Size(125, 43);
            this.CodeAnalysis.TabIndex = 10;
            this.CodeAnalysis.Text = "Начать анализ участка кода";
            this.CodeAnalysis.UseVisualStyleBackColor = true;
            this.CodeAnalysis.Click += new System.EventHandler(this.CodeAnalysis_Click);
            // 
            // ToChooseFile
            // 
            this.ToChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToChooseFile.Location = new System.Drawing.Point(512, 22);
            this.ToChooseFile.Name = "ToChooseFile";
            this.ToChooseFile.Size = new System.Drawing.Size(125, 35);
            this.ToChooseFile.TabIndex = 9;
            this.ToChooseFile.Text = "Выберите файл";
            this.ToChooseFile.UseVisualStyleBackColor = true;
            this.ToChooseFile.Click += new System.EventHandler(this.ToChooseFile_Click);
            // 
            // OpenFile
            // 
            this.OpenFile.FileName = "OpenFile";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1039, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(118, 17);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // CalculationWin
            // 
            this.CalculationWin.AutoSize = true;
            this.CalculationWin.Controls.Add(this.flagAllSolution);
            this.CalculationWin.Controls.Add(this.SCompareText);
            this.CalculationWin.Controls.Add(this.SMapText);
            this.CalculationWin.Controls.Add(this.label3);
            this.CalculationWin.Controls.Add(this.label2);
            this.CalculationWin.Controls.Add(this.label4);
            this.CalculationWin.Controls.Add(this.label1);
            this.CalculationWin.Controls.Add(this.label5);
            this.CalculationWin.Controls.Add(this.label6);
            this.CalculationWin.Controls.Add(this.CountIteration);
            this.CalculationWin.Controls.Add(this.label9);
            this.CalculationWin.Controls.Add(this.AutoCalcWinButton);
            this.CalculationWin.Controls.Add(this.labelAWithWin);
            this.CalculationWin.Controls.Add(this.label7);
            this.CalculationWin.Controls.Add(this.label8);
            this.CalculationWin.Controls.Add(this.LimitMemory);
            this.CalculationWin.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CalculationWin.Location = new System.Drawing.Point(643, 22);
            this.CalculationWin.Name = "CalculationWin";
            this.CalculationWin.Size = new System.Drawing.Size(384, 308);
            this.CalculationWin.TabIndex = 12;
            this.CalculationWin.TabStop = false;
            this.CalculationWin.Text = "Данные для подсчёта выигрыша";
            this.CalculationWin.Visible = false;
            // 
            // flagAllSolution
            // 
            this.flagAllSolution.AutoSize = true;
            this.flagAllSolution.Location = new System.Drawing.Point(15, 169);
            this.flagAllSolution.Name = "flagAllSolution";
            this.flagAllSolution.Size = new System.Drawing.Size(207, 25);
            this.flagAllSolution.TabIndex = 21;
            this.flagAllSolution.Text = "Показать все решения";
            this.flagAllSolution.UseVisualStyleBackColor = true;
            // 
            // SCompareText
            // 
            this.SCompareText.ForeColor = System.Drawing.Color.Silver;
            this.SCompareText.Location = new System.Drawing.Point(104, 55);
            this.SCompareText.Name = "SCompareText";
            this.SCompareText.Size = new System.Drawing.Size(143, 29);
            this.SCompareText.TabIndex = 20;
            this.SCompareText.Text = "10000000000000";
            this.SCompareText.Enter += new System.EventHandler(this.SCompareText_Enter);
            this.SCompareText.Leave += new System.EventHandler(this.SCompareText_Leave);
            // 
            // SMapText
            // 
            this.SMapText.ForeColor = System.Drawing.Color.Silver;
            this.SMapText.Location = new System.Drawing.Point(79, 22);
            this.SMapText.Name = "SMapText";
            this.SMapText.Size = new System.Drawing.Size(117, 29);
            this.SMapText.TabIndex = 19;
            this.SMapText.Text = "10000000000";
            this.SMapText.Enter += new System.EventHandler(this.SMapText_Enter);
            this.SMapText.Leave += new System.EventHandler(this.SMapText_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = " = ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(23, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "map";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 21);
            this.label4.TabIndex = 16;
            this.label4.Text = "s";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 13;
            this.label1.Text = "s";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(28, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "compare";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(74, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 21);
            this.label6.TabIndex = 18;
            this.label6.Text = " = ";
            // 
            // CountIteration
            // 
            this.CountIteration.ForeColor = System.Drawing.Color.Silver;
            this.CountIteration.Location = new System.Drawing.Point(192, 120);
            this.CountIteration.Name = "CountIteration";
            this.CountIteration.Size = new System.Drawing.Size(93, 29);
            this.CountIteration.TabIndex = 12;
            this.CountIteration.Text = "10000";
            this.CountIteration.Enter += new System.EventHandler(this.CountIteration_Enter);
            this.CountIteration.Leave += new System.EventHandler(this.CountIteration_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 128);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(185, 21);
            this.label9.TabIndex = 11;
            this.label9.Text = "Число итераций(N) = ";
            // 
            // AutoCalcWinButton
            // 
            this.AutoCalcWinButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AutoCalcWinButton.Location = new System.Drawing.Point(16, 200);
            this.AutoCalcWinButton.Name = "AutoCalcWinButton";
            this.AutoCalcWinButton.Size = new System.Drawing.Size(137, 46);
            this.AutoCalcWinButton.TabIndex = 7;
            this.AutoCalcWinButton.Text = "Автоматический расчёт";
            this.AutoCalcWinButton.UseVisualStyleBackColor = true;
            this.AutoCalcWinButton.Click += new System.EventHandler(this.AutoCalcWinButton_Click);
            // 
            // labelAWithWin
            // 
            this.labelAWithWin.AutoSize = true;
            this.labelAWithWin.Location = new System.Drawing.Point(12, 262);
            this.labelAWithWin.Name = "labelAWithWin";
            this.labelAWithWin.Size = new System.Drawing.Size(0, 21);
            this.labelAWithWin.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "V = ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(162, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 21);
            this.label8.TabIndex = 8;
            this.label8.Text = "байт";
            // 
            // LimitMemory
            // 
            this.LimitMemory.Location = new System.Drawing.Point(55, 90);
            this.LimitMemory.Name = "LimitMemory";
            this.LimitMemory.Size = new System.Drawing.Size(109, 29);
            this.LimitMemory.TabIndex = 7;
            // 
            // MyTable
            // 
            this.MyTable.AllowUserToAddRows = false;
            this.MyTable.AllowUserToDeleteRows = false;
            this.MyTable.BackgroundColor = System.Drawing.SystemColors.Control;
            this.MyTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MyTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MyTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column8,
            this.Column6,
            this.Column3,
            this.Column5,
            this.Column9,
            this.Column7,
            this.Column4});
            this.MyTable.Location = new System.Drawing.Point(538, 344);
            this.MyTable.Name = "MyTable";
            this.MyTable.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.MyTable.Size = new System.Drawing.Size(625, 44);
            this.MyTable.TabIndex = 13;
            this.MyTable.Visible = false;
            this.MyTable.CurrentCellDirtyStateChanged += new System.EventHandler(this.MyTable_CurrentCellDirtyStateChanged);
            // 
            // Column1
            // 
            this.Column1.FillWeight = 6.791172F;
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            this.Column1.Width = 30;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 119.1196F;
            this.Column2.HeaderText = "Итератор";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 70;
            // 
            // Column8
            // 
            this.Column8.FillWeight = 72.88135F;
            this.Column8.HeaderText = "Тип данных";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 69;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Тип контейнера";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 70;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 138.9695F;
            this.Column3.HeaderText = "Номер строки";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 70;
            // 
            // Column5
            // 
            this.Column5.FillWeight = 184.1371F;
            this.Column5.HeaderText = "Количество элементов";
            this.Column5.Name = "Column5";
            this.Column5.Width = 70;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "P";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 50;
            // 
            // Column7
            // 
            this.Column7.FillWeight = 44.89193F;
            this.Column7.HeaderText = "V";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column4
            // 
            this.Column4.FillWeight = 130.235F;
            this.Column4.HeaderText = "Рекомендации";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // AllSolutionsTxtBox
            // 
            this.AllSolutionsTxtBox.Location = new System.Drawing.Point(1061, 36);
            this.AllSolutionsTxtBox.Name = "AllSolutionsTxtBox";
            this.AllSolutionsTxtBox.Size = new System.Drawing.Size(264, 256);
            this.AllSolutionsTxtBox.TabIndex = 14;
            this.AllSolutionsTxtBox.Text = "";
            this.AllSolutionsTxtBox.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 552);
            this.Controls.Add(this.AllSolutionsTxtBox);
            this.Controls.Add(this.MyTable);
            this.Controls.Add(this.CalculationWin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.CodeAnalysis);
            this.Controls.Add(this.ToChooseFile);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Magisters Work Windows";
            this.groupBox1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.CalculationWin.ResumeLayout(false);
            this.CalculationWin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MyTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CodeAnalysis;
        private System.Windows.Forms.Button ToChooseFile;
        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox CalculationWin;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button AutoCalcWinButton;
        private System.Windows.Forms.Label labelAWithWin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox LimitMemory;
        private System.Windows.Forms.TextBox CountIteration;
        private System.Windows.Forms.DataGridView MyTable;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.TextBox SCompareText;
        private System.Windows.Forms.TextBox SMapText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox AllSolutionsTxtBox;
        private System.Windows.Forms.CheckBox flagAllSolution;
    }
}


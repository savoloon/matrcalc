
namespace WindowsFormsApp3
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.MatrixB = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.MatrixA = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ClearA = new System.Windows.Forms.Button();
            this.ClearB = new System.Windows.Forms.Button();
            this.increaseN1 = new System.Windows.Forms.Button();
            this.decreaseN1 = new System.Windows.Forms.Button();
            this.decreaseM1 = new System.Windows.Forms.Button();
            this.increaseM1 = new System.Windows.Forms.Button();
            this.increaseN2 = new System.Windows.Forms.Button();
            this.decreaseN2 = new System.Windows.Forms.Button();
            this.decreaseM2 = new System.Windows.Forms.Button();
            this.increaseM2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.detA = new System.Windows.Forms.Button();
            this.Apown = new System.Windows.Forms.Button();
            this.Axn = new System.Windows.Forms.Button();
            this.inverseA = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.inverseB = new System.Windows.Forms.Button();
            this.Bxn = new System.Windows.Forms.Button();
            this.Bpown = new System.Windows.Forms.Button();
            this.detB = new System.Windows.Forms.Button();
            this.N1 = new System.Windows.Forms.Label();
            this.M1 = new System.Windows.Forms.Label();
            this.N2 = new System.Windows.Forms.Label();
            this.M2 = new System.Windows.Forms.Label();
            this.equal = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оПрограммеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(878, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(103, 20);
            this.оПрограммеToolStripMenuItem.Text = "О программе...";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.M2);
            this.groupBox2.Controls.Add(this.N2);
            this.groupBox2.Controls.Add(this.increaseM2);
            this.groupBox2.Controls.Add(this.decreaseM2);
            this.groupBox2.Controls.Add(this.decreaseN2);
            this.groupBox2.Controls.Add(this.increaseN2);
            this.groupBox2.Controls.Add(this.ClearB);
            this.groupBox2.Controls.Add(this.MatrixB);
            this.groupBox2.Location = new System.Drawing.Point(493, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(385, 377);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // MatrixB
            // 
            this.MatrixB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixB.Location = new System.Drawing.Point(40, 38);
            this.MatrixB.Name = "MatrixB";
            this.MatrixB.Size = new System.Drawing.Size(331, 299);
            this.MatrixB.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.M1);
            this.groupBox1.Controls.Add(this.N1);
            this.groupBox1.Controls.Add(this.increaseM1);
            this.groupBox1.Controls.Add(this.decreaseM1);
            this.groupBox1.Controls.Add(this.decreaseN1);
            this.groupBox1.Controls.Add(this.increaseN1);
            this.groupBox1.Controls.Add(this.ClearA);
            this.groupBox1.Controls.Add(this.MatrixA);
            this.groupBox1.Location = new System.Drawing.Point(0, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 377);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // MatrixA
            // 
            this.MatrixA.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MatrixA.Location = new System.Drawing.Point(0, 38);
            this.MatrixA.Name = "MatrixA";
            this.MatrixA.Size = new System.Drawing.Size(331, 299);
            this.MatrixA.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Матрица A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Матрица B";
            // 
            // ClearA
            // 
            this.ClearA.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearA.Location = new System.Drawing.Point(133, 11);
            this.ClearA.Name = "ClearA";
            this.ClearA.Size = new System.Drawing.Size(66, 21);
            this.ClearA.TabIndex = 1;
            this.ClearA.Text = "Clear";
            this.ClearA.UseVisualStyleBackColor = true;
            this.ClearA.Click += new System.EventHandler(this.ClearA_Click);
            // 
            // ClearB
            // 
            this.ClearB.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClearB.Location = new System.Drawing.Point(167, 11);
            this.ClearB.Name = "ClearB";
            this.ClearB.Size = new System.Drawing.Size(66, 21);
            this.ClearB.TabIndex = 2;
            this.ClearB.Text = "Clear";
            this.ClearB.UseVisualStyleBackColor = true;
            this.ClearB.Click += new System.EventHandler(this.ClearB_Click);
            // 
            // increaseN1
            // 
            this.increaseN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increaseN1.Location = new System.Drawing.Point(337, 38);
            this.increaseN1.Name = "increaseN1";
            this.increaseN1.Size = new System.Drawing.Size(34, 70);
            this.increaseN1.TabIndex = 2;
            this.increaseN1.Text = "+";
            this.increaseN1.UseVisualStyleBackColor = true;
            this.increaseN1.Click += new System.EventHandler(this.increaseN1_Click);
            // 
            // decreaseN1
            // 
            this.decreaseN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreaseN1.Location = new System.Drawing.Point(337, 237);
            this.decreaseN1.Name = "decreaseN1";
            this.decreaseN1.Size = new System.Drawing.Size(34, 70);
            this.decreaseN1.TabIndex = 3;
            this.decreaseN1.Text = "-";
            this.decreaseN1.UseVisualStyleBackColor = true;
            this.decreaseN1.Click += new System.EventHandler(this.decreaseN1_Click);
            // 
            // decreaseM1
            // 
            this.decreaseM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreaseM1.Location = new System.Drawing.Point(228, 343);
            this.decreaseM1.Name = "decreaseM1";
            this.decreaseM1.Size = new System.Drawing.Size(73, 28);
            this.decreaseM1.TabIndex = 4;
            this.decreaseM1.Text = "-";
            this.decreaseM1.UseVisualStyleBackColor = true;
            this.decreaseM1.Click += new System.EventHandler(this.decreaseM1_Click);
            // 
            // increaseM1
            // 
            this.increaseM1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increaseM1.Location = new System.Drawing.Point(45, 343);
            this.increaseM1.Name = "increaseM1";
            this.increaseM1.Size = new System.Drawing.Size(73, 28);
            this.increaseM1.TabIndex = 5;
            this.increaseM1.Text = "+";
            this.increaseM1.UseVisualStyleBackColor = true;
            this.increaseM1.Click += new System.EventHandler(this.increaseM1_Click);
            // 
            // increaseN2
            // 
            this.increaseN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increaseN2.Location = new System.Drawing.Point(6, 38);
            this.increaseN2.Name = "increaseN2";
            this.increaseN2.Size = new System.Drawing.Size(34, 70);
            this.increaseN2.TabIndex = 6;
            this.increaseN2.Text = "+";
            this.increaseN2.UseVisualStyleBackColor = true;
            this.increaseN2.Click += new System.EventHandler(this.increaseN2_Click);
            // 
            // decreaseN2
            // 
            this.decreaseN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreaseN2.Location = new System.Drawing.Point(6, 237);
            this.decreaseN2.Name = "decreaseN2";
            this.decreaseN2.Size = new System.Drawing.Size(34, 70);
            this.decreaseN2.TabIndex = 6;
            this.decreaseN2.Text = "-";
            this.decreaseN2.UseVisualStyleBackColor = true;
            this.decreaseN2.Click += new System.EventHandler(this.decreaseN2_Click);
            // 
            // decreaseM2
            // 
            this.decreaseM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decreaseM2.Location = new System.Drawing.Point(79, 343);
            this.decreaseM2.Name = "decreaseM2";
            this.decreaseM2.Size = new System.Drawing.Size(73, 28);
            this.decreaseM2.TabIndex = 6;
            this.decreaseM2.Text = "-";
            this.decreaseM2.UseVisualStyleBackColor = true;
            this.decreaseM2.Click += new System.EventHandler(this.decreaseM2_Click);
            // 
            // increaseM2
            // 
            this.increaseM2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.increaseM2.Location = new System.Drawing.Point(283, 343);
            this.increaseM2.Name = "increaseM2";
            this.increaseM2.Size = new System.Drawing.Size(73, 28);
            this.increaseM2.TabIndex = 6;
            this.increaseM2.Text = "+";
            this.increaseM2.UseVisualStyleBackColor = true;
            this.increaseM2.Click += new System.EventHandler(this.increaseM2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "+",
            "-",
            "*"});
            this.comboBox1.Location = new System.Drawing.Point(387, 143);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 24);
            this.comboBox1.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.inverseA);
            this.groupBox3.Controls.Add(this.Axn);
            this.groupBox3.Controls.Add(this.Apown);
            this.groupBox3.Controls.Add(this.detA);
            this.groupBox3.Location = new System.Drawing.Point(0, 429);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 96);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Операции с A";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 439);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "n=";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(398, 436);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // detA
            // 
            this.detA.Location = new System.Drawing.Point(12, 16);
            this.detA.Name = "detA";
            this.detA.Size = new System.Drawing.Size(75, 23);
            this.detA.TabIndex = 0;
            this.detA.Text = "Ранг А";
            this.detA.UseVisualStyleBackColor = true;
            this.detA.Click += new System.EventHandler(this.detA_Click);
            // 
            // Apown
            // 
            this.Apown.Location = new System.Drawing.Point(124, 16);
            this.Apown.Name = "Apown";
            this.Apown.Size = new System.Drawing.Size(75, 23);
            this.Apown.TabIndex = 1;
            this.Apown.Text = "А^n";
            this.Apown.UseVisualStyleBackColor = true;
            this.Apown.Click += new System.EventHandler(this.Apown_Click);
            // 
            // Axn
            // 
            this.Axn.Location = new System.Drawing.Point(226, 16);
            this.Axn.Name = "Axn";
            this.Axn.Size = new System.Drawing.Size(75, 23);
            this.Axn.TabIndex = 2;
            this.Axn.Text = "А*n";
            this.Axn.UseVisualStyleBackColor = true;
            this.Axn.Click += new System.EventHandler(this.Axn_Click);
            // 
            // inverseA
            // 
            this.inverseA.Location = new System.Drawing.Point(124, 60);
            this.inverseA.Name = "inverseA";
            this.inverseA.Size = new System.Drawing.Size(75, 23);
            this.inverseA.TabIndex = 3;
            this.inverseA.Text = "Обратная А";
            this.inverseA.UseVisualStyleBackColor = true;
            this.inverseA.Click += new System.EventHandler(this.inverseA_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.inverseB);
            this.groupBox4.Controls.Add(this.Bxn);
            this.groupBox4.Controls.Add(this.Bpown);
            this.groupBox4.Controls.Add(this.detB);
            this.groupBox4.Location = new System.Drawing.Point(548, 429);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 96);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Операции с В";
            // 
            // inverseB
            // 
            this.inverseB.Location = new System.Drawing.Point(124, 60);
            this.inverseB.Name = "inverseB";
            this.inverseB.Size = new System.Drawing.Size(75, 23);
            this.inverseB.TabIndex = 3;
            this.inverseB.Text = "Обратная В";
            this.inverseB.UseVisualStyleBackColor = true;
            this.inverseB.Click += new System.EventHandler(this.inverseB_Click);
            // 
            // Bxn
            // 
            this.Bxn.Location = new System.Drawing.Point(226, 16);
            this.Bxn.Name = "Bxn";
            this.Bxn.Size = new System.Drawing.Size(75, 23);
            this.Bxn.TabIndex = 2;
            this.Bxn.Text = "В*n";
            this.Bxn.UseVisualStyleBackColor = true;
            this.Bxn.Click += new System.EventHandler(this.Bxn_Click);
            // 
            // Bpown
            // 
            this.Bpown.Location = new System.Drawing.Point(124, 16);
            this.Bpown.Name = "Bpown";
            this.Bpown.Size = new System.Drawing.Size(75, 23);
            this.Bpown.TabIndex = 1;
            this.Bpown.Text = "В^n";
            this.Bpown.UseVisualStyleBackColor = true;
            this.Bpown.Click += new System.EventHandler(this.Bpown_Click);
            // 
            // detB
            // 
            this.detB.Location = new System.Drawing.Point(12, 16);
            this.detB.Name = "detB";
            this.detB.Size = new System.Drawing.Size(75, 23);
            this.detB.TabIndex = 0;
            this.detB.Text = "Ранг В";
            this.detB.UseVisualStyleBackColor = true;
            this.detB.Click += new System.EventHandler(this.detB_Click);
            // 
            // N1
            // 
            this.N1.AutoSize = true;
            this.N1.Location = new System.Drawing.Point(346, 165);
            this.N1.Name = "N1";
            this.N1.Size = new System.Drawing.Size(13, 13);
            this.N1.TabIndex = 6;
            this.N1.Text = "1";
            // 
            // M1
            // 
            this.M1.AutoSize = true;
            this.M1.Location = new System.Drawing.Point(166, 353);
            this.M1.Name = "M1";
            this.M1.Size = new System.Drawing.Size(13, 13);
            this.M1.TabIndex = 7;
            this.M1.Text = "1";
            // 
            // N2
            // 
            this.N2.AutoSize = true;
            this.N2.Location = new System.Drawing.Point(6, 165);
            this.N2.Name = "N2";
            this.N2.Size = new System.Drawing.Size(13, 13);
            this.N2.TabIndex = 7;
            this.N2.Text = "1";
            // 
            // M2
            // 
            this.M2.AutoSize = true;
            this.M2.Location = new System.Drawing.Point(212, 353);
            this.M2.Name = "M2";
            this.M2.Size = new System.Drawing.Size(13, 13);
            this.M2.TabIndex = 8;
            this.M2.Text = "1";
            // 
            // equal
            // 
            this.equal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.equal.Location = new System.Drawing.Point(398, 187);
            this.equal.Name = "equal";
            this.equal.Size = new System.Drawing.Size(75, 37);
            this.equal.TabIndex = 11;
            this.equal.Text = "=";
            this.equal.UseVisualStyleBackColor = true;
            this.equal.Click += new System.EventHandler(this.equal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 561);
            this.Controls.Add(this.equal);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixB)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MatrixA)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView MatrixB;
        private System.Windows.Forms.Button increaseM2;
        private System.Windows.Forms.Button decreaseM2;
        private System.Windows.Forms.Button decreaseN2;
        private System.Windows.Forms.Button increaseN2;
        private System.Windows.Forms.Button ClearB;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button increaseM1;
        private System.Windows.Forms.Button decreaseM1;
        private System.Windows.Forms.Button decreaseN1;
        private System.Windows.Forms.Button increaseN1;
        private System.Windows.Forms.Button ClearA;
        private System.Windows.Forms.DataGridView MatrixA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button inverseA;
        private System.Windows.Forms.Button Axn;
        private System.Windows.Forms.Button Apown;
        private System.Windows.Forms.Button detA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button inverseB;
        private System.Windows.Forms.Button Bxn;
        private System.Windows.Forms.Button Bpown;
        private System.Windows.Forms.Button detB;
        private System.Windows.Forms.Label M2;
        private System.Windows.Forms.Label N2;
        private System.Windows.Forms.Label M1;
        private System.Windows.Forms.Label N1;
        private System.Windows.Forms.Button equal;
    }
}


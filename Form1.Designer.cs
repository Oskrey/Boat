namespace Модель_Лотки_Вальтера
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
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxε = new System.Windows.Forms.TextBox();
            this.textBoxα = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxδ = new System.Windows.Forms.TextBox();
            this.textBoxβ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(29, 12);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 20);
            this.textBoxX0.TabIndex = 0;
            // 
            // textBoxε
            // 
            this.textBoxε.Location = new System.Drawing.Point(29, 38);
            this.textBoxε.Name = "textBoxε";
            this.textBoxε.Size = new System.Drawing.Size(100, 20);
            this.textBoxε.TabIndex = 1;
            // 
            // textBoxα
            // 
            this.textBoxα.Location = new System.Drawing.Point(29, 64);
            this.textBoxα.Name = "textBoxα";
            this.textBoxα.Size = new System.Drawing.Size(100, 20);
            this.textBoxα.TabIndex = 2;
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(29, 90);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(100, 20);
            this.textBoxY0.TabIndex = 3;
            // 
            // textBoxδ
            // 
            this.textBoxδ.Location = new System.Drawing.Point(29, 116);
            this.textBoxδ.Name = "textBoxδ";
            this.textBoxδ.Size = new System.Drawing.Size(100, 20);
            this.textBoxδ.TabIndex = 4;
            // 
            // textBoxβ
            // 
            this.textBoxβ.Location = new System.Drawing.Point(29, 142);
            this.textBoxβ.Name = "textBoxβ";
            this.textBoxβ.Size = new System.Drawing.Size(100, 20);
            this.textBoxβ.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "x0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "ε";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "α";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "y0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 119);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "δ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "β";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(38, 168);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 213);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(195, 225);
            this.dataGridView1.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxβ);
            this.Controls.Add(this.textBoxδ);
            this.Controls.Add(this.textBoxY0);
            this.Controls.Add(this.textBoxα);
            this.Controls.Add(this.textBoxε);
            this.Controls.Add(this.textBoxX0);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TextBox textBoxε;
        private System.Windows.Forms.TextBox textBoxα;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxδ;
        private System.Windows.Forms.TextBox textBoxβ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


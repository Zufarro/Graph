namespace Graph
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbVerticesNum = new System.Windows.Forms.TextBox();
            this.tbEdges = new System.Windows.Forms.TextBox();
            this.tbPrint = new System.Windows.Forms.TextBox();
            this.cbInput = new System.Windows.Forms.ComboBox();
            this.cbPrint = new System.Windows.Forms.ComboBox();
            this.tbMatr1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbMatr2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMatrixRes = new System.Windows.Forms.TextBox();
            this.btMultiply = new System.Windows.Forms.Button();
            this.tbEdgesNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbN1 = new System.Windows.Forms.TextBox();
            this.tbM2 = new System.Windows.Forms.TextBox();
            this.tbN2 = new System.Windows.Forms.TextBox();
            this.tbM1 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Число вершин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ввод ребер";
            // 
            // tbVerticesNum
            // 
            this.tbVerticesNum.Location = new System.Drawing.Point(145, 48);
            this.tbVerticesNum.Name = "tbVerticesNum";
            this.tbVerticesNum.Size = new System.Drawing.Size(100, 22);
            this.tbVerticesNum.TabIndex = 2;
            // 
            // tbEdges
            // 
            this.tbEdges.Location = new System.Drawing.Point(29, 135);
            this.tbEdges.Multiline = true;
            this.tbEdges.Name = "tbEdges";
            this.tbEdges.Size = new System.Drawing.Size(205, 283);
            this.tbEdges.TabIndex = 3;
            // 
            // tbPrint
            // 
            this.tbPrint.Location = new System.Drawing.Point(29, 506);
            this.tbPrint.Multiline = true;
            this.tbPrint.Name = "tbPrint";
            this.tbPrint.ReadOnly = true;
            this.tbPrint.Size = new System.Drawing.Size(603, 47);
            this.tbPrint.TabIndex = 5;
            // 
            // cbInput
            // 
            this.cbInput.FormattingEnabled = true;
            this.cbInput.Location = new System.Drawing.Point(71, 424);
            this.cbInput.Name = "cbInput";
            this.cbInput.Size = new System.Drawing.Size(121, 24);
            this.cbInput.TabIndex = 6;
            this.cbInput.Text = "Выбрать ввод";
            this.cbInput.SelectedIndexChanged += new System.EventHandler(this.CbInput_SelectedIndexChanged);
            // 
            // cbPrint
            // 
            this.cbPrint.FormattingEnabled = true;
            this.cbPrint.Location = new System.Drawing.Point(29, 476);
            this.cbPrint.Name = "cbPrint";
            this.cbPrint.Size = new System.Drawing.Size(163, 24);
            this.cbPrint.TabIndex = 7;
            this.cbPrint.Text = "Выбрать обход";
            this.cbPrint.SelectedIndexChanged += new System.EventHandler(this.CbPrint_SelectedIndexChanged);
            // 
            // tbMatr1
            // 
            this.tbMatr1.Location = new System.Drawing.Point(336, 166);
            this.tbMatr1.Multiline = true;
            this.tbMatr1.Name = "tbMatr1";
            this.tbMatr1.Size = new System.Drawing.Size(125, 125);
            this.tbMatr1.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Умножение матриц";
            // 
            // tbMatr2
            // 
            this.tbMatr2.Location = new System.Drawing.Point(507, 166);
            this.tbMatr2.Multiline = true;
            this.tbMatr2.Name = "tbMatr2";
            this.tbMatr2.Size = new System.Drawing.Size(125, 125);
            this.tbMatr2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(476, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "Х";
            // 
            // tbMatrixRes
            // 
            this.tbMatrixRes.Location = new System.Drawing.Point(420, 341);
            this.tbMatrixRes.Multiline = true;
            this.tbMatrixRes.Name = "tbMatrixRes";
            this.tbMatrixRes.ReadOnly = true;
            this.tbMatrixRes.Size = new System.Drawing.Size(125, 125);
            this.tbMatrixRes.TabIndex = 12;
            // 
            // btMultiply
            // 
            this.btMultiply.Location = new System.Drawing.Point(434, 297);
            this.btMultiply.Name = "btMultiply";
            this.btMultiply.Size = new System.Drawing.Size(100, 29);
            this.btMultiply.TabIndex = 13;
            this.btMultiply.Text = "Умножить";
            this.btMultiply.UseVisualStyleBackColor = true;
            this.btMultiply.Click += new System.EventHandler(this.BtMultiply_Click);
            // 
            // tbEdgesNum
            // 
            this.tbEdgesNum.Location = new System.Drawing.Point(145, 81);
            this.tbEdgesNum.Name = "tbEdgesNum";
            this.tbEdgesNum.Size = new System.Drawing.Size(100, 22);
            this.tbEdgesNum.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Число ребер";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(282, 135);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Размер";
            // 
            // tbN1
            // 
            this.tbN1.Location = new System.Drawing.Point(358, 134);
            this.tbN1.Name = "tbN1";
            this.tbN1.Size = new System.Drawing.Size(31, 22);
            this.tbN1.TabIndex = 17;
            this.tbN1.TextChanged += new System.EventHandler(this.TbN1_TextChanged);
            // 
            // tbM2
            // 
            this.tbM2.Location = new System.Drawing.Point(578, 135);
            this.tbM2.Name = "tbM2";
            this.tbM2.Size = new System.Drawing.Size(31, 22);
            this.tbM2.TabIndex = 18;
            // 
            // tbN2
            // 
            this.tbN2.Location = new System.Drawing.Point(521, 135);
            this.tbN2.Name = "tbN2";
            this.tbN2.ReadOnly = true;
            this.tbN2.Size = new System.Drawing.Size(31, 22);
            this.tbN2.TabIndex = 19;
            // 
            // tbM1
            // 
            this.tbM1.Location = new System.Drawing.Point(418, 134);
            this.tbM1.Name = "tbM1";
            this.tbM1.Size = new System.Drawing.Size(31, 22);
            this.tbM1.TabIndex = 20;
            this.tbM1.TextChanged += new System.EventHandler(this.TbM1_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(395, 137);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "Х";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 138);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 17);
            this.label8.TabIndex = 22;
            this.label8.Text = "Х";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 582);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbM1);
            this.Controls.Add(this.tbN2);
            this.Controls.Add(this.tbM2);
            this.Controls.Add(this.tbN1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEdgesNum);
            this.Controls.Add(this.btMultiply);
            this.Controls.Add(this.tbMatrixRes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMatr2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbMatr1);
            this.Controls.Add(this.cbPrint);
            this.Controls.Add(this.cbInput);
            this.Controls.Add(this.tbPrint);
            this.Controls.Add(this.tbEdges);
            this.Controls.Add(this.tbVerticesNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Работа с графами";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbVerticesNum;
        private System.Windows.Forms.TextBox tbEdges;
        private System.Windows.Forms.TextBox tbPrint;
        private System.Windows.Forms.ComboBox cbInput;
        private System.Windows.Forms.ComboBox cbPrint;
        private System.Windows.Forms.TextBox tbMatr1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbMatr2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMatrixRes;
        private System.Windows.Forms.Button btMultiply;
        private System.Windows.Forms.TextBox tbEdgesNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbN1;
        private System.Windows.Forms.TextBox tbM2;
        private System.Windows.Forms.TextBox tbN2;
        private System.Windows.Forms.TextBox tbM1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}


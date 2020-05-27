namespace WindowsFormsApp1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Mode01 = new System.Windows.Forms.RadioButton();
            this.Mode02 = new System.Windows.Forms.RadioButton();
            this.Mode03 = new System.Windows.Forms.RadioButton();
            this.Mode04 = new System.Windows.Forms.RadioButton();
            this.Mode05 = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.Sorting01 = new System.Windows.Forms.Label();
            this.Sorting02 = new System.Windows.Forms.Label();
            this.Sorting03 = new System.Windows.Forms.Label();
            this.Sorting04 = new System.Windows.Forms.Label();
            this.Sorting05 = new System.Windows.Forms.Label();
            this.SelectedSort01 = new System.Windows.Forms.RadioButton();
            this.SelectedSort02 = new System.Windows.Forms.RadioButton();
            this.SelectedSort03 = new System.Windows.Forms.RadioButton();
            this.SelectedSort04 = new System.Windows.Forms.RadioButton();
            this.SelectedSort05 = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 100);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(791, 100);
            this.label1.TabIndex = 0;
            this.label1.Text = "Натиснiть на одну з вказаних клавiш, щоб вибрати режим роботи:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Додавання записiв";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Редагування записiв";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(351, 22);
            this.label4.TabIndex = 3;
            this.label4.Text = "Виведення iнформацiї з файла на екран";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(13, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(164, 22);
            this.label5.TabIndex = 4;
            this.label5.Text = "Знищення записів";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(13, 264);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 5;
            this.label6.Text = "Сортування";
            // 
            // Mode01
            // 
            this.Mode01.AutoSize = true;
            this.Mode01.Location = new System.Drawing.Point(390, 106);
            this.Mode01.Name = "Mode01";
            this.Mode01.Size = new System.Drawing.Size(17, 16);
            this.Mode01.TabIndex = 6;
            this.Mode01.UseVisualStyleBackColor = true;
            // 
            // Mode02
            // 
            this.Mode02.AutoSize = true;
            this.Mode02.Location = new System.Drawing.Point(390, 144);
            this.Mode02.Name = "Mode02";
            this.Mode02.Size = new System.Drawing.Size(17, 16);
            this.Mode02.TabIndex = 6;
            this.Mode02.UseVisualStyleBackColor = true;
            // 
            // Mode03
            // 
            this.Mode03.AutoSize = true;
            this.Mode03.Location = new System.Drawing.Point(390, 184);
            this.Mode03.Name = "Mode03";
            this.Mode03.Size = new System.Drawing.Size(17, 16);
            this.Mode03.TabIndex = 6;
            this.Mode03.UseVisualStyleBackColor = true;
            // 
            // Mode04
            // 
            this.Mode04.AutoSize = true;
            this.Mode04.Location = new System.Drawing.Point(390, 225);
            this.Mode04.Name = "Mode04";
            this.Mode04.Size = new System.Drawing.Size(17, 16);
            this.Mode04.TabIndex = 6;
            this.Mode04.UseVisualStyleBackColor = true;
            // 
            // Mode05
            // 
            this.Mode05.AutoSize = true;
            this.Mode05.Location = new System.Drawing.Point(390, 266);
            this.Mode05.Name = "Mode05";
            this.Mode05.Size = new System.Drawing.Size(17, 16);
            this.Mode05.TabIndex = 6;
            this.Mode05.UseVisualStyleBackColor = true;
            this.Mode05.CheckedChanged += new System.EventHandler(this.Mode05_CheckedChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(306, 387);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Вибрати";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sorting01
            // 
            this.Sorting01.AutoSize = true;
            this.Sorting01.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorting01.Location = new System.Drawing.Point(442, 106);
            this.Sorting01.Name = "Sorting01";
            this.Sorting01.Size = new System.Drawing.Size(174, 22);
            this.Sorting01.TabIndex = 8;
            this.Sorting01.Text = "За номером квидка";
            this.Sorting01.Visible = false;
            // 
            // Sorting02
            // 
            this.Sorting02.AutoSize = true;
            this.Sorting02.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorting02.Location = new System.Drawing.Point(442, 144);
            this.Sorting02.Name = "Sorting02";
            this.Sorting02.Size = new System.Drawing.Size(201, 22);
            this.Sorting02.TabIndex = 9;
            this.Sorting02.Text = "За прiзвищем покупця";
            this.Sorting02.Visible = false;
            // 
            // Sorting03
            // 
            this.Sorting03.AutoSize = true;
            this.Sorting03.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorting03.Location = new System.Drawing.Point(442, 184);
            this.Sorting03.Name = "Sorting03";
            this.Sorting03.Size = new System.Drawing.Size(161, 22);
            this.Sorting03.TabIndex = 10;
            this.Sorting03.Text = "За назвою фiльму";
            this.Sorting03.Visible = false;
            // 
            // Sorting04
            // 
            this.Sorting04.AutoSize = true;
            this.Sorting04.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorting04.Location = new System.Drawing.Point(442, 225);
            this.Sorting04.Name = "Sorting04";
            this.Sorting04.Size = new System.Drawing.Size(151, 22);
            this.Sorting04.TabIndex = 11;
            this.Sorting04.Text = "За цiною квидка";
            this.Sorting04.Visible = false;
            // 
            // Sorting05
            // 
            this.Sorting05.AutoSize = true;
            this.Sorting05.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Sorting05.Location = new System.Drawing.Point(442, 266);
            this.Sorting05.Name = "Sorting05";
            this.Sorting05.Size = new System.Drawing.Size(174, 22);
            this.Sorting05.TabIndex = 12;
            this.Sorting05.Text = "За статусом оплати";
            this.Sorting05.Visible = false;
            // 
            // SelectedSort01
            // 
            this.SelectedSort01.AutoSize = true;
            this.SelectedSort01.Location = new System.Drawing.Point(684, 108);
            this.SelectedSort01.Name = "SelectedSort01";
            this.SelectedSort01.Size = new System.Drawing.Size(17, 16);
            this.SelectedSort01.TabIndex = 13;
            this.SelectedSort01.TabStop = true;
            this.SelectedSort01.UseVisualStyleBackColor = true;
            this.SelectedSort01.Visible = false;
            this.SelectedSort01.CheckedChanged += new System.EventHandler(this.SelectedSort01_CheckedChanged);
            // 
            // SelectedSort02
            // 
            this.SelectedSort02.AutoSize = true;
            this.SelectedSort02.Location = new System.Drawing.Point(684, 146);
            this.SelectedSort02.Name = "SelectedSort02";
            this.SelectedSort02.Size = new System.Drawing.Size(17, 16);
            this.SelectedSort02.TabIndex = 13;
            this.SelectedSort02.TabStop = true;
            this.SelectedSort02.UseVisualStyleBackColor = true;
            this.SelectedSort02.Visible = false;
            this.SelectedSort02.CheckedChanged += new System.EventHandler(this.SelectedSort02_CheckedChanged);
            // 
            // SelectedSort03
            // 
            this.SelectedSort03.AutoSize = true;
            this.SelectedSort03.Location = new System.Drawing.Point(684, 188);
            this.SelectedSort03.Name = "SelectedSort03";
            this.SelectedSort03.Size = new System.Drawing.Size(17, 16);
            this.SelectedSort03.TabIndex = 13;
            this.SelectedSort03.TabStop = true;
            this.SelectedSort03.UseVisualStyleBackColor = true;
            this.SelectedSort03.Visible = false;
            this.SelectedSort03.CheckedChanged += new System.EventHandler(this.SelectedSort03_CheckedChanged);
            // 
            // SelectedSort04
            // 
            this.SelectedSort04.AutoSize = true;
            this.SelectedSort04.Location = new System.Drawing.Point(684, 227);
            this.SelectedSort04.Name = "SelectedSort04";
            this.SelectedSort04.Size = new System.Drawing.Size(17, 16);
            this.SelectedSort04.TabIndex = 13;
            this.SelectedSort04.TabStop = true;
            this.SelectedSort04.UseVisualStyleBackColor = true;
            this.SelectedSort04.Visible = false;
            this.SelectedSort04.CheckedChanged += new System.EventHandler(this.SelectedSort04_CheckedChanged);
            // 
            // SelectedSort05
            // 
            this.SelectedSort05.AutoSize = true;
            this.SelectedSort05.Location = new System.Drawing.Point(684, 268);
            this.SelectedSort05.Name = "SelectedSort05";
            this.SelectedSort05.Size = new System.Drawing.Size(17, 16);
            this.SelectedSort05.TabIndex = 13;
            this.SelectedSort05.TabStop = true;
            this.SelectedSort05.UseVisualStyleBackColor = true;
            this.SelectedSort05.Visible = false;
            this.SelectedSort05.CheckedChanged += new System.EventHandler(this.SelectedSort05_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 446);
            this.Controls.Add(this.SelectedSort05);
            this.Controls.Add(this.SelectedSort04);
            this.Controls.Add(this.SelectedSort03);
            this.Controls.Add(this.SelectedSort02);
            this.Controls.Add(this.SelectedSort01);
            this.Controls.Add(this.Sorting05);
            this.Controls.Add(this.Sorting04);
            this.Controls.Add(this.Sorting03);
            this.Controls.Add(this.Sorting02);
            this.Controls.Add(this.Sorting01);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Mode05);
            this.Controls.Add(this.Mode04);
            this.Controls.Add(this.Mode03);
            this.Controls.Add(this.Mode02);
            this.Controls.Add(this.Mode01);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Меню";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton Mode01;
        private System.Windows.Forms.RadioButton Mode02;
        private System.Windows.Forms.RadioButton Mode03;
        private System.Windows.Forms.RadioButton Mode04;
        private System.Windows.Forms.RadioButton Mode05;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Sorting01;
        private System.Windows.Forms.Label Sorting02;
        private System.Windows.Forms.Label Sorting03;
        private System.Windows.Forms.Label Sorting04;
        private System.Windows.Forms.Label Sorting05;
        private System.Windows.Forms.RadioButton SelectedSort01;
        private System.Windows.Forms.RadioButton SelectedSort02;
        private System.Windows.Forms.RadioButton SelectedSort03;
        private System.Windows.Forms.RadioButton SelectedSort04;
        private System.Windows.Forms.RadioButton SelectedSort05;
    }
}


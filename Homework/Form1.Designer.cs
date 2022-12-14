namespace Homework
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
            this.textBoxXReadValue = new System.Windows.Forms.TextBox();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxYReadValue = new System.Windows.Forms.TextBox();
            this.textBoxZ = new System.Windows.Forms.TextBox();
            this.textBoxZReadValue = new System.Windows.Forms.TextBox();
            this.theIntendedAnswerOutput = new System.Windows.Forms.TextBox();
            this.calculate = new System.Windows.Forms.Button();
            this.theRealAnswerOutput = new System.Windows.Forms.TextBox();
            this.theRealAnswer = new System.Windows.Forms.TextBox();
            this.theIntendedAnswer = new System.Windows.Forms.TextBox();
            this.textDegreeX = new System.Windows.Forms.TextBox();
            this.textDegreeZ = new System.Windows.Forms.TextBox();
            this.textDegreeY = new System.Windows.Forms.TextBox();
            this.degreeXRead = new System.Windows.Forms.TextBox();
            this.degreeZRead = new System.Windows.Forms.TextBox();
            this.degreeYRead = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // textBoxXReadValue
            // 
            this.textBoxXReadValue.Location = new System.Drawing.Point(77, 12);
            this.textBoxXReadValue.Name = "textBoxXReadValue";
            this.textBoxXReadValue.Size = new System.Drawing.Size(149, 20);
            this.textBoxXReadValue.TabIndex = 0;
            this.textBoxXReadValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReadValueKeyPress);
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(12, 12);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.ReadOnly = true;
            this.textBoxX.Size = new System.Drawing.Size(59, 20);
            this.textBoxX.TabIndex = 1;
            this.textBoxX.Text = "Ваш X ->";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(12, 38);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.ReadOnly = true;
            this.textBoxY.Size = new System.Drawing.Size(59, 20);
            this.textBoxY.TabIndex = 3;
            this.textBoxY.Text = "Ваш Y ->";
            // 
            // textBoxYReadValue
            // 
            this.textBoxYReadValue.Location = new System.Drawing.Point(77, 38);
            this.textBoxYReadValue.Name = "textBoxYReadValue";
            this.textBoxYReadValue.Size = new System.Drawing.Size(149, 20);
            this.textBoxYReadValue.TabIndex = 2;
            // 
            // textBoxZ
            // 
            this.textBoxZ.Location = new System.Drawing.Point(12, 64);
            this.textBoxZ.Name = "textBoxZ";
            this.textBoxZ.ReadOnly = true;
            this.textBoxZ.Size = new System.Drawing.Size(59, 20);
            this.textBoxZ.TabIndex = 5;
            this.textBoxZ.Text = "Ваш Z ->";
            // 
            // textBoxZReadValue
            // 
            this.textBoxZReadValue.Location = new System.Drawing.Point(77, 64);
            this.textBoxZReadValue.Name = "textBoxZReadValue";
            this.textBoxZReadValue.Size = new System.Drawing.Size(149, 20);
            this.textBoxZReadValue.TabIndex = 4;
            // 
            // theIntendedAnswerOutput
            // 
            this.theIntendedAnswerOutput.Location = new System.Drawing.Point(128, 157);
            this.theIntendedAnswerOutput.Name = "theIntendedAnswerOutput";
            this.theIntendedAnswerOutput.ReadOnly = true;
            this.theIntendedAnswerOutput.Size = new System.Drawing.Size(149, 20);
            this.theIntendedAnswerOutput.TabIndex = 6;
            // 
            // calculate
            // 
            this.calculate.Location = new System.Drawing.Point(54, 90);
            this.calculate.Name = "calculate";
            this.calculate.Size = new System.Drawing.Size(100, 23);
            this.calculate.TabIndex = 7;
            this.calculate.Text = "Вычислить";
            this.calculate.UseVisualStyleBackColor = true;
            this.calculate.Click += new System.EventHandler(this.Calculate);
            // 
            // theRealAnswerOutput
            // 
            this.theRealAnswerOutput.Location = new System.Drawing.Point(128, 183);
            this.theRealAnswerOutput.Name = "theRealAnswerOutput";
            this.theRealAnswerOutput.ReadOnly = true;
            this.theRealAnswerOutput.Size = new System.Drawing.Size(149, 20);
            this.theRealAnswerOutput.TabIndex = 8;
            // 
            // theRealAnswer
            // 
            this.theRealAnswer.Location = new System.Drawing.Point(12, 183);
            this.theRealAnswer.Name = "theRealAnswer";
            this.theRealAnswer.ReadOnly = true;
            this.theRealAnswer.Size = new System.Drawing.Size(110, 20);
            this.theRealAnswer.TabIndex = 9;
            this.theRealAnswer.Text = "Вычисленный ответ";
            // 
            // theIntendedAnswer
            // 
            this.theIntendedAnswer.Location = new System.Drawing.Point(12, 157);
            this.theIntendedAnswer.Name = "theIntendedAnswer";
            this.theIntendedAnswer.ReadOnly = true;
            this.theIntendedAnswer.Size = new System.Drawing.Size(110, 20);
            this.theIntendedAnswer.TabIndex = 10;
            this.theIntendedAnswer.Text = "Ожидаемый ответ";
            // 
            // textDegreeX
            // 
            this.textDegreeX.Location = new System.Drawing.Point(232, 12);
            this.textDegreeX.Name = "textDegreeX";
            this.textDegreeX.ReadOnly = true;
            this.textDegreeX.Size = new System.Drawing.Size(54, 20);
            this.textDegreeX.TabIndex = 11;
            this.textDegreeX.Text = "Степень";
            // 
            // textDegreeZ
            // 
            this.textDegreeZ.Location = new System.Drawing.Point(232, 64);
            this.textDegreeZ.Name = "textDegreeZ";
            this.textDegreeZ.ReadOnly = true;
            this.textDegreeZ.Size = new System.Drawing.Size(54, 20);
            this.textDegreeZ.TabIndex = 12;
            this.textDegreeZ.Text = "Степень";
            // 
            // textDegreeY
            // 
            this.textDegreeY.Location = new System.Drawing.Point(232, 38);
            this.textDegreeY.Name = "textDegreeY";
            this.textDegreeY.ReadOnly = true;
            this.textDegreeY.Size = new System.Drawing.Size(54, 20);
            this.textDegreeY.TabIndex = 13;
            this.textDegreeY.Text = "Степень";
            // 
            // degreeXRead
            // 
            this.degreeXRead.Location = new System.Drawing.Point(293, 11);
            this.degreeXRead.Name = "degreeXRead";
            this.degreeXRead.Size = new System.Drawing.Size(48, 20);
            this.degreeXRead.TabIndex = 14;
            this.degreeXRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReadValueKeyPress);
            // 
            // degreeZRead
            // 
            this.degreeZRead.Location = new System.Drawing.Point(292, 64);
            this.degreeZRead.Name = "degreeZRead";
            this.degreeZRead.Size = new System.Drawing.Size(48, 20);
            this.degreeZRead.TabIndex = 15;
            this.degreeZRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReadValueKeyPress);
            // 
            // degreeYRead
            // 
            this.degreeYRead.Location = new System.Drawing.Point(292, 37);
            this.degreeYRead.Name = "degreeYRead";
            this.degreeYRead.Size = new System.Drawing.Size(48, 20);
            this.degreeYRead.TabIndex = 16;
            this.degreeYRead.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxReadValueKeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 376);
            this.Controls.Add(this.degreeYRead);
            this.Controls.Add(this.degreeZRead);
            this.Controls.Add(this.degreeXRead);
            this.Controls.Add(this.textDegreeY);
            this.Controls.Add(this.textDegreeZ);
            this.Controls.Add(this.textDegreeX);
            this.Controls.Add(this.theIntendedAnswer);
            this.Controls.Add(this.theRealAnswer);
            this.Controls.Add(this.theRealAnswerOutput);
            this.Controls.Add(this.calculate);
            this.Controls.Add(this.theIntendedAnswerOutput);
            this.Controls.Add(this.textBoxZ);
            this.Controls.Add(this.textBoxZReadValue);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxYReadValue);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.textBoxXReadValue);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxXReadValue;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxYReadValue;
        private System.Windows.Forms.TextBox textBoxZ;
        private System.Windows.Forms.TextBox textBoxZReadValue;
        private System.Windows.Forms.TextBox theIntendedAnswerOutput;
        private System.Windows.Forms.Button calculate;
        private System.Windows.Forms.TextBox theRealAnswerOutput;
        private System.Windows.Forms.TextBox theRealAnswer;
        private System.Windows.Forms.TextBox theIntendedAnswer;
        private System.Windows.Forms.TextBox textDegreeX;
        private System.Windows.Forms.TextBox textDegreeZ;
        private System.Windows.Forms.TextBox textDegreeY;
        private System.Windows.Forms.TextBox degreeXRead;
        private System.Windows.Forms.TextBox degreeZRead;
        private System.Windows.Forms.TextBox degreeYRead;
    }
}


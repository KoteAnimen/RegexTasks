
namespace RegexTasks
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.text = new System.Windows.Forms.TextBox();
            this.regularExpression = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.TextBox();
            this.GetAnswer = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Исходное строка";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GetAnswer);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.answer);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.regularExpression);
            this.groupBox2.Location = new System.Drawing.Point(13, 99);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 198);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Решение";
            // 
            // text
            // 
            this.text.Location = new System.Drawing.Point(7, 39);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(433, 29);
            this.text.TabIndex = 0;
            // 
            // regularExpression
            // 
            this.regularExpression.Location = new System.Drawing.Point(7, 55);
            this.regularExpression.Name = "regularExpression";
            this.regularExpression.Size = new System.Drawing.Size(433, 29);
            this.regularExpression.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Регулярное выражение";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ответ";
            // 
            // answer
            // 
            this.answer.Location = new System.Drawing.Point(7, 114);
            this.answer.Name = "answer";
            this.answer.ReadOnly = true;
            this.answer.Size = new System.Drawing.Size(433, 29);
            this.answer.TabIndex = 3;
            // 
            // GetAnswer
            // 
            this.GetAnswer.Location = new System.Drawing.Point(125, 149);
            this.GetAnswer.Name = "GetAnswer";
            this.GetAnswer.Size = new System.Drawing.Size(195, 38);
            this.GetAnswer.TabIndex = 5;
            this.GetAnswer.Text = "Получить ответ";
            this.GetAnswer.UseVisualStyleBackColor = true;
            this.GetAnswer.Click += new System.EventHandler(this.GetAnswer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 307);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регулярные выражения";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox text;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button GetAnswer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox regularExpression;
    }
}


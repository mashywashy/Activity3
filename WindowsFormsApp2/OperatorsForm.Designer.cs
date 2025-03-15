namespace WindowsFormsApp2
{
    partial class OperatorsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstNum = new System.Windows.Forms.TextBox();
            this.secondNum = new System.Windows.Forms.TextBox();
            this.operators = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.secondWord = new System.Windows.Forms.TextBox();
            this.firstWord = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.finalWord = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter first number:";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(69, 119);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(107, 13);
            this.result.TabIndex = 1;
            this.result.Text = "Perform an Operation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Select an Operator";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Enter second number:";
            // 
            // firstNum
            // 
            this.firstNum.Location = new System.Drawing.Point(180, 29);
            this.firstNum.Name = "firstNum";
            this.firstNum.Size = new System.Drawing.Size(100, 20);
            this.firstNum.TabIndex = 4;
            // 
            // secondNum
            // 
            this.secondNum.Location = new System.Drawing.Point(180, 60);
            this.secondNum.Name = "secondNum";
            this.secondNum.Size = new System.Drawing.Size(100, 20);
            this.secondNum.TabIndex = 5;
            // 
            // operators
            // 
            this.operators.FormattingEnabled = true;
            this.operators.Location = new System.Drawing.Point(180, 90);
            this.operators.MaxDropDownItems = 5;
            this.operators.Name = "operators";
            this.operators.Size = new System.Drawing.Size(121, 21);
            this.operators.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 389);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(108, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Show Message";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // secondWord
            // 
            this.secondWord.Location = new System.Drawing.Point(180, 283);
            this.secondWord.Name = "secondWord";
            this.secondWord.Size = new System.Drawing.Size(100, 20);
            this.secondWord.TabIndex = 13;
            // 
            // firstWord
            // 
            this.firstWord.Location = new System.Drawing.Point(180, 252);
            this.firstWord.Name = "firstWord";
            this.firstWord.Size = new System.Drawing.Size(100, 20);
            this.firstWord.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Enter second words:";
            // 
            // finalWord
            // 
            this.finalWord.AutoSize = true;
            this.finalWord.Location = new System.Drawing.Point(69, 313);
            this.finalWord.Name = "finalWord";
            this.finalWord.Size = new System.Drawing.Size(63, 13);
            this.finalWord.TabIndex = 9;
            this.finalWord.Text = "Enter words";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(69, 252);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Enter first words:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(464, 415);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OperatorsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(562, 457);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.secondWord);
            this.Controls.Add(this.firstWord);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.finalWord);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.operators);
            this.Controls.Add(this.secondNum);
            this.Controls.Add(this.firstNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label1);
            this.Name = "OperatorsForm";
            this.Text = "OperatorsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox firstNum;
        private System.Windows.Forms.TextBox secondNum;
        private System.Windows.Forms.ComboBox operators;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox secondWord;
        private System.Windows.Forms.TextBox firstWord;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label finalWord;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
    }
}
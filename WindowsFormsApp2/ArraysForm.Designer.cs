namespace WindowsFormsApp2
{
    partial class ArraysForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.numToLocate = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.Locate = new System.Windows.Forms.Button();
            this.smallestResult = new System.Windows.Forms.Label();
            this.largestResult = new System.Windows.Forms.Label();
            this.containsResult = new System.Windows.Forms.Label();
            this.sumResult = new System.Windows.Forms.Label();
            this.meanResult = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Array of numbers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter a number to locate:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Enter a number:";
            // 
            // num
            // 
            this.num.Location = new System.Drawing.Point(145, 65);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(100, 20);
            this.num.TabIndex = 3;
            // 
            // numToLocate
            // 
            this.numToLocate.Location = new System.Drawing.Point(178, 95);
            this.numToLocate.Name = "numToLocate";
            this.numToLocate.Size = new System.Drawing.Size(100, 20);
            this.numToLocate.TabIndex = 4;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(275, 63);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 5;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Locate
            // 
            this.Locate.Location = new System.Drawing.Point(49, 125);
            this.Locate.Name = "Locate";
            this.Locate.Size = new System.Drawing.Size(75, 23);
            this.Locate.TabIndex = 6;
            this.Locate.Text = "Locate";
            this.Locate.UseVisualStyleBackColor = true;
            this.Locate.Click += new System.EventHandler(this.Locate_Click);
            // 
            // smallestResult
            // 
            this.smallestResult.AutoSize = true;
            this.smallestResult.Location = new System.Drawing.Point(46, 231);
            this.smallestResult.Name = "smallestResult";
            this.smallestResult.Size = new System.Drawing.Size(126, 13);
            this.smallestResult.TabIndex = 7;
            this.smallestResult.Text = "The smallest number is__";
            // 
            // largestResult
            // 
            this.largestResult.AutoSize = true;
            this.largestResult.Location = new System.Drawing.Point(46, 208);
            this.largestResult.Name = "largestResult";
            this.largestResult.Size = new System.Drawing.Size(120, 13);
            this.largestResult.TabIndex = 8;
            this.largestResult.Text = "The largest number is__";
            // 
            // containsResult
            // 
            this.containsResult.AutoSize = true;
            this.containsResult.Location = new System.Drawing.Point(46, 173);
            this.containsResult.Name = "containsResult";
            this.containsResult.Size = new System.Drawing.Size(249, 13);
            this.containsResult.TabIndex = 9;
            this.containsResult.Text = "Number__is an element/not an element of the array";
            // 
            // sumResult
            // 
            this.sumResult.AutoSize = true;
            this.sumResult.Location = new System.Drawing.Point(301, 208);
            this.sumResult.Name = "sumResult";
            this.sumResult.Size = new System.Drawing.Size(126, 13);
            this.sumResult.TabIndex = 11;
            this.sumResult.Text = "The sum of the array is__";
            // 
            // meanResult
            // 
            this.meanResult.AutoSize = true;
            this.meanResult.Location = new System.Drawing.Point(301, 231);
            this.meanResult.Name = "meanResult";
            this.meanResult.Size = new System.Drawing.Size(133, 13);
            this.meanResult.TabIndex = 10;
            this.meanResult.Text = "The mean of the array is__";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 452);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(206, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "_is an element/not an element of the array";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 475);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(154, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "There are __ words in the array";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Locate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(255, 305);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 16;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(122, 307);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 15;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(46, 309);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Enter a word:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "Enter a word to locate:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(46, 281);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Array of words";
            // 
            // ArraysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 540);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.sumResult);
            this.Controls.Add(this.meanResult);
            this.Controls.Add(this.containsResult);
            this.Controls.Add(this.largestResult);
            this.Controls.Add(this.smallestResult);
            this.Controls.Add(this.Locate);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.numToLocate);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ArraysForm";
            this.Text = "ArraysForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox numToLocate;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button Locate;
        private System.Windows.Forms.Label smallestResult;
        private System.Windows.Forms.Label largestResult;
        private System.Windows.Forms.Label containsResult;
        private System.Windows.Forms.Label sumResult;
        private System.Windows.Forms.Label meanResult;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}
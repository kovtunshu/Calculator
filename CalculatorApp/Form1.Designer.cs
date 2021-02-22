
namespace CalculatorApp
{
    partial class Form1
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
            this.bnClose = new System.Windows.Forms.Button();
            this.tbOperand1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bnAdd = new System.Windows.Forms.Button();
            this.bnMultiply = new System.Windows.Forms.Button();
            this.tbOperand2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bnSubstr = new System.Windows.Forms.Button();
            this.bnDivide = new System.Windows.Forms.Button();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bnClose
            // 
            this.bnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bnClose.Location = new System.Drawing.Point(497, 128);
            this.bnClose.Name = "bnClose";
            this.bnClose.Size = new System.Drawing.Size(75, 23);
            this.bnClose.TabIndex = 0;
            this.bnClose.Text = "Close";
            this.bnClose.UseVisualStyleBackColor = true;
            this.bnClose.Click += new System.EventHandler(this.bnClose_Click);
            // 
            // tbOperand1
            // 
            this.tbOperand1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.tbOperand1.Location = new System.Drawing.Point(88, 65);
            this.tbOperand1.Name = "tbOperand1";
            this.tbOperand1.Size = new System.Drawing.Size(100, 20);
            this.tbOperand1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Operand 1";
            // 
            // bnAdd
            // 
            this.bnAdd.ForeColor = System.Drawing.Color.DarkRed;
            this.bnAdd.Location = new System.Drawing.Point(194, 63);
            this.bnAdd.Name = "bnAdd";
            this.bnAdd.Size = new System.Drawing.Size(45, 23);
            this.bnAdd.TabIndex = 3;
            this.bnAdd.Text = "+";
            this.bnAdd.UseVisualStyleBackColor = true;
            this.bnAdd.Click += new System.EventHandler(this.bnMathAction_Click);
            // 
            // bnMultiply
            // 
            this.bnMultiply.Location = new System.Drawing.Point(245, 63);
            this.bnMultiply.Name = "bnMultiply";
            this.bnMultiply.Size = new System.Drawing.Size(45, 23);
            this.bnMultiply.TabIndex = 3;
            this.bnMultiply.Text = "*";
            this.bnMultiply.UseVisualStyleBackColor = true;
            this.bnMultiply.Click += new System.EventHandler(this.bnMathAction_Click);
            // 
            // tbOperand2
            // 
            this.tbOperand2.Location = new System.Drawing.Point(88, 94);
            this.tbOperand2.Name = "tbOperand2";
            this.tbOperand2.Size = new System.Drawing.Size(100, 20);
            this.tbOperand2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Operand 2";
            // 
            // bnSubstr
            // 
            this.bnSubstr.Location = new System.Drawing.Point(194, 92);
            this.bnSubstr.Name = "bnSubstr";
            this.bnSubstr.Size = new System.Drawing.Size(45, 23);
            this.bnSubstr.TabIndex = 3;
            this.bnSubstr.Text = "-";
            this.bnSubstr.UseVisualStyleBackColor = true;
            this.bnSubstr.Click += new System.EventHandler(this.bnMathAction_Click);
            // 
            // bnDivide
            // 
            this.bnDivide.Location = new System.Drawing.Point(245, 92);
            this.bnDivide.Name = "bnDivide";
            this.bnDivide.Size = new System.Drawing.Size(45, 23);
            this.bnDivide.TabIndex = 3;
            this.bnDivide.Text = "/";
            this.bnDivide.UseVisualStyleBackColor = true;
            this.bnDivide.Click += new System.EventHandler(this.bnMathAction_Click);
            // 
            // tbResult
            // 
            this.tbResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbResult.Location = new System.Drawing.Point(296, 65);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(274, 47);
            this.tbResult.TabIndex = 1;
            this.tbResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(82, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 31);
            this.label3.TabIndex = 4;
            this.label3.Text = "Моя первая программа на C#";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 163);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bnDivide);
            this.Controls.Add(this.bnSubstr);
            this.Controls.Add(this.bnMultiply);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnAdd);
            this.Controls.Add(this.tbOperand2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbOperand1);
            this.Controls.Add(this.bnClose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bnClose;
        private System.Windows.Forms.TextBox tbOperand1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnAdd;
        private System.Windows.Forms.Button bnMultiply;
        private System.Windows.Forms.TextBox tbOperand2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bnSubstr;
        private System.Windows.Forms.Button bnDivide;
        private System.Windows.Forms.TextBox tbResult;
        private System.Windows.Forms.Label label3;
    }
}


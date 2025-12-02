namespace Advent_of_Code_2025_Day_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtZeroHits = new TextBox();
            lblText1 = new Label();
            lblText2 = new Label();
            txtInput = new TextBox();
            lblEnter = new Label();
            btnCalculate = new Button();
            SuspendLayout();
            // 
            // txtZeroHits
            // 
            txtZeroHits.Location = new Point(124, 138);
            txtZeroHits.Name = "txtZeroHits";
            txtZeroHits.ReadOnly = true;
            txtZeroHits.Size = new Size(157, 27);
            txtZeroHits.TabIndex = 0;
            txtZeroHits.TabStop = false;
            txtZeroHits.TextAlign = HorizontalAlignment.Center;
            // 
            // lblText1
            // 
            lblText1.AutoSize = true;
            lblText1.Location = new Point(99, 115);
            lblText1.Name = "lblText1";
            lblText1.Size = new Size(207, 20);
            lblText1.TabIndex = 1;
            lblText1.Text = "This Input Set Hit/Passed Zero";
            // 
            // lblText2
            // 
            lblText2.AutoSize = true;
            lblText2.Location = new Point(178, 168);
            lblText2.Name = "lblText2";
            lblText2.Size = new Size(48, 20);
            lblText2.TabIndex = 2;
            lblText2.Text = "Times";
            // 
            // txtInput
            // 
            txtInput.Location = new Point(150, 32);
            txtInput.Multiline = true;
            txtInput.Name = "txtInput";
            txtInput.Size = new Size(115, 27);
            txtInput.TabIndex = 3;
            // 
            // lblEnter
            // 
            lblEnter.AutoSize = true;
            lblEnter.Location = new Point(150, 9);
            lblEnter.Name = "lblEnter";
            lblEnter.Size = new Size(115, 20);
            lblEnter.TabIndex = 4;
            lblEnter.Text = "Enter A Dataset:";
            // 
            // btnCalculate
            // 
            btnCalculate.Location = new Point(150, 65);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(115, 29);
            btnCalculate.TabIndex = 5;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = true;
            btnCalculate.Click += btnCalculate_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 203);
            Controls.Add(btnCalculate);
            Controls.Add(lblEnter);
            Controls.Add(txtInput);
            Controls.Add(lblText2);
            Controls.Add(lblText1);
            Controls.Add(txtZeroHits);
            Name = "Form1";
            Text = "Advent of Code Day 1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtZeroHits;
        private Label lblText1;
        private Label lblText2;
        private TextBox txtInput;
        private Label lblEnter;
        private Button btnCalculate;
    }
}

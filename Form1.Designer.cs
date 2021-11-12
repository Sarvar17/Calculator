namespace Calculator2
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
            this.exitButton = new System.Windows.Forms.Button();
            this.oneButton = new System.Windows.Forms.Button();
            this.twoButton = new System.Windows.Forms.Button();
            this.threeButton = new System.Windows.Forms.Button();
            this.slashButton = new System.Windows.Forms.Button();
            this.fourButton = new System.Windows.Forms.Button();
            this.fiveButton = new System.Windows.Forms.Button();
            this.sixButton = new System.Windows.Forms.Button();
            this.multiplyButton = new System.Windows.Forms.Button();
            this.sevenButton = new System.Windows.Forms.Button();
            this.eightButton = new System.Windows.Forms.Button();
            this.nineButton = new System.Windows.Forms.Button();
            this.plusButton = new System.Windows.Forms.Button();
            this.zeroButton = new System.Windows.Forms.Button();
            this.minusButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.ceButton = new System.Windows.Forms.Button();
            this.cButton = new System.Windows.Forms.Button();
            this.equalButtton = new System.Windows.Forms.Button();
            this.calculatorTextBox = new System.Windows.Forms.TextBox();
            this.calculatorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.exitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(397, -4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(54, 43);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // oneButton
            // 
            this.oneButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.oneButton.Location = new System.Drawing.Point(24, 166);
            this.oneButton.Name = "oneButton";
            this.oneButton.Size = new System.Drawing.Size(67, 48);
            this.oneButton.TabIndex = 1;
            this.oneButton.Text = "1";
            this.oneButton.UseVisualStyleBackColor = true;
            this.oneButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // twoButton
            // 
            this.twoButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.twoButton.Location = new System.Drawing.Point(107, 166);
            this.twoButton.Name = "twoButton";
            this.twoButton.Size = new System.Drawing.Size(67, 48);
            this.twoButton.TabIndex = 1;
            this.twoButton.Text = "2";
            this.twoButton.UseVisualStyleBackColor = true;
            this.twoButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // threeButton
            // 
            this.threeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.threeButton.Location = new System.Drawing.Point(189, 166);
            this.threeButton.Name = "threeButton";
            this.threeButton.Size = new System.Drawing.Size(67, 48);
            this.threeButton.TabIndex = 1;
            this.threeButton.Text = "3";
            this.threeButton.UseVisualStyleBackColor = true;
            this.threeButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // slashButton
            // 
            this.slashButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.slashButton.Location = new System.Drawing.Point(271, 166);
            this.slashButton.Name = "slashButton";
            this.slashButton.Size = new System.Drawing.Size(67, 48);
            this.slashButton.TabIndex = 1;
            this.slashButton.Text = "/";
            this.slashButton.UseVisualStyleBackColor = true;
            this.slashButton.Click += new System.EventHandler(this.operatorClick);
            // 
            // fourButton
            // 
            this.fourButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fourButton.Location = new System.Drawing.Point(24, 230);
            this.fourButton.Name = "fourButton";
            this.fourButton.Size = new System.Drawing.Size(67, 48);
            this.fourButton.TabIndex = 1;
            this.fourButton.Text = "4";
            this.fourButton.UseVisualStyleBackColor = true;
            this.fourButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // fiveButton
            // 
            this.fiveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fiveButton.Location = new System.Drawing.Point(108, 230);
            this.fiveButton.Name = "fiveButton";
            this.fiveButton.Size = new System.Drawing.Size(67, 48);
            this.fiveButton.TabIndex = 1;
            this.fiveButton.Text = "5";
            this.fiveButton.UseVisualStyleBackColor = true;
            this.fiveButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // sixButton
            // 
            this.sixButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sixButton.Location = new System.Drawing.Point(189, 230);
            this.sixButton.Name = "sixButton";
            this.sixButton.Size = new System.Drawing.Size(67, 48);
            this.sixButton.TabIndex = 1;
            this.sixButton.Text = "6";
            this.sixButton.UseVisualStyleBackColor = true;
            this.sixButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // multiplyButton
            // 
            this.multiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplyButton.Location = new System.Drawing.Point(271, 230);
            this.multiplyButton.Name = "multiplyButton";
            this.multiplyButton.Size = new System.Drawing.Size(67, 48);
            this.multiplyButton.TabIndex = 1;
            this.multiplyButton.Text = "*";
            this.multiplyButton.UseVisualStyleBackColor = true;
            this.multiplyButton.Click += new System.EventHandler(this.operatorClick);
            // 
            // sevenButton
            // 
            this.sevenButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sevenButton.Location = new System.Drawing.Point(24, 294);
            this.sevenButton.Name = "sevenButton";
            this.sevenButton.Size = new System.Drawing.Size(67, 48);
            this.sevenButton.TabIndex = 1;
            this.sevenButton.Text = "7";
            this.sevenButton.UseVisualStyleBackColor = true;
            this.sevenButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // eightButton
            // 
            this.eightButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eightButton.Location = new System.Drawing.Point(107, 294);
            this.eightButton.Name = "eightButton";
            this.eightButton.Size = new System.Drawing.Size(67, 48);
            this.eightButton.TabIndex = 1;
            this.eightButton.Text = "8";
            this.eightButton.UseVisualStyleBackColor = true;
            this.eightButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // nineButton
            // 
            this.nineButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nineButton.Location = new System.Drawing.Point(189, 294);
            this.nineButton.Name = "nineButton";
            this.nineButton.Size = new System.Drawing.Size(67, 48);
            this.nineButton.TabIndex = 1;
            this.nineButton.Text = "9";
            this.nineButton.UseVisualStyleBackColor = true;
            this.nineButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // plusButton
            // 
            this.plusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusButton.Location = new System.Drawing.Point(271, 294);
            this.plusButton.Name = "plusButton";
            this.plusButton.Size = new System.Drawing.Size(67, 48);
            this.plusButton.TabIndex = 1;
            this.plusButton.Text = "+";
            this.plusButton.UseVisualStyleBackColor = true;
            this.plusButton.Click += new System.EventHandler(this.operatorClick);
            // 
            // zeroButton
            // 
            this.zeroButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.zeroButton.Location = new System.Drawing.Point(24, 358);
            this.zeroButton.Name = "zeroButton";
            this.zeroButton.Size = new System.Drawing.Size(150, 48);
            this.zeroButton.TabIndex = 1;
            this.zeroButton.Text = "0";
            this.zeroButton.UseVisualStyleBackColor = true;
            this.zeroButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // minusButton
            // 
            this.minusButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusButton.Location = new System.Drawing.Point(271, 358);
            this.minusButton.Name = "minusButton";
            this.minusButton.Size = new System.Drawing.Size(67, 48);
            this.minusButton.TabIndex = 1;
            this.minusButton.Text = "-";
            this.minusButton.UseVisualStyleBackColor = true;
            this.minusButton.Click += new System.EventHandler(this.operatorClick);
            // 
            // dotButton
            // 
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotButton.Location = new System.Drawing.Point(189, 358);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(67, 48);
            this.dotButton.TabIndex = 1;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = true;
            this.dotButton.Click += new System.EventHandler(this.zeroButton_Click);
            // 
            // ceButton
            // 
            this.ceButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ceButton.Location = new System.Drawing.Point(353, 166);
            this.ceButton.Name = "ceButton";
            this.ceButton.Size = new System.Drawing.Size(67, 48);
            this.ceButton.TabIndex = 1;
            this.ceButton.Text = "CE";
            this.ceButton.UseVisualStyleBackColor = true;
            this.ceButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // cButton
            // 
            this.cButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cButton.Location = new System.Drawing.Point(353, 230);
            this.cButton.Name = "cButton";
            this.cButton.Size = new System.Drawing.Size(67, 48);
            this.cButton.TabIndex = 1;
            this.cButton.Text = "C";
            this.cButton.UseVisualStyleBackColor = true;
            this.cButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // equalButtton
            // 
            this.equalButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalButtton.Location = new System.Drawing.Point(353, 295);
            this.equalButtton.Name = "equalButtton";
            this.equalButtton.Size = new System.Drawing.Size(67, 111);
            this.equalButtton.TabIndex = 1;
            this.equalButtton.Text = "=";
            this.equalButtton.UseVisualStyleBackColor = true;
            this.equalButtton.Click += new System.EventHandler(this.button4_Click);
            // 
            // calculatorTextBox
            // 
            this.calculatorTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.calculatorTextBox.Location = new System.Drawing.Point(24, 109);
            this.calculatorTextBox.Name = "calculatorTextBox";
            this.calculatorTextBox.Size = new System.Drawing.Size(396, 39);
            this.calculatorTextBox.TabIndex = 2;
            this.calculatorTextBox.Text = "0";
            this.calculatorTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // calculatorLabel
            // 
            this.calculatorLabel.AutoSize = true;
            this.calculatorLabel.Location = new System.Drawing.Point(24, 65);
            this.calculatorLabel.Name = "calculatorLabel";
            this.calculatorLabel.Size = new System.Drawing.Size(0, 30);
            this.calculatorLabel.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(448, 433);
            this.Controls.Add(this.calculatorLabel);
            this.Controls.Add(this.calculatorTextBox);
            this.Controls.Add(this.minusButton);
            this.Controls.Add(this.equalButtton);
            this.Controls.Add(this.plusButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.cButton);
            this.Controls.Add(this.nineButton);
            this.Controls.Add(this.multiplyButton);
            this.Controls.Add(this.sixButton);
            this.Controls.Add(this.ceButton);
            this.Controls.Add(this.eightButton);
            this.Controls.Add(this.slashButton);
            this.Controls.Add(this.fiveButton);
            this.Controls.Add(this.zeroButton);
            this.Controls.Add(this.sevenButton);
            this.Controls.Add(this.threeButton);
            this.Controls.Add(this.fourButton);
            this.Controls.Add(this.twoButton);
            this.Controls.Add(this.oneButton);
            this.Controls.Add(this.exitButton);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.DarkOrange;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "Form1";
            this.Text = "Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button oneButton;
        private System.Windows.Forms.Button twoButton;
        private System.Windows.Forms.Button threeButton;
        private System.Windows.Forms.Button slashButton;
        private System.Windows.Forms.Button fourButton;
        private System.Windows.Forms.Button fiveButton;
        private System.Windows.Forms.Button sixButton;
        private System.Windows.Forms.Button multiplyButton;
        private System.Windows.Forms.Button sevenButton;
        private System.Windows.Forms.Button eightButton;
        private System.Windows.Forms.Button nineButton;
        private System.Windows.Forms.Button plusButton;
        private System.Windows.Forms.Button zeroButton;
        private System.Windows.Forms.Button minusButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button ceButton;
        private System.Windows.Forms.Button cButton;
        private System.Windows.Forms.Button equalButtton;
        private System.Windows.Forms.TextBox calculatorTextBox;
        private System.Windows.Forms.Label calculatorLabel;
    }
}


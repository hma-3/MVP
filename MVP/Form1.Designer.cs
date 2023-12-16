namespace MVP
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
            label1 = new Label();
            label2 = new Label();
            labelTxt = new TextBox();
            inputTxt = new TextBox();
            buttonSet = new Button();
            buttonReverse = new Button();
            buttonClear = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 137);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(74, 18);
            label1.TabIndex = 0;
            label1.Text = "Результат:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 17);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(95, 18);
            label2.TabIndex = 1;
            label2.Text = "Введіть текст:";
            // 
            // labelTxt
            // 
            labelTxt.Location = new Point(135, 133);
            labelTxt.Margin = new Padding(4, 2, 4, 2);
            labelTxt.Name = "labelTxt";
            labelTxt.ReadOnly = true;
            labelTxt.Size = new Size(457, 25);
            labelTxt.TabIndex = 2;
            // 
            // inputTxt
            // 
            inputTxt.Location = new Point(135, 14);
            inputTxt.Margin = new Padding(4, 2, 4, 2);
            inputTxt.Name = "inputTxt";
            inputTxt.Size = new Size(457, 25);
            inputTxt.TabIndex = 3;
            // 
            // buttonSet
            // 
            buttonSet.BackColor = Color.SkyBlue;
            buttonSet.FlatAppearance.BorderSize = 0;
            buttonSet.FlatStyle = FlatStyle.Flat;
            buttonSet.ForeColor = SystemColors.ControlText;
            buttonSet.Location = new Point(27, 65);
            buttonSet.Margin = new Padding(4, 2, 4, 2);
            buttonSet.Name = "buttonSet";
            buttonSet.Size = new Size(153, 38);
            buttonSet.TabIndex = 4;
            buttonSet.Text = "Ввести";
            buttonSet.UseVisualStyleBackColor = false;
            buttonSet.Click += ButtonSet_Click;
            // 
            // buttonReverse
            // 
            buttonReverse.BackColor = Color.SkyBlue;
            buttonReverse.FlatAppearance.BorderSize = 0;
            buttonReverse.FlatStyle = FlatStyle.Flat;
            buttonReverse.Location = new Point(233, 65);
            buttonReverse.Margin = new Padding(4, 2, 4, 2);
            buttonReverse.Name = "buttonReverse";
            buttonReverse.Size = new Size(153, 38);
            buttonReverse.TabIndex = 5;
            buttonReverse.Text = "Обернути";
            buttonReverse.UseVisualStyleBackColor = false;
            buttonReverse.Click += ButtonReverse_Click;
            // 
            // buttonClear
            // 
            buttonClear.BackColor = Color.SkyBlue;
            buttonClear.FlatAppearance.BorderSize = 0;
            buttonClear.FlatStyle = FlatStyle.Flat;
            buttonClear.Location = new Point(440, 65);
            buttonClear.Margin = new Padding(4, 2, 4, 2);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(153, 38);
            buttonClear.TabIndex = 6;
            buttonClear.Text = "Очистити";
            buttonClear.UseVisualStyleBackColor = false;
            buttonClear.Click += buttonClear_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(624, 194);
            Controls.Add(buttonClear);
            Controls.Add(buttonReverse);
            Controls.Add(buttonSet);
            Controls.Add(inputTxt);
            Controls.Add(labelTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Arial Unicode MS", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 2, 4, 2);
            Name = "Form1";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MVP example";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox labelTxt;
        private TextBox inputTxt;
        private Button buttonSet;
        private Button buttonReverse;
        private Button buttonClear;
    }
}
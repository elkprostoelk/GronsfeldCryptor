namespace GronsfeldCryptor
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
            originalRichTextBox = new RichTextBox();
            resultRichTextBox = new RichTextBox();
            encryptButton = new Button();
            decryptButton = new Button();
            keyTextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // originalRichTextBox
            // 
            originalRichTextBox.Location = new Point(12, 46);
            originalRichTextBox.Name = "originalRichTextBox";
            originalRichTextBox.Size = new Size(294, 361);
            originalRichTextBox.TabIndex = 0;
            originalRichTextBox.Text = "";
            // 
            // resultRichTextBox
            // 
            resultRichTextBox.Location = new Point(547, 46);
            resultRichTextBox.Name = "resultRichTextBox";
            resultRichTextBox.ReadOnly = true;
            resultRichTextBox.Size = new Size(294, 361);
            resultRichTextBox.TabIndex = 0;
            resultRichTextBox.Text = "";
            // 
            // encryptButton
            // 
            encryptButton.Location = new Point(365, 214);
            encryptButton.Name = "encryptButton";
            encryptButton.Size = new Size(121, 48);
            encryptButton.TabIndex = 2;
            encryptButton.Text = "Зашифрувати";
            encryptButton.UseVisualStyleBackColor = true;
            encryptButton.Click += encryptButton_Click;
            // 
            // decryptButton
            // 
            decryptButton.Location = new Point(365, 286);
            decryptButton.Name = "decryptButton";
            decryptButton.Size = new Size(121, 48);
            decryptButton.TabIndex = 2;
            decryptButton.Text = "Дешифрувати";
            decryptButton.UseVisualStyleBackColor = true;
            decryptButton.Click += decryptButton_Click;
            // 
            // keyTextBox
            // 
            keyTextBox.Location = new Point(328, 91);
            keyTextBox.Name = "keyTextBox";
            keyTextBox.Size = new Size(199, 23);
            keyTextBox.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 73);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 4;
            label1.Text = "Ключ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 28);
            label3.Name = "label3";
            label3.Size = new Size(105, 15);
            label3.TabIndex = 6;
            label3.Text = "Початковий текст";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(547, 28);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 7;
            label4.Text = "Кінцевий текст";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 450);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(keyTextBox);
            Controls.Add(decryptButton);
            Controls.Add(encryptButton);
            Controls.Add(resultRichTextBox);
            Controls.Add(originalRichTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox originalRichTextBox;
        private RichTextBox resultRichTextBox;
        private Button encryptButton;
        private Button decryptButton;
        private TextBox keyTextBox;
        private Label label1;
        private Label label3;
        private Label label4;
    }
}
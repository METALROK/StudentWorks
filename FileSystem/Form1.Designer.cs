namespace ClientInterface
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
            printDialog1 = new PrintDialog();
            DirectoryClearButton = new Button();
            OldStringClearButton = new Button();
            NewStringClearButton = new Button();
            SubmitButton = new Button();
            DirectoryTextBox = new TextBox();
            OldStringTextBox = new TextBox();
            NewStringTextBox = new TextBox();
            DirectoryLabel = new Label();
            DirectoryEmptyLabel = new Label();
            OldStringLabel = new Label();
            OldStringEmptyLabel = new Label();
            NewStringLabel = new Label();
            NewStringEmptyLabel = new Label();
            SuspendLayout();
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // DirectoryClearButton
            // 
            DirectoryClearButton.Location = new Point(500, 60);
            DirectoryClearButton.Name = "DirectoryClearButton";
            DirectoryClearButton.Size = new Size(112, 34);
            DirectoryClearButton.TabIndex = 0;
            DirectoryClearButton.Text = "Очистить";
            DirectoryClearButton.UseVisualStyleBackColor = true;
            DirectoryClearButton.Click += DirectoryClearButton_Click;
            // 
            // OldStringClearButton
            // 
            OldStringClearButton.Location = new Point(500, 160);
            OldStringClearButton.Name = "OldStringClearButton";
            OldStringClearButton.Size = new Size(112, 34);
            OldStringClearButton.TabIndex = 1;
            OldStringClearButton.Text = "Очистить";
            OldStringClearButton.UseVisualStyleBackColor = true;
            OldStringClearButton.Click += OldStringClearButton_Click;
            // 
            // NewStringClearButton
            // 
            NewStringClearButton.Location = new Point(500, 257);
            NewStringClearButton.Name = "NewStringClearButton";
            NewStringClearButton.Size = new Size(112, 34);
            NewStringClearButton.TabIndex = 2;
            NewStringClearButton.Text = "Очистить";
            NewStringClearButton.UseVisualStyleBackColor = true;
            NewStringClearButton.Click += NewStringClearButton_Click;
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(50, 344);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.Size = new Size(137, 34);
            SubmitButton.TabIndex = 3;
            SubmitButton.Text = "Подтвердить";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // DirectoryTextBox
            // 
            DirectoryTextBox.Location = new Point(50, 60);
            DirectoryTextBox.Name = "DirectoryTextBox";
            DirectoryTextBox.Size = new Size(425, 31);
            DirectoryTextBox.TabIndex = 4;
            DirectoryTextBox.TextChanged += DirectoryTextBox_TextChanged;
            // 
            // OldStringTextBox
            // 
            OldStringTextBox.Location = new Point(50, 160);
            OldStringTextBox.Name = "OldStringTextBox";
            OldStringTextBox.Size = new Size(425, 31);
            OldStringTextBox.TabIndex = 5;
            OldStringTextBox.TextChanged += OldStringTextBox_TextChanged;
            // 
            // NewStringTextBox
            // 
            NewStringTextBox.Location = new Point(50, 260);
            NewStringTextBox.Name = "NewStringTextBox";
            NewStringTextBox.Size = new Size(425, 31);
            NewStringTextBox.TabIndex = 6;
            NewStringTextBox.TextChanged += NewStringTextBox_TextChanged;
            // 
            // DirectoryLabel
            // 
            DirectoryLabel.AutoSize = true;
            DirectoryLabel.Location = new Point(50, 30);
            DirectoryLabel.Name = "DirectoryLabel";
            DirectoryLabel.Size = new Size(111, 25);
            DirectoryLabel.TabIndex = 7;
            DirectoryLabel.Text = "Директория";
            // 
            // DirectoryEmptyLabel
            // 
            DirectoryEmptyLabel.AutoSize = true;
            DirectoryEmptyLabel.ForeColor = Color.Red;
            DirectoryEmptyLabel.Location = new Point(50, 95);
            DirectoryEmptyLabel.Name = "DirectoryEmptyLabel";
            DirectoryEmptyLabel.Size = new Size(195, 25);
            DirectoryEmptyLabel.TabIndex = 8;
            DirectoryEmptyLabel.Text = "Директорий не указан";
            DirectoryEmptyLabel.Visible = false;
            // 
            // OldStringLabel
            // 
            OldStringLabel.AutoSize = true;
            OldStringLabel.Location = new Point(50, 130);
            OldStringLabel.Name = "OldStringLabel";
            OldStringLabel.Size = new Size(316, 25);
            OldStringLabel.TabIndex = 9;
            OldStringLabel.Text = "Строка, которую требуется заменить";
            // 
            // OldStringEmptyLabel
            // 
            OldStringEmptyLabel.AutoSize = true;
            OldStringEmptyLabel.ForeColor = Color.Red;
            OldStringEmptyLabel.Location = new Point(50, 195);
            OldStringEmptyLabel.Name = "OldStringEmptyLabel";
            OldStringEmptyLabel.Size = new Size(166, 25);
            OldStringEmptyLabel.TabIndex = 10;
            OldStringEmptyLabel.Text = "Строка не введена";
            OldStringEmptyLabel.Visible = false;
            // 
            // NewStringLabel
            // 
            NewStringLabel.AutoSize = true;
            NewStringLabel.Location = new Point(50, 230);
            NewStringLabel.Name = "NewStringLabel";
            NewStringLabel.Size = new Size(137, 25);
            NewStringLabel.TabIndex = 11;
            NewStringLabel.Text = "Строка замены";
            // 
            // NewStringEmptyLabel
            // 
            NewStringEmptyLabel.AutoSize = true;
            NewStringEmptyLabel.ForeColor = Color.Red;
            NewStringEmptyLabel.Location = new Point(50, 295);
            NewStringEmptyLabel.Name = "NewStringEmptyLabel";
            NewStringEmptyLabel.Size = new Size(166, 25);
            NewStringEmptyLabel.TabIndex = 12;
            NewStringEmptyLabel.Text = "Строка не введена";
            NewStringEmptyLabel.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 444);
            Controls.Add(NewStringEmptyLabel);
            Controls.Add(NewStringLabel);
            Controls.Add(OldStringEmptyLabel);
            Controls.Add(OldStringLabel);
            Controls.Add(DirectoryEmptyLabel);
            Controls.Add(DirectoryLabel);
            Controls.Add(NewStringTextBox);
            Controls.Add(OldStringTextBox);
            Controls.Add(DirectoryTextBox);
            Controls.Add(SubmitButton);
            Controls.Add(NewStringClearButton);
            Controls.Add(OldStringClearButton);
            Controls.Add(DirectoryClearButton);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PrintDialog printDialog1;
        private Button DirectoryClearButton;
        private Button OldStringClearButton;
        private Button NewStringClearButton;
        private Button SubmitButton;
        private TextBox DirectoryTextBox;
        private TextBox OldStringTextBox;
        private TextBox NewStringTextBox;
        private Label DirectoryLabel;
        private Label DirectoryEmptyLabel;
        private Label OldStringLabel;
        private Label OldStringEmptyLabel;
        private Label NewStringLabel;
        private Label NewStringEmptyLabel;
    }
}
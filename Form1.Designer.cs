
namespace Any2Base64_Converter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_OpenFile = new System.Windows.Forms.Button();
            this.TextBox_PathToFile = new System.Windows.Forms.TextBox();
            this.Label_ChooseFile = new System.Windows.Forms.Label();
            this.TextBox_FileToBase64 = new System.Windows.Forms.TextBox();
            this.Label_FileInBase64 = new System.Windows.Forms.Label();
            this.Button_CopyToClipboard = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Button_SaveToBase64 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Button_RecoverFromBase64 = new System.Windows.Forms.Button();
            this.Label_FileInBase64_2 = new System.Windows.Forms.Label();
            this.Button_OpenFile2 = new System.Windows.Forms.Button();
            this.Label_ChooseFile2 = new System.Windows.Forms.Label();
            this.TextBox_PathToFile2 = new System.Windows.Forms.TextBox();
            this.TextBox_Base64ToFile = new System.Windows.Forms.TextBox();
            this.Button_Close2 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.Label_ProgramName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Button_Close3 = new System.Windows.Forms.Button();
            this.TextBox_About = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Close
            // 
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close.Image")));
            this.Button_Close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Close.Location = new System.Drawing.Point(503, 406);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(210, 55);
            this.Button_Close.TabIndex = 0;
            this.Button_Close.Text = "Закрыть";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_OpenFile
            // 
            this.Button_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("Button_OpenFile.Image")));
            this.Button_OpenFile.Location = new System.Drawing.Point(673, 19);
            this.Button_OpenFile.Name = "Button_OpenFile";
            this.Button_OpenFile.Size = new System.Drawing.Size(40, 40);
            this.Button_OpenFile.TabIndex = 2;
            this.Button_OpenFile.UseVisualStyleBackColor = true;
            this.Button_OpenFile.Click += new System.EventHandler(this.Button_OpenFile_Click);
            // 
            // TextBox_PathToFile
            // 
            this.TextBox_PathToFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_PathToFile.Location = new System.Drawing.Point(6, 26);
            this.TextBox_PathToFile.Name = "TextBox_PathToFile";
            this.TextBox_PathToFile.Size = new System.Drawing.Size(661, 27);
            this.TextBox_PathToFile.TabIndex = 3;
            // 
            // Label_ChooseFile
            // 
            this.Label_ChooseFile.AutoSize = true;
            this.Label_ChooseFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ChooseFile.Location = new System.Drawing.Point(2, 3);
            this.Label_ChooseFile.Name = "Label_ChooseFile";
            this.Label_ChooseFile.Size = new System.Drawing.Size(401, 20);
            this.Label_ChooseFile.TabIndex = 4;
            this.Label_ChooseFile.Text = "Файл для конвертирования в формат Base64:";
            // 
            // TextBox_FileToBase64
            // 
            this.TextBox_FileToBase64.Location = new System.Drawing.Point(6, 89);
            this.TextBox_FileToBase64.MaxLength = 0;
            this.TextBox_FileToBase64.Multiline = true;
            this.TextBox_FileToBase64.Name = "TextBox_FileToBase64";
            this.TextBox_FileToBase64.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_FileToBase64.Size = new System.Drawing.Size(707, 311);
            this.TextBox_FileToBase64.TabIndex = 5;
            // 
            // Label_FileInBase64
            // 
            this.Label_FileInBase64.AutoSize = true;
            this.Label_FileInBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FileInBase64.Location = new System.Drawing.Point(2, 66);
            this.Label_FileInBase64.Name = "Label_FileInBase64";
            this.Label_FileInBase64.Size = new System.Drawing.Size(321, 20);
            this.Label_FileInBase64.TabIndex = 6;
            this.Label_FileInBase64.Text = "Выбранный файл в формате Base64:";
            // 
            // Button_CopyToClipboard
            // 
            this.Button_CopyToClipboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_CopyToClipboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_CopyToClipboard.Image = ((System.Drawing.Image)(resources.GetObject("Button_CopyToClipboard.Image")));
            this.Button_CopyToClipboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_CopyToClipboard.Location = new System.Drawing.Point(6, 406);
            this.Button_CopyToClipboard.Name = "Button_CopyToClipboard";
            this.Button_CopyToClipboard.Size = new System.Drawing.Size(210, 55);
            this.Button_CopyToClipboard.TabIndex = 7;
            this.Button_CopyToClipboard.Text = "Копировать в буфер обмена";
            this.Button_CopyToClipboard.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_CopyToClipboard.UseVisualStyleBackColor = true;
            this.Button_CopyToClipboard.Click += new System.EventHandler(this.Button_CopyToClipboard_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(728, 500);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.Button_SaveToBase64);
            this.tabPage1.Controls.Add(this.TextBox_FileToBase64);
            this.tabPage1.Controls.Add(this.Button_Close);
            this.tabPage1.Controls.Add(this.Button_CopyToClipboard);
            this.tabPage1.Controls.Add(this.Label_FileInBase64);
            this.tabPage1.Controls.Add(this.Button_OpenFile);
            this.tabPage1.Controls.Add(this.Label_ChooseFile);
            this.tabPage1.Controls.Add(this.TextBox_PathToFile);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(720, 467);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Файл -> Base64";
            // 
            // Button_SaveToBase64
            // 
            this.Button_SaveToBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_SaveToBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SaveToBase64.Image = ((System.Drawing.Image)(resources.GetObject("Button_SaveToBase64.Image")));
            this.Button_SaveToBase64.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_SaveToBase64.Location = new System.Drawing.Point(222, 406);
            this.Button_SaveToBase64.Name = "Button_SaveToBase64";
            this.Button_SaveToBase64.Size = new System.Drawing.Size(210, 55);
            this.Button_SaveToBase64.TabIndex = 8;
            this.Button_SaveToBase64.Text = "Сохранить в формате Base64";
            this.Button_SaveToBase64.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_SaveToBase64.UseVisualStyleBackColor = true;
            this.Button_SaveToBase64.Click += new System.EventHandler(this.Button_SaveToBase64_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.Button_RecoverFromBase64);
            this.tabPage2.Controls.Add(this.Label_FileInBase64_2);
            this.tabPage2.Controls.Add(this.Button_OpenFile2);
            this.tabPage2.Controls.Add(this.Label_ChooseFile2);
            this.tabPage2.Controls.Add(this.TextBox_PathToFile2);
            this.tabPage2.Controls.Add(this.TextBox_Base64ToFile);
            this.tabPage2.Controls.Add(this.Button_Close2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(720, 467);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Base64 -> Файл";
            // 
            // Button_RecoverFromBase64
            // 
            this.Button_RecoverFromBase64.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_RecoverFromBase64.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_RecoverFromBase64.Image = ((System.Drawing.Image)(resources.GetObject("Button_RecoverFromBase64.Image")));
            this.Button_RecoverFromBase64.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_RecoverFromBase64.Location = new System.Drawing.Point(6, 406);
            this.Button_RecoverFromBase64.Name = "Button_RecoverFromBase64";
            this.Button_RecoverFromBase64.Size = new System.Drawing.Size(210, 55);
            this.Button_RecoverFromBase64.TabIndex = 11;
            this.Button_RecoverFromBase64.Text = "Восстановить выбранный файл";
            this.Button_RecoverFromBase64.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Button_RecoverFromBase64.UseVisualStyleBackColor = true;
            this.Button_RecoverFromBase64.Click += new System.EventHandler(this.Button_RecoverFromBase64_Click);
            // 
            // Label_FileInBase64_2
            // 
            this.Label_FileInBase64_2.AutoSize = true;
            this.Label_FileInBase64_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_FileInBase64_2.Location = new System.Drawing.Point(2, 66);
            this.Label_FileInBase64_2.Name = "Label_FileInBase64_2";
            this.Label_FileInBase64_2.Size = new System.Drawing.Size(321, 20);
            this.Label_FileInBase64_2.TabIndex = 10;
            this.Label_FileInBase64_2.Text = "Выбранный файл в формате Base64:";
            // 
            // Button_OpenFile2
            // 
            this.Button_OpenFile2.Image = ((System.Drawing.Image)(resources.GetObject("Button_OpenFile2.Image")));
            this.Button_OpenFile2.Location = new System.Drawing.Point(673, 19);
            this.Button_OpenFile2.Name = "Button_OpenFile2";
            this.Button_OpenFile2.Size = new System.Drawing.Size(40, 40);
            this.Button_OpenFile2.TabIndex = 7;
            this.Button_OpenFile2.UseVisualStyleBackColor = true;
            this.Button_OpenFile2.Click += new System.EventHandler(this.Button_OpenFile2_Click);
            // 
            // Label_ChooseFile2
            // 
            this.Label_ChooseFile2.AutoSize = true;
            this.Label_ChooseFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ChooseFile2.Location = new System.Drawing.Point(2, 3);
            this.Label_ChooseFile2.Name = "Label_ChooseFile2";
            this.Label_ChooseFile2.Size = new System.Drawing.Size(409, 20);
            this.Label_ChooseFile2.TabIndex = 9;
            this.Label_ChooseFile2.Text = "Файл для восстановления из формата Base64:";
            // 
            // TextBox_PathToFile2
            // 
            this.TextBox_PathToFile2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_PathToFile2.Location = new System.Drawing.Point(6, 26);
            this.TextBox_PathToFile2.Name = "TextBox_PathToFile2";
            this.TextBox_PathToFile2.Size = new System.Drawing.Size(661, 27);
            this.TextBox_PathToFile2.TabIndex = 8;
            // 
            // TextBox_Base64ToFile
            // 
            this.TextBox_Base64ToFile.Location = new System.Drawing.Point(6, 89);
            this.TextBox_Base64ToFile.MaxLength = 0;
            this.TextBox_Base64ToFile.Multiline = true;
            this.TextBox_Base64ToFile.Name = "TextBox_Base64ToFile";
            this.TextBox_Base64ToFile.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Base64ToFile.Size = new System.Drawing.Size(707, 311);
            this.TextBox_Base64ToFile.TabIndex = 6;
            // 
            // Button_Close2
            // 
            this.Button_Close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close2.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close2.Image")));
            this.Button_Close2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Close2.Location = new System.Drawing.Point(503, 406);
            this.Button_Close2.Name = "Button_Close2";
            this.Button_Close2.Size = new System.Drawing.Size(210, 55);
            this.Button_Close2.TabIndex = 1;
            this.Button_Close2.Text = "Закрыть";
            this.Button_Close2.UseVisualStyleBackColor = true;
            this.Button_Close2.Click += new System.EventHandler(this.Button_Close2_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.Label_ProgramName);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Controls.Add(this.Button_Close3);
            this.tabPage3.Controls.Add(this.TextBox_About);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(720, 467);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "О программе";
            // 
            // Label_ProgramName
            // 
            this.Label_ProgramName.AutoSize = true;
            this.Label_ProgramName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Label_ProgramName.Location = new System.Drawing.Point(30, 48);
            this.Label_ProgramName.Name = "Label_ProgramName";
            this.Label_ProgramName.Size = new System.Drawing.Size(246, 20);
            this.Label_ProgramName.TabIndex = 4;
            this.Label_ProgramName.Text = "Any2Base64 Converter v.1.0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(613, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Button_Close3
            // 
            this.Button_Close3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Close3.Image = ((System.Drawing.Image)(resources.GetObject("Button_Close3.Image")));
            this.Button_Close3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Button_Close3.Location = new System.Drawing.Point(503, 406);
            this.Button_Close3.Name = "Button_Close3";
            this.Button_Close3.Size = new System.Drawing.Size(210, 55);
            this.Button_Close3.TabIndex = 2;
            this.Button_Close3.Text = "Закрыть";
            this.Button_Close3.UseVisualStyleBackColor = true;
            this.Button_Close3.Click += new System.EventHandler(this.Button_Close3_Click);
            // 
            // TextBox_About
            // 
            this.TextBox_About.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TextBox_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBox_About.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_About.Location = new System.Drawing.Point(34, 92);
            this.TextBox_About.Multiline = true;
            this.TextBox_About.Name = "TextBox_About";
            this.TextBox_About.ReadOnly = true;
            this.TextBox_About.Size = new System.Drawing.Size(649, 292);
            this.TextBox_About.TabIndex = 0;
            this.TextBox_About.Text = "Конвертер любых файлов в формат Base64 и обратно.\r\nАвтор: Банков Михаил aka PC_US" +
    "ER.\r\nE-mail: pcuser@internet.ru\r\nGithub: https://github.com/Mikhail-Bankov";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(732, 505);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Any2Base64 Converter";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_OpenFile;
        private System.Windows.Forms.TextBox TextBox_PathToFile;
        private System.Windows.Forms.Label Label_ChooseFile;
        private System.Windows.Forms.TextBox TextBox_FileToBase64;
        private System.Windows.Forms.Label Label_FileInBase64;
        private System.Windows.Forms.Button Button_CopyToClipboard;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox TextBox_About;
        private System.Windows.Forms.Button Button_Close2;
        private System.Windows.Forms.Button Button_Close3;
        private System.Windows.Forms.TextBox TextBox_Base64ToFile;
        private System.Windows.Forms.Button Button_SaveToBase64;
        private System.Windows.Forms.Button Button_OpenFile2;
        private System.Windows.Forms.Label Label_ChooseFile2;
        private System.Windows.Forms.TextBox TextBox_PathToFile2;
        private System.Windows.Forms.Label Label_FileInBase64_2;
        private System.Windows.Forms.Button Button_RecoverFromBase64;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_ProgramName;
    }
}


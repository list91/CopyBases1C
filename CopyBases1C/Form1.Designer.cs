﻿namespace CopyBases1C
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_ReadBasesList = new System.Windows.Forms.Button();
            this.button_CopyBases = new System.Windows.Forms.Button();
            this.textBox_BasesList = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_FolderCopy = new System.Windows.Forms.TextBox();
            this.listBox_Bases = new System.Windows.Forms.ListBox();
            this.textBox_debug = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_SaveBoth = new System.Windows.Forms.RadioButton();
            this.radioButton_Replace = new System.Windows.Forms.RadioButton();
            this.radioButton_NotCopy = new System.Windows.Forms.RadioButton();
            this.button_OpenFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button_SelectBasesList = new System.Windows.Forms.Button();
            this.button_SelectFolderCopy = new System.Windows.Forms.Button();
            this.checkBox_OpenFolder = new System.Windows.Forms.CheckBox();
            this.label_Version = new System.Windows.Forms.Label();
            this.textBoxZipName = new System.Windows.Forms.TextBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Файл списка баз:";
            // 
            // button_ReadBasesList
            // 
            this.button_ReadBasesList.Location = new System.Drawing.Point(451, 4);
            this.button_ReadBasesList.Name = "button_ReadBasesList";
            this.button_ReadBasesList.Size = new System.Drawing.Size(113, 23);
            this.button_ReadBasesList.TabIndex = 2;
            this.button_ReadBasesList.Text = "Обновить список";
            this.button_ReadBasesList.UseVisualStyleBackColor = true;
            this.button_ReadBasesList.Click += new System.EventHandler(this.button_ReadBasesList_Click);
            // 
            // button_CopyBases
            // 
            this.button_CopyBases.Location = new System.Drawing.Point(451, 33);
            this.button_CopyBases.Name = "button_CopyBases";
            this.button_CopyBases.Size = new System.Drawing.Size(113, 23);
            this.button_CopyBases.TabIndex = 3;
            this.button_CopyBases.Text = "Скопровать базы";
            this.button_CopyBases.UseVisualStyleBackColor = true;
            this.button_CopyBases.Click += new System.EventHandler(this.button_CopyBases_Click);
            // 
            // textBox_BasesList
            // 
            this.textBox_BasesList.Location = new System.Drawing.Point(150, 6);
            this.textBox_BasesList.Name = "textBox_BasesList";
            this.textBox_BasesList.Size = new System.Drawing.Size(263, 20);
            this.textBox_BasesList.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.label2.Location = new System.Drawing.Point(12, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Путь к копиям:";
            // 
            // textBox_FolderCopy
            // 
            this.textBox_FolderCopy.Location = new System.Drawing.Point(150, 35);
            this.textBox_FolderCopy.Name = "textBox_FolderCopy";
            this.textBox_FolderCopy.Size = new System.Drawing.Size(263, 20);
            this.textBox_FolderCopy.TabIndex = 5;
            this.textBox_FolderCopy.TextChanged += new System.EventHandler(this.textBox_FolderCopy_TextChanged);
            this.textBox_FolderCopy.Leave += new System.EventHandler(this.textBox_FolderCopy_Leave);
            // 
            // listBox_Bases
            // 
            this.listBox_Bases.FormattingEnabled = true;
            this.listBox_Bases.Items.AddRange(new object[] {
            "Пусто"});
            this.listBox_Bases.Location = new System.Drawing.Point(150, 119);
            this.listBox_Bases.Name = "listBox_Bases";
            this.listBox_Bases.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listBox_Bases.Size = new System.Drawing.Size(295, 212);
            this.listBox_Bases.TabIndex = 0;
            this.listBox_Bases.SelectedIndexChanged += new System.EventHandler(this.listBox_Bases_SelectedIndexChanged);
            // 
            // textBox_debug
            // 
            this.textBox_debug.Enabled = false;
            this.textBox_debug.Location = new System.Drawing.Point(12, 337);
            this.textBox_debug.Multiline = true;
            this.textBox_debug.Name = "textBox_debug";
            this.textBox_debug.Size = new System.Drawing.Size(549, 57);
            this.textBox_debug.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_SaveBoth);
            this.groupBox1.Controls.Add(this.radioButton_Replace);
            this.groupBox1.Controls.Add(this.radioButton_NotCopy);
            this.groupBox1.Location = new System.Drawing.Point(452, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(112, 107);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Если копия уже есть:";
            // 
            // radioButton_SaveBoth
            // 
            this.radioButton_SaveBoth.AutoSize = true;
            this.radioButton_SaveBoth.Location = new System.Drawing.Point(6, 79);
            this.radioButton_SaveBoth.Name = "radioButton_SaveBoth";
            this.radioButton_SaveBoth.Size = new System.Drawing.Size(99, 17);
            this.radioButton_SaveBoth.TabIndex = 0;
            this.radioButton_SaveBoth.Text = "Сохранить оба";
            this.radioButton_SaveBoth.UseVisualStyleBackColor = true;
            // 
            // radioButton_Replace
            // 
            this.radioButton_Replace.AutoSize = true;
            this.radioButton_Replace.Location = new System.Drawing.Point(7, 56);
            this.radioButton_Replace.Name = "radioButton_Replace";
            this.radioButton_Replace.Size = new System.Drawing.Size(75, 17);
            this.radioButton_Replace.TabIndex = 0;
            this.radioButton_Replace.Text = "Заменить";
            this.radioButton_Replace.UseVisualStyleBackColor = true;
            // 
            // radioButton_NotCopy
            // 
            this.radioButton_NotCopy.AutoSize = true;
            this.radioButton_NotCopy.Checked = true;
            this.radioButton_NotCopy.Location = new System.Drawing.Point(7, 33);
            this.radioButton_NotCopy.Name = "radioButton_NotCopy";
            this.radioButton_NotCopy.Size = new System.Drawing.Size(101, 17);
            this.radioButton_NotCopy.TabIndex = 0;
            this.radioButton_NotCopy.TabStop = true;
            this.radioButton_NotCopy.Text = "Не копировать";
            this.radioButton_NotCopy.UseVisualStyleBackColor = true;
            // 
            // button_OpenFolder
            // 
            this.button_OpenFolder.Location = new System.Drawing.Point(451, 250);
            this.button_OpenFolder.Name = "button_OpenFolder";
            this.button_OpenFolder.Size = new System.Drawing.Size(113, 23);
            this.button_OpenFolder.TabIndex = 3;
            this.button_OpenFolder.Text = "Открыть копии";
            this.button_OpenFolder.UseVisualStyleBackColor = true;
            this.button_OpenFolder.Click += new System.EventHandler(this.button_OpenFolder_Click);
            // 
            // button_SelectBasesList
            // 
            this.button_SelectBasesList.Location = new System.Drawing.Point(419, 4);
            this.button_SelectBasesList.Name = "button_SelectBasesList";
            this.button_SelectBasesList.Size = new System.Drawing.Size(26, 23);
            this.button_SelectBasesList.TabIndex = 9;
            this.button_SelectBasesList.Text = "...";
            this.button_SelectBasesList.UseVisualStyleBackColor = true;
            this.button_SelectBasesList.Click += new System.EventHandler(this.button_SelectBasesList_Click);
            // 
            // button_SelectFolderCopy
            // 
            this.button_SelectFolderCopy.Location = new System.Drawing.Point(419, 33);
            this.button_SelectFolderCopy.Name = "button_SelectFolderCopy";
            this.button_SelectFolderCopy.Size = new System.Drawing.Size(26, 23);
            this.button_SelectFolderCopy.TabIndex = 9;
            this.button_SelectFolderCopy.Text = "...";
            this.button_SelectFolderCopy.UseVisualStyleBackColor = true;
            this.button_SelectFolderCopy.Click += new System.EventHandler(this.button_SelectFolderCopy_Click);
            // 
            // checkBox_OpenFolder
            // 
            this.checkBox_OpenFolder.AutoSize = true;
            this.checkBox_OpenFolder.Checked = true;
            this.checkBox_OpenFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_OpenFolder.Location = new System.Drawing.Point(452, 201);
            this.checkBox_OpenFolder.Name = "checkBox_OpenFolder";
            this.checkBox_OpenFolder.Size = new System.Drawing.Size(100, 43);
            this.checkBox_OpenFolder.TabIndex = 10;
            this.checkBox_OpenFolder.Text = "По окончании \r\nкопирования \r\nоткрыть папку";
            this.checkBox_OpenFolder.UseVisualStyleBackColor = true;
            // 
            // label_Version
            // 
            this.label_Version.AutoSize = true;
            this.label_Version.Location = new System.Drawing.Point(12, 397);
            this.label_Version.Name = "label_Version";
            this.label_Version.Size = new System.Drawing.Size(35, 13);
            this.label_Version.TabIndex = 11;
            this.label_Version.Text = "label3";
            // 
            // textBoxZipName
            // 
            this.textBoxZipName.Location = new System.Drawing.Point(150, 63);
            this.textBoxZipName.Name = "textBoxZipName";
            this.textBoxZipName.Size = new System.Drawing.Size(192, 20);
            this.textBoxZipName.TabIndex = 12;
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(150, 89);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(192, 20);
            this.textBoxFileName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.label3.Location = new System.Drawing.Point(12, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Имя архива";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Имя файла";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(12, 148);
            this.trackBar1.Maximum = 9;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(132, 45);
            this.trackBar1.TabIndex = 18;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Default;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Уровень сжатия";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Cursor = System.Windows.Forms.Cursors.Default;
            this.label6.Location = new System.Drawing.Point(109, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 417);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trackBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.textBoxZipName);
            this.Controls.Add(this.label_Version);
            this.Controls.Add(this.checkBox_OpenFolder);
            this.Controls.Add(this.button_SelectFolderCopy);
            this.Controls.Add(this.button_SelectBasesList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_debug);
            this.Controls.Add(this.textBox_FolderCopy);
            this.Controls.Add(this.textBox_BasesList);
            this.Controls.Add(this.button_OpenFolder);
            this.Controls.Add(this.button_CopyBases);
            this.Controls.Add(this.button_ReadBasesList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox_Bases);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Копирование баз 1С";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_ReadBasesList;
        private System.Windows.Forms.Button button_CopyBases;
        private System.Windows.Forms.TextBox textBox_BasesList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_FolderCopy;
        private System.Windows.Forms.ListBox listBox_Bases;
        private System.Windows.Forms.TextBox textBox_debug;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_SaveBoth;
        private System.Windows.Forms.RadioButton radioButton_Replace;
        private System.Windows.Forms.RadioButton radioButton_NotCopy;
        private System.Windows.Forms.Button button_OpenFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button_SelectBasesList;
        private System.Windows.Forms.Button button_SelectFolderCopy;
        private System.Windows.Forms.CheckBox checkBox_OpenFolder;
        private System.Windows.Forms.Label label_Version;
        private System.Windows.Forms.TextBox textBoxZipName;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}


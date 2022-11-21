namespace FileHadler
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
            this.cboSystemDrives = new System.Windows.Forms.ComboBox();
            this.txtSystemDetails = new System.Windows.Forms.TextBox();
            this.btnCreateDirectory = new System.Windows.Forms.Button();
            this.txtNewDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNewSubDirectory = new System.Windows.Forms.TextBox();
            this.btnCreateSubDirectory = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboDirectoryFile = new System.Windows.Forms.ComboBox();
            this.btnShowDF = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCopy = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCDDestination = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCDSource = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNewFile = new System.Windows.Forms.TextBox();
            this.btnNewFile = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSelectedFile = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label9 = new System.Windows.Forms.Label();
            this.txtRenameFile = new System.Windows.Forms.TextBox();
            this.btnRenameFile = new System.Windows.Forms.Button();
            this.txtUpdate = new System.Windows.Forms.TextBox();
            this.txtFind = new System.Windows.Forms.TextBox();
            this.txtRead = new System.Windows.Forms.TextBox();
            this.txtWrite = new System.Windows.Forms.TextBox();
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnFine = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboSystemDrives
            // 
            this.cboSystemDrives.FormattingEnabled = true;
            this.cboSystemDrives.Location = new System.Drawing.Point(18, 36);
            this.cboSystemDrives.Margin = new System.Windows.Forms.Padding(2);
            this.cboSystemDrives.Name = "cboSystemDrives";
            this.cboSystemDrives.Size = new System.Drawing.Size(424, 28);
            this.cboSystemDrives.TabIndex = 0;
            this.cboSystemDrives.SelectedIndexChanged += new System.EventHandler(this.cboSystemDrives_SelectedIndexChanged);
            // 
            // txtSystemDetails
            // 
            this.txtSystemDetails.Location = new System.Drawing.Point(18, 109);
            this.txtSystemDetails.Margin = new System.Windows.Forms.Padding(2);
            this.txtSystemDetails.Multiline = true;
            this.txtSystemDetails.Name = "txtSystemDetails";
            this.txtSystemDetails.Size = new System.Drawing.Size(424, 202);
            this.txtSystemDetails.TabIndex = 1;
            // 
            // btnCreateDirectory
            // 
            this.btnCreateDirectory.Location = new System.Drawing.Point(1105, 51);
            this.btnCreateDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateDirectory.Name = "btnCreateDirectory";
            this.btnCreateDirectory.Size = new System.Drawing.Size(173, 27);
            this.btnCreateDirectory.TabIndex = 2;
            this.btnCreateDirectory.Text = "Create Directory";
            this.btnCreateDirectory.UseVisualStyleBackColor = true;
            this.btnCreateDirectory.Click += new System.EventHandler(this.btnCreateDirectory_Click);
            // 
            // txtNewDirectory
            // 
            this.txtNewDirectory.Location = new System.Drawing.Point(706, 51);
            this.txtNewDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewDirectory.Name = "txtNewDirectory";
            this.txtNewDirectory.Size = new System.Drawing.Size(372, 27);
            this.txtNewDirectory.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(486, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "New Directory(include path)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(486, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "New Sub Directory";
            // 
            // txtNewSubDirectory
            // 
            this.txtNewSubDirectory.Location = new System.Drawing.Point(706, 106);
            this.txtNewSubDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewSubDirectory.Name = "txtNewSubDirectory";
            this.txtNewSubDirectory.Size = new System.Drawing.Size(372, 27);
            this.txtNewSubDirectory.TabIndex = 6;
            // 
            // btnCreateSubDirectory
            // 
            this.btnCreateSubDirectory.Location = new System.Drawing.Point(1105, 111);
            this.btnCreateSubDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.btnCreateSubDirectory.Name = "btnCreateSubDirectory";
            this.btnCreateSubDirectory.Size = new System.Drawing.Size(173, 27);
            this.btnCreateSubDirectory.TabIndex = 5;
            this.btnCreateSubDirectory.Text = "Create Sub Directory";
            this.btnCreateSubDirectory.UseVisualStyleBackColor = true;
            this.btnCreateSubDirectory.Click += new System.EventHandler(this.btnCreateSubDirectory_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(486, 179);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Show directory details";
            // 
            // cboDirectoryFile
            // 
            this.cboDirectoryFile.FormattingEnabled = true;
            this.cboDirectoryFile.Location = new System.Drawing.Point(706, 173);
            this.cboDirectoryFile.Margin = new System.Windows.Forms.Padding(2);
            this.cboDirectoryFile.Name = "cboDirectoryFile";
            this.cboDirectoryFile.Size = new System.Drawing.Size(372, 28);
            this.cboDirectoryFile.TabIndex = 9;
            // 
            // btnShowDF
            // 
            this.btnShowDF.Location = new System.Drawing.Point(1105, 172);
            this.btnShowDF.Margin = new System.Windows.Forms.Padding(2);
            this.btnShowDF.Name = "btnShowDF";
            this.btnShowDF.Size = new System.Drawing.Size(173, 27);
            this.btnShowDF.TabIndex = 10;
            this.btnShowDF.Text = "Show directory files";
            this.btnShowDF.UseVisualStyleBackColor = true;
            this.btnShowDF.Click += new System.EventHandler(this.btnShowDF_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCopy);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCDDestination);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCDSource);
            this.panel1.Location = new System.Drawing.Point(486, 218);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 138);
            this.panel1.TabIndex = 11;
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(617, 41);
            this.btnCopy.Margin = new System.Windows.Forms.Padding(2);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(173, 64);
            this.btnCopy.TabIndex = 12;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(24, 85);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Destination";
            // 
            // txtCDDestination
            // 
            this.txtCDDestination.Location = new System.Drawing.Point(221, 80);
            this.txtCDDestination.Margin = new System.Windows.Forms.Padding(2);
            this.txtCDDestination.Name = "txtCDDestination";
            this.txtCDDestination.Size = new System.Drawing.Size(372, 27);
            this.txtCDDestination.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(24, 48);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Source";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(27, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 25);
            this.label4.TabIndex = 12;
            this.label4.Text = "Copy directory";
            // 
            // txtCDSource
            // 
            this.txtCDSource.Location = new System.Drawing.Point(221, 43);
            this.txtCDSource.Margin = new System.Windows.Forms.Padding(2);
            this.txtCDSource.Name = "txtCDSource";
            this.txtCDSource.Size = new System.Drawing.Size(372, 27);
            this.txtCDSource.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(486, 395);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(167, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "New File(include path)";
            // 
            // txtNewFile
            // 
            this.txtNewFile.Location = new System.Drawing.Point(706, 390);
            this.txtNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtNewFile.Name = "txtNewFile";
            this.txtNewFile.Size = new System.Drawing.Size(372, 27);
            this.txtNewFile.TabIndex = 13;
            // 
            // btnNewFile
            // 
            this.btnNewFile.Location = new System.Drawing.Point(1102, 388);
            this.btnNewFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnNewFile.Name = "btnNewFile";
            this.btnNewFile.Size = new System.Drawing.Size(173, 27);
            this.btnNewFile.TabIndex = 12;
            this.btnNewFile.Text = "Create New file";
            this.btnNewFile.UseVisualStyleBackColor = true;
            this.btnNewFile.Click += new System.EventHandler(this.btnNewFile_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(486, 434);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Select file";
            // 
            // txtSelectedFile
            // 
            this.txtSelectedFile.Location = new System.Drawing.Point(706, 429);
            this.txtSelectedFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtSelectedFile.Name = "txtSelectedFile";
            this.txtSelectedFile.Size = new System.Drawing.Size(372, 27);
            this.txtSelectedFile.TabIndex = 16;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(1102, 426);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(173, 27);
            this.btnOpenFile.TabIndex = 15;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(486, 474);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Rename file";
            // 
            // txtRenameFile
            // 
            this.txtRenameFile.Location = new System.Drawing.Point(706, 470);
            this.txtRenameFile.Margin = new System.Windows.Forms.Padding(2);
            this.txtRenameFile.Name = "txtRenameFile";
            this.txtRenameFile.Size = new System.Drawing.Size(372, 27);
            this.txtRenameFile.TabIndex = 19;
            // 
            // btnRenameFile
            // 
            this.btnRenameFile.Location = new System.Drawing.Point(1102, 467);
            this.btnRenameFile.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenameFile.Name = "btnRenameFile";
            this.btnRenameFile.Size = new System.Drawing.Size(173, 27);
            this.btnRenameFile.TabIndex = 18;
            this.btnRenameFile.Text = "Rename File";
            this.btnRenameFile.UseVisualStyleBackColor = true;
            this.btnRenameFile.Click += new System.EventHandler(this.btnRenameFile_Click);
            // 
            // txtUpdate
            // 
            this.txtUpdate.Location = new System.Drawing.Point(862, 594);
            this.txtUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.txtUpdate.Multiline = true;
            this.txtUpdate.Name = "txtUpdate";
            this.txtUpdate.Size = new System.Drawing.Size(235, 190);
            this.txtUpdate.TabIndex = 21;
            // 
            // txtFind
            // 
            this.txtFind.Location = new System.Drawing.Point(571, 594);
            this.txtFind.Margin = new System.Windows.Forms.Padding(2);
            this.txtFind.Multiline = true;
            this.txtFind.Name = "txtFind";
            this.txtFind.Size = new System.Drawing.Size(235, 190);
            this.txtFind.TabIndex = 22;
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(308, 594);
            this.txtRead.Margin = new System.Windows.Forms.Padding(2);
            this.txtRead.Multiline = true;
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(235, 190);
            this.txtRead.TabIndex = 23;
            // 
            // txtWrite
            // 
            this.txtWrite.Location = new System.Drawing.Point(34, 594);
            this.txtWrite.Margin = new System.Windows.Forms.Padding(2);
            this.txtWrite.Multiline = true;
            this.txtWrite.Name = "txtWrite";
            this.txtWrite.Size = new System.Drawing.Size(235, 190);
            this.txtWrite.TabIndex = 24;
            // 
            // btnWrite
            // 
            this.btnWrite.Location = new System.Drawing.Point(34, 797);
            this.btnWrite.Margin = new System.Windows.Forms.Padding(2);
            this.btnWrite.Name = "btnWrite";
            this.btnWrite.Size = new System.Drawing.Size(90, 27);
            this.btnWrite.TabIndex = 25;
            this.btnWrite.Text = "Write";
            this.btnWrite.UseVisualStyleBackColor = true;
            this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(308, 797);
            this.btnRead.Margin = new System.Windows.Forms.Padding(2);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(90, 27);
            this.btnRead.TabIndex = 26;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnFine
            // 
            this.btnFine.Location = new System.Drawing.Point(571, 797);
            this.btnFine.Margin = new System.Windows.Forms.Padding(2);
            this.btnFine.Name = "btnFine";
            this.btnFine.Size = new System.Drawing.Size(90, 27);
            this.btnFine.TabIndex = 27;
            this.btnFine.Text = "Find";
            this.btnFine.UseVisualStyleBackColor = true;
            this.btnFine.Click += new System.EventHandler(this.btnFine_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(862, 797);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 27);
            this.btnUpdate.TabIndex = 28;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(34, 554);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 20);
            this.label10.TabIndex = 29;
            this.label10.Text = "Write";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(308, 554);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Read";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(571, 554);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(39, 20);
            this.label12.TabIndex = 31;
            this.label12.Text = "Find";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label13.Location = new System.Drawing.Point(862, 554);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Update";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1309, 840);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnFine);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnWrite);
            this.Controls.Add(this.txtWrite);
            this.Controls.Add(this.txtRead);
            this.Controls.Add(this.txtFind);
            this.Controls.Add(this.txtUpdate);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtRenameFile);
            this.Controls.Add(this.btnRenameFile);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSelectedFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtNewFile);
            this.Controls.Add(this.btnNewFile);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnShowDF);
            this.Controls.Add(this.cboDirectoryFile);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNewSubDirectory);
            this.Controls.Add(this.btnCreateSubDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNewDirectory);
            this.Controls.Add(this.btnCreateDirectory);
            this.Controls.Add(this.txtSystemDetails);
            this.Controls.Add(this.cboSystemDrives);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "File Handler";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cboSystemDrives;
        private TextBox txtSystemDetails;
        private Button btnCreateDirectory;
        private TextBox txtNewDirectory;
        private Label label1;
        private Label label2;
        private TextBox txtNewSubDirectory;
        private Button btnCreateSubDirectory;
        private Label label3;
        private ComboBox cboDirectoryFile;
        private Button btnShowDF;
        private Panel panel1;
        private Button btnCopy;
        private Label label6;
        private TextBox txtCDDestination;
        private Label label5;
        private Label label4;
        private TextBox txtCDSource;
        private Label label7;
        private TextBox txtNewFile;
        private Button btnNewFile;
        private Label label8;
        private TextBox txtSelectedFile;
        private Button btnOpenFile;
        private OpenFileDialog openFileDialog1;
        private Label label9;
        private TextBox txtRenameFile;
        private Button btnRenameFile;
        private TextBox txtUpdate;
        private TextBox txtFind;
        private TextBox txtRead;
        private TextBox txtWrite;
        private Button btnWrite;
        private Button btnRead;
        private Button btnFine;
        private Button btnUpdate;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}
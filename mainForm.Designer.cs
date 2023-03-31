
namespace Hyria_MyFS
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Control, null);
            this.duckIMG = new System.Windows.Forms.PictureBox();
            this.fsList = new System.Windows.Forms.ListView();
            this.FSLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLAttributes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.rmvButton = new System.Windows.Forms.Button();
            this.filenameBox = new System.Windows.Forms.TextBox();
            this.filesizeBox = new System.Windows.Forms.TextBox();
            this.fsSecLabel = new System.Windows.Forms.Label();
            this.appBanner = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.sectorSizBox = new System.Windows.Forms.TextBox();
            this.sectorSizLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.hiddenChkBox = new System.Windows.Forms.CheckBox();
            this.readChkBox = new System.Windows.Forms.CheckBox();
            this.extnsionBox = new System.Windows.Forms.TextBox();
            this.extnsionLabel = new System.Windows.Forms.Label();
            this.authorChkBox = new System.Windows.Forms.CheckBox();
            this.authBox = new System.Windows.Forms.TextBox();
            this.listofSectors = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FSLSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.duckIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // duckIMG
            // 
            this.duckIMG.Image = ((System.Drawing.Image)(resources.GetObject("duckIMG.Image")));
            this.duckIMG.Location = new System.Drawing.Point(12, 12);
            this.duckIMG.Name = "duckIMG";
            this.duckIMG.Size = new System.Drawing.Size(139, 90);
            this.duckIMG.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.duckIMG.TabIndex = 0;
            this.duckIMG.TabStop = false;
            this.duckIMG.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // fsList
            // 
            this.fsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FSLName,
            this.FSExtension,
            this.FSLSize,
            this.FSLAttributes,
            this.FSLSector});
            this.fsList.HideSelection = false;
            listViewItem1.ToolTipText = "Current files in File System";
            this.fsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.fsList.Location = new System.Drawing.Point(520, 66);
            this.fsList.Name = "fsList";
            this.fsList.Size = new System.Drawing.Size(359, 380);
            this.fsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.fsList.TabIndex = 1;
            this.fsList.UseCompatibleStateImageBehavior = false;
            this.fsList.View = System.Windows.Forms.View.Details;
            // 
            // FSLName
            // 
            this.FSLName.Text = "Filename";
            this.FSLName.Width = 70;
            // 
            // FSExtension
            // 
            this.FSExtension.Text = "Extension";
            this.FSExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSExtension.Width = 70;
            // 
            // FSLSize
            // 
            this.FSLSize.Text = "Size";
            this.FSLSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLSize.Width = 70;
            // 
            // FSLAttributes
            // 
            this.FSLAttributes.Text = "Attributes";
            this.FSLAttributes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLAttributes.Width = 70;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(9, 205);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "File Name:";
            this.fileNameLabel.Click += new System.EventHandler(this.selFile1_Click);
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(9, 283);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(47, 13);
            this.fileSizeLabel.TabIndex = 3;
            this.fileSizeLabel.Text = "File size:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 405);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // rmvButton
            // 
            this.rmvButton.Location = new System.Drawing.Point(337, 375);
            this.rmvButton.Name = "rmvButton";
            this.rmvButton.Size = new System.Drawing.Size(75, 23);
            this.rmvButton.TabIndex = 6;
            this.rmvButton.Text = "Remove";
            this.rmvButton.UseVisualStyleBackColor = true;
            // 
            // filenameBox
            // 
            this.filenameBox.Location = new System.Drawing.Point(12, 221);
            this.filenameBox.Name = "filenameBox";
            this.filenameBox.Size = new System.Drawing.Size(100, 20);
            this.filenameBox.TabIndex = 8;
            // 
            // filesizeBox
            // 
            this.filesizeBox.Location = new System.Drawing.Point(12, 299);
            this.filesizeBox.Name = "filesizeBox";
            this.filesizeBox.Size = new System.Drawing.Size(100, 20);
            this.filesizeBox.TabIndex = 9;
            // 
            // fsSecLabel
            // 
            this.fsSecLabel.AutoSize = true;
            this.fsSecLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsSecLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.fsSecLabel.Location = new System.Drawing.Point(270, 136);
            this.fsSecLabel.Name = "fsSecLabel";
            this.fsSecLabel.Size = new System.Drawing.Size(204, 31);
            this.fsSecLabel.TabIndex = 10;
            this.fsSecLabel.Text = "File System Listbox";
            this.fsSecLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // appBanner
            // 
            this.appBanner.AutoSize = true;
            this.appBanner.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.appBanner.Location = new System.Drawing.Point(157, 9);
            this.appBanner.Name = "appBanner";
            this.appBanner.Size = new System.Drawing.Size(220, 31);
            this.appBanner.TabIndex = 11;
            this.appBanner.Text = "Razie\'s File Manager ";
            this.appBanner.Click += new System.EventHandler(this.label4_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 476);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // sectorSizBox
            // 
            this.sectorSizBox.Location = new System.Drawing.Point(79, 119);
            this.sectorSizBox.Name = "sectorSizBox";
            this.sectorSizBox.ReadOnly = true;
            this.sectorSizBox.Size = new System.Drawing.Size(55, 20);
            this.sectorSizBox.TabIndex = 13;
            this.sectorSizBox.Text = "500";
            // 
            // sectorSizLabel
            // 
            this.sectorSizLabel.AutoSize = true;
            this.sectorSizLabel.Location = new System.Drawing.Point(12, 122);
            this.sectorSizLabel.Name = "sectorSizLabel";
            this.sectorSizLabel.Size = new System.Drawing.Size(61, 13);
            this.sectorSizLabel.TabIndex = 14;
            this.sectorSizLabel.Text = "Sector Size";
            this.sectorSizLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // instructionLabel
            // 
            this.instructionLabel.AutoSize = true;
            this.instructionLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabel.ForeColor = System.Drawing.Color.Black;
            this.instructionLabel.Location = new System.Drawing.Point(9, 170);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(201, 17);
            this.instructionLabel.TabIndex = 15;
            this.instructionLabel.Text = "Complete the following form:";
            // 
            // hiddenChkBox
            // 
            this.hiddenChkBox.AutoSize = true;
            this.hiddenChkBox.Location = new System.Drawing.Point(15, 327);
            this.hiddenChkBox.Name = "hiddenChkBox";
            this.hiddenChkBox.Size = new System.Drawing.Size(66, 17);
            this.hiddenChkBox.TabIndex = 16;
            this.hiddenChkBox.Text = "Hidden?";
            this.hiddenChkBox.UseVisualStyleBackColor = true;
            // 
            // readChkBox
            // 
            this.readChkBox.AutoSize = true;
            this.readChkBox.Location = new System.Drawing.Point(15, 350);
            this.readChkBox.Name = "readChkBox";
            this.readChkBox.Size = new System.Drawing.Size(80, 17);
            this.readChkBox.TabIndex = 17;
            this.readChkBox.Text = "Read only?";
            this.readChkBox.UseVisualStyleBackColor = true;
            // 
            // extnsionBox
            // 
            this.extnsionBox.Location = new System.Drawing.Point(12, 260);
            this.extnsionBox.Name = "extnsionBox";
            this.extnsionBox.Size = new System.Drawing.Size(100, 20);
            this.extnsionBox.TabIndex = 19;
            // 
            // extnsionLabel
            // 
            this.extnsionLabel.AutoSize = true;
            this.extnsionLabel.Location = new System.Drawing.Point(9, 244);
            this.extnsionLabel.Name = "extnsionLabel";
            this.extnsionLabel.Size = new System.Drawing.Size(56, 13);
            this.extnsionLabel.TabIndex = 18;
            this.extnsionLabel.Text = "Extension:";
            this.extnsionLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // authorChkBox
            // 
            this.authorChkBox.AutoSize = true;
            this.authorChkBox.Location = new System.Drawing.Point(15, 373);
            this.authorChkBox.Name = "authorChkBox";
            this.authorChkBox.Size = new System.Drawing.Size(63, 17);
            this.authorChkBox.TabIndex = 20;
            this.authorChkBox.Text = "Author?";
            this.authorChkBox.UseVisualStyleBackColor = true;
            // 
            // authBox
            // 
            this.authBox.HideSelection = false;
            this.authBox.Location = new System.Drawing.Point(84, 370);
            this.authBox.Name = "authBox";
            this.authBox.Size = new System.Drawing.Size(38, 20);
            this.authBox.TabIndex = 21;
            this.authBox.Text = "Initials";
            this.authBox.Visible = false;
            // 
            // listofSectors
            // 
            this.listofSectors.FormattingEnabled = true;
            this.listofSectors.Location = new System.Drawing.Point(265, 170);
            this.listofSectors.Name = "listofSectors";
            this.listofSectors.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.listofSectors.Size = new System.Drawing.Size(220, 199);
            this.listofSectors.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(656, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 31);
            this.label1.TabIndex = 23;
            this.label1.Text = "List of Sectors";
            // 
            // FSLSector
            // 
            this.FSLSector.Text = "Sectors";
            this.FSLSector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLSector.Width = 70;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(884, 511);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listofSectors);
            this.Controls.Add(this.authBox);
            this.Controls.Add(this.authorChkBox);
            this.Controls.Add(this.extnsionBox);
            this.Controls.Add(this.extnsionLabel);
            this.Controls.Add(this.readChkBox);
            this.Controls.Add(this.hiddenChkBox);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.sectorSizLabel);
            this.Controls.Add(this.sectorSizBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.appBanner);
            this.Controls.Add(this.fsSecLabel);
            this.Controls.Add(this.filesizeBox);
            this.Controls.Add(this.filenameBox);
            this.Controls.Add(this.rmvButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fsList);
            this.Controls.Add(this.duckIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(900, 550);
            this.MinimumSize = new System.Drawing.Size(900, 550);
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = " CmpSc472 File Storage System";
            this.Load += new System.EventHandler(this.mainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.duckIMG)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox duckIMG;
        private System.Windows.Forms.ListView fsList;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button rmvButton;
        private System.Windows.Forms.TextBox filenameBox;
        private System.Windows.Forms.TextBox filesizeBox;
        private System.Windows.Forms.Label fsSecLabel;
        private System.Windows.Forms.Label appBanner;
        private System.Windows.Forms.ColumnHeader FSLName;
        private System.Windows.Forms.ColumnHeader FSLSize;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.ColumnHeader FSExtension;
        private System.Windows.Forms.ColumnHeader FSLAttributes;
        private System.Windows.Forms.TextBox sectorSizBox;
        private System.Windows.Forms.Label sectorSizLabel;
        private System.Windows.Forms.Label instructionLabel;
        private System.Windows.Forms.CheckBox hiddenChkBox;
        private System.Windows.Forms.CheckBox readChkBox;
        private System.Windows.Forms.TextBox extnsionBox;
        private System.Windows.Forms.Label extnsionLabel;
        private System.Windows.Forms.CheckBox authorChkBox;
        private System.Windows.Forms.TextBox authBox;
        private System.Windows.Forms.ListBox listofSectors;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ColumnHeader FSLSector;
    }
}


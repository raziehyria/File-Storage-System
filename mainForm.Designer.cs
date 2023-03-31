
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
            this.listofSectors = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLAttributes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLSector = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fsSecLabel = new System.Windows.Forms.Label();
            this.appBanner = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.sectorSizBox = new System.Windows.Forms.TextBox();
            this.sectorSizLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.extnsionLabel = new System.Windows.Forms.Label();
            this.listofSecLabel = new System.Windows.Forms.Label();
            this.rmvBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.hiddnChkBx = new System.Windows.Forms.CheckBox();
            this.readonlyChkBx = new System.Windows.Forms.CheckBox();
            this.authorChkBx = new System.Windows.Forms.CheckBox();
            this.filenameBoxInp = new System.Windows.Forms.TextBox();
            this.extnsBoxInp = new System.Windows.Forms.TextBox();
            this.sizeBoxInp = new System.Windows.Forms.TextBox();
            this.fileSystemBox = new System.Windows.Forms.ListView();
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
            // 
            // listofSectors
            // 
            this.listofSectors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.FSLName,
            this.FSExtension,
            this.FSLSize,
            this.FSLAttributes,
            this.FSLSector});
            this.listofSectors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listofSectors.HideSelection = false;
            listViewItem1.ToolTipText = "Current files in File System";
            this.listofSectors.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listofSectors.Location = new System.Drawing.Point(533, 67);
            this.listofSectors.Name = "listofSectors";
            this.listofSectors.Size = new System.Drawing.Size(409, 380);
            this.listofSectors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listofSectors.TabIndex = 1;
            this.listofSectors.UseCompatibleStateImageBehavior = false;
            this.listofSectors.View = System.Windows.Forms.View.Details;
            this.listofSectors.SelectedIndexChanged += new System.EventHandler(this.listofSectors_SelectedIndexChanged);
            // 
            // Index
            // 
            this.Index.Text = "Index";
            this.Index.Width = 42;
            // 
            // FSLName
            // 
            this.FSLName.Text = "Filename";
            this.FSLName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.FSLSize.Width = 57;
            // 
            // FSLAttributes
            // 
            this.FSLAttributes.Text = "Attributes";
            this.FSLAttributes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLAttributes.Width = 70;
            // 
            // FSLSector
            // 
            this.FSLSector.Text = "# Sectors";
            this.FSLSector.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLSector.Width = 63;
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(9, 205);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "File Name:";
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
            // fsSecLabel
            // 
            this.fsSecLabel.AutoSize = true;
            this.fsSecLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsSecLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.fsSecLabel.Location = new System.Drawing.Point(278, 136);
            this.fsSecLabel.Name = "fsSecLabel";
            this.fsSecLabel.Size = new System.Drawing.Size(204, 31);
            this.fsSecLabel.TabIndex = 10;
            this.fsSecLabel.Text = "File System Listbox";
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
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 476);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 12;
            this.exitButton.Text = "Exit Program";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sectorSizBox
            // 
            this.sectorSizBox.Location = new System.Drawing.Point(79, 119);
            this.sectorSizBox.Name = "sectorSizBox";
            this.sectorSizBox.ReadOnly = true;
            this.sectorSizBox.Size = new System.Drawing.Size(55, 20);
            this.sectorSizBox.TabIndex = 13;
            this.sectorSizBox.Text = "500";
            this.sectorSizBox.TextChanged += new System.EventHandler(this.sectorSizBox_TextChanged);
            // 
            // sectorSizLabel
            // 
            this.sectorSizLabel.AutoSize = true;
            this.sectorSizLabel.Location = new System.Drawing.Point(12, 122);
            this.sectorSizLabel.Name = "sectorSizLabel";
            this.sectorSizLabel.Size = new System.Drawing.Size(61, 13);
            this.sectorSizLabel.TabIndex = 14;
            this.sectorSizLabel.Text = "Sector Size";
            this.sectorSizLabel.Click += new System.EventHandler(this.sectorSizLabel_Click);
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
            // extnsionLabel
            // 
            this.extnsionLabel.AutoSize = true;
            this.extnsionLabel.Location = new System.Drawing.Point(9, 244);
            this.extnsionLabel.Name = "extnsionLabel";
            this.extnsionLabel.Size = new System.Drawing.Size(56, 13);
            this.extnsionLabel.TabIndex = 18;
            this.extnsionLabel.Text = "Extension:";
            // 
            // listofSecLabel
            // 
            this.listofSecLabel.AutoSize = true;
            this.listofSecLabel.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listofSecLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.listofSecLabel.Location = new System.Drawing.Point(679, 33);
            this.listofSecLabel.Name = "listofSecLabel";
            this.listofSecLabel.Size = new System.Drawing.Size(150, 31);
            this.listofSecLabel.TabIndex = 23;
            this.listofSecLabel.Text = "List of Sectors";
            // 
            // rmvBtn
            // 
            this.rmvBtn.Location = new System.Drawing.Point(345, 376);
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.Size = new System.Drawing.Size(75, 23);
            this.rmvBtn.TabIndex = 24;
            this.rmvBtn.Text = "Remove";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.rmvBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(59, 394);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // hiddnChkBx
            // 
            this.hiddnChkBx.AutoSize = true;
            this.hiddnChkBx.Location = new System.Drawing.Point(7, 325);
            this.hiddnChkBx.Name = "hiddnChkBx";
            this.hiddnChkBx.Size = new System.Drawing.Size(66, 17);
            this.hiddnChkBx.TabIndex = 26;
            this.hiddnChkBx.Text = "Hidden?";
            this.hiddnChkBx.UseVisualStyleBackColor = true;
            this.hiddnChkBx.CheckedChanged += new System.EventHandler(this.hiddnChkBx_CheckedChanged);
            // 
            // readonlyChkBx
            // 
            this.readonlyChkBx.AutoSize = true;
            this.readonlyChkBx.Location = new System.Drawing.Point(7, 348);
            this.readonlyChkBx.Name = "readonlyChkBx";
            this.readonlyChkBx.Size = new System.Drawing.Size(82, 17);
            this.readonlyChkBx.TabIndex = 27;
            this.readonlyChkBx.Text = "Read Only?";
            this.readonlyChkBx.UseVisualStyleBackColor = true;
            this.readonlyChkBx.CheckedChanged += new System.EventHandler(this.readonlyChkBx_CheckedChanged);
            // 
            // authorChkBx
            // 
            this.authorChkBx.AutoSize = true;
            this.authorChkBx.Location = new System.Drawing.Point(7, 371);
            this.authorChkBx.Name = "authorChkBx";
            this.authorChkBx.Size = new System.Drawing.Size(63, 17);
            this.authorChkBx.TabIndex = 28;
            this.authorChkBx.Text = "Author?";
            this.authorChkBx.UseVisualStyleBackColor = true;
            this.authorChkBx.CheckedChanged += new System.EventHandler(this.authorChkBx_CheckedChanged);
            // 
            // filenameBoxInp
            // 
            this.filenameBoxInp.Location = new System.Drawing.Point(7, 221);
            this.filenameBoxInp.Name = "filenameBoxInp";
            this.filenameBoxInp.Size = new System.Drawing.Size(100, 20);
            this.filenameBoxInp.TabIndex = 29;
            this.filenameBoxInp.TextChanged += new System.EventHandler(this.filenameBoxInp_TextChanged);
            // 
            // extnsBoxInp
            // 
            this.extnsBoxInp.Location = new System.Drawing.Point(7, 260);
            this.extnsBoxInp.Name = "extnsBoxInp";
            this.extnsBoxInp.Size = new System.Drawing.Size(100, 20);
            this.extnsBoxInp.TabIndex = 30;
            this.extnsBoxInp.TextChanged += new System.EventHandler(this.extnsBoxInp_TextChanged);
            // 
            // sizeBoxInp
            // 
            this.sizeBoxInp.Location = new System.Drawing.Point(7, 299);
            this.sizeBoxInp.Name = "sizeBoxInp";
            this.sizeBoxInp.Size = new System.Drawing.Size(100, 20);
            this.sizeBoxInp.TabIndex = 31;
            this.sizeBoxInp.TextChanged += new System.EventHandler(this.sizeBoxInp_TextChanged);
            // 
            // fileSystemBox
            // 
            this.fileSystemBox.HideSelection = false;
            this.fileSystemBox.Location = new System.Drawing.Point(284, 170);
            this.fileSystemBox.Name = "fileSystemBox";
            this.fileSystemBox.Size = new System.Drawing.Size(198, 195);
            this.fileSystemBox.TabIndex = 32;
            this.fileSystemBox.UseCompatibleStateImageBehavior = false;
            this.fileSystemBox.View = System.Windows.Forms.View.List;
            this.fileSystemBox.SelectedIndexChanged += new System.EventHandler(this.fileSystemBox_SelectedIndexChanged);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(954, 531);
            this.Controls.Add(this.fileSystemBox);
            this.Controls.Add(this.sizeBoxInp);
            this.Controls.Add(this.extnsBoxInp);
            this.Controls.Add(this.filenameBoxInp);
            this.Controls.Add(this.authorChkBx);
            this.Controls.Add(this.readonlyChkBx);
            this.Controls.Add(this.hiddnChkBx);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.rmvBtn);
            this.Controls.Add(this.listofSecLabel);
            this.Controls.Add(this.extnsionLabel);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.sectorSizLabel);
            this.Controls.Add(this.sectorSizBox);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.appBanner);
            this.Controls.Add(this.fsSecLabel);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.listofSectors);
            this.Controls.Add(this.duckIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(970, 570);
            this.MinimumSize = new System.Drawing.Size(970, 570);
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
        private System.Windows.Forms.ListView listofSectors;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.Label fileSizeLabel;
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
        private System.Windows.Forms.Label extnsionLabel;
        private System.Windows.Forms.Label listofSecLabel;
        private System.Windows.Forms.ColumnHeader FSLSector;
        private System.Windows.Forms.Button rmvBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.CheckBox hiddnChkBx;
        private System.Windows.Forms.CheckBox readonlyChkBx;
        private System.Windows.Forms.CheckBox authorChkBx;
        private System.Windows.Forms.TextBox filenameBoxInp;
        private System.Windows.Forms.TextBox extnsBoxInp;
        private System.Windows.Forms.TextBox sizeBoxInp;
        private System.Windows.Forms.ColumnHeader Index;
        private System.Windows.Forms.ListView fileSystemBox;
    }
}


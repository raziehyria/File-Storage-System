
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
            this.currentFiles = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.duckIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // duckIMG
            // 
            resources.ApplyResources(this.duckIMG, "duckIMG");
            this.duckIMG.Name = "duckIMG";
            this.duckIMG.TabStop = false;
            // 
            // listofSectors
            // 
            resources.ApplyResources(this.listofSectors, "listofSectors");
            this.listofSectors.AutoArrange = false;
            this.listofSectors.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listofSectors.BackgroundImageTiled = true;
            this.listofSectors.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.FSLName,
            this.FSExtension,
            this.FSLSize,
            this.FSLAttributes,
            this.FSLSector});
            this.listofSectors.ForeColor = System.Drawing.SystemColors.Desktop;
            this.listofSectors.FullRowSelect = true;
            this.listofSectors.GridLines = true;
            this.listofSectors.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listofSectors.HideSelection = false;
            this.listofSectors.MultiSelect = false;
            this.listofSectors.Name = "listofSectors";
            this.listofSectors.ShowGroups = false;
            this.listofSectors.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listofSectors.TileSize = new System.Drawing.Size(20, 20);
            this.listofSectors.UseCompatibleStateImageBehavior = false;
            this.listofSectors.View = System.Windows.Forms.View.Details;
            this.listofSectors.ColumnWidthChanged += new System.Windows.Forms.ColumnWidthChangedEventHandler(this.listofSectors_ColumnWidthChanged);
            this.listofSectors.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.listofSectors_ColumnWidthChanging);
            this.listofSectors.SelectedIndexChanged += new System.EventHandler(this.listofSectors_SelectedIndexChanged);
            this.listofSectors.ContextMenuStripChanged += new System.EventHandler(this.listofSectors_ContextMenuStripChanged);
            this.listofSectors.Layout += new System.Windows.Forms.LayoutEventHandler(this.listofSectors_Layout);
            // 
            // Index
            // 
            resources.ApplyResources(this.Index, "Index");
            // 
            // FSLName
            // 
            resources.ApplyResources(this.FSLName, "FSLName");
            // 
            // FSExtension
            // 
            resources.ApplyResources(this.FSExtension, "FSExtension");
            // 
            // FSLSize
            // 
            resources.ApplyResources(this.FSLSize, "FSLSize");
            // 
            // FSLAttributes
            // 
            resources.ApplyResources(this.FSLAttributes, "FSLAttributes");
            // 
            // FSLSector
            // 
            resources.ApplyResources(this.FSLSector, "FSLSector");
            // 
            // fileNameLabel
            // 
            resources.ApplyResources(this.fileNameLabel, "fileNameLabel");
            this.fileNameLabel.Name = "fileNameLabel";
            // 
            // fileSizeLabel
            // 
            resources.ApplyResources(this.fileSizeLabel, "fileSizeLabel");
            this.fileSizeLabel.Name = "fileSizeLabel";
            // 
            // fsSecLabel
            // 
            resources.ApplyResources(this.fsSecLabel, "fsSecLabel");
            this.fsSecLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.fsSecLabel.Name = "fsSecLabel";
            // 
            // appBanner
            // 
            resources.ApplyResources(this.appBanner, "appBanner");
            this.appBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.appBanner.Name = "appBanner";
            // 
            // exitButton
            // 
            resources.ApplyResources(this.exitButton, "exitButton");
            this.exitButton.Name = "exitButton";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // sectorSizBox
            // 
            resources.ApplyResources(this.sectorSizBox, "sectorSizBox");
            this.sectorSizBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.sectorSizBox.Name = "sectorSizBox";
            this.sectorSizBox.ReadOnly = true;
            this.sectorSizBox.TextChanged += new System.EventHandler(this.sectorSizBox_TextChanged);
            // 
            // sectorSizLabel
            // 
            resources.ApplyResources(this.sectorSizLabel, "sectorSizLabel");
            this.sectorSizLabel.Name = "sectorSizLabel";
            this.sectorSizLabel.Click += new System.EventHandler(this.sectorSizLabel_Click);
            // 
            // instructionLabel
            // 
            resources.ApplyResources(this.instructionLabel, "instructionLabel");
            this.instructionLabel.ForeColor = System.Drawing.Color.Black;
            this.instructionLabel.Name = "instructionLabel";
            // 
            // extnsionLabel
            // 
            resources.ApplyResources(this.extnsionLabel, "extnsionLabel");
            this.extnsionLabel.Name = "extnsionLabel";
            // 
            // listofSecLabel
            // 
            resources.ApplyResources(this.listofSecLabel, "listofSecLabel");
            this.listofSecLabel.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.listofSecLabel.Name = "listofSecLabel";
            // 
            // rmvBtn
            // 
            resources.ApplyResources(this.rmvBtn, "rmvBtn");
            this.rmvBtn.Name = "rmvBtn";
            this.rmvBtn.UseVisualStyleBackColor = true;
            this.rmvBtn.Click += new System.EventHandler(this.rmvBtn_Click);
            // 
            // addBtn
            // 
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.Name = "addBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // hiddnChkBx
            // 
            resources.ApplyResources(this.hiddnChkBx, "hiddnChkBx");
            this.hiddnChkBx.Name = "hiddnChkBx";
            this.hiddnChkBx.UseVisualStyleBackColor = true;
            this.hiddnChkBx.CheckedChanged += new System.EventHandler(this.hiddnChkBx_CheckedChanged);
            // 
            // readonlyChkBx
            // 
            resources.ApplyResources(this.readonlyChkBx, "readonlyChkBx");
            this.readonlyChkBx.Name = "readonlyChkBx";
            this.readonlyChkBx.UseVisualStyleBackColor = true;
            this.readonlyChkBx.CheckedChanged += new System.EventHandler(this.readonlyChkBx_CheckedChanged);
            // 
            // authorChkBx
            // 
            resources.ApplyResources(this.authorChkBx, "authorChkBx");
            this.authorChkBx.Name = "authorChkBx";
            this.authorChkBx.UseVisualStyleBackColor = true;
            this.authorChkBx.CheckedChanged += new System.EventHandler(this.authorChkBx_CheckedChanged);
            // 
            // filenameBoxInp
            // 
            resources.ApplyResources(this.filenameBoxInp, "filenameBoxInp");
            this.filenameBoxInp.Name = "filenameBoxInp";
            this.filenameBoxInp.TextChanged += new System.EventHandler(this.filenameBoxInp_TextChanged);
            // 
            // extnsBoxInp
            // 
            resources.ApplyResources(this.extnsBoxInp, "extnsBoxInp");
            this.extnsBoxInp.Name = "extnsBoxInp";
            this.extnsBoxInp.TextChanged += new System.EventHandler(this.extnsBoxInp_TextChanged);
            // 
            // sizeBoxInp
            // 
            resources.ApplyResources(this.sizeBoxInp, "sizeBoxInp");
            this.sizeBoxInp.Name = "sizeBoxInp";
            this.sizeBoxInp.TextChanged += new System.EventHandler(this.sizeBoxInp_TextChanged);
            // 
            // fileSystemBox
            // 
            resources.ApplyResources(this.fileSystemBox, "fileSystemBox");
            this.fileSystemBox.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.fileSystemBox.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.currentFiles});
            this.fileSystemBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fileSystemBox.GridLines = true;
            this.fileSystemBox.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.fileSystemBox.HideSelection = false;
            this.fileSystemBox.HoverSelection = true;
            this.fileSystemBox.MultiSelect = false;
            this.fileSystemBox.Name = "fileSystemBox";
            this.fileSystemBox.UseCompatibleStateImageBehavior = false;
            this.fileSystemBox.View = System.Windows.Forms.View.Details;
            this.fileSystemBox.SelectedIndexChanged += new System.EventHandler(this.fileSystemBox_SelectedIndexChanged);
            // 
            // currentFiles
            // 
            resources.ApplyResources(this.currentFiles, "currentFiles");
            // 
            // mainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.SystemColors.Control;
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "mainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
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
        private System.Windows.Forms.ListView fileSystemBox;
        private System.Windows.Forms.ColumnHeader currentFiles;
        private System.Windows.Forms.ColumnHeader Index;
    }
}


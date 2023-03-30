
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
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Empty, System.Drawing.SystemColors.Control, null);
            this.duckIMG = new System.Windows.Forms.PictureBox();
            this.fsList = new System.Windows.Forms.ListView();
            this.FSLName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSExtension = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLSize = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FSLAttributes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.selFile1 = new System.Windows.Forms.Label();
            this.selFile2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.fsBanner = new System.Windows.Forms.Label();
            this.appBanner = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.duckIMG)).BeginInit();
            this.SuspendLayout();
            // 
            // duckIMG
            // 
            this.duckIMG.Image = ((System.Drawing.Image)(resources.GetObject("duckIMG.Image")));
            this.duckIMG.Location = new System.Drawing.Point(12, 12);
            this.duckIMG.Name = "duckIMG";
            this.duckIMG.Size = new System.Drawing.Size(200, 192);
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
            this.FSLAttributes});
            this.fsList.HideSelection = false;
            this.fsList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.fsList.Location = new System.Drawing.Point(375, 104);
            this.fsList.Name = "fsList";
            this.fsList.Size = new System.Drawing.Size(413, 286);
            this.fsList.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.fsList.TabIndex = 1;
            this.fsList.UseCompatibleStateImageBehavior = false;
            this.fsList.View = System.Windows.Forms.View.Details;
            // 
            // FSLName
            // 
            this.FSLName.Text = "Filename";
            this.FSLName.Width = 110;
            // 
            // FSExtension
            // 
            this.FSExtension.Text = "Extension";
            this.FSExtension.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSExtension.Width = 100;
            // 
            // FSLSize
            // 
            this.FSLSize.Text = "Size";
            this.FSLSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLSize.Width = 100;
            // 
            // FSLAttributes
            // 
            this.FSLAttributes.Text = "Attributes";
            this.FSLAttributes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FSLAttributes.Width = 100;
            // 
            // selFile1
            // 
            this.selFile1.AutoSize = true;
            this.selFile1.Location = new System.Drawing.Point(48, 241);
            this.selFile1.Name = "selFile1";
            this.selFile1.Size = new System.Drawing.Size(85, 13);
            this.selFile1.TabIndex = 2;
            this.selFile1.Text = "Select your file...";
            // 
            // selFile2
            // 
            this.selFile2.AutoSize = true;
            this.selFile2.Location = new System.Drawing.Point(48, 301);
            this.selFile2.Name = "selFile2";
            this.selFile2.Size = new System.Drawing.Size(85, 13);
            this.selFile2.TabIndex = 3;
            this.selFile2.Text = "Select your file...";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(157, 257);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 317);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Add";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(51, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(51, 317);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // fsBanner
            // 
            this.fsBanner.AutoSize = true;
            this.fsBanner.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fsBanner.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.fsBanner.Location = new System.Drawing.Point(502, 70);
            this.fsBanner.Name = "fsBanner";
            this.fsBanner.Size = new System.Drawing.Size(166, 31);
            this.fsBanner.TabIndex = 10;
            this.fsBanner.Text = "File System List";
            this.fsBanner.Click += new System.EventHandler(this.label3_Click);
            // 
            // appBanner
            // 
            this.appBanner.AutoSize = true;
            this.appBanner.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appBanner.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.appBanner.Location = new System.Drawing.Point(218, 12);
            this.appBanner.Name = "appBanner";
            this.appBanner.Size = new System.Drawing.Size(220, 31);
            this.appBanner.TabIndex = 11;
            this.appBanner.Text = "Razie\'s File Manager ";
            this.appBanner.Click += new System.EventHandler(this.label4_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(713, 396);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 12;
            this.button4.Text = "Remove";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.appBanner);
            this.Controls.Add(this.fsBanner);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.selFile2);
            this.Controls.Add(this.selFile1);
            this.Controls.Add(this.fsList);
            this.Controls.Add(this.duckIMG);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
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
        private System.Windows.Forms.Label selFile1;
        private System.Windows.Forms.Label selFile2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label fsBanner;
        private System.Windows.Forms.Label appBanner;
        private System.Windows.Forms.ColumnHeader FSLName;
        private System.Windows.Forms.ColumnHeader FSLSize;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ColumnHeader FSExtension;
        private System.Windows.Forms.ColumnHeader FSLAttributes;
    }
}


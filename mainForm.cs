using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Hyria_MyFS
{
    
    public partial class mainForm : Form
    {
        private int counter = 0;
        public mainForm()
        {
            InitializeComponent();
        }
        
        private void mainForm_Load(object sender, EventArgs e)
        {

        }


        private void addBtn_Click(object sender, EventArgs e)
        {
            // Get the values from the input controls
            string fileInfo;
            char hiddenChar = 'h';
            char readOnlyChar = 'r';
            string authorChar = "a";
            string filename = filenameBoxInp.Text;
            string extension = extnsBoxInp.Text;
            int size;
            int sectors;
            string tagname;
            
            //adjusting attributes depending on input
            if (hiddnChkBx.Checked == true)
                hiddenChar = 'H';

            if (readonlyChkBx.Checked == true)
                readOnlyChar = 'R';

            if (authorChkBx.Checked == true)
                authorChar = "RH";

            // checking for only numerical input in size box
            if (!int.TryParse(sizeBoxInp.Text, out size))
            {
                // The input is not a valid integer, so show an error message
                MessageBox.Show("Please enter a valid integer for the file size.");
                return;
            }

            // Calculate the number of sectors needed for the entry
            sectors = (size + 499) / 500;

            // Combine the filename, extension, and size into a single string for Tag
            tagname = filename + extension + size.ToString();

            // checking to make sure the file doesn't already exist in the file system
            foreach (ListViewItem existingItem in fileSystemBox.Items)
            {
                if (existingItem.Tag.ToString() == tagname)
                {
                    MessageBox.Show("File already exists in the file system.");
                    return;
                }
            }

            // string that will populate fileSystemBox
            fileInfo = filename + ", " + extension + ", " + size + ", " + hiddenChar + ", " + readOnlyChar + ", " + (authorChar);

            // Create a new ListViewItem for fileSystemBox
            ListViewItem lbitem = new ListViewItem(fileInfo);
            lbitem.Tag = tagname;

            // Create a new ListViewItem for listofsectors
            ListViewItem item = new ListViewItem(counter.ToString());
            item.SubItems.Add(filename);
            item.SubItems.Add(extension);
            item.SubItems.Add(size.ToString());
            item.SubItems.Add((hiddenChar.ToString()) + ", " + (readOnlyChar.ToString()) + ", " + (authorChar));
            item.SubItems.Add(sectors.ToString());
            item.Tag = tagname;

            // Add the new entry's
            fileSystemBox.Items.Add(lbitem);

            // Adding to multiple sectors
            if (sectors > 1)
            {

                for (int i = 1; i <= sectors; i++)
                {
                    
                    // Add the new entry to the list
                    ListViewItem sitem = new ListViewItem(counter.ToString());
                    sitem.SubItems.Add(filename);
                    sitem.SubItems.Add(extension);
                    sitem.SubItems.Add(size.ToString());
                    sitem.SubItems.Add((hiddenChar.ToString()) + ", " + (readOnlyChar.ToString()) + ", " + (authorChar));
                    sitem.SubItems.Add(sectors.ToString());
                    sitem.Tag = tagname;

                    // Add the new entry to the list
                    listofSectors.Items.Add(sitem);
                    counter++;
                    size = size - 500;

                }
            }
            // otherwise, it doesnt exceed the max sector size of 500, and only one entry is added
            else
            {
                listofSectors.Items.Add(item);
                // Increment the counter for the next entry
                counter++;
            }


            // resetting text boxes after entry
            listofSectors.Sort();
            filenameBoxInp.Clear();
            extnsBoxInp.Clear();
            sizeBoxInp.Clear();
            hiddnChkBx.Checked = false;
            readonlyChkBx.Checked = false;
            authorChkBx.Checked = false;
        }

        private void rmvBtn_Click(object sender, EventArgs e)
        {
            addBtn.Enabled = !addBtn.Enabled;
            // Get the selected item's tagname
            string selectedTag = fileSystemBox.SelectedItems[0].Tag.ToString();

            // Remove the selected items from both lists
            for (int i = listofSectors.Items.Count - 1; i >= 0; i--)
            {

                if (listofSectors.Items[i].Tag != null && listofSectors.Items[i].Tag.ToString() == selectedTag)// using the items tag
                {   // we let the user know we are removing it from both lists
                    listofSectors.Items.RemoveAt(i);
                }
            }
            MessageBox.Show("Removing all entries of: " + selectedTag, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            fileSystemBox.Items.Remove(fileSystemBox.SelectedItems[0]);

            // reset the counter
            counter = listofSectors.Items.Count;
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void checkAddEnable()
        {
            if ((filenameBoxInp.TextLength > 0) && (extnsBoxInp.TextLength > 0) &&(sizeBoxInp.TextLength > 0))
                addBtn.Enabled = true;
            else
                addBtn.Enabled = false;
        }
        private void filenameBoxInp_TextChanged(object sender, EventArgs e)
        {
            checkAddEnable();
            
        }

        private void extnsBoxInp_TextChanged(object sender, EventArgs e)
        {
            checkAddEnable();
            
        }

        private void sizeBoxInp_TextChanged(object sender, EventArgs e)
        {
            checkAddEnable();
            
        }

        private void hiddnChkBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void readonlyChkBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void authorChkBx_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void listofSectors_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the selected items in the ListView
            listofSectors.SelectedItems.Clear();

            // Set the ListView's HideSelection property to true
            // to prevent the selection from appearing when the control loses focus
            listofSectors.HideSelection = true;
            
        }
        private void fileSystemBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rmvBtn.Enabled = (fileSystemBox.SelectedItems.Count > 0);
        }

        private void sectorSizBox_TextChanged(object sender, EventArgs e)
        {
            sectorSizBox.ReadOnly = true;
        }

        private void sectorSizLabel_Click(object sender, EventArgs e)
        {

        }

        private void listofSectors_ContextMenuStripChanged(object sender, EventArgs e)
        {

        }

        private void listofSectors_ColumnWidthChanging(object sender, ColumnWidthChangingEventArgs e)
        {
            // Cancel the column width changing event
            e.Cancel = true;
        }

        private void listofSectors_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
        
        }

        private void listofSectors_Layout(object sender, LayoutEventArgs e)
        {

        }
    }
}

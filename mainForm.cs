using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace Hyria_MyFS
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {

        }

        private int counter = 1;
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
            
            // program would crash if non numbers were entered, this is to catch that error
            if (!int.TryParse(sizeBoxInp.Text, out size))
            {
                // The input is not a valid integer, so show an error message
                MessageBox.Show("Please enter a valid integer for the file size.");
                return;
            }


            // Calculate the number of sectors needed for this item
            int sectors = (size + 499) / 500;

            // Combine the filename, extension, and size into a single string
            string tagname = filename + extension + size.ToString();

            if (hiddnChkBx.Checked == true)
                hiddenChar = 'H';

            if (readonlyChkBx.Checked == true)
                readOnlyChar = 'R';
            
            if (authorChkBx.Checked == true)
                authorChar = "RH";

            // Create a new ListViewItem with the values
            ListViewItem item = new ListViewItem(counter.ToString());
            item.SubItems.Add(filename);
            item.SubItems.Add(extension);
            item.SubItems.Add(size.ToString());
            item.SubItems.Add((hiddenChar.ToString()) + ", " + (readOnlyChar.ToString()) + ", " + (authorChar));
            item.SubItems.Add(sectors.ToString());
            item.Tag = tagname;

            // Add the new item to the fileSystemBox ListView
            fileInfo = filename + ", " + extension + ", " + size + ", " + hiddenChar + ", " + readOnlyChar + ", " + (authorChar);

            // Add the new entry to both lists
            listofSectors.Items.Add(item);
            fileSystemBox.Items.Add(fileInfo).Tag = tagname;
            
            // Increment the counter for the next entry
            counter++;
            
            // clearing out the textboxes after
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

            // Remove the selected items from both lists
            foreach (ListViewItem item in listofSectors.Items)
            {
                if (item.Tag.ToString() == fileSystemBox.SelectedItems[0].Tag.ToString())
                {
                    listofSectors.Items.Remove(item);
                    break;
                }
            }
            fileSystemBox.Items.Remove(fileSystemBox.SelectedItems[0]);

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
            //listofSectors.SelectedItems.Clear();

            // Set the ListView's HideSelection property to true
            // to prevent the selection from appearing when the control loses focus
            //listofSectors.HideSelection = true;
        }
        private void fileSystemBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void sectorSizBox_TextChanged(object sender, EventArgs e)
        {
            sectorSizBox.ReadOnly = true;
        }

        private void sectorSizLabel_Click(object sender, EventArgs e)
        {

        }

        
    }
}

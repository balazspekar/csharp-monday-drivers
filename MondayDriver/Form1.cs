using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MondayDriver
{
    public partial class MondayDrivesForm : Form
    {

        // This is a property
        public string CurrentPath
        {
            get { return pathTextBox.Text; }
        }

        public MondayDrivesForm()
        {
            InitializeComponent();
        }

        private void MondayDrivesForm_Load(object sender, EventArgs e)
        {
            // Looking up the available drives in Windows and populating the ComboBox
            DriveInfo[] allDrives = DriveInfo.GetDrives();

            driveComboBox.DataSource = allDrives;

            // Making the ComboBox readonly
            driveComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            pathTextBox.ReadOnly = true;


        }

        private void driveComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Whenever the combobox changes, it's path is being set to the textbox as well
            pathTextBox.Text = driveComboBox.SelectedIndex == -1 ? string.Empty : driveComboBox.SelectedItem.ToString();
        }

        private void pathTextBox_TextChanged(object sender, EventArgs e)
        {
            if (pathTextBox.Text != "")
            {
                // Playing with the ListBox
                string[] dirEntries = Directory.GetDirectories(pathTextBox.Text);
                string[] fileEntries = Directory.GetFiles(pathTextBox.Text);
                var entriesList = new List<string>();

                foreach (var dirEntry in dirEntries)
                {
                    entriesList.Add(dirEntry);
                }

                foreach (var fileEntry in fileEntries)
                {
                    entriesList.Add(fileEntry);
                }

                fileListBox.DataSource = entriesList;
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            var selectedItemInListBox = (string) fileListBox.SelectedItem;
            var attribute = File.GetAttributes(selectedItemInListBox);
            if (attribute == FileAttributes.Directory)
            {
                pathTextBox.Text = (string) fileListBox.SelectedItem;
            }
            else
            {
                
                //MessageBox.Show(text);
                using (Form2 form2 = new Form2(selectedItemInListBox))
                {
                    if (form2.ShowDialog() == DialogResult.OK)
                    {
                       
                    }
                }
            }

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            //File.Delete(@"YOURFILEPATH");
            //MessageBox.Show(pathTextBox.Text + " has been deleted!");
            MessageBox.Show("This code is commented out because of security purposes.");
        }

    }
}

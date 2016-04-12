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


        }
    }
}

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
    public partial class Form2 : Form
    {
        private string path;

        public Form2(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            contentTextBox.ReadOnly = true;
            string text = File.ReadAllText(path);
            contentTextBox.Text = text;
        }

       
    }
}

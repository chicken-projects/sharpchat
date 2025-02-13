using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lume_executor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void homebutton_Click(object sender, EventArgs e)
        {
            Form1 Form1Instance = new Form1(); // Make sure Form1 is in the same namespace or correctly referenced
            Form1Instance.TopLevel = false; // Make Form1 a child of this form
            Form1Instance.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            Form1Instance.Dock = DockStyle.Fill; // Make Form1 fill the entire window

            this.Controls.Clear(); // Clear existing controls
            this.Controls.Add(Form1Instance); // Add Form1 inside current form
            Form1Instance.Show(); // Show Form1 inside current form
        }

        private void settingsbutton_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizebutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}

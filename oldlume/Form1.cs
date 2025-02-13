using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace lume_executor
{
    public partial class lumeexecutor : Form
    {
        public lumeexecutor()
        {
            InitializeComponent();

            // Attach MouseDown event manually to enable dragging
            toolStrip1.MouseDown += toolStrip1_MouseDown;
        }

        // Windows API constants and functions for dragging the window
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Event handler to enable dragging the form using the ToolStrip
        private void toolStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Your logic here
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Your logic here
        }

        private void button5_Click(object sender, EventArgs e)
        {
            // Your logic here
        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Your logic here
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form2 Form2Instance = new Form2(); // Make sure Form2 is in the same namespace or correctly referenced
            Form2Instance.TopLevel = false; // Make Form2 a child of this form
            Form2Instance.FormBorderStyle = FormBorderStyle.None; // Remove title bar
            Form2Instance.Dock = DockStyle.Fill; // Make Form2 fill the entire window

            this.Controls.Clear(); // Clear existing controls
            this.Controls.Add(Form2Instance); // Add Form2 inside current form
            Form2Instance.Show(); // Show Form2 inside current form
        }
    }
}

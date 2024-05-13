using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            AttachHoverEffect(button1, descBox1);
            AttachHoverEffect(button2, descBox2);
            AttachHoverEffect(button3, descBox3);
            AttachHoverEffect(button4, descBox4);

            descBox1.Visible = false;
            descBox2.Visible = false;
            descBox3.Visible = false;
            descBox4.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        private void AttachHoverEffect(Control control, Control description)
        {
            Size originalSize = control.Size;
            Point originalLoc = control.Location;

            control.MouseEnter += (sender, e) =>
            {
                int widthDifference = 10;
                int heightDifference = 10;

                Size newSize = new(originalSize.Width + widthDifference, originalSize.Height + heightDifference);
                Point newLocation = new(control.Location.X - 5, control.Location.Y - 5);

                control.Size = newSize;
                control.Location = newLocation;

                description.Visible = true;
            };

            control.MouseLeave += (sender, e) =>
            {
                control.Size = originalSize;
                control.Location = originalLoc;

                description.Visible = false;
            };
        }

        private void accPanel_MouseEnter(object sender, EventArgs e)
        {
            accPanel.Location = new Point(837, 0);
        }

        private void accPanel_MouseLeave(object sender, EventArgs e)
        {
            accPanel.Location = new Point(987, 0);
        }
    }
}

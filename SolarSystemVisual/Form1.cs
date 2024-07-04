using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SolarSystemVisual
{
    public partial class Form1 : Form
    {
        // Refresh Rate
        private Timer refreshTimer = new Timer();

        // Brush for drawing planets
        private SolidBrush brush;
        private Pen orbitalPath = new Pen(Color.Red);





        public Form1()
        {
            InitializeComponent();
            // Double Buffer (Taken From StackOverFlow) - This is essential to rendering all the multiple bubble entities without the flicker issue
            typeof(Panel).InvokeMember("DoubleBuffered", BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.NonPublic, null, panel1, new object[] { true });
            refreshTimer.Interval = 10;
            refreshTimer.Start();
            refreshTimer.Tick += new EventHandler(RenderRefresh);
        }


        private void RenderRefresh(object source, EventArgs e)
        {



            // Refresh contents of panel1
            panel1.Refresh();

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            int mouseX = e.X;
            int mouseY = e.Y;

            label1.Text = $"X: {mouseX} Y: {mouseY}";
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
 
        }

 

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("A Key was pressed");
            if (e.KeyCode == Keys.D)
            { 
                Console.WriteLine($"Pressed?");
                PlanetPropertyBox.Visible = !(PlanetPropertyBox.Visible);
                PlanetPropertyBox.Enabled = !(PlanetPropertyBox.Enabled);
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

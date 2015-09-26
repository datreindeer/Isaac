using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Isaac
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        public static String version = "1.0";


        //Quit Button
        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); //Exit All Forms //Shuts down program
        }

        //Settings Button
        private void button2_Click(object sender, EventArgs e)
        {

        }

        //Play Button
        private void button1_Click(object sender, EventArgs e)
        {
            var gameForm = new Game();

            Hide();
            gameForm.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Menu_Load(object sender, EventArgs e)
        {
            label2.Text = "TBOI Clicker" + " - " + "2015" + " - " + "Yngve" + " - " + "Version " + version;
        }
    }
}

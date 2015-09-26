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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }
        public static String CharName = "Isaac";

        public static int Level = 0;
        public static int Health = 100;
        public static int Power = 0;
        public static int Damage = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void Game_Load(object sender, EventArgs e)
        {
            label2.Text = "" + CharName;
        }
    }
}

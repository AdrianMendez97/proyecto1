using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo
{
    public partial class Dificultad : Form
    {
        public Dificultad()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Dificil a = new Dificil();
            a.Show();
          

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Facil a = new Facil();
            a.Show();
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_OpenBar
{
    public partial class Cargando : Form
    {
        public Cargando()
        {
            //Pongo el cursor como reloj de arena
            Cursor.Show();
            Cursor.Current = Cursors.WaitCursor;
            InitializeComponent();
            
        }

       

        private void timer_Tick(object sender, EventArgs e)
        {
            //Pongo el cursor como reloj de arena
            //Cursor.Show();
            //Cursor.Current = Cursors.WaitCursor;

            //Al finalizar el timer, abre el formulario de Login
            timer.Stop();

            //Desactivo el cursor como reloj de arena
            //Cursor.Hide();
            //Cursor.Current = Cursors.Default;

            //Inicio el formulario de inicio de sesion y oculto el de "cargando"
            Frm_Login frm = new Frm_Login();
            frm.ShowDialog();

            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Cargando_Load(object sender, EventArgs e)
        {

        }

        private void Cargando_Shown(object sender, EventArgs e)
        {
            
            //Intervalo del timer
            timer = new Timer();
            timer.Interval = 2000;
            timer.Start();
            timer.Tick += timer_Tick;
            
        }
    }
}

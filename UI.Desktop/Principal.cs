using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Desktop
{
    public partial class Principal : Form
    {
        #region Constructores
        public Principal()
        {
            InitializeComponent();

        }
        #endregion

        #region Eventos del formuario
        
        private void Principal_Load(object sender, EventArgs e)
        {
            Login formLogin = new Login();
            if (formLogin.ShowDialog() != DialogResult.OK)
            {
                this.Dispose();
            }
        }
        #endregion

        #region Eventos de controles

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Usuarios formUsuarios = new Usuarios();
            formUsuarios.ShowDialog();
        }

        private void especialidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Especialidades formEspecialidades = new Especialidades();
            formEspecialidades.ShowDialog();
        }

        private void planesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Planes formPlanes = new Planes();
            formPlanes.ShowDialog();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Materias formMaterias = new Materias();
            formMaterias.ShowDialog();
        }
        #endregion

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Login();
        }

        private void Login()
        {
            Login formLogin = new Login();
            formLogin.ShowDialog();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Warning",
               MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                this.Close();
        }
    }
}

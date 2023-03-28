using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02_01
{
    public partial class manUsuario : Form
    {
        public manUsuario()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string telefono = txtFono.Text;
            string email = txtEmail.Text;
            string direccion = txtDireccion.Text;
            string fecha_nacimiento = dtpFechaNacimiento.Value.Date.ToShortDateString();

            
            dgvUsuarios.Rows.Add("", dni, nombre, apellido, fecha_nacimiento, telefono, email, direccion);
            

            

        }
    }
}

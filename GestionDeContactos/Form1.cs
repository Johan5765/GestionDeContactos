using GestionDeContactos.Data;
using GestionDeContactos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace GestionDeContactos
{
    public partial class Form1 : Form
    {
        private ContactoContext _contactoContext = new ContactoContext();
        private int? _idSeleccionado = null;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var contactos = _contactoContext.Contactos.ToList();
            dataGridViewContactos.DataSource = contactos;

            labelID.Enabled = false;
            tbxId.Enabled = false;

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbxNombre.Text))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }


            string nombre = tbxNombre.Text;
            string? email = string.IsNullOrWhiteSpace(tbxEmail.Text) ? null : tbxEmail.Text;
            string? telefono = string.IsNullOrWhiteSpace(mtbxTelefono.Text) ? null : mtbxTelefono.Text; //Tienes que modificar este input para dar formato de numero de telefono


            if (email != null && _contactoContext.Contactos.Any(x => x.email == email))
            {
                MessageBox.Show("Ese email ya está en uso por otro contacto");
                return;
            }

            var nuevo = new Contacto { nombre = nombre, email = email, telefono = telefono };

            _contactoContext.Contactos.Add(nuevo);
            _contactoContext.SaveChanges();

            dataGridViewContactos.DataSource = _contactoContext.Contactos.ToList();

            tbxNombre.Clear();
            tbxEmail.Clear();
            mtbxTelefono.Clear();//Tienes que modificar este input para dar formato de numero de telefono

        }



        private void btnModificar_Click(object sender, EventArgs e)
        {


            if (_idSeleccionado == null)
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla");
                return;
            }
            string nombre = tbxNombre.Text;
            string? email = string.IsNullOrWhiteSpace(tbxEmail.Text) ? null : tbxEmail.Text;
            string? telefono = string.IsNullOrWhiteSpace(mtbxTelefono.Text) ? null : mtbxTelefono.Text;


            var contacto = _contactoContext.Contactos.FirstOrDefault(x => x.idContacto == _idSeleccionado);
            if (contacto == null) { return; }

            if ( _contactoContext.Contactos.Any(x => x.email == email) && contacto.email != email)
            {
                MessageBox.Show("Ese email ya está en uso por otro contacto");
                return;
            }

            contacto.nombre = nombre;
            contacto.email = email;
            contacto.telefono = telefono;
            

            _contactoContext.SaveChanges();

            dataGridViewContactos.DataSource = _contactoContext.Contactos.ToList();

            tbxNombre.Clear();
            tbxEmail.Clear();
            mtbxTelefono.Clear();
            tbxId.Clear();
            _idSeleccionado = null;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            if (_idSeleccionado == null)
            {
                MessageBox.Show("Debes seleccionar una fila de la tabla");
                return;
            }


            var ejemplo = _contactoContext.Contactos.FirstOrDefault(x => x.idContacto == _idSeleccionado);
            if (ejemplo == null)
            {
                MessageBox.Show("No existe ese contacto");
                return;
            }
            DialogResult confirmacion = MessageBox.Show("Estas seguro de elimnar este contacto?", "Confirmar eliminacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirmacion == DialogResult.No)
            {
                return;
            }
            _contactoContext.Contactos.Remove(ejemplo);
            _contactoContext.SaveChanges();

            dataGridViewContactos.DataSource = _contactoContext.Contactos.ToList();



            tbxNombre.Clear();
            tbxEmail.Clear();
            mtbxTelefono.Clear();
            tbxId.Clear();
            _idSeleccionado = null;
        }

        private void labelID_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tbxNombre.Clear();
            tbxEmail.Clear();
            mtbxTelefono.Clear();
            tbxId.Clear();
            _idSeleccionado = null;

        }

        private void mtbxTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void dataGridViewContactos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridViewContactos.Rows[e.RowIndex];
                _idSeleccionado = Convert.ToInt32(fila.Cells["idContacto"].Value);

                tbxNombre.Text = fila.Cells["nombre"].Value?.ToString() ?? string.Empty;
                mtbxTelefono.Text = fila.Cells["telefono"].Value?.ToString() ?? string.Empty;
                tbxEmail.Text = fila.Cells["email"].Value?.ToString() ?? string.Empty;
                tbxId.Text = _idSeleccionado.ToString();



            }
        }

        private void tbxBuscar_TextChanged(object sender, EventArgs e)
        {
            string textBuscar = tbxBuscar.Text.ToLower();
            
            var vista = _contactoContext.Contactos
            .Where(x =>  x.nombre.Contains(textBuscar)|| x.email.Contains(textBuscar))
            .ToList();

            dataGridViewContactos.DataSource = vista;
            
        }
    }
}

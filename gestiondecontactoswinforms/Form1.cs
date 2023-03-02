using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using gestiondecontactoswinforms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace gestiondecontactoswinforms
{
    public partial class Form1 : Form
    {
        List<Contacto> contactos = new List<Contacto>();
        public Form1()
        {
            InitializeComponent();

        }


        private void addContact()
        {
            Contacto nuevoContacto = new Contacto
            {
                id = Convert.ToInt32(numericUpDown1.Value),
                name = txtB1.Text,
                email = txtB2.Text,
                phone = txtB3.Text
            };

            // Añadimos un nuevo contacto a la lista 
            contactos.Add(nuevoContacto);
            // Limpiamos los campos que añade el contacto y le aumentamos uno al proximo id
            txtB1.Clear();
            txtB2.Clear();
            txtB3.Clear();
            numericUpDown1.Value = Convert.ToInt32(numericUpDown1.Value) + 1;
            MessageBox.Show("Usuario Añadido con exito", "Ok",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            updateListBoxContacts();
        }


        // Método que realiza la lógica para añadir un nuevo contacto
        // Btn que añade un contacto (utiliza el metodo de añadir un nuevo contacto)
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            addContact();
        }



        // Método que actualiza el ListBox, con los contactos añadidos
        // Se agrega en el Listbox el email
        private void updateListBoxContacts()
        {
            listBox1.Items.Clear();
            foreach (Contacto contacto in contactos)
            {
                //listBox1.Items.Add(contacto.id);
                listBox1.Items.Add(contacto.email);
            }
        }




        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Llamamos al metodo que elimina un contacto, al momento que 
            // damos click en el botón
            deleteContact();
        }

        // Creamos un metodo que tiene la logica para eliminar el usuario que 
        // seleccionemos del listBox1
        private void deleteContact ()
        {
            //listBox1
            // Seleccionamos el campo del email
            string emailSeleccionado = listBox1.Text;
            Contacto contactoSeleccionado = contactos.FirstOrDefault(c => c.email == emailSeleccionado);

            if (contactoSeleccionado != null)
            {
                contactos.Remove(contactoSeleccionado);
                updateListBoxContacts();
                MessageBox.Show("Se ha eliminado el contacto", "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }else
            {
                MessageBox.Show("No se ha seleccionado ningún contacto para eliminar", "Bad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Llamamos al metodo que selecciona los datos del contacto  a actualizar
            contactToUpdate();
        }

        // Método que  selecciona los datos del contacto  a actualizar
        private void contactToUpdate()
        {
            string emailContact = listBox1.SelectedItem.ToString();
            Contacto contactoSeleccionado = contactos.FirstOrDefault(c => c.email == emailContact);
            if (contactoSeleccionado != null)
            {
                numericUpDown1.Value = contactoSeleccionado.id;
                txtB1.Text = contactoSeleccionado.name;
                txtB2.Text = contactoSeleccionado.email;
                txtB3.Text = contactoSeleccionado.phone;
            }
        }


        // Llamamos al Método que actualiza un contacto en párticular
        private void button1_Click(object sender, EventArgs e)
        {
            updateContact();
        }

        // Método que actualiza un contacto en párticular
        private void updateContact ()
        {
            string emailContact = listBox1.Text;
            int index = contactos.FindIndex(c => c.email == emailContact);
            if (index != -1)
            {
                // Actualiza el objeto en la lista
                contactos[index].id = Convert.ToInt32(numericUpDown1.Value);
                contactos[index].name = txtB1.Text;
                contactos[index].email = txtB2.Text;
                contactos[index].phone = txtB3.Text;
                MessageBox.Show("Actualización éxitosa", "Done",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            updateListBoxContacts();
        }

        private void btnSearchContact_Click(object sender, EventArgs e)
        {
            SearchingContact();
        }
        // Método para buscar un contacto
        private void SearchingContact()
        {
            string theContactIs = SearchContact.Text.ToLower();
            listBox1.Items.Clear();
            foreach (Contacto contacto in contactos)
            {
                if (contacto.name.ToLower().Contains(theContactIs) ||
                    contacto.email.ToLower().Contains(theContactIs) ||
                    contacto.phone.ToLower().Contains(theContactIs))
                {
                    listBox1.Items.Add(contacto.email);
                    updateListBoxContacts();
                    MessageBox.Show("Busqueda exitosa", "Done",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }else
                {
                    MessageBox.Show("No existe el contacto", "Bad",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }

    }
}

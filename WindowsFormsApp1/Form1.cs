using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Enums;
using WindowsFormsApp1.Model;
using WindowsFormsApp1.Poco;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            componen();
        }

        private void componen()
        {
            dgvEmpleado.ReadOnly = true;
            cmbCargo.Items.AddRange(Enum.GetValues(typeof(Cargo)).Cast<object>().ToArray());
            cmbProfesion.Items.AddRange(Enum.GetValues(typeof(Profesion)).Cast<object>().ToArray());
            cmbCargo.SelectedIndex = 0;
            cmbProfesion.SelectedIndex = 0;
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            int ID = Int32.Parse(txtID.Text);
            string Nombres = txtNombre.Text;
            string Apellido = txtApellido.Text;
            string Cedula = txtCedula.Text;
            int telefono = Int32.Parse(txtTelefono.Text);
            string Correo = txtCorreo.Text;
            int index = cmbCargo.SelectedIndex;
            int index2 = cmbProfesion.SelectedIndex;
            Profesion profesion = (Profesion)Enum.GetValues(typeof(Profesion)).GetValue(index);
            Cargo cargo = (Cargo)Enum.GetValues(typeof(Cargo)).GetValue(index2);
            double salario = Double.Parse(txtSalario.Text);

            Empleado gg = new Empleado()
            {
                ID = ID,
                Nombre = Nombres,
                Apellido = Apellido,
                Cedula = Cedula,
                Telefono = telefono,
                Correo = Correo,
                Cargo = cargo,
                Profesion = profesion,
                Salario = salario
            };
            EmpleadoModel.Add(gg);
            dgvEmpleado.DataSource
        }
    }
}

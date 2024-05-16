using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examen1m1_Empleados
{
    public partial class EmpleadosForm : Form
    {

        Repository _repository = new Repository();
        List<Empleado> empleados = new List<Empleado>();




        public EmpleadosForm()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtNombre.Text) &&
            !string.IsNullOrWhiteSpace(txtApellido.Text) &&
            numSalario.Value != 0)
            {
                Empleado empleado = new Empleado
                {
                    Nombre = txtNombre.Text,
                    Apellido = txtApellido.Text,
                    Salario = Math.Round(numSalario.Value, 2),
                    Area = txtArea.Text,
                };

                ActualizarDataGridView(empleado);


            }
            else
            {
                MessageBox.Show("Por favor, complete todos los campos y asegúrese de que el salario sea un valor numérico válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        private void SerializeButton_Click(object sender, EventArgs e)
        {

            if (dgvDatos.Rows.Count>0)
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.InitialDirectory = "c:\\";
                    saveFileDialog.Filter = "All files (*.*)|*.*|Archivos json (*.json)|*.json";
                    saveFileDialog.FilterIndex = 2;
                    saveFileDialog.RestoreDirectory = true;

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filename = saveFileDialog.FileName + ".json";
                        _repository.Serialize(empleados, filename);
                    }
                } 
            }
        }
        void ActualizarDataGridView(Empleado empleado)
        {
            empleados.Add(empleado);
            dgvDatos.DataSource = null;
            dgvDatos.DataSource = empleados;
        }

        private  async void btnCalcular_Click(object sender, EventArgs e)
        {
            if (empleados != null && dgvDatos.Rows.Count != 0)
            {
                decimal totalSalarios = await _repository.CalcularSalarios(empleados);

                txtResult.Text = totalSalarios.ToString();
            }
        }
    }
}

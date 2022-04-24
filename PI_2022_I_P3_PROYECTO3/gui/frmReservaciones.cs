using PI_2022_I_P3_PROYECTO3.Objetos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI_2022_I_P3_PROYECTO3.gui
{
    public partial class frmReservaciones : Form
    {
        protected int contadorTextBox { get; set; } = 8;
        List<RestauranteReservaciones> retristroGrid = new List<RestauranteReservaciones>();
        List<ComboBoxItem> registrocomo = new List<ComboBoxItem>();
        private StreamWriter archivoWriter;
        private StreamReader archivoReader;
        enum IndicesTextBox
        {
            ID,
            NombreCliente,
            NumeroTelefono,
            FechaReservacion,
            HoraReservacion,
            Ticket,
            Mesa,
            Personas
        }
        public frmReservaciones()
        {
            InitializeComponent();
        }

        public void LimpiartTextbox()
        {
            foreach (Control ControlGUI in Controls)
            {
                (ControlGUI as TextBox)?.Clear();
            }
        }

        public string[] ObtenerValoresTextBox()
        {
            return new string[]
            {
           txtID.Text,
           txtNombreCliente.Text,
           txtTelefono.Text,
           txtFecha.Text,
           txtHora.Text,
           txtTicket.Text,
           txtMesa.Text,
           txtPersonas.Text
            };

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                archivoWriter?.Close();
            }
            catch (IOException)
            {
                MessageBox.Show("NO SE PUEDE CERRAR EL ARCHIVO ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            Application.Exit();
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void lblDireccion_Click(object sender, EventArgs e)
        {
        }

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestaurante From = new frmRestaurante();
            From.Show();
        }

        private void btnGuardarcomo_Click(object sender, EventArgs e)
        {
        }
        private void btnReguistarCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
        }

        private void btbAbrirArchivo_Click(object sender, EventArgs e)
        {

        }

        private void btnSiguienteReguistro_Click(object sender, EventArgs e)
        {
        }
        public void SetearValoresTextBox(string[] valores)
        {
            if (valores.Length != contadorTextBox)
                throw (new ArgumentException(
                  $"Deberia de ser  {contadorTextBox} Elementos del  Arreglo", nameof(valores)));
            else
            {
                txtID.Text              = valores[(int)IndicesTextBox.ID];
                txtNombreCliente.Text   = valores[(int)IndicesTextBox.NombreCliente];
                txtTelefono.Text        = valores[(int)IndicesTextBox.NumeroTelefono];
                txtFecha.Text           = valores[(int)IndicesTextBox.FechaReservacion];
                txtHora.Text            = valores[(int)IndicesTextBox.HoraReservacion];
                txtTicket.Text          = valores[(int)IndicesTextBox.Ticket];
                txtMesa.Text            = valores[(int)IndicesTextBox.Mesa];
                txtPersonas.Text        = valores[(int)IndicesTextBox.Personas];
                retristroGrid.Add(new RestauranteReservaciones(
                    Convert.ToInt32(txtID.Text),
                    txtNombreCliente.Text,
                    txtTelefono.Text,
                    txtFecha.Text,
                    txtHora.Text,
                    txtTicket.Text,
                    txtMesa.Text,
                    txtPersonas.Text));

                registrocomo.Add(new ComboBoxItem(
                    txtNombreCliente.Text,
                    txtID.Text));
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void bntMostrar_Click(object sender, EventArgs e)
        {
        }

        private void btnGuardarcomo_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            string nombreArchivo;
            using (var ArchivoSeleccionado = new SaveFileDialog())
            {
                ArchivoSeleccionado.CheckFileExists = false;
                result = ArchivoSeleccionado.ShowDialog();
                nombreArchivo = ArchivoSeleccionado.FileName;
            }

            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo invalido,", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salida = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salida);
                        btnGuardarcomo.Enabled = false;
                        btnRegistrarCliente.Enabled = true;
                    }
                    catch (IOException)
                    {

                        MessageBox.Show("Error ABRIEndo el archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }

            }
        }
        private void btnRegistrarCliente_Click_1(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndicesTextBox.ID]))
            {
                try
                {
                    int NumeroId = int.Parse(valores[(int)IndicesTextBox.ID]);
                    if (NumeroId > 0)
                    {
                        var cuenta = new RestauranteReservaciones(
                            NumeroId,
                            valores[(int)IndicesTextBox.NombreCliente],
                            valores[(int)IndicesTextBox.NumeroTelefono],
                            valores[(int)IndicesTextBox.FechaReservacion],
                            valores[(int)IndicesTextBox.HoraReservacion],
                            valores[(int)IndicesTextBox.Ticket],
                            valores[(int)IndicesTextBox.Mesa],
                            valores[(int)IndicesTextBox.Personas]
                            );
                        archivoWriter.WriteLine(
                            $"{cuenta.ID}, {cuenta.NombreCliente}, {cuenta.NumeroTelefono},{cuenta.FechaReservacion}," +
                            $"{cuenta.HoraReservacion},{cuenta.Ticket},{cuenta.Mesa}, {cuenta.Personas}"
                            );
                    }
                    else
                    {
                        MessageBox.Show("Numero de ID invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (IOException)
                {

                    MessageBox.Show("Error Escribiendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Formato Invalido ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                if (txtID.Text == "" || txtNombreCliente.Text == "" || txtTelefono.Text == "" || txtFecha.Text == ""
                    || txtHora.Text == "" || txtTicket.Text == " " || txtMesa.Text =="" || txtPersonas.Text=="")
                {
                    MessageBox.Show("por favor llenar los el espacio en blaco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                else
                {
                    MessageBox.Show("Datos registrados correctamente!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiartTextbox();
            }
            
        }
        private void btnAbrirArchivo_Click(object sender, EventArgs e)
        {
            DialogResult Resultado;
            string nombreArchivo;
            using (OpenFileDialog archivoSeleccionado = new OpenFileDialog())
            {
                Resultado = archivoSeleccionado.ShowDialog();
                nombreArchivo = archivoSeleccionado.FileName;
            }
            if (Resultado == DialogResult.OK)
            {
                LimpiartTextbox();
                if (string.IsNullOrEmpty(nombreArchivo))
                {
                    MessageBox.Show("Nombre de archivo Invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        FileStream entrada = new FileStream(
                        nombreArchivo, FileMode.Open, FileAccess.Read);
                        archivoReader = new StreamReader(entrada);
                        btnAbrirArchivo.Enabled = false;
                        btnSiguienteReguistro.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void btnSiguienteReguistro_Click_1(object sender, EventArgs e)
        {
            try
            {
                var registroEntrada = archivoReader.ReadLine();
                if (registroEntrada != null)
                {
                    string[] entradacampo = registroEntrada.Split(',');
                    SetearValoresTextBox(entradacampo);
                }
                else
                {
                    archivoReader.Close();
                    btnAbrirArchivo.Enabled = true; btnSiguienteReguistro.Enabled = false;
                    LimpiartTextbox();
                    MessageBox.Show("No  tiene mas  registro en el Archivo", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Error Leyendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bntMostrar_Click_1(object sender, EventArgs e)
        {
            dgvMesas.DataSource = retristroGrid;
            cboIDNombre1.DisplayMember = "Text";
            cboIDNombre1.ValueMember = "Value";
            cboIDNombre1.DataSource = registrocomo; ;
        }

        private void lblIDNombreCliente_Click(object sender, EventArgs e)
        {
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada =  dgvMesas.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvMesas.Rows[FilaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboIDNombre1.SelectedItem;
            int valoresSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"El nombre seleccionado es:{itemSeleccionado} y el ID:{valoresSeleccionado}");
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }

        private void txtHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtMesa_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }

        private void txtPersonas_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
    }
}

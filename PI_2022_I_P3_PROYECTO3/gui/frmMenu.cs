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
    public partial class frmMenu : Form
    {
        protected int ContadorTextBox { get; set; } = 6;
        List<RestauranteMenu> registrarGrid = new List<RestauranteMenu>();
        List<ComboBoxItem> registroComo = new List<ComboBoxItem>();
        private StreamWriter archivoWriter;
        private StreamReader archivoReader;
        enum IndiceTextBox
        {
            ID,
            NombreCliente,
            RTN,
            Comida,
            Refresco,
            Postre
        }
        public frmMenu()
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
            txtNombre.Text,
            txtRTN.Text,
            txtComida.Text,
            txtRefresco.Text,
            txtPostre.Text,
            };
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
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

        private void regresarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRestaurante From = new frmRestaurante();
            From.Show();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
        }

        private void btnGuardarComo_Click(object sender, EventArgs e)
        { 
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {  
        }

        private void btnArbriArchivo_Click(object sender, EventArgs e)
        {
        }

        private void btnSiguienteReguistro_Click(object sender, EventArgs e)
        {
        }

        public void SetearValoresTextBox(string[] valores)
        {
            if (valores.Length != ContadorTextBox)
                throw (new ArgumentException(
                  $"Deberia de ser  {ContadorTextBox} Elementos del  Arreglo", nameof(valores)));
            else
            {
                txtID.Text              = valores[(int)IndiceTextBox.ID];
                txtNombre.Text          = valores[(int)IndiceTextBox.NombreCliente];
                txtRTN.Text             = valores[(int)IndiceTextBox.RTN];
                txtComida.Text          = valores[(int)IndiceTextBox.Comida];
                txtRefresco.Text        = valores[(int)IndiceTextBox.Refresco];
                txtPostre.Text          = valores[(int)IndiceTextBox.Postre];
                
                registrarGrid.Add(new RestauranteMenu(
                    Convert.ToInt32(txtID.Text),
                    txtNombre.Text,
                    txtRTN.Text,
                    txtComida.Text,
                    txtRefresco.Text,
                    txtPostre.Text));

                registroComo.Add(new ComboBoxItem(
                    txtNombre.Text, txtID.Text));
            }
        }

        private void btnMostar_Click(object sender, EventArgs e)
        {
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnArbriArchivo_Click_1(object sender, EventArgs e)
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
                        btnArbriArchivo.Enabled = false;
                        btnRegistrar.Enabled = true;
                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }
        }

        private void btnGuardarComo_Click_1(object sender, EventArgs e)
        {
            DialogResult result;
            string nombrearchivo;
            using (var archivoSeleccionado = new SaveFileDialog())
            {
                archivoSeleccionado.CheckFileExists = false;
                result = archivoSeleccionado.ShowDialog();
                nombrearchivo = archivoSeleccionado.FileName;
            }
            if (result == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(nombrearchivo))
                {
                    MessageBox.Show("Nombre de Archivo invalido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    try
                    {
                        var salir = new FileStream(nombrearchivo, FileMode.OpenOrCreate, FileAccess.Write);
                        archivoWriter = new StreamWriter(salir);
                        btnGuardarComo.Enabled = false;
                        btnRegistrar.Enabled = true;

                    }
                    catch (IOException)
                    {
                        MessageBox.Show("Error abriendo el Archivo ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }
        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            string[] valores = ObtenerValoresTextBox();
            if (!string.IsNullOrEmpty(valores[(int)IndiceTextBox.ID]))
            {
                try
                {
                    int NumeroId = int.Parse(valores[(int)IndiceTextBox.ID]);
                    if (NumeroId > 0)
                    {
                        var cuenta = new RestauranteMenu(
                            NumeroId,
                            valores[(int)IndiceTextBox.NombreCliente],
                            valores[(int)IndiceTextBox.RTN],
                            valores[(int)IndiceTextBox.Comida],
                            valores[(int)IndiceTextBox.Refresco],
                            valores[(int)IndiceTextBox.Postre]
                            );
                        archivoWriter.WriteLine(
                            $"{cuenta.ID}, {cuenta.NomnbreCliente},{cuenta.RTN}," +
                            $"{cuenta.Comida},{cuenta.Refresco},{cuenta.Postre}");
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
                if (txtID.Text == "" || txtNombre.Text == "" || txtRTN.Text == "" || txtComida.Text == "" || txtRefresco.Text == ""
                   || txtPostre.Text == "")
                {
                    MessageBox.Show("por favor llenar los el espacio en blaco ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    MessageBox.Show("Datos registrados correctamente!!!", "Save", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                LimpiartTextbox();
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
                    btnArbriArchivo.Enabled = true; btnSiguienteReguistro.Enabled = false;
                    LimpiartTextbox();
                    MessageBox.Show("No  tiene mas  registro en el Archivo", String.Empty, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (IOException)
            {

                MessageBox.Show("Error Leyendo el Archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnMostar_Click_1(object sender, EventArgs e)
        {
            dgvPrit.DataSource = registrarGrid;
            cboClienteN.DisplayMember = "Text";
            cboClienteN.ValueMember = "Value";
            cboClienteN.DataSource = registroComo;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void btnSleccionar_Click(object sender, EventArgs e)
        {
            int FilaSeleccionada = dgvPrit.CurrentCell.RowIndex;
            MessageBox.Show($"Grid {dgvPrit.Rows[FilaSeleccionada].Cells[0].Value}");

            ComboBoxItem itemSeleccionado = (ComboBoxItem)cboClienteN.SelectedItem;
            int valoresSeleccionado = Convert.ToInt32(itemSeleccionado.Value);
            MessageBox.Show($"El nombre seleccionado es:{itemSeleccionado} y el ID:{valoresSeleccionado}");
        }

        private void txtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.SoloNumeros(e);
        }
        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtRTN_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtComida_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtRefresco_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
        private void txtPostre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Validar.sololetras(e);
        }
    }
}

using PI_2022_I_P3_PROYECTO3.gui;

namespace PI_2022_I_P3_PROYECTO3
{
    public partial class frmRestaurante : Form
    {
        public frmRestaurante()
        {
            InitializeComponent();
        }
        private StreamWriter archivoWriter;

        private void frmRestaurante_Load(object sender, EventArgs e)
        {
            

        }

        private void lblCorreo_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void salirToolStripMenuItem_Click_1(object sender, EventArgs e)
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

        private void clienteToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente Form= new frmCliente();
            Form.Show();

           
        }

        private void reservacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
          frmReservaciones  Form = new frmReservaciones();
            Form.Show();
        }

        private void menuToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            
        }

        private void frmservicioADomicilioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmServicioaDomicilio  Form = new frmServicioaDomicilio();
            Form.Show();
        }

        private void menuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu Form = new frmMenu();
            Form.Show();
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCliente Form = new frmCliente();
            Form.Show();
        }

        private void btnReservaciones_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmReservaciones Form = new frmReservaciones();
            Form.Show();
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMenu Form = new frmMenu();
            Form.Show();
        }

        private void btnServicioaDomicilio_Click(object sender, EventArgs e)
        {
            this.Hide();
           frmServicioaDomicilio Form = new frmServicioaDomicilio();
            Form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAutoServicio Form = new frmAutoServicio();
            Form.Show();
        }

        private void btnEmpleadoNevi_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmEmpleadoNuevo Form = new frmEmpleadoNuevo();
            Form.Show();
        }
    }
}
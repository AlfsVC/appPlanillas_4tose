using System;
using System.Windows.Forms;

namespace appPlanillas_4tose.ui
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            bean.Empleado empleado=new bean.Empleado();
            dao.EmpleadoDAO empleadoDAO=new dao.EmpleadoDAO();
            empleado.Dni=txtDni.Text;
            empleado.Passwordd=txtPasswordd.Text;
            if (empleadoDAO.Login(empleado))
            {
                MessageBox.Show(empleado.Nombres);

            }
            else MessageBox.Show("Usuario y/o password invalidos");
        }
    }
}

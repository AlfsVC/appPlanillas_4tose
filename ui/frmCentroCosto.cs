using System;
using System.Data;
using System.Windows.Forms;

namespace appPlanillas_4tose.ui
{
    public partial class frmCentroCosto : Form
    {    
        bean.CentroCosto centroCosto=new bean.CentroCosto();
        dao.CentroCostoDAO centroCostoDAO = new dao.CentroCostoDAO();
        util.Util util = new util.Util();
        DataTable dtRegistros;
        bool bHayRegistros;
        int indexRegistro;
       

        public frmCentroCosto()
        {
            InitializeComponent();
        }

        private void frmCentroCosto_Load (object sender, EventArgs e)
        {
            getRegistros();
            Navegar(true);
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Navegar(false);
            verRegistros(-1);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Navegar(false);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = txtID.Text == "" ? 0 : int.Parse(txtID.Text);
            string detelle = txtDetalle.Text;
            //validar

            if (centroCostoDAO.Guardar(new bean.CentroCosto(id, detelle))) {
                getRegistros();
                for (int i = 0; i < dtRegistros.Rows.Count; i++)
                    if (dtRegistros.Rows[i]["Detalle"].ToString().Trim().Equals(detelle))
                    {
                        dgvRegistros.Rows[i].Cells["Detalle"].Selected = true; break;
                        
                    }

                MessageBox.Show("Registros " + (id == 0 ? "guardado" : "actualizado"));
                
            }
            Navegar(true);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Navegar(true);
            verRegistros(indexRegistro);
        }
        private void dgvRegistros_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            verRegistros(indexRegistro = e.RowIndex);
        }

        private void getRegistros()
        {
            dtRegistros = centroCostoDAO.getCentroCostos();
            if (bHayRegistros = dtRegistros != null)
            {
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Columns["id"].Visible = false;
                dgvRegistros.Columns["Detalle"].Width = dgvRegistros.Width - 3;
            }
            
        }

        private void Navegar(bool bOnoff) 
        {
            btnNuevo.Visible= bOnoff;
            btnEditar.Visible = btnEliminar.Visible = bOnoff && bHayRegistros;
            btnGuardar.Visible = btnCancelar.Visible = !bOnoff;
            
            dgvRegistros.Enabled = bOnoff && bHayRegistros;
            txtBuscar.Visible = bOnoff && bHayRegistros;
            txtDetalle.ReadOnly = bOnoff;

            if ( !bOnoff ) txtDetalle.Focus();

        }

        private void verRegistros(int index) 
        {
            
            bool bLimpiar = index == -1;
            txtID.Text = bLimpiar ? "" : dtRegistros.Rows[index]["id"].ToString();
            txtDetalle.Text = bLimpiar ? "" : dtRegistros.Rows[index]["Detalle"].ToString();

        }
        
        private void txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = util.LetterSpaceBack(sender, e);
        }

        private void txtDetalle_Leave(object sender, EventArgs e)
        {
            txtDetalle.Text=txtDetalle.Text.Trim();
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string filtro = txtBuscar.Text.Trim();
            FiltrarRegistros(filtro);
        }

        private void FiltrarRegistros(string filtro)
        {
            if (dtRegistros != null)
            {
                DataView dv = dtRegistros.DefaultView;
                dv.RowFilter = $"Detalle LIKE '%{filtro}%'"; 
                dgvRegistros.DataSource = dv.ToTable();
            }
        }
    }
}

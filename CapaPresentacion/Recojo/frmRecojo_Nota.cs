using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaBC;
using CapaBE;

namespace CapaPresentacion.Recojo
{
    public partial class frmRecojo_Nota : Form
    {
        public Int32 ID_Reco_Ide = 0;
        public Int32 ID_Reco_Ide_Detalle = 0;
        public Int32 ID_Veces = 0;
        public string Operacion_Nota = "";
        public frmRecojo_Nota()
        {
            InitializeComponent();
        }

        private void frmRecojo_Nota_Load(object sender, EventArgs e)
        {
            ENResultOperation R = ClsRecojo_CabeceraBC.Obtener_Registro(ID_Reco_Ide);
            DataTable dt = (DataTable)R.Valor;
            DataRow ROW = dt.Rows[0];
            ID_Veces = Convert.ToInt32(ROW["VECES"].ToString());

 
            if (Operacion_Nota == "N")
            {
                txtIde_Detalle.Text = "0";
                txtNota.Text = "";
            }
            else
            {
                ENResultOperation N = ClsRecojo_NotaBC.Obtener_Registro(ID_Reco_Ide, ID_Reco_Ide_Detalle);
                DataTable dtn = (DataTable)N.Valor;
                if (dtn.Rows.Count != 0)
                {
                    DataRow ROWN = dtn.Rows[0];
                    txtIde_Detalle.Text = ROWN["RECO_IDE_DETALLE"].ToString();
                    txtNota.Text = ROWN["RECO_NOTA"].ToString();
                    if (Operacion_Nota == "E") btnGrabar.Text = "Elimina";
                }
            }
            txtNota.Focus();
        }

        private void Procesar_Operacion()
        {
            ClsRecojo_NotaBE TipoBE = new ClsRecojo_NotaBE();
            TipoBE.Reco_ide = ID_Reco_Ide;
            TipoBE.Reco_ide_detalle = ID_Reco_Ide_Detalle;
            TipoBE.Reco_nota = txtNota.Text;
            TipoBE.Veces = ID_Veces;
            TipoBE.Usuario = "ADMIN";


            switch (Operacion_Nota)
            {
                case "N":
                    ENResultOperation R = ClsRecojo_NotaBC.Crear(TipoBE);
                    break;
                case "M": ClsRecojo_NotaBC.Actualizar(TipoBE);
                    break;
                case "E": ClsRecojo_NotaBC.Eliminar(TipoBE);
                    break;
            }
            this.Close();
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            Procesar_Operacion();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

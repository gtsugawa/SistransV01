using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmClientesTab : Form
    {
        public FrmClientesTab()
        {
            InitializeComponent();
        }

        void FormatoDgv()
        {
            //------------------------------------------------------------------//      
            var dgv = dgvListado;

            dgv.MultiSelect = false;
            dgv.ReadOnly = true;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            /*---------Centrar titulo de cabecera --------------*/
            dgv.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            /*-- No se hace visible la primera columna del datagrid */
            dgv.RowHeadersVisible = false;
            /*---No premite cambiar el tamaño a la columna*/
            dgv.AllowUserToResizeColumns = false;
            dgv.AllowUserToResizeRows = false;
            /*---------------Tipo de fuente y tamaño-----*/
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 9);
            /*----------Alterna colores en el grid -------*/
            dgv.RowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.White;
            /*---Pintado de color a la cabecera del datagrid ---*/
            DataGridViewCellStyle style = this.dgvListado.ColumnHeadersDefaultCellStyle;
            style.BackColor = Color.Honeydew;
            style.ForeColor = Color.Gray;

            //dgv.Columns.Clear();
            dgv.ColumnCount = 29;
            // Setear Cabecera de Columna 
            dgv.Columns[0].Name = "ESTADO";
            dgv.Columns[1].Name = "SERIE";
            dgv.Columns[2].Name = "NUMERO";
            dgv.Columns[3].Name = "FEMISION";
            dgv.Columns[4].Name = "FTRASLADO";
            dgv.Columns[5].Name = "TRANSPORTISTA";
            dgv.Columns[6].Name = "CONDUCTOR";
            dgv.Columns[7].Name = "VEHICULO";
            dgv.Columns[8].Name = "TN";
            dgv.Columns[9].Name = "KM";
            dgv.Columns[10].Name = "REMITENTE";
            dgv.Columns[11].Name = "PEDIDOPOR";
            dgv.Columns[12].Name = "CANTIDAD";
            dgv.Columns[13].Name = "PESO";
            dgv.Columns[14].Name = "VOLUMEN";
            dgv.Columns[15].Name = "LOCALIDAD";

            dgv.Columns[16].Name = "HSALIDA";
            dgv.Columns[17].Name = "FRETORNO";
            dgv.Columns[18].Name = "KMINICIAL";
            dgv.Columns[19].Name = "KMFINAL";
            dgv.Columns[20].Name = "REPARTO";
            dgv.Columns[21].Name = "LUGAR";
            dgv.Columns[22].Name = "TIPO";
            dgv.Columns[23].Name = "DIRECCION";
            dgv.Columns[24].Name = "LOCA_CODIGO_POSTAL";
            dgv.Columns[25].Name = "LOCA_NOMBRE";
            dgv.Columns[26].Name = "PAIS_NOMBRE";
            dgv.Columns[27].Name = "CHOFER_NOMBRE";
            dgv.Columns[28].Name = "PUNTOS_REPARTO";

            dgv.Columns[0].Width = 25;
            dgv.Columns[0].HeaderText = "Est";
            dgv.Columns[0].DataPropertyName = "Reco_Estado";

            dgv.Columns[1].Width = 40;
            dgv.Columns[1].HeaderText = "Serie";
            dgv.Columns[1].DataPropertyName = "Serie_Numero_Recojo";

            dgv.Columns[2].Width = 60;
            dgv.Columns[2].HeaderText = "Numero";
            dgv.Columns[2].DataPropertyName = "Reco_Numero_Recojo";

            dgv.Columns[3].Width = 80;
            dgv.Columns[3].HeaderText = "F.Emision";
            dgv.Columns[3].DataPropertyName = "Reco_Fecha_Emision";

            dgv.Columns[4].Width = 80;
            dgv.Columns[4].HeaderText = "F.Traslado";
            dgv.Columns[4].DataPropertyName = "Reco_Fecha_Traslado";

            dgv.Columns[5].Width = 150;
            dgv.Columns[5].HeaderText = "Transportista";
            dgv.Columns[5].DataPropertyName = "Tran_Razon_Social";

            dgv.Columns[6].Width = 180;
            dgv.Columns[6].HeaderText = "Conductor";
            dgv.Columns[6].DataPropertyName = "Chofer_Nombre";

            dgv.Columns[7].Width = 100;
            dgv.Columns[7].HeaderText = "Vehiculo";
            dgv.Columns[7].DataPropertyName = "Tran_Vehi_Placa";

            dgv.Columns[8].Width = 60;
            dgv.Columns[8].HeaderText = "TN";
            dgv.Columns[8].DataPropertyName = "Reco_Tonelaje";

            dgv.Columns[9].Width = 60;
            dgv.Columns[9].HeaderText = "KM";
            dgv.Columns[9].DataPropertyName = "Kilometraje";

            dgv.Columns[10].Width = 160;
            dgv.Columns[10].HeaderText = "Remitente";
            dgv.Columns[10].DataPropertyName = "Clie_Razon_Social";

            dgv.Columns[11].Width = 160;
            dgv.Columns[11].HeaderText = "Pedido Por";
            dgv.Columns[11].DataPropertyName = "Contacto_Nombre";

            dgv.Columns[12].Width = 60;
            dgv.Columns[12].HeaderText = "Cantidad";
            dgv.Columns[12].DataPropertyName = "Reco_Numero_Item";

            dgv.Columns[13].Width = 60;
            dgv.Columns[13].HeaderText = "Peso";
            dgv.Columns[13].DataPropertyName = "Reco_Tonelaje";

            dgv.Columns[14].Width = 60;
            dgv.Columns[14].HeaderText = "Volumen";
            dgv.Columns[14].DataPropertyName = "Reco_Volumen";

            dgv.Columns[15].Width = 60;
            dgv.Columns[15].HeaderText = "Localidad";
            dgv.Columns[15].DataPropertyName = "Loca_Codigo_Postal";

            // Columnas que no Deben Verse

            dgv.Columns[16].DataPropertyName = "Reco_Hora_Salida";
            dgv.Columns[16].Visible = false;
            dgv.Columns[17].DataPropertyName = "Reco_Fecha_Retorno";
            dgv.Columns[17].Visible = false;
            dgv.Columns[18].DataPropertyName = "Reco_Udometro_Inicial";
            dgv.Columns[18].Visible = false;
            dgv.Columns[19].DataPropertyName = "Reco_Udometro_Final";
            dgv.Columns[19].Visible = false;
            dgv.Columns[20].DataPropertyName = "Reco_Reparto_Destinatario";
            dgv.Columns[20].Visible = false;
            dgv.Columns[21].DataPropertyName = "Loca_Nombre";
            dgv.Columns[21].Visible = false;
            dgv.Columns[22].DataPropertyName = "Reco_Tipo";
            dgv.Columns[22].Visible = false;
            dgv.Columns[23].DataPropertyName = "Reco_Direccion";
            dgv.Columns[23].Visible = false;
            dgv.Columns[24].DataPropertyName = "Loca_Codigo_Postal";
            dgv.Columns[24].Visible = false;
            dgv.Columns[25].DataPropertyName = "Loca_Nombre";
            dgv.Columns[25].Visible = false;
            dgv.Columns[26].DataPropertyName = "Pais_Nombre";
            dgv.Columns[26].Visible = false;
            dgv.Columns[27].DataPropertyName = "Chofer_Nombre";
            dgv.Columns[27].Visible = false;
            dgv.Columns[28].DataPropertyName = "Reco_Punto_Reparto";
            dgv.Columns[28].Visible = false;
        }
    }
}

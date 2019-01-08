using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace CapaPresentacion.Tablas
{
    public partial class frmCodigo_Veh : Form
    {
        public frmCodigo_Veh()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            OpenFileDialog Abrir = new OpenFileDialog();
            Abrir.Filter = "*.bmp;*.gif;¨.jgp;*.png|*.bmp;*.gif,*.jpg;*.png";
            Abrir.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            Abrir.Title = "Seleccionar la imagen que se guardará en la base de datos";
            Abrir.RestoreDirectory = true;

            if (Abrir.ShowDialog() == DialogResult.OK)
            {
                lblRutaImagen.Text = Abrir.FileName;
                txtNombre.Text = Abrir.SafeFileName;
                pictureBox1.Image = Image.FromFile(Abrir.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            else
            {
                lblRutaImagen.Text = "";
                pictureBox1.Image = null;
            }
        }

        private const string Conectar = @"Data Source=CORPURSAC\SQLEXPRESS;Initial Catalog=BD_SIAC_TERAH;Integrated Security=True";
        SqlConnection cn = new SqlConnection(Conectar);

        private void InsertarFotoEnBDD(int id,string filefoto)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                FileStream fs = new FileStream(filefoto, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                ms.SetLength(fs.Length);
                fs.Read(ms.GetBuffer(), 0, (int)fs.Length);
                byte[] arrImg = ms.GetBuffer();
                ms.Flush();
                fs.Close();

                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();

                    cmd.CommandText = "insert into imagenes values (" +
                        "@id" +
                        ",@nombre" +
                        ",@imagen" +
                        ")";
                    cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;
                    cmd.Parameters.Add("@nombre", SqlDbType.NVarChar, 64).Value = Path.GetFileName(filefoto);
                    cmd.Parameters.Add("@imagen", SqlDbType.VarBinary).Value = arrImg;

                    cmd.ExecuteNonQuery();
                    cn.Close();
                    
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private Image ObtenerBitmapdeBDD(int id)
        {
            try
            {
                using (SqlCommand cmd = cn.CreateCommand())
                {
                    cn.Open();

                    cmd.CommandText = "select imagen from IMAGENES where id = @id";
                    cmd.Parameters.Add("@id", SqlDbType.BigInt).Value = id;

                    byte[] arrImg = (byte[])cmd.ExecuteScalar();
                    cn.Close();
                    MemoryStream ms = new MemoryStream(arrImg);
                    Image img = Image.FromStream(ms);

                    ms.Close();
                   
                    return img;
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        private void btnSaveToBDD_Click(object sender, EventArgs e)
        {
            string str = txtID.Text.Trim();
            int Num;
            bool isNum = int.TryParse(str, out Num);
            if (!isNum)
            {
                MessageBox.Show("Falta introducir un id", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else
            {
                if (pictureBox1.Image == null || lblRutaImagen.Text == "")
                {
                    MessageBox.Show("","Atención",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    try
                    {
                        InsertarFotoEnBDD(Num, lblRutaImagen.Text);
                        MessageBox.Show("Se guardó la foto en la Base de Datos", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
             }
        }

        private void btnLoadFromBDDtoImg_Click(object sender, EventArgs e)
        {
            string str = txtID.Text.Trim();
            int Num;
            bool isNum = int.TryParse(str, out Num);
            if (!isNum)
            {
                MessageBox.Show("Falta introducir un id", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtID.Focus();
            }
            else
            {
                try
                {
                    lblRutaImagen.Text = "";
                    txtID.Text = "";
                    pictureBox1.Image = ObtenerBitmapdeBDD(Num);
                    pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

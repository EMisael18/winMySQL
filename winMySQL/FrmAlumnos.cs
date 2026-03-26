using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using winMySQL.Clases;
using System.IO;



namespace WinMySQL.Vistas
{
    public partial class FrmAlumnos : Form
    {
        OpenFileDialog ofdExcel = new OpenFileDialog();
        Datos datos = new Datos();
        DataSet ds;
        public FrmAlumnos()
        {
            InitializeComponent();
        }

        private void FrmAlumnos_Activated(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void FrmAlumnos_Load(object sender, EventArgs e)
        {
            try
            {
                ds = datos.ejecutar("Select * from Alumnos");
                if (ds != null)
                {
                    dgvAlumnos.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnAgregarAlumno_Click(object sender, EventArgs e)
        {
            FrmAlumno alumn = new FrmAlumno();
            alumn.Show();
        }

        private void dgvAlumnos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmAlumno alumno = new FrmAlumno(
            Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value),
                dgvAlumnos.CurrentRow.Cells[1].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[2].Value.ToString(),
                dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[4].Value),
                Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[5].Value),
                dgvAlumnos.CurrentRow.Cells[6].Value.ToString());
            alumno.ShowDialog();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int idalumno = Convert.ToInt32(dgvAlumnos.CurrentRow.Cells[0].Value);
            if (MessageBox.Show("Deseas eliminar al alumno: " + dgvAlumnos.CurrentRow.Cells[1].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[2].Value.ToString() + " " + dgvAlumnos.CurrentRow.Cells[3].Value.ToString(),
                "sistema", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                bool f = datos.ejecutarcomando($"delete from Alumnos where IdAlumnos={idalumno}");
                if (f == true)
                {
                    MessageBox.Show("Alumno eliminado con exito", "Sistema");
                }
                else MessageBox.Show("error al eliminar al alumno", "Sistema");
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {
            string path;
            DialogResult dr = ofdExcel.ShowDialog();
            if (dr == DialogResult.OK)
            {
                path = ofdExcel.FileName;

                ExcelPackage.License.SetNonCommercialPersonal("Luis Mota"); //Libreria para uso no comercial
                using (var package = new ExcelPackage(new FileInfo(path)))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int rowCount = worksheet.Dimension.Rows;
                    int columnCount = worksheet.Dimension.Columns;
                    DataTable dt = new DataTable();
                    for (int i = 0; i < columnCount; i++)
                    {
                        dt.Columns.Add(worksheet.Cells[1, i + 1].Value.ToString());
                    }
                    for (int i = 2; i <= rowCount; i++)
                    {
                        DataRow drNew = dt.NewRow();
                        for (int col = 1; col <= columnCount; col++)
                            if (worksheet.Cells[i, col].Value == null)
                            {
                                drNew[col - 1] = "";
                                continue;
                            }
                            else
                            {
                                try
                                {
                                    drNew[col - 1] = worksheet.Cells[i, col].Value.ToString();
                                }
                                catch (Exception ex)
                                {
                                    drNew[col - 1] = worksheet.Cells[i, col].Value;
                                }
                            }
                    
                    dt.Rows.Add(drNew);
                        string carreraNombre = drNew[5].ToString();

                        DataSet dsCarrera = datos.ejecutar($"SELECT IdCarrera FROM Carreras WHERE Nombre='{carreraNombre}'");
                        int idCarrera = Convert.ToInt32(dsCarrera.Tables[0].Rows[0][0]);

                        string comando = $"INSERT INTO Alumnos(Nombre, ApellidoPat, ApellidoMat, NumeroControl, Semestre, Carrera) " +
                                         $"VALUES('{drNew[3]}','{drNew[1]}','{drNew[2]}','{drNew[0]}',{drNew[4]},{idCarrera})";

                        datos.ejecutarcomando(comando);

                    }
                }
            }

        }
    }
}

        
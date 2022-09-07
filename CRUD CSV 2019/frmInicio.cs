using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CRUD_CSV_2019
{
    public partial class frmInicio : Form
    {
        public frmInicio()
        {
            InitializeComponent();
            
        }
        private Stream myStream;
        string line, rutaArchivo = string.Empty;
        string[] valores;
        bool archivoLeido = false;
        private void BtnLeerCSV_Click(object sender, EventArgs e)
        {
            bool columnasLeidas = false;
            dgvCSV.Rows.Clear();
            dgvCSV.Columns.Clear();
            OpenFileDialog fileDialog = new OpenFileDialog
            {
                Filter = "Archivos CSV (*.csv) | *.csv"
            };
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                rutaArchivo = fileDialog.FileName;
                try
                {
                    if((myStream=fileDialog.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            StreamReader file = new StreamReader(rutaArchivo);
                            while((line = file.ReadLine()) != null)
                            {
                                valores = line.Split(';');//parte la linea del documento en un array por cada ';'
                                if (columnasLeidas == false)
                                {
                                    foreach(string columnas in valores)//lee todo lo guardado en valores y lo guarda en columnas
                                    {
                                        DataGridViewTextBoxColumn dgvColumnas = new DataGridViewTextBoxColumn//se declara clase columna
                                        {
                                            HeaderText = columnas //el texto de la columna va a ser lo que se guardo en 'columnas' por el foreach
                                        };
                                        dgvCSV.Columns.Add(dgvColumnas);
                                    }                                    
                                    columnasLeidas=true;//despues de haber leido la primera linea, dejará de agregar las columnas 
                                }
                                else
                                {
                                    dgvCSV.Rows.Add(valores);//al estar en el while, va con la siguiente linea y agrega las filas
                                }
                                
                            }                            
                            file.Close();
                        }
                        StreamReader archivoLeido = new StreamReader(rutaArchivo);
                        txtArchivo.Text = archivoLeido.ReadToEnd();
                        archivoLeido.Close();
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show("Error: No se pudo encontrar el archivo en el disco. Original error: " + ex.Message);
                }
                archivoLeido=true;
            }
        }

        private void btnModificarCSV_Click(object sender, EventArgs e)
        {
            
            if (archivoLeido == false)
            {
                OpenFileDialog fileDialog = new OpenFileDialog()
                {
                    Filter = "Archivos CSV (*.csv)| *.csv"
                };
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = fileDialog.FileName;
                    StreamReader file = new StreamReader(rutaArchivo);
                    txtArchivo.Text = file.ReadToEnd();
                    file.Close();
                    archivoLeido = true;
                }      
            }
            else
            {
                DialogResult alerta = MessageBox.Show("Modificará el ultimo archivo leído con exactamente lo que haya en la caja de texto.\rDesea continuar?", "Cuidado", MessageBoxButtons.OKCancel);
                if(alerta == DialogResult.OK)
                {
                    StreamWriter streamWriter = new StreamWriter(rutaArchivo);
                    streamWriter.Write(txtArchivo.Text);
                    MessageBox.Show("Archivo modificado con exito");
                    streamWriter.Close();
                    txtArchivo.Clear();
                }                
            }           
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult alerta = MessageBox.Show("Eliminará el ultimo archivo leído con exactamente lo que haya en la caja de texto.\rDesea continuar?", "Cuidado", MessageBoxButtons.OKCancel);
                if (alerta == DialogResult.OK)
                {
                    File.Delete(rutaArchivo);
                    txtArchivo.Clear();
                    MessageBox.Show("Archivo Eliminado con exito");
                }
            }catch(Exception error)
            {
                MessageBox.Show("Debe leer o modificar un archivo antes de eliminarlo. " + error.Message, "Recuerde");
            }
            
        }

        private void btnCrearCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveDialog = new SaveFileDialog
            {
                Filter = "Archivos CSV (*.csv)| *.csv"
            };
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveDialog.FileName);
                streamWriter.Write(txtArchivo.Text);    
                MessageBox.Show("Archivo creado con exito");
                streamWriter.Close();
                txtArchivo.Clear();
            }

        }
    }
}

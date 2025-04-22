using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace LaboratorioProgramacion
{
    internal class Conexion
    {
        public DataTable dtProductos { get; set; }
        public DataSet DS { get; set; }
        public OleDbDataAdapter DA { get; set; }

        public Conexion()
        {
            try
            {
                // conexión con la base 
                OleDbConnection cnn = new OleDbConnection();
                cnn.ConnectionString = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Productos.mdb";
                cnn.Open();
                // comando
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandType = CommandType.TableDirect;
                cmd.CommandText = "Productos";
                cmd.Connection = cnn;
                // data adapter
                DA = new OleDbDataAdapter(cmd);
                //dataset
                DS = new DataSet();
                // leer la tabla
                DA.Fill(DS, "Productos"); // se lee y guarda la tabla en el DataSet
                                          // clave primaria
                DataColumn[] dc = new DataColumn[1]; // arreglo de 1 elemento para la clave primaria
                dc[0] = DS.Tables["Productos"].Columns["Código"];
                DS.Tables["Productos"].PrimaryKey = dc;
                // commandbuilder
                OleDbCommandBuilder cb = new OleDbCommandBuilder(DA);
                //
                dtProductos = DS.Tables["Productos"];
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.Message);
            }
        }
    }

   
}

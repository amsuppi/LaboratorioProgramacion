﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LaboratorioProgramacion
{
    internal class clsProductos
    {
        string cadenaConexion = $"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=Productos.mdb;";

        public void conexion()
        {

            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();
                    
                    MessageBox.Show("Conexión exitosa a la base de datos.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }
        }

        public void agregarProducto(int Codigo, string Nombre, string Precio, int Stock, string Descripcion, string Categorias)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "INSERT INTO Productos (Codigo, Nombre, Descripcion, Precio, Stock, Categorias) VALUES (?, ?, ?, ?, ?, ?)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", Codigo);
                        comando.Parameters.AddWithValue("?", Nombre);
                        comando.Parameters.AddWithValue("?", Descripcion);
                        comando.Parameters.AddWithValue("?", Precio);
                        comando.Parameters.AddWithValue("?", Stock);
                        comando.Parameters.AddWithValue("?", Categorias);

                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show("Producto agregado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar a la base de datos: " + ex.Message);
                }
            }

        }

        public void modificarProducto(int Codigo, string Nombre, string Precio, int Stock, string Descripcion, string Categorias)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "UPDATE Productos SET Nombre = ?, Descripcion = ?, Precio = ?, Stock = ?, Categorias = ? WHERE Codigo = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", Nombre);
                        comando.Parameters.AddWithValue("?", Descripcion);
                        comando.Parameters.AddWithValue("?", Precio);
                        comando.Parameters.AddWithValue("?", Stock);
                        comando.Parameters.AddWithValue("?", Categorias);
                        comando.Parameters.AddWithValue("?", Codigo); // El Código va al final porque está en el WHERE

                        int filas = comando.ExecuteNonQuery();
                        MessageBox.Show("Producto modificado correctamente");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al conectar o modificar en la base de datos: " + ex.Message);
                }
            }
        }

        public void eliminarProducto(int Codigo)
        {
            using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
            {
                try
                {
                    conexion.Open();

                    string query = "DELETE FROM Productos WHERE Codigo = ?";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("?", Codigo);

                        int filas = comando.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente");
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto con el código especificado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al eliminar el producto: " + ex.Message);
                }
            }
        }

    }
}

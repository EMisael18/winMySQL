using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace winMySQL.Clases
{
    internal class Datos
    {
       String CadenaConexion = "Server=localhost;Database=prueba;Uid=root;Pwd=misaelmontoya";
        MySqlConnection Conexion;
        public void conectar()
        {
            try
            {
                Conexion = new MySqlConnection(CadenaConexion);
                Conexion.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        private void desconectar()
        {
            try
            {
                Conexion.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}

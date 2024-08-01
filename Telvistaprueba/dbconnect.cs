using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Telvistaprueba
{
    internal class dbconnect
    {

        //conectamos a la base de datos :D
        SqlConnection conexion = new SqlConnection(@"Data Source=Akirengi\SQLEXPRESS01;Initial Catalog = Productos;Integrated Security=True");

        //Metodo para abrir la conexion
        public void Openconnection()
        {
            if(conexion.State == System.Data.ConnectionState.Closed)
            {
                Console.WriteLine("[Help] Base de datos conectada");
                conexion.Open();
            }
        }

        //Metodo para cerrar la conexion
        public void Closeconnection()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                Console.WriteLine("[Help] Base de datos desconectada");
                conexion.Close();
            }
        }

        //Metodo para tomar la conexion
        public SqlConnection Getconnection()
        {
            return conexion;
        }
    }
}

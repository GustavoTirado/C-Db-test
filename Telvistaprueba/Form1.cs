using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telvistaprueba
{
    public partial class Form1 : Form
    {
        dbconnect db = new dbconnect(); //Llamo a la clase para conectarme a la base
        public Form1()
        {
            InitializeComponent();
        }

        //Metodo para llenar los productos en el listview

        public void llenarprovedor()
        {

            listprovedor.Items.Clear();

            db.Openconnection();

            string query = "SELECT * FROM cat_provedores";
            SqlCommand comando = new SqlCommand(query, db.Getconnection());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listItem = new ListViewItem(reader["id"].ToString());
                listItem.SubItems.Add(reader["Nombre"].ToString());
                listItem.SubItems.Add(reader["RFC"].ToString());
                listprovedor.Items.Add(listItem);

            }
            db.Closeconnection();
            llenarTipoproducto();

        }

        public void llenarTipoproducto()
        {

            listtipoproducto.Items.Clear();

            db.Openconnection();

            string query = "SELECT * FROM cat_TipoProducto";
            SqlCommand comando = new SqlCommand(query, db.Getconnection());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listItem = new ListViewItem(reader["id"].ToString());
                listItem.SubItems.Add(reader["Nombre"].ToString());
                listtipoproducto.Items.Add(listItem);

            }
            db.Closeconnection();

        }

        public void LlenarProductos()
        {
            listProductos.Items.Clear();

            db.Openconnection();

            string query = "SELECT * FROM Productos";
            SqlCommand comando = new SqlCommand(query,db.Getconnection());
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem listItem = new ListViewItem(reader["id"].ToString());
                listItem.SubItems.Add(reader["Nombre"].ToString());
                listItem.SubItems.Add(reader["IDProvedor"].ToString());
                listItem.SubItems.Add(reader["IDTipo"].ToString());
                listItem.SubItems.Add(reader["Cantidad"].ToString());

                DateTime fechaproducto = (DateTime)reader["Fecha"];
                listItem.SubItems.Add(fechaproducto.ToString("dd/MM/yyyy"));
                

                listItem.SubItems.Add(reader["Modelo"].ToString());
                listItem.SubItems.Add(reader["Marca"].ToString());
                listProductos.Items.Add(listItem);

            }
            db.Closeconnection();

            llenarprovedor();


        }

        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            LlenarProductos();
        }

        //Boton para refresh
        private void button1_Click(object sender, EventArgs e)
        {
            LlenarProductos();
        }

        //Boton para eliminar
        private void button2_Click(object sender, EventArgs e)
        {

            if (listProductos.SelectedItems.Count>0) {
                ListViewItem selectedItem = listProductos.SelectedItems[0];
                string id = selectedItem.Text;

                db.Openconnection();

                string query = "DELETE FROM Productos WHERE id = @id";

                SqlCommand comando = new SqlCommand(query, db.Getconnection());
                comando.Parameters.AddWithValue("@id", id);
                comando.ExecuteNonQuery();
                db.Closeconnection();
                LlenarProductos();

                MessageBox.Show("item eliminado con el id: " + id);
            }
            else
            {
                MessageBox.Show("[ERROR] no tienes ningun item seleccionado");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            db.Openconnection();

            if (listprovedor.SelectedItems.Count > 0){
                //Condicion en caso de seleccionar algo

            }
            else
            {
                
                MessageBox.Show("[ERROR] no tienes ningun provedor seleccionado");
                return;
            }

            if (listtipoproducto.SelectedItems.Count > 0){
                //Condicion en caso de seleccionar algo
            }
            else
                {
                MessageBox.Show("[ERROR] no tienes ningun tipo de producto seleccionado");
                return;
            }

            string Nombre = tbproducto.Text;

        
            string Cantidad = tbcantidad.Text;
            string Fecha = tbalta.Text;
            string Modelo = tbmodelo.Text;
            string Marca = tbmarca.Text;

            

            

            ListViewItem selectedprovedor = listprovedor.SelectedItems[0];
            ListViewItem selectedtipo = listtipoproducto.SelectedItems[0];

            int IDProvedor = Int32.Parse(selectedprovedor.Text);
            int IDTipo = Int32.Parse(selectedtipo.Text);


            string query = "INSERT INTO Productos(Nombre,IDProvedor,IDTipo,Cantidad,Fecha,Modelo,Marca) VALUES(@Nombre,@IDProvedor,@IDTipo,@Cantidad,@Fecha,@Modelo,@Marca)";

            SqlCommand comando = new SqlCommand(query,db.Getconnection());
            comando.Parameters.AddWithValue("@Nombre", Nombre);
            comando.Parameters.AddWithValue("@IDProvedor", IDProvedor);
            comando.Parameters.AddWithValue("@IDTipo", IDTipo);
            comando.Parameters.AddWithValue("@Cantidad",Cantidad);
            comando.Parameters.AddWithValue("@Fecha",Fecha);
            comando.Parameters.AddWithValue("@Modelo", Modelo);
            comando.Parameters.AddWithValue("@Marca", Marca);

            comando.ExecuteNonQuery();
            db.Closeconnection();
            LlenarProductos();


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listprovedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}

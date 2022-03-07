using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP.Models
{
     class ChelasBD
    {
        private string ConnectionString = "Data Source=DESKTOP-AQHMBBT\\SQLEXPRESS;Initial Catalog=FundamentosCSHARP; Integrated Security=true";

        public List<Cerveza> Get()
        {
            List<Cerveza> chelas = new List<Cerveza>();

            string query = "select nombre, marca, alcohol, cantidad " + "from ChelasBD";

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                SqlCommand cmd = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int cant = reader.GetInt32(3);
                    String nom = reader.GetString(0);
                    Cerveza chelita = new Cerveza(cant, nom);
                    chelita.Alcohol = reader.GetInt32(2);
                    chelita.Marca = reader.GetString(1);
                    chelas.Add(chelita);
                }

                reader.Close();
                connection.Close();
            }

                return chelas;
        }

        public void Add(Cerveza chela)
        {
            string query = "insert into ChelasBD(nombre, marca, alcohol, cantidad) "+
                "values (@nombre,@marca,@alcohol,@cantidad)";

            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nombre", chela.Nombre);
                cmd.Parameters.AddWithValue("@marca", chela.Marca);
                cmd.Parameters.AddWithValue("@alcohol", chela.Alcohol);
                cmd.Parameters.AddWithValue("@cantidad", chela.Cantidad);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();

            }
        }

        public void Edit(Cerveza chela, int ID)
        {
            string query = "update ChelasBD set nombre=@nombre, " +
                "marca=@marca, alcohol=@alcohol, cantidad=@cantidad " +
                "where id=@id";

            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(query, connection);

                cmd.Parameters.AddWithValue("@nombre", chela.Nombre);
                cmd.Parameters.AddWithValue("@marca", chela.Marca);
                cmd.Parameters.AddWithValue("@alcohol", chela.Alcohol);
                cmd.Parameters.AddWithValue("@cantidad", chela.Cantidad);
                cmd.Parameters.AddWithValue("@id", ID);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();

            }
        }

        public void Delete(int ID)
        {
            string query = "delete from ChelasBD "+
                "where id=@id";

            using (var connection = new SqlConnection(ConnectionString))
            {
                var cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@id", ID);

                connection.Open();
                cmd.ExecuteNonQuery();

                connection.Close();

            }
        }

    }
}

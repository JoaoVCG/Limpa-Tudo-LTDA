using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Limpa_Tudo_LTDA.Camadas.DAL
{
    public class Pedido
    {
        private string strConex = Conectar.getConectar();

        public List<Model.Pedido> Select()
        {
            List<Model.Pedido> lstPedido = new List<Model.Pedido>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select pedido.id, pedido.data, pedido.cliente, cliente.nome from Pedido inner join cliente on cliente.id=pedido.cliente;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    Model.Pedido Pedido = new Model.Pedido();
                    Pedido.id = Convert.ToInt32(reader["id"]);
                    Pedido.cliente = Convert.ToInt32(reader["cliente"]);
                    Pedido.data = Convert.ToDateTime(reader["data"].ToString());
                    Pedido.nome = reader["nome"].ToString();
                    lstPedido.Add(Pedido);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Pedido;");
            }
            finally
            {
                conectar.Close();
            }
            return lstPedido;
        }

        public List<Model.Pedido> SelectById(int id)
        {
            List<Model.Pedido> lstPedido = new List<Model.Pedido>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Pedido where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", id);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Pedido Pedido = new Model.Pedido();
                    Pedido.id = Convert.ToInt32(reader["id"]);
                    Pedido.cliente = Convert.ToInt32(reader["cliente"]);
                    Pedido.data = Convert.ToDateTime(reader["data"].ToString());
                    lstPedido.Add(Pedido);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Pedido;");
            }
            finally
            {
                conectar.Close();
            }
            return lstPedido;
        }

        public List<Model.Pedido> SelectByCliente(int cliente)
        {
            List<Model.Pedido> lstPedido = new List<Model.Pedido>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Pedido where cliente=@cliente;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@cliente", cliente);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Pedido Pedido = new Model.Pedido();
                    Pedido.id = Convert.ToInt32(reader["id"]);
                    Pedido.cliente = Convert.ToInt32(reader["cliente"]);
                    Pedido.data = Convert.ToDateTime(reader["data"].ToString());
                    lstPedido.Add(Pedido);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Pedido;");
            }
            finally
            {
                conectar.Close();
            }
            return lstPedido;
        }

        public void Insert(Model.Pedido Pedido)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Insert into Pedido values ";
            sql = sql + " (@data, @cliente);";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@data", Pedido.data);
            cmd.Parameters.AddWithValue("@cliente", Pedido.cliente);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na insercao de Locacao");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Update(Model.Pedido Pedido)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Update Pedido set data=@data, cliente=@cliente ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@data", Pedido.data);
            cmd.Parameters.AddWithValue("@cliente", Pedido.cliente);
            cmd.Parameters.AddWithValue("@id", Pedido.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch 
            {
                Console.WriteLine("Erro na atualizacao de Pedido");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Delete(Model.Pedido Pedido)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Delete from Pedido where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", Pedido.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao Pedido");
            }
            finally
            {
                conectar.Close();
            }
        }
    }
}

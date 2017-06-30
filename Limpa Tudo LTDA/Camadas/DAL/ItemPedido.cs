using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.DAL
{
    public class ItemPedido
    {

        private string strConex = Conectar.getConectar();

        public List<Model.ItemPedido> Select()
        {
            List<Model.ItemPedido> lstItemPedido = new List<Model.ItemPedido>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from ItemPedido;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemPedido ItemPedido = new Model.ItemPedido();
                    ItemPedido.id = Convert.ToInt32(reader["id"]);
                    ItemPedido.pedido = Convert.ToInt32(reader["pedido"]);
                    ItemPedido.produto = Convert.ToInt32(reader["produto"]);
                    ItemPedido.entrega = Convert.ToDateTime(reader["entrega"].ToString());
                    ItemPedido.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemPedido.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemPedido.Add(ItemPedido);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Pedido;");
            }
            finally
            {
                conectar.Close();
            }
            return lstItemPedido;
        }

        public List<Model.ItemPedido> SelectById(int id)
        {
            List<Model.ItemPedido> lstItemPedido = new List<Model.ItemPedido>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from ItemPedido where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", id);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while(reader.Read())
                {
                    Model.ItemPedido ItemPedido = new Model.ItemPedido();
                    ItemPedido.id = Convert.ToInt32(reader["id"]);
                    ItemPedido.pedido = Convert.ToInt32(reader["pedido"]);
                    ItemPedido.produto = Convert.ToInt32(reader["produto"]);
                    ItemPedido.entrega = Convert.ToDateTime(reader["entrega"].ToString());
                    ItemPedido.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemPedido.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemPedido.Add(ItemPedido);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Pedido por id;");
            }
            finally
            {
                conectar.Close();
            }
            return lstItemPedido;
        }

        public List<Model.ItemPedido> SelectByPedido(int pedido)
        {
            List<Model.ItemPedido> lstItemPedido = new List<Model.ItemPedido>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from ItemPedido where pedido=@pedido;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@pedido", pedido);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.ItemPedido ItemPedido = new Model.ItemPedido();
                    ItemPedido.id = Convert.ToInt32(reader["id"]);
                    ItemPedido.pedido = Convert.ToInt32(reader["pedido"]);
                    ItemPedido.produto = Convert.ToInt32(reader["produto"]);
                    ItemPedido.entrega = Convert.ToDateTime(reader["entrega"].ToString());
                    ItemPedido.valor = Convert.ToSingle(reader["valor"].ToString());
                    ItemPedido.dias = Convert.ToInt32(reader["dias"].ToString());
                    lstItemPedido.Add(ItemPedido);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Item Pedido por pedio;");
            }
            finally
            {
                conectar.Close();
            }
            return lstItemPedido;
        }

        public void Insert(Model.ItemPedido ItemPedido)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Insert into ItemPedido values ";
            sql = sql + " (@pedido ,@produto, @entrega, @valor, @dias);";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@pedido", ItemPedido.pedido);
            cmd.Parameters.AddWithValue("@produto", ItemPedido.produto);
            cmd.Parameters.AddWithValue("@entrega", ItemPedido.entrega);
            cmd.Parameters.AddWithValue("@valor", ItemPedido.valor);
            cmd.Parameters.AddWithValue("@dias", ItemPedido.dias);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na insercao de Item Pedido");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Update(Model.ItemPedido ItemPedido)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Update ItemPedido set pedido=@pedido, produto=@produto, ";
            sql += "entrega=@entrega, valor=@valor, dias=@dias ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@pedido", ItemPedido.pedido);
            cmd.Parameters.AddWithValue("@produto", ItemPedido.produto);
            cmd.Parameters.AddWithValue("@entrega", ItemPedido.entrega);
            cmd.Parameters.AddWithValue("@valor", ItemPedido.valor);
            cmd.Parameters.AddWithValue("@dias", ItemPedido.dias);
            cmd.Parameters.AddWithValue("@id", ItemPedido.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de Item Pedido");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Delete(Model.ItemPedido ItemPedido)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Delete from ItemPedido where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", ItemPedido.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao Item Pedido");
            }
            finally
            {
                conectar.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.DAL
{
    public class Produto
    {

        private string strConex = Conectar.getConectar();

        public List<Model.Produto> Select()
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Produto;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produto Produto = new Model.Produto();
                    Produto.id = Convert.ToInt32(reader["id"]);
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    Produto.status = Convert.ToChar(reader["status"].ToString());
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto;");
            }
            finally
            {
                conectar.Close();
            }
            return lstProduto;
        }

        public List<Model.Produto> SelectById(int id)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Produto where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", id);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produto Produto = new Model.Produto();
                    Produto.id = Convert.ToInt32(reader["id"]);
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    Produto.status = Convert.ToChar(reader["status"].ToString());
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto;");
            }
            finally
            {
                conectar.Close();
            }
            return lstProduto;
        }

        public List<Model.Produto> SelectByNome(string descricao)
        {
            List<Model.Produto> lstProduto = new List<Model.Produto>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Produto where (descricao like @descricao);";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@descricao", "%" + descricao.Trim() + "%");
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Produto Produto = new Model.Produto();
                    Produto.id = Convert.ToInt32(reader["id"]);
                    Produto.descricao = reader["descricao"].ToString();
                    Produto.valor = Convert.ToSingle(reader["valor"].ToString());
                    Produto.status = Convert.ToChar(reader["status"].ToString());
                    lstProduto.Add(Produto);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Produto;");
            }
            finally
            {
                conectar.Close();
            }
            return lstProduto;
        }

        public void Insert(Model.Produto Produto)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Insert into Produto values ";
            sql = sql + " (@descricao, @valor, @status);";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@descricao", Produto.descricao);
            cmd.Parameters.AddWithValue("@valor", Produto.valor);
            cmd.Parameters.AddWithValue("@status", Produto.status);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na insercao de Produto");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Update(Model.Produto Produto)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Update Produto set descricao=@descricao, valor=@valor, status=@status ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@descricao", Produto.descricao);
            cmd.Parameters.AddWithValue("@valor", Produto.valor);
            cmd.Parameters.AddWithValue("@status", Produto.status);
            cmd.Parameters.AddWithValue("@id", Produto.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualizacao de Produto");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Delete (Model.Produto Produto)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Delete from Produto where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", Produto.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao Produto");
            }
            finally
            {
                conectar.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limpa_Tudo_LTDA.Camadas.DAL
{
    public class Cliente
    {
        private string strConex = Conectar.getConectar();

        public List<Model.Cliente> Select()
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Cliente;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente;");
            }
            finally
            {
                conectar.Close();
            }
            return lstCliente;
        }

        public List<Model.Cliente> SelectById(int id)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Cliente where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", id);
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente;");
            }
            finally
            {
                conectar.Close();
            }
            return lstCliente;
        }

        public List<Model.Cliente> SelectByNome(string nome)
        {
            List<Model.Cliente> lstCliente = new List<Model.Cliente>();
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "select * from Cliente where (nome like @nome);";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@nome", "%" + nome.Trim() + "%");
            conectar.Open();
            try
            {
                SqlDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (reader.Read())
                {
                    Model.Cliente cliente = new Model.Cliente();
                    cliente.id = Convert.ToInt32(reader["id"]);
                    cliente.nome = reader["nome"].ToString();
                    cliente.endereco = reader["endereco"].ToString();
                    cliente.cidade = reader["cidade"].ToString();
                    cliente.estado = reader["estado"].ToString();
                    cliente.telefone = reader["telefone"].ToString();
                    lstCliente.Add(cliente);
                }
            }
            catch
            {
                Console.WriteLine("Erro - Sql Select Cliente;");
            }
            finally
            {
                conectar.Close();
            }
            return lstCliente;
        }

        public void Insert(Model.Cliente cliente)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Insert into Cliente values ";
            sql = sql + " (@nome ,@endereco, @cidade, @estado, @telefone);";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção de cliente");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Update(Model.Cliente cliente)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Update Cliente set nome=@nome, endereco=@endereco, ";
            sql += "cidade=@cidade, estado=@estado, telefone=@telefone ";
            sql += " where id=@id;";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@nome", cliente.nome);
            cmd.Parameters.AddWithValue("@endereco", cliente.endereco);
            cmd.Parameters.AddWithValue("@cidade", cliente.cidade);
            cmd.Parameters.AddWithValue("@estado", cliente.estado);
            cmd.Parameters.AddWithValue("@telefone", cliente.telefone);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização de Clientes");
            }
            finally
            {
                conectar.Close();
            }
        }

        public void Delete(Model.Cliente cliente)
        {
            SqlConnection conectar = new SqlConnection(strConex);
            string sql = "Delete from Cliente where id=@id; ";
            SqlCommand cmd = new SqlCommand(sql, conectar);
            cmd.Parameters.AddWithValue("@id", cliente.id);
            conectar.Open();
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na remocao Cliente");
            }
            finally
            {
                conectar.Close();
            }
        }
    }
}

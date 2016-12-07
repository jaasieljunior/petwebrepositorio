using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using Backend.Erro;
using System.Data.SqlClient;

namespace Backend.Dados
{
    public class ClienteDaoImp : ClienteDao
    {
        Conexao conn;

        public ClienteDaoImp()
        {
            this.conn = new Conexao();
        }

       /* public Cliente getCliente(int ClienteId)
        {


            try
            {
                this.conn.openConnection();
                Cliente Cliente = new Cliente();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "SELECT u.id,u.nome,u.email,u.login,u.telefone,u.data_cadastro,c.cpf,c.rg FROM cliente c  INNER JOIN usuario u ON c.usuario_id  = u.id WHERE u.id = @cliente";
                cmd.Connection = this.conn.SqlConn;
                cmd.Parameters.AddWithValue("@veterinario", ClienteId);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                    Cliente.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    Cliente.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    Cliente.Email = reader.GetString(reader.GetOrdinal("email"));
                    Cliente.Login = reader.GetString(reader.GetOrdinal("login"));
                    Cliente.Telefone = reader.GetString(reader.GetOrdinal("telefone"));
                    Cliente.Cpf = reader.GetInt32(reader.GetOrdinal("Cpf"));
                    Cliente.Rg = reader.GetInt32(reader.GetOrdinal("Rg"));


                }
                this.conn.closeConnection();

                return Cliente;
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Veterinarios :" + ce.Message);
            }

        }*/




            /*

         public void alterarCliente(Cliente cliente)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE cliente SET cpf = @cpf WHERE usuario_id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", cliente.Cpf);
                cmd.Parameters.AddWithValue("@id", cliente.Usuario.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }
        }

        public void deletarCliente(Cliente cliente)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM cliente WHERE id_usuario = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", cliente.Usuario.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Deletar Usuario :" + ce.Message);
            }
        }*/

        public void insertCliente(Cliente cliente)
        {
            try
            {

                this.conn.openConnection();
                //  string sql = " INSERT INTO cliente(cpf,rg) OUTPUT INSERTED.PK__cliente__2ED7D2AF24517759 VALUES (@cliente_id,@cpf,@rg)";
                string sql = "INSERT INTO cliente(usuario_id,cpf,rg) VALUES (@usuario_id,@cpf,@rg)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
               // int modified = (int)cmd.ExecuteScalar();
                cmd.Parameters.AddWithValue("@usuario_id", cliente.Id);
                cmd.Parameters.AddWithValue("@cpf", cliente.CPF);
                cmd.Parameters.AddWithValue("@rg", cliente.RG);



                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Usuario :" + ce.Message);
            }
        }
        /*
        public List<Cliente> listCliente()
        {
            {
                List<Cliente> lcliente = new List<Cliente>();

                try
                {
                    this.conn.openConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select usuario_id,cpf,rg from cliente";
                    cmd.Connection = this.conn.SqlConn;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Cliente cliente = new Cliente();
                        cliente.Usuario.Id= reader.GetInt32(reader.GetOrdinal("usuario_id"));
                        cliente.Cpf = reader.GetString(reader.GetOrdinal("cpf"));
                        cliente.Rg = reader.GetString(reader.GetOrdinal("rg"));
                        lcliente.Add(cliente);
                    }
                    this.conn.closeConnection();
                }
                catch (SqlException ce)
                {

                    throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
                }

                return lcliente;



            }
        }*/
    }
}

    

 



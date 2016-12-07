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
    public class Cliente_AnimalDaoImp : Cliente_AnimalDao
    {
        Conexao conn;
        public Cliente_AnimalDaoImp() {
            
        this.conn = new Conexao();

        }

        public void alterarCliente_Animal(Cliente_Animal cliente_animal)
        {
            throw new NotImplementedException();
        }

        public void deletarCliente_Animal(Cliente_Animal cliente_animal)
        {
            throw new NotImplementedException();
        }

        public void insertCliente_Animal(Cliente_Animal cliente_animal)
        {
            try
            {

                this.conn.openConnection();
                string sql = "insert into animal_cliente(cliente_id,animal_id) values (@cliente_id,@animal_id)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                //cmd.Parameters.AddWithValue("@cliente_id", cliente_animal.Cliente_id.Usuario.Id);
                cmd.Parameters.AddWithValue("@cpf", cliente_animal.Animal_id.Id);
                

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Usuario :" + ce.Message);
            }
        }

        public List<Cliente_Animal> listCliente_Animal()
        {
            List<Cliente_Animal> lcliente = new List<Cliente_Animal>();
            Cliente_Animal cliente_animal = new Cliente_Animal();

            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select usuario.nome, animal.nome,especie.nome from animal_cliente inner join animal on animal.id = animal_cliente.animal_id inner join cliente on cliente.usuario_id = animal_cliente.cliente_id inner join usuario on cliente.usuario_id = usuario.id inner join especie on animal.especie_id = especie.id where usuario.id = @usuario_id";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                //cmd.Parameters.AddWithValue("@cliente_id", cliente_animal.Cliente_id.Usuario.Id);
                while (reader.Read())
                {
                    Cliente_Animal clianim = new Cliente_Animal();
                   
                 //   clianim.Cliente_id.Usuario.Nome = reader.GetString(reader.GetOrdinal("usuario.nome"));
                    clianim.Animal_id.Nome = reader.GetString(reader.GetOrdinal("animal.nome"));
                    clianim.Animal_id.Especie.Nome = reader.GetString(reader.GetOrdinal("especie.nome"));
                    lcliente.Add(clianim);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
            }

            return lcliente;

        }
    }
}

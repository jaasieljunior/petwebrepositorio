using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Util;
using Backend.Erro;

namespace Backend.Dados
{
    public class AnimalDaoImp
    {

        public Conexao conn;

        public AnimalDaoImp()
        {

            this.conn = new Conexao();
        }




        /* public Animal getAnimal(int animalId)
         {


             try
             {

                 EspecieDaoImp especieImp = new EspecieDaoImp();

                 this.conn.openConnection();
                 Animal animal = new Animal();
                 SqlCommand cmd = new SqlCommand();
                 cmd.CommandText = "SELECT id,nome FROM animal WHERE id = @animal";
                 cmd.Connection = this.conn.SqlConn;
                 cmd.Parameters.AddWithValue("@animal", animalId);
                 SqlDataReader reader = cmd.ExecuteReader();
                 while (reader.Read())
                 {


                     animal.Id = reader.GetInt32(reader.GetOrdinal("id"));
                     animal.Nome = reader.GetString(reader.GetOrdinal("nome"));
                     animal.Idade = reader.GetInt32(reader.GetOrdinal("idade"));
                     animal.Peso = reader.GetFloat(reader.GetOrdinal("peso"));
                     int especieId = reader.GetInt32(reader.GetOrdinal("especie_id"));
                     animal.Especie = especieImp.getEspecie(especieId);
                     animal.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));


                 }
                 this.conn.closeConnection();

                 return animal;
             }
             catch (SqlException ce)
             {

                 throw new DaoException("Erro ao listar Animals :" + ce.Message);
             }
         }*/

        public void insertAnimal(Animal animal)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO animal(id,nome,idade,peso,especie_id) VALUES (@id,@nome,@idade,@peso,@especie_id)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", animal.Id);
                cmd.Parameters.AddWithValue("@nome", animal.Nome);
                cmd.Parameters.AddWithValue("@idade", animal.Idade);
                cmd.Parameters.AddWithValue("@peso", animal.Peso);
                cmd.Parameters.AddWithValue("@especie_id", animal.Especie.Id);




                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Animal :" + ce.Message);
            }
        }

        public void alterarAnimal(Animal animal)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE cliente SET nome = @nome WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", animal.Nome);
                cmd.Parameters.AddWithValue("@id", animal.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Animal :" + ce.Message);
            }
        }
        public void deletarAnimal(Animal animal)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM animal WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", animal.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Deletar Animal :" + ce.Message);
            }
        }

        public List<Animal> listAnimal()
        {
            {
                List<Animal> lAnimal = new List<Animal>();

                try
                {
                    this.conn.openConnection();

                    SqlCommand cmd = new SqlCommand();
                    cmd.CommandText = "select animal.id, animal.nome, animal.idade, animal.peso, animal.data_cadastro, animal.especie_id, especie.nome from animal inner join especie on animal.especie_id = especie.id";
                    cmd.Connection = this.conn.SqlConn;
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        Animal animal = new Animal();
                        animal.Id = reader.GetInt32(reader.GetOrdinal("id"));
                        animal.Nome = reader.GetString(reader.GetOrdinal("nome"));
                        animal.Idade = reader.GetInt32(reader.GetOrdinal("idade"));
                        animal.Peso = reader.GetInt32(reader.GetOrdinal("peso"));
                        animal.DataCadastro = reader.GetDateTime(reader.GetOrdinal("data_cadastro"));
                        animal.Especie.Id = reader.GetInt32(reader.GetOrdinal("especie_id"));
                        animal.Especie.Nome = reader.GetString(reader.GetOrdinal("nome"));
                        lAnimal.Add(animal);
                    }
                    this.conn.closeConnection();
                }
                catch (SqlException ce)
                {

                    throw new DaoException("Erro ao listar Animais :" + ce.Message);
                }

                return lAnimal;



            }
        }


    }
}

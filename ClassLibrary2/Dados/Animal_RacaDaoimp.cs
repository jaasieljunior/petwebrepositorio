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
    public class Animal_RacaDaoimp : Animal_RacaDao
    {
        Conexao conn;
       public  Animal_RacaDaoimp(){
            this.conn = new Conexao();

        }
        public void alterarAnimal_Raca(Animal_Raca animal_raca)
        {
            throw new NotImplementedException();
        }

        public void deletarAnimal_Raca(Animal_Raca animal_raca)
        {
            throw new NotImplementedException();
        }

        public void insertAnimal_Raca(Animal_Raca animal_raca)
        {
            try
            {

                this.conn.openConnection();
                string sql = "insert into raca_animal(animal_id,raca_id) values (@animal_id,@raca_id)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@animal_id", animal_raca.Animal_id.Id);
                cmd.Parameters.AddWithValue("@cor_id", animal_raca.Raca_id.Id);


                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Animal_cor :" + ce.Message);
            }
        }

        public List<Animal_Raca> listAnimal_Raca()
        {
            List<Animal_Raca> lAnimalRaca = new List<Animal_Raca>();
            Animal_Raca animaraca = new Animal_Raca();

            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select animal.nome, raca.nome from animal inner join raca_animal on animal.id = raca_animal.animal_id  inner join raca on raca_animal.raca_id = raca.id where animal.id = @animal_cod";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();



                cmd.Parameters.AddWithValue("@animal_cod", animaraca.Animal_id.Id);
                while (reader.Read())
                {
                    //Animal_Cor animacor = new Animal_Cor();

                    animaraca.Animal_id.Nome = reader.GetString(reader.GetOrdinal("animal.nome"));
                    animaraca.Raca_id.Nome = reader.GetString(reader.GetOrdinal("raca.nome"));

                    lAnimalRaca.Add(animaraca);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Animais_racas :" + ce.Message);
            }

            return lAnimalRaca;
        }
    }
}

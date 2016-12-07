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
    public class Animal_CorDaoImp : Animal_CorDao
    {
        Conexao conn;
        public Animal_CorDaoImp()
        {

            this.conn = new Conexao();

        }
        public void alterarAnimal_Cor(Animal_Cor animal_cor)
        {
            throw new NotImplementedException();
        }

        public void deletarAnimal_Cor(Animal_Cor animal_cor)
        {
            throw new NotImplementedException();
        }

        public void insertAnimal_Cor(Animal_Cor animal_cor)
        {
            try
            {

                this.conn.openConnection();
                string sql = "insert into cor_animal(animal_id,cor_id) values (@animal_id,@cor_id)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@animal_id", animal_cor.Animal_id.Id);
                cmd.Parameters.AddWithValue("@cor_id", animal_cor.Cor_id.Id);


                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Animal_cor :" + ce.Message);
            }
        }

        public List<Animal_Cor> listAnimal_Cor()
        {
            List<Animal_Cor> lAnimalCor = new List<Animal_Cor>();
            Animal_Cor animacor = new Animal_Cor();

            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select animal.nome, cor.nome from animal inner join cor_animal on animal.id = cor_animal.animal_id inner join cor on cor_animal.cor_id = cor.id where animal.id = @animal_cod";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                
                
                
                cmd.Parameters.AddWithValue("@animal_cod", animacor.Animal_id.Id);
                while (reader.Read())
                {
                   //Animal_Cor animacor = new Animal_Cor();

                    animacor.Animal_id.Nome = reader.GetString(reader.GetOrdinal("animal.nome"));
                    animacor.Cor_id.Nome = reader.GetString(reader.GetOrdinal("cor.nome"));

                    lAnimalCor.Add(animacor);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
            }

            return lAnimalCor;

        }


    }
}

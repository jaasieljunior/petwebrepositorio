using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Basicas;
using Backend.Erro;
using Backend.Util;

namespace Backend.Dados
{
    public class RacaDaoImp : RacaDao
    {
        Conexao conn;
        
        public RacaDaoImp(){

            this.conn = new Conexao();
        }

        public void AlterarRaca(Raca raca)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE raca SET nome = @nome WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", raca.Nome);
                
                cmd.Parameters.AddWithValue("@id", raca.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Raça :" + ce.Message);
            }
        }

        public void DeletarRaca(Raca raca)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM raca WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", raca.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Excluir Raça :" + ce.Message);
            }
        }

        public void insertRaca(Raca raca)
        {
            try
            {

                this.conn.openConnection();
                //string sql = "INSERT INTO raca(id,nome) VALUES (@id,@nome)";
               string sql = "INSERT INTO raca(nome) VALUES (@nome)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                //cmd.Parameters.AddWithValue("@id", raca.Id);
                cmd.Parameters.AddWithValue("@nome", raca.Nome);
               


                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Raça :" + ce.Message);
            }
        }

        public List<Raca> listRaca()
        {
            List<Raca> lRaca = new List<Raca>();

            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "select id,nome from cor";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Raca raca = new Raca();
                    raca.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    raca.Nome = reader.GetString(reader.GetOrdinal("nome"));

                    lRaca.Add(raca);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Raça :" + ce.Message);
            }

            return lRaca;
        }
    }
}

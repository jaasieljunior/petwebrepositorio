using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using Backend.Erro;

namespace Backend.Dados
{
    public class VacinaDaoImp : VacinaDao
    {
        Conexao conn;

        public VacinaDaoImp()
        {
            this.conn = new Conexao();
        }


        public void inserirVacina(Vacina vacina)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO vacina (nome,descricao,data_cadastro) VALUES (@nome,@descricao,@data_cadastro)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                //cmd.Parameters.AddWithValue("@nome,@descricao,@data_cadastro", vacina.Nome, vacina.Descricao);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException e)
            {

                throw new DaoException("Erro ao Inserir a vacina :" + e.Message);
            }
            
                
        }


        public void alterarVacina(Vacina vacina)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE vacina SET nome = @nome,descricao = @descricao,data_cadastro = @data_cadastro WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", vacina.Nome);
                cmd.Parameters.AddWithValue("@id", vacina.Id);
                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException e)
            {

                throw new DaoException("Erro ao Alterar a vacina :" + e.Message);
            }


        }


        public void deletarVacina(Vacina vacina)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM vacina WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", vacina.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }catch (SqlException ce){

                throw new DaoException("Erro ao Alterar Vacina :" + ce.Message);
            }


        }


        public List<Vacina> listVacina() { 
        
            List<Vacina> lVacina = new List<Vacina>();
            
            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select id,nome from vacina";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Vacina vacina = new Vacina();
                    vacina.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    vacina.Nome = reader.GetString(reader.GetOrdinal("nome"));
                    lVacina.Add(vacina);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Vacinas :" + ce.Message);
            }

            return lVacina;



        }
    }
}


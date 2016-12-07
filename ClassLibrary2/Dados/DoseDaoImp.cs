using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Backend.Util;
using Backend.Basicas;
using System.Data.SqlClient;
using Backend.Erro;

namespace Backend.Dados
{
    public class DoseDaoImp : DoseDao
    {

        Conexao conn;

        public DoseDaoImp()
        {
            this.conn = new Conexao();
        }


        public void insertDose(Dose dose)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO dose (dosagem,numero,data_cadastro) VALUES (@dosagem , @numero , NOW())";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", dose.Dosagem);
                cmd.Parameters.AddWithValue("@numero", dose.Numero);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Dose :" + ce.Message);
            }
            
                
        }



        public void alterarDose(Dose dose)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE dose SET dosagem = @dosagem , numero = @numero WHERE id = @id";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@dosagem", dose.Dosagem);
                cmd.Parameters.AddWithValue("@numero", dose.Numero);
                cmd.Parameters.AddWithValue("@id", dose.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Dose :" + ce.Message);
            }


        }


        public void deletarDose(Dose dose)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM dose WHERE id = @id";
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;
                    
                cmd.Parameters.AddWithValue("@id", dose.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }catch (SqlException ce){

                throw new DaoException("Erro ao deletar dose :" + ce.Message);
            }


        }


        public List<Dose> listDose() { 
        
            List<Dose> lDose = new List<Dose>();
            
            try
            {
                this.conn.openConnection();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "Select id,nome from dose";
                cmd.Connection = this.conn.SqlConn;
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Dose dose = new Dose();
                    dose.Id = reader.GetInt32(reader.GetOrdinal("id"));
                    dose.Dosagem = reader.GetString(reader.GetOrdinal("dosagem"));
                    dose.Numero = reader.GetFloat(reader.GetOrdinal("numero"));

                    lDose.Add(dose);
                }
                this.conn.closeConnection();
            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao listar Doses :" + ce.Message);
            }

            return lDose;



        }

    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Backend.Basicas;
using Backend.Erro;
using Backend.Util;

namespace Backend.Dados
{
    public class CorDaoImp : CorDao
    {

        Conexao conn;
        public CorDaoImp()
        {

            this.conn = new Conexao();

        }
        public void AlterarCor(Cor cor)
        {
            try
            {

                this.conn.openConnection();
                string sql = "UPDATE cor SET nome = @nome WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@nome", cor.Nome);
                cmd.Parameters.AddWithValue("@id", cor.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Alterar Usuario :" + ce.Message);
            }
        }

        public void DeletarCor(Cor cor)
        {
            try
            {

                this.conn.openConnection();
                string sql = "DELETE FROM cor WHERE id = @id";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                cmd.Parameters.AddWithValue("@id", cor.Id);

                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Excluir Cor :" + ce.Message);
            }
        }

        public void insertCor(Cor cor)
        {
            try
            {

                this.conn.openConnection();
                string sql = "INSERT INTO cor(nome) VALUES (@nome)";
                //SqlCommand cmd = new SqlCommand(sql, conn.getConn());
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = this.conn.SqlConn;
                cmd.CommandText = sql;

                //cmd.Parameters.AddWithValue("@id", cor.Id);
                cmd.Parameters.AddWithValue("@nome", cor.Nome);



                cmd.ExecuteNonQuery();
                this.conn.closeConnection();


            }
            catch (SqlException ce)
            {

                throw new DaoException("Erro ao Inserir Cor :" + ce.Message);
            }
        }


        public List<Cor> listCor()
        {
            try
            {
                XmlDocument medidas = new XmlDocument();
                medidas.Load(@"C:\Users\Moises\Desktop\Eudes\petweB\ClassLibrary2\File\Cores.xml");
                List<Cor> listMedida = new List<Cor>();
                foreach (XmlNode item in medidas.DocumentElement.ChildNodes)
                {
                    Cor cor = new Cor();
                    cor.Nome = item.ChildNodes.Item(0).ChildNodes.Item(0).InnerText;
                    listMedida.Add(cor);
                }
                return listMedida;
            }

            catch (GeralException c)
            {
                throw new GeralException(c.Message);
            }

        }


        /* public List<Cor> listCor()
       {
           List<Cor> lCor = new List<Cor>();

           try
           {
               this.conn.openConnection();

               SqlCommand cmd = new SqlCommand();
               cmd.CommandText = "select id,nome from cor";
               cmd.Connection = this.conn.SqlConn;
               SqlDataReader reader = cmd.ExecuteReader();
               while (reader.Read())
               {
                   Cor cor = new Cor();
                   cor.Id = reader.GetInt32(reader.GetOrdinal("id"));
                   cor.Nome = reader.GetString(reader.GetOrdinal("nome"));

                   lCor.Add(cor);
               }
               this.conn.closeConnection();
           }
           catch (SqlException ce)
           {

               throw new DaoException("Erro ao listar Usuarios :" + ce.Message);
           }

           return lCor;

       } */
    }
}
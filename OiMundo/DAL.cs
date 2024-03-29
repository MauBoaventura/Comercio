﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlServerCe;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace OiMundo
{
    public class DAL
    {
        private static SqlConnection objSqlCeConnection = null;
        private static DAL objSqlServerCeDAL = null;
        private static string connString = null;
        public DAL()
        {
            string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Maurício\\Documents\\Mercado.mdf;Integrated Security=True;Connect Timeout=30";
            objSqlCeConnection = new SqlConnection(connString);
            //Console.WriteLine("Hello World!");

            // SqlCommand dCmd = new SqlCommand(@"Alter Table dbo.customer ADD DateOfVisit DATETIME NOT NULL DEFAULT(GETDATE());", objSqlCeConnection);
            // dCmd.ExecuteNonQuery();
        }

        public static DAL GetInstance(string connString)
        {
            if (objSqlServerCeDAL == null)
            {
                objSqlServerCeDAL = new DAL();
            }
            return objSqlServerCeDAL;
        }
        public void Open()
        {
            try
            {
                if (objSqlCeConnection.State == ConnectionState.Closed)
                {
                    objSqlCeConnection.Open();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

      

        public void Dispose()
        {
            try
            {
                if (objSqlCeConnection.State != ConnectionState.Closed)
                {
                    objSqlCeConnection.Close();
                    objSqlCeConnection.Dispose();
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public int Insert(Produto _produto, string sql)
        {
            DAL objSqlCeServerDAL = DAL.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCommand dCmd = new SqlCommand(sql, objSqlCeConnection);
            dCmd.CommandType = CommandType.Text;
            try
            {
                dCmd.Parameters.AddWithValue("@CodBarras", _produto.CodBarras);
                dCmd.Parameters.AddWithValue("@Descricao", _produto.Descricao);
                dCmd.Parameters.AddWithValue("@Quantidade", _produto.Quantidade);
                dCmd.Parameters.AddWithValue("@PrecoCompra", _produto.PrecoCompra);
                dCmd.Parameters.AddWithValue("@PrecoVenda", _produto.PrecoVenda);
                dCmd.Parameters.AddWithValue("@Validade", _produto.Validade);
                Console.WriteLine(sql);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }
        public int Update(Produto _produto, string sql)
        {
            DAL objSqlCeServerDAL = DAL.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCommand dCmd = new SqlCommand(sql, objSqlCeConnection);
            dCmd.CommandType = CommandType.Text;
            try
            {
                dCmd.Parameters.AddWithValue("@CodBarras", _produto.CodBarras);
                dCmd.Parameters.AddWithValue("@Descricao", _produto.Descricao);
                dCmd.Parameters.AddWithValue("@Quantidade", _produto.Quantidade);
                dCmd.Parameters.AddWithValue("@PrecoCompra", _produto.PrecoCompra);
                dCmd.Parameters.AddWithValue("@PrecoVenda", _produto.PrecoVenda);
                dCmd.Parameters.AddWithValue("@Validade", _produto.Validade);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }
        public DataTable Load(string sql)
        {
            DAL objSqlCeServerDAL = DAL.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlDataAdapter dAd = new SqlDataAdapter(sql, objSqlCeConnection);
            dAd.SelectCommand.CommandType = CommandType.Text;
            DataSet dSet = new DataSet();
            try
            {
                dAd.Fill(dSet, "Produtos");
                return dSet.Tables["Produtos"];
            }
            catch
            {
                throw;
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }
        public int Delete(int Id, string sql)
        {
            DAL objSqlCeServerDAL = DAL.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCommand dCmd = new SqlCommand(sql, objSqlCeConnection);
            dCmd.CommandType = CommandType.Text;
            try
            {
                dCmd.Parameters.AddWithValue("@Id", Id);
                return dCmd.ExecuteNonQuery();
            }
            catch
            {
                throw;
            }
            finally
            {
                dCmd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }

        public DataTable SelectById(int Id, string sql)
        {
            DAL objSqlCeServerDAL = DAL.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlDataAdapter dAd = new SqlDataAdapter(sql, objSqlCeConnection);
            dAd.SelectCommand.CommandType = CommandType.Text;
            DataSet dSet = new DataSet();
            try
            {
                dAd.Fill(dSet, "tbProdutos");
                return dSet.Tables["tbProdutos"];
            }
            catch
            {
                throw;
            }
            finally
            {
                dSet.Dispose();
                dAd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
        }

        public Produto SelectByCod(string cmdSelecionarByCod, string CodBarras)
        {
            DAL objSqlCeServerDAL = DAL.GetInstance(connString);
            objSqlCeServerDAL.Open();
            SqlCommand dCmd = new SqlCommand(cmdSelecionarByCod, objSqlCeConnection);
            dCmd.CommandType = CommandType.Text;
            try
            {
                dCmd.Parameters.AddWithValue("@CodBarras", CodBarras);
                SqlDataReader reader = dCmd.ExecuteReader();

                reader.Read();
                int id = reader.GetInt32(0);
                string cod = reader.GetString(1);
                string desc = reader.GetString(2);
                int quant = reader.GetInt32(3);
                string preco = reader.GetString(5);
                Produto p=new Produto();
                p.Id = id;
                p.CodBarras = cod;
                p.Descricao = desc;
                p.Quantidade = quant;
                p.PrecoVenda = preco;
                return p;
            }
            catch
            {
                MessageBox.Show("Produto não cadastrado");
            }
            finally
            {
                dCmd.Dispose();
                objSqlCeServerDAL.Dispose();
            }
            return null;
        }

    }
}






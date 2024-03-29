﻿using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace DAO
{
    public class AnimalDAO
    {
        public int qtd;
        public int Inserir(AnimalEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                try
                {
                    con.ConnectionString = DAO.Properties.Settings.Default.banco;
                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    con.Open();
                    cn.CommandText = "INSERT INTO Animal ([especie], [raca], [nome], [idadenumero1], [idadetipo1], [idadenumero2], [idadetipo2], [proprietario], [telefone], [email], [cuidados_esp], [alergico]) VALUES (@especie, @raca, @nome, @idadenumero1,  @idadetipo1, @idadenumero2, @idadetipo2, @proprietario, @telefone, @email, @cuidados_esp, @alergico)";
                    cn.Parameters.Add("especie", SqlDbType.VarChar).Value = objTabela.Especie;
                    cn.Parameters.Add("raca", SqlDbType.VarChar).Value = objTabela.Raca;
                    cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;
                    cn.Parameters.Add("idadenumero1", SqlDbType.VarChar).Value = objTabela.Idadenumero1;
                    cn.Parameters.Add("idadetipo1", SqlDbType.VarChar).Value = objTabela.Idadetipo1;
                    cn.Parameters.Add("idadenumero2", SqlDbType.VarChar).Value = objTabela.Idadenumero2;
                    cn.Parameters.Add("idadetipo2", SqlDbType.VarChar).Value = objTabela.Idadetipo2;
                    cn.Parameters.Add("proprietario", SqlDbType.VarChar).Value = objTabela.Proprietario;
                    cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                    cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                    cn.Parameters.Add("cuidados_esp", SqlDbType.VarChar).Value = objTabela.Cuidados_esp;
                    cn.Parameters.Add("alergico", SqlDbType.VarChar).Value = objTabela.Alergico;
                    //cn.Parameters.Add("foto", SqlDbType.Binary).Value = objTabela.Foto;
                    cn.Connection = con;
                    qtd = cn.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error DAO - INSERT: " + ex.Message);
                }
                return qtd;
            }
        }
        public List<AnimalEnt> Buscar(AnimalEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Animal WHERE nome like @nome";
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome + "%";
                cn.Connection = con;
                SqlDataReader dr;
                List<AnimalEnt> lista = new List<AnimalEnt>();

                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AnimalEnt dado = new AnimalEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Especie = Convert.ToString(dr["especie"]);
                        dado.Raca = Convert.ToString(dr["raca"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Idadenumero1 = Convert.ToString(dr["idadenumero1"]);
                        dado.Idadetipo1 = Convert.ToString(dr["idadetipo1"]);
                        dado.Idadenumero2 = Convert.ToString(dr["idadenumero2"]);
                        dado.Idadetipo2 = Convert.ToString(dr["idadetipo2"]);
                        dado.Proprietario = Convert.ToString(dr["proprietario"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Cuidados_esp = Convert.ToString(dr["cuidados_esp"]);
                        dado.Alergico = Convert.ToString(dr["alergico"]);

                        if (dr["foto"] != DBNull.Value)
                        {
                            dado.Foto = (byte[])dr["foto"];
                        }

                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
        public int Editar(AnimalEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "UPDATE Animal SET especie = @especie, raca = @raca, nome = @nome, " +
                                "idadenumero1 = @idadenumero1, idadetipo1 = @idadetipo1, idadenumero2 = @idadenumero2, " +
                                "idadetipo2 = @idadetipo2, proprietario = @proprietario,  telefone = @telefone,  " +
                                "email = @email, cuidados_esp = @cuidados_esp, alergico = @alergico WHERE id = @id";
                cn.Parameters.Add("especie", SqlDbType.VarChar).Value = objTabela.Especie;
                cn.Parameters.Add("raca", SqlDbType.VarChar).Value = objTabela.Raca;
                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = objTabela.Nome;

                cn.Parameters.Add("idadenumero1", SqlDbType.VarChar).Value = objTabela.Idadenumero1;
                cn.Parameters.Add("idadetipo1", SqlDbType.VarChar).Value = objTabela.Idadetipo1;
                cn.Parameters.Add("idadenumero2", SqlDbType.VarChar).Value = objTabela.Idadenumero2;
                cn.Parameters.Add("idadetipo2", SqlDbType.VarChar).Value = objTabela.Idadetipo2;

                cn.Parameters.Add("proprietario", SqlDbType.VarChar).Value = objTabela.Proprietario;
                cn.Parameters.Add("telefone", SqlDbType.VarChar).Value = objTabela.Telefone;
                cn.Parameters.Add("email", SqlDbType.VarChar).Value = objTabela.Email;
                cn.Parameters.Add("cuidados_esp", SqlDbType.VarChar).Value = objTabela.Cuidados_esp;
                cn.Parameters.Add("alergico", SqlDbType.VarChar).Value = objTabela.Alergico;
                cn.Parameters.Add("id", SqlDbType.Int).Value = Convert.ToInt32(objTabela.Id);
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }
        public int Excluir(AnimalEnt objTabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "DELETE FROM Animal WHERE id = @id";
                cn.Parameters.Add("id", SqlDbType.Int).Value = objTabela.Id;
                cn.Connection = con;
                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }

        }
        public DataTable ListaDataTable()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                con.Open();
                string query = "SELECT * FROM Animal ORDER BY nome ASC";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
        }

        public List<AnimalEnt> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = DAO.Properties.Settings.Default.banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();
                cn.CommandText = "SELECT * FROM Animal ORDER BY nome ASC";
                cn.Connection = con;
                SqlDataReader dr;
                List<AnimalEnt> lista = new List<AnimalEnt>();
                dr = cn.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        AnimalEnt dado = new AnimalEnt();
                        dado.Id = Convert.ToInt32(dr["id"]);
                        dado.Especie = Convert.ToString(dr["especie"]);
                        dado.Raca = Convert.ToString(dr["raca"]);
                        dado.Nome = Convert.ToString(dr["nome"]);
                        dado.Idadenumero1 = Convert.ToString(dr["idadenumero1"]);
                        dado.Idadetipo1 = Convert.ToString(dr["idadetipo1"]);
                        dado.Idadenumero2 = Convert.ToString(dr["idadenumero2"]);
                        dado.Idadetipo2 = Convert.ToString(dr["idadetipo2"]);
                        dado.Proprietario = Convert.ToString(dr["proprietario"]);
                        dado.Telefone = Convert.ToString(dr["telefone"]);
                        dado.Email = Convert.ToString(dr["email"]);
                        dado.Cuidados_esp = Convert.ToString(dr["cuidados_esp"]);
                        dado.Alergico = Convert.ToString(dr["alergico"]);

                        if (dr["foto"] != DBNull.Value) 
                        {
                            dado.Foto = (byte[])dr["foto"];
                        }
                        
                        lista.Add(dado);
                    }
                }
                return lista;
            }
        }
    }
}
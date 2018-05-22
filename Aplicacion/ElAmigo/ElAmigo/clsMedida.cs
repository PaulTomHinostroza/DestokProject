﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ElAmigo
{
    public class clsMedida
    {
        private int _IdMedida;
        private string _DescripcionMed;
        private string _AbreviaturaMed;
        
        //constructor para insertar medida
        public clsMedida(string parDescripcionMed, string parAbreviaturaMed)
        {
            DescripcionMed = parDescripcionMed;
            AbreviaturaMed = parAbreviaturaMed;

        }

        //constructor para lista medida
        public clsMedida(int parIdMedida, string parDescripcionMed, string parAbreviaturaMed)
        {
            IdMedida = parIdMedida;
            DescripcionMed = parDescripcionMed;
            AbreviaturaMed = parAbreviaturaMed;

        }
        public int IdMedida
        {
            get { return _IdMedida; }
            set { _IdMedida = value; }
        }

        public string AbreviaturaMed
        {
            get { return _AbreviaturaMed; }
            set { _AbreviaturaMed = value.ToUpper(); }
        }

        public string DescripcionMed
        {
            get { return _DescripcionMed; }
            set { _DescripcionMed = value.ToUpper(); }
        }


        public void InsertarMedida()
        {
            SqlConnection conexion = new SqlConnection(mdlVariables.CadenaDeConexion);
            SqlCommand cmd = new SqlCommand("usp_Medida_Insertar", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parDescripcion_Med", DescripcionMed);
            cmd.Parameters.AddWithValue("@parAbreviatura_Med", AbreviaturaMed);
            conexion.Open();
            cmd.ExecuteReader();
            conexion.Close();
        }

        public static List<clsMedida> ListarMedidaTodos()
        {
            List<clsMedida> x = new List<clsMedida>();
            SqlConnection conexion = new SqlConnection(mdlVariables.CadenaDeConexion);
            SqlCommand cmd = new SqlCommand("usp_Medida_Listar_Todos", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            conexion.Open();
            SqlDataReader contenedor;
            contenedor = cmd.ExecuteReader();

            while (contenedor.Read() == true)
            {
                clsMedida MiObjeto;
                MiObjeto = new clsMedida(Convert.ToInt32(contenedor["IdMedida"]),contenedor["Descripcion_Med"].ToString(),
                                            contenedor["Abreviatura_Med"].ToString());

                x.Add(MiObjeto);
            }
            conexion.Close();
            return x;
        }

        public static List<clsMedida> ListarMedidaPorDescripcion(string parDescripcion)
        {
            List<clsMedida> x = new List<clsMedida>();
            SqlConnection conexion = new SqlConnection(mdlVariables.CadenaDeConexion);
            SqlCommand cmd = new SqlCommand("usp_Medida_ListarPorDescripcion", conexion);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@parDescripcion_Med", parDescripcion);
            conexion.Open();
            SqlDataReader contenedor;
            contenedor = cmd.ExecuteReader();

            while (contenedor.Read() == true)
            {
                clsMedida MiObjeto;
                MiObjeto = new clsMedida(Convert.ToInt32(contenedor["IdMedida"]), contenedor["Descripcion_Med"].ToString(),
                                            contenedor["Abreviatura_Med"].ToString());

                x.Add(MiObjeto);
            }
            conexion.Close();
            return x;
        }
    }
}

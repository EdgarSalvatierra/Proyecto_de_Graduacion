﻿using Capa_Datos.Data.Conexion;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Capa_Datos.Model;
using System.Collections;

namespace Capa_Datos.Data.Paciente
{
    public class PacienteData
    {
        ConexionSql conexion = new ConexionSql();

        public SqlCommand command;

        SqlDataReader reader;

        public void Delete(int Id)
        {
            try
            {
                string query = $@"Delete From tbl_Registros_de_Pacientes where Cod_paciente = '{Id}'";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Codigo", Id));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }

        public void Insert(string Nombre, string Apellido,long telefono, DateTime FechadeNacimiento, string sexo)
        {
            try
            {
                command = new SqlCommand("Sp_Paciente_Insert", conexion.abrirconexion());

                command.CommandType = CommandType.StoredProcedure;

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                command.Parameters.Add(new SqlParameter("@Apellido", Apellido));

                command.Parameters.Add(new SqlParameter("@Fecha_de_Nacimiento", FechadeNacimiento));

                command.Parameters.Add(new SqlParameter("@Telefono", telefono));

                command.Parameters.Add(new SqlParameter("@Sexo", sexo));

                command.ExecuteNonQuery();
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable Read()
        {
            try
            {
                string query = $@"Select Cod_paciente as 'Codigo',Nombre as 'Nombre',Apellido as 'Apellido',Fecha_de_Nacimiento as 'Fecha de Nacimiento',Edad as 'Edad',Sexo as 'Sexo',Telefono as 'Telefono'
                           From tbl_Registros_de_Pacientes where Estado = 1";

                command = new SqlCommand(query, conexion.abrirconexion());

                SqlDataAdapter adapter = new SqlDataAdapter();

                adapter.SelectCommand = command;

                DataTable data = new DataTable();

                adapter.Fill(data);

                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable CargarDatos()
        {
            try
            {
                string query = "Select Cod_paciente,Nombre From tbl_Registros_de_Pacientes";

                command = new SqlCommand(query, conexion.abrirconexion());

                DataTable data = new DataTable();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    data.Load(reader);
                }
                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public DataTable ReadForName(string Codigo)
        {
            try
            {
                string query = $@"select Cod_paciente as 'Codigo',Nombre,Fecha_de_Nacimiento as 'Fecha de Nacimiento',Sexo,Telefono From tbl_Registros_de_Pacientes where Nombre Like '{Codigo}' + '%'";

                command = new SqlCommand(query, conexion.abrirconexion()); ;

                DataTable data = new DataTable();

                reader = command.ExecuteReader();

                if (reader.HasRows)
                {
                    data.Load(reader);
                }
                return data;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public void UpdateEstado(DateTime Numero)
        {
            try
            {
                string query = $@"Update tbl_Registros_de_Pacientes set Estado = 0 where Fecha_de_Nacimiento = Convert(date,@Numero) ";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Numero", Numero));

                command.ExecuteNonQuery();
            }
             finally
            {
                conexion.cerrarconexion();
            }
        }
        public int CargarPacienteEdad(string Nombre)
        {
            try
            {
                List<Registro_Paciente> lista = new List<Registro_Paciente>();

                string query = $@"select Edad From tbl_Registros_de_Pacientes where Nombre = @Nombre";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verificar si la columna existe antes de intentar leerla
                        if (reader.HasRows)
                        {
                            lista.Add(new Registro_Paciente
                            {
                                Edad = Convert.ToInt32(reader["Edad"])
                            });
                        }
                    }
                }

                return lista.FirstOrDefault().Edad;
            }
            finally
            {
                conexion.cerrarconexion();
            }
        }
        public string CargarPacienteSexo(string Nombre)
        {
            try
            {
                List<Registro_Paciente> lista = new List<Registro_Paciente>();

                string query = $@"select Sexo From tbl_Registros_de_Pacientes where Nombre = @Nombre";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verificar si la columna existe antes de intentar leerla
                        if (reader.HasRows)
                        {
                            lista.Add(new Registro_Paciente
                            {
                                Sexo = reader["Sexo"].ToString()
                            });
                        }
                    }
                }
                return lista.FirstOrDefault()?.Sexo;
            }
            finally
            {
              conexion.cerrarconexion();
            }
        }
        public long CargarPacienteTelefono(string Nombre)
        {
            try
            {
                List<Registro_Paciente> lista = new List<Registro_Paciente>();

                string query = $@"select Telefono From tbl_Registros_de_Pacientes where Nombre = @Nombre";

                command = new SqlCommand(query, conexion.abrirconexion());

                command.Parameters.Add(new SqlParameter("@Nombre", Nombre));

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Verificar si la columna existe antes de intentar leerla
                        if (reader.HasRows)
                        {
                            lista.Add(new Registro_Paciente
                            {
                                Telefono = Convert.ToInt64(reader["Telefono"])
                            });
                        }
                    }
                }

                return lista.FirstOrDefault().Telefono;
            }
            finally
            {
                conexion.cerrarconexion();
            }
           
        }
    }
}

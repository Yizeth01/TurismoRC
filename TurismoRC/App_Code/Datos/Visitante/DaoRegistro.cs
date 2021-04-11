using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;


public class DaoRegistro
{
    public void insertarRegistro(ERegistro solicitud)
    {
        using (var db = new Mapeo())
        {
            db.Registro.Add(solicitud);
            db.SaveChanges();
        }
    }


    public int validarUsuario(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_usuario", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_usuario", NpgsqlDbType.Text).Value = user.Usuario;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_usuario"].ToString());
    }

    public int validarUsuarioRegistro(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_usuario_registro", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_usuario", NpgsqlDbType.Text).Value = user.Usuario;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_usuario_registro"].ToString());
    }

    public int validarDocumento(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_documento", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Text).Value = user.Documento;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_documento"].ToString());
    }
    public int validarCorreo(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_correo", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = user.Correo;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_correo"].ToString());
    }

    public int validarDocumentoRegistro(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_documento_registro", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_documento", NpgsqlDbType.Text).Value = user.Documento;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_documento_registro"].ToString());
    }

    public int validarCorreoRegistro(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_correo_registro", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_correo", NpgsqlDbType.Text).Value = user.Correo;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_correo_registro"].ToString());
    }

    public int validarTelefono(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_telefono", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = user.Telefono;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_telefono"].ToString());
    }

    public int validarDireccion(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_direccion", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = user.Direccion;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_direccion"].ToString());
    }

    public int validarTelefonoRegistro(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_telefono_registro", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_telefono", NpgsqlDbType.Text).Value = user.Telefono;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_telefono_registro"].ToString());
    }

    public int validarDireccionRegistro(ERegistro user)
    {
        DataTable Usuario = new DataTable();
        NpgsqlConnection conection = new NpgsqlConnection(ConfigurationManager.ConnectionStrings["Conexion"].ConnectionString);
        try
        {
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter("usuarios.f_validar_direccion_registro", conection);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("_direccion", NpgsqlDbType.Text).Value = user.Direccion;

            conection.Open();
            dataAdapter.Fill(Usuario);

        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            if (conection != null)
            {
                conection.Close();
            }
        }

        return int.Parse(Usuario.Rows[0]["f_validar_direccion_registro"].ToString());
    }

    public List<ERegistro> obtenerSolicitudes()
    {
        using (var db = new Mapeo())
        {
            return (from uu in db.Registro
                    ///join estado in db.Estado on uu.EstadoId equals estado.Id

                    select new
                    {
                        uu,
                        //estado


                    }).ToList().Select(m => new ERegistro
                    {
                        Id = m.uu.Id,
                        Nombre = m.uu.Nombre,
                        Direccion = m.uu.Direccion,
                        Correo = m.uu.Correo,
                        Usuario = m.uu.Usuario,
                        Clave = m.uu.Clave,
                        Documento = m.uu.Documento,
                        Telefono = m.uu.Telefono,
                        EstadoId = m.uu.EstadoId,
                        //Estado = m.estado.Nombre


                    }).ToList();
        }

    }

}
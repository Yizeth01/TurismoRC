using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class View_Visitante_Registro : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {


    }

    protected void BTN_Preregistro_Click(object sender, EventArgs e)
    {
        
            ERegistro solicitud = new ERegistro();



            if (TB_Nombre.Text == "" || TB_Direccion.Text == "" || TB_Correo.Text == "" || TB_Usuario.Text == ""
                || TB_Clave.Text == "" || TB_Telefono.Text == "" || TB_Documento.Text == "")
            {

                ClientScriptManager cm = this.ClientScript;
                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('POR FAVOR INGRESE TODOS LOS VALORES');</script>");
            }
            else
            {

                solicitud.Nombre = TB_Nombre.Text;
                solicitud.Nombre = solicitud.Nombre.Trim();
                solicitud.Nombre = solicitud.Nombre.ToLower();
                solicitud.Direccion = TB_Direccion.Text;
                solicitud.Direccion = solicitud.Direccion.Trim();
                solicitud.Direccion = solicitud.Direccion.ToLower();
                solicitud.Correo = TB_Correo.Text;
                solicitud.Correo = solicitud.Correo.Trim();
                solicitud.Usuario = TB_Usuario.Text;
                solicitud.Usuario = solicitud.Usuario.Trim();
                solicitud.Clave = TB_Clave.Text;
                solicitud.Telefono = TB_Telefono.Text;
                solicitud.Telefono = solicitud.Telefono.Trim();
                solicitud.Documento = TB_Documento.Text;
                solicitud.Documento = solicitud.Documento.Trim();
                solicitud.EstadoId = 2;
                solicitud.ValidarUsuario = new DaoRegistro().validarUsuario(solicitud);
                solicitud.ValidarCorreo = new DaoRegistro().validarCorreo(solicitud);
                solicitud.ValidarDocumento = new DaoRegistro().validarDocumentoRegistro(solicitud);
                solicitud.ValidarUsuario2 = new DaoRegistro().validarUsuarioRegistro(solicitud);
                solicitud.ValidarCorreo2 = new DaoRegistro().validarCorreoRegistro(solicitud);
                solicitud.ValidarDocumento2 = new DaoRegistro().validarDocumentoRegistro(solicitud);
                solicitud.ValidarTelefono = new DaoRegistro().validarTelefono(solicitud);
                solicitud.ValidarDireccion = new DaoRegistro().validarDireccion(solicitud);
                solicitud.ValiarTelefonoRegistro = new DaoRegistro().validarTelefonoRegistro(solicitud);
                solicitud.ValidarDireccionRegistro = new DaoRegistro().validarDireccionRegistro(solicitud);

                if (solicitud.ValidarUsuario == 1)
                {
                    if (solicitud.ValidarDocumento == 1)
                    {
                        if (solicitud.ValidarCorreo == 1)
                        {
                            if (solicitud.ValidarUsuario2 == 1)
                            {
                                if (solicitud.ValidarDocumento2 == 1)
                                {
                                    if (solicitud.ValidarCorreo2 == 1)
                                    {
                                        if (solicitud.ValidarTelefono == 1)
                                        {
                                            if (solicitud.ValiarTelefonoRegistro == 1)
                                            {
                                                if (solicitud.ValidarDireccion == 1)
                                                {
                                                    if (solicitud.ValidarDireccionRegistro == 1)
                                                    {
                                                        new DaoRegistro().insertarRegistro(solicitud);
                                                        ClientScriptManager cm = this.ClientScript;
                                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('SU SOLICITUD HA SIDO EXITOSA');</script>");
                                                        //Response.Redirect("~/CatalogoVisitante.aspx");
                                                        TB_Nombre.Text = "";
                                                        TB_Direccion.Text = "";
                                                        TB_Correo.Text = "";
                                                        TB_Usuario.Text = "";
                                                        TB_Clave.Text = "";
                                                        TB_Telefono.Text = "";
                                                        TB_Documento.Text = "";

                                                    }
                                                    else
                                                    {
                                                        ClientScriptManager cm = this.ClientScript;
                                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('LA DIRECCION YA ESTA REGISTRADA');</script>");

                                                    }
                                                }
                                                else
                                                {
                                                    ClientScriptManager cm = this.ClientScript;
                                                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('LA DIRECCION YA ESTA REGISTRADA');</script>");

                                                }
                                            }
                                            else
                                            {
                                                ClientScriptManager cm = this.ClientScript;
                                                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL TELEFONO YA ESTA REGISTRADO');</script>");

                                            }
                                        }
                                        else
                                        {
                                            ClientScriptManager cm = this.ClientScript;
                                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL TELEFONO YA ESTA REGISTRADO');</script>");

                                        }
                                    }
                                    else
                                    {
                                        ClientScriptManager cm = this.ClientScript;
                                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL CORREO YA ESTA REGISTRADO');</script>");

                                    }
                                }
                                else
                                {
                                    ClientScriptManager cm = this.ClientScript;
                                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL DOCUMENTO YA ESTA REGISTRADO');</script>");

                                }
                            }
                            else
                            {
                                ClientScriptManager cm = this.ClientScript;
                                cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL USUARIO YA ESTA REGISTRADO');</script>");

                            }

                        }
                        else
                        {
                            ClientScriptManager cm = this.ClientScript;
                            cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL CORREO YA ESTA REGISTRADO');</script>");
                        }
                    }
                    else
                    {
                        ClientScriptManager cm = this.ClientScript;
                        cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL DOCUMENTO YA ESTA REGISTRADO');</script>");
                    }
                }
                else
                {
                    ClientScriptManager cm = this.ClientScript;
                    cm.RegisterClientScriptBlock(this.GetType(), "", "<script type='text/javascript'>alert('EL NOMBRE DE USUARIO YA EXISTE');</script>");
                }

            }
        }




    }



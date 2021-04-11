using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

[Serializable]
[Table("usuario", Schema = "usuarios")]
public class EUser
{
    private int id;
    private string nombre;
    private string documento;
    private string correo;
    private string direccion;
    private string telefono;
    private string clave;
    private int rolId;
    private int estadoId;
    private string userName;
    private int validarUsuario;
    private int validarCorreo;
    private int validarDocumento;
    private int validarUsuario2;
    private int validarCorreo2;
    private int validarDocumento2;
    private int validarDireccion;
    private int validarDireccionRegistro;
    private int validarTelefono;
    private int valiarTelefonoRegistro;




    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }
    [Column("cedula")]
    public string Documento { get => documento; set => documento = value; }
    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }
    [Column("direccion")]
    public string Direccion { get => direccion; set => direccion = value; }
    [Column("telefono")]
    public string Telefono { get => telefono; set => telefono = value; }
    [Column("clave")]
    public string Clave { get => clave; set => clave = value; }
    [Column("rol_id")]
    public int RolId { get => rolId; set => rolId = value; }
    [Column("estado_id")]
    public int EstadoId { get => estadoId; set => estadoId = value; }
    [Column("user_name")]
    public string UserName { get => userName; set => userName = value; }
    [NotMapped]
    public int ValidarUsuario { get => validarUsuario; set => validarUsuario = value; }
    [NotMapped]
    public int ValidarCorreo { get => validarCorreo; set => validarCorreo = value; }
    [NotMapped]
    public int ValidarDocumento { get => validarDocumento; set => validarDocumento = value; }
    [NotMapped]
    public int ValidarUsuario2 { get => validarUsuario2; set => validarUsuario2 = value; }
    [NotMapped]
    public int ValidarCorreo2 { get => validarCorreo2; set => validarCorreo2 = value; }
    [NotMapped]
    public int ValidarDocumento2 { get => validarDocumento2; set => validarDocumento2 = value; }
    [NotMapped]
    public int ValidarDireccion { get => validarDireccion; set => validarDireccion = value; }
    [NotMapped]
    public int ValidarDireccionRegistro { get => validarDireccionRegistro; set => validarDireccionRegistro = value; }
    [NotMapped]
    public int ValidarTelefono { get => validarTelefono; set => validarTelefono = value; }
    [NotMapped]
    public int ValiarTelefonoRegistro { get => valiarTelefonoRegistro; set => valiarTelefonoRegistro = value; }


}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

[Serializable]
[Table("registro", Schema = "usuarios")]

public class ERegistro
{
    private int id;
    private string nombre;
    private string direccion;
    private string correo;
    private string usuario;
    private string clave;
    private string documento;
    private string telefono;
    private Nullable<int> estadoId;
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
    [Column("direccion")]
    public string Direccion { get => direccion; set => direccion = value; }
    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }
    [Column("usuario")]
    public string Usuario { get => usuario; set => usuario = value; }
    [Column("clave")]
    public string Clave { get => clave; set => clave = value; }
    [Column("documento")]
    public string Documento { get => documento; set => documento = value; }
    [Column("telefono")]
    public string Telefono { get => telefono; set => telefono = value; }
    [Column("estado_id")]
    public Nullable<int> EstadoId { get => estadoId; set => estadoId = value; }
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

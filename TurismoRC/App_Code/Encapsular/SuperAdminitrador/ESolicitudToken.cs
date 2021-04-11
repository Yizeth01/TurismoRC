using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


[Serializable]
[Table("token_correo", Schema = "usuarios")]
public class ESolicitudToken
{
    private int id;
    private String correo;
    private string nombre;

    [Key]
    [Column("id")]
    public int Id { get => id; set => id = value; }
    [Column("correo")]
    public string Correo { get => correo; set => correo = value; }
    [Column("nombre")]
    public string Nombre { get => nombre; set => nombre = value; }

}
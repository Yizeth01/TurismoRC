using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


public class Mapeo : DbContext
{
   static Mapeo()
    {
        Database.SetInitializer<Mapeo>(null);
    }
    private readonly string schema;

    public Mapeo()
        : base("name=Conexion2")
    {
        
    }
    public DbSet<EUser> Usuarios { get; set; }
    public DbSet<ERegistro> Registro { get; set; }

    protected override void OnModelCreating(DbModelBuilder builder)
    {
        builder.HasDefaultSchema(this.schema);

        base.OnModelCreating(builder);
    }
}
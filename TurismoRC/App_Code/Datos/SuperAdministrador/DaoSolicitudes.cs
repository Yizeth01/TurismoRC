using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class DaoSolicitudes
{
    public List<ERegistro> obtenerSolicitudes()
    {
        using (var db = new Mapeo())
        {
            return db.Registro.Where(x => x.EstadoId == 2).ToList().Select(m => new ERegistro
            {
                Id = m.Id,
                Nombre = m.Nombre,
                Documento = m.Documento,
                Correo = m.Correo,
                Direccion = m.Direccion,
                Telefono = m.Telefono,
                //RolId = 5,
                //Estado = "EN ESPERA",
                EstadoId = m.EstadoId,
                Usuario = m.Usuario,
                Clave = m.Clave

            }).ToList();
        }

    }

    


}
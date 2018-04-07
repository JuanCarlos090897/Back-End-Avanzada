using ProyectoCVA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Models
{
    public interface IUsuarioRepository
    {
        bool CrearUsuario(Usuario usuario);
        bool EditarUsuario(Usuario usuario);
        bool EliminarUsuario(int id);
        bool ExisteUsuario(int id);
        Usuario ObtenerUsuarioPorId(int id);
        List<Usuario> ObtenerUsuarios();

    }
}

using ProyectoCVA.Data;
using ProyectoCVA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Models
{
    public class UsuarioDBRepository : IUsuarioRepository
    {


        private ProyectoContext context;

        public UsuarioDBRepository(ProyectoContext _context)
        {
            context = _context;
        }

        public bool CrearUsuario(Usuario usuario)
        {
            context.Usuarios.Add(usuario);
            return context.SaveChanges() > 0;
        }

        public bool EditarUsuario(Usuario usuario)
        {
            try
            {
                var UsuarioOriginal = context.Usuarios.SingleOrDefault(a => a.UsuarioId == usuario.UsuarioId);
                UsuarioOriginal.Nombre = usuario.Nombre;
                UsuarioOriginal.Tipo = usuario.Tipo;
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EliminarUsuario(int id)
        {
            try
            {
                context.Usuarios.Remove(context.Usuarios.Where(a => a.UsuarioId == id).Single());
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ExisteUsuario(int id)
        {
            return context.Usuarios.Any(a => a.UsuarioId == id);
        }

        public List<Usuario> ObtenerUsuarios()
        {
            return context.Usuarios.ToList();
        }

        public Usuario ObtenerUsuarioPorId(int id)
        {
            return context.Usuarios.Where(a => a.UsuarioId == id).SingleOrDefault();
        }
    }
}

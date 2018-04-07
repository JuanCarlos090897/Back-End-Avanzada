using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.ViewModels.EstudiantesVM
{
    public class PerfilViewModel
    {
        public List<Models.Entities.Usuario> ListaUsuarios { get; set; } // esto es para llevar una lista de usuarios y asi poder usar sus atributos
        public string Title { get; set; }
    }
}

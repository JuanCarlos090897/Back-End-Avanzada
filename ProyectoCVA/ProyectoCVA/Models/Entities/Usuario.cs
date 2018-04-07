using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Models.Entities
{
    public class Usuario // esto son todas las caracteristicas que puede tener un usuario gets y sets
    {
        public int UsuarioId { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string CorreoPersonal { get; set; }
        public int Cedula { get; set; }
        public int Beca { get; set; }
        public int Telefono { get; set; }
        public string Pais { get; set; }

        public DateTime FechaNacimiento { get; set; }
        public string Genero { get; set; }
        public int Carnet { get; set; } // (Se quedo int) se hizo string porque son 11 digitos y un int no aguanta mas de 10(se dejo en int si se pide mas de e10 entonces se hace tipo string o long) igual usaremos el UsuarioId como carnet tambien 
        public string CorreoUniversitario { get; set; }



        public TipoUsuario Tipo { get; set; }


        public enum TipoUsuario
        {
            Estudiante = 0,
            Profesor = 1,
            Registro = 2,
            Director = 3
        }

    }
}

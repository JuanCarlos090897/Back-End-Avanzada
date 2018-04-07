using ProyectoCVA.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Models.Matricula
{
    public class Matricula
    {
        public int MatriculaId { get; set; }
        public int UsuarioId { get; set; } // esto seria una llave foranea hacia usuario desde Matricula
        public int Periodo { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFinal { get; set; }


        public Usuario Usuario { get; set; }// esto hace que UsuarioId Sea una llave foranea sin esto no es foranea

    }
}

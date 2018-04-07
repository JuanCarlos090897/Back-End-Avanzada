using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.ViewModels.MatriculaMV
{
    public class Matriculamv
    {
        public List<Models.Matricula.Matricula> ListaMatriculas { get; set; } // esto es para llevar una lista de matriculas y asi poder usar sus atributos
        public string Title { get; set; }
    }
}

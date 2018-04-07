using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Models.Matricula
{
    public interface IMatriculaRepository
    {
        bool CrearMatricula(Matricula matricula);
        //bool EditarMatricula(Matricula matricula);
        bool EliminarMatricula(int id);
        bool ExisteMatricula(int id);
        Matricula ObtenerMatriculaPorId(int id);
        List<Matricula> ObtenerMatriculas();
    }
}

using ProyectoCVA.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Models.Matricula
{
    public class MatriculaDBRepository : IMatriculaRepository
    {


        private ProyectoContext context;

        public MatriculaDBRepository(ProyectoContext _context)
        {
            context = _context;
        }

        public bool CrearMatricula(Matricula matricula)
        {
            context.Matriculas.Add(matricula);
            return context.SaveChanges() > 0;
        }

        

        public bool EliminarMatricula(int id)
        {
            try
            {
                context.Matriculas.Remove(context.Matriculas.Where(a => a.MatriculaId == id).Single());
                context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool ExisteMatricula(int id)
        {
            return context.Matriculas.Any(a => a.MatriculaId == id);
        }

        public List<Matricula> ObtenerMatriculas()
        {
            return context.Matriculas.ToList();
        }

        public Matricula ObtenerMatriculaPorId(int id)
        {
            return context.Matriculas.Where(a => a.MatriculaId == id).SingleOrDefault();
        }

       
        
    }
}

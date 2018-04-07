using ProyectoCVA.Models.Entities;
using ProyectoCVA.Models.Matricula;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Data
{
    public class ProyectoInitializer
    {
        public static void Initialize(ProyectoContext context)
        {


            context.Database.EnsureCreated();

            // Look for any students.
            if (context.Usuarios.Any())
            {
                return;   // DB has been seeded
            }

            var usuarios = new Usuario[]
            {
            new Usuario{Nombre = "Juan", Tipo = Usuario.TipoUsuario.Director, Apellidos = "Quesada", Telefono = 8689865, Cedula = 207690228, Beca = 50, CorreoUniversitario = "juan.quesada13@hotmail.com", Pais = "Costa Rica", CorreoPersonal = "juanca_quesada@hotmail.com", FechaNacimiento = DateTime.Parse("1997-08-09"), Carnet = 1, Genero = "Masculino"},
             new Usuario{Nombre = "Melisa", Tipo = Usuario.TipoUsuario.Director, Apellidos = "Quesada", Telefono = 8689865, Cedula = 207690228, Beca = 100, CorreoUniversitario = "melisa.quesada13@hotmail.com", Pais = "Costa Rica", CorreoPersonal = "melisa_quesada@hotmail.com", FechaNacimiento = DateTime.Parse("1997-08-10"), Carnet = 1, Genero = "Femenino"},
            new Usuario {Nombre = "Carlos", Tipo = Usuario.TipoUsuario.Estudiante, Apellidos = "Vargas", Telefono = 86875951, Cedula = 207690228, Beca = 60, CorreoUniversitario = "carlos.vargas13@hotmail.com", Pais = "Panama", CorreoPersonal = "carlos_vargas@hotmail.com", FechaNacimiento = DateTime.Parse("1997-08-11"), Carnet = 2, Genero = "Masculino"},
            new Usuario { Nombre = "Alberto", Tipo = Usuario.TipoUsuario.Profesor, Apellidos = "Rodriguez", Telefono = 86873221, Cedula = 207690228, Beca = 40, CorreoUniversitario = "alberto.rodriguez13@hotmail.com", Pais = "Nicaragua", CorreoPersonal = "alberto_rodriguez@hotmail.com", FechaNacimiento = DateTime.Parse("1997-08-12"), Carnet = 3, Genero = "Masculino" },
            new Usuario{ Nombre = "Sabrina", Tipo = Usuario.TipoUsuario.Registro, Apellidos = "Valverde", Telefono = 86878595, Cedula = 207690228, Beca = 30, CorreoUniversitario = "sabrina.valverde13@hotmail.com", Pais = "Venezuela", CorreoPersonal = "sabrina_valverde@hotmail.com", FechaNacimiento = DateTime.Parse("1997-08-13"), Carnet = 4, Genero = "Femenino" }
            
            };
            foreach (Usuario u in usuarios)
            {
                context.Usuarios.Add(u); //la diferencia entre Usuarios y usuarios es que Usuarios es de context y el otro es de esta clase
            }
            context.SaveChanges();


            var matriculas = new Matricula[]
            {
            new Matricula{FechaInicio = DateTime.Parse("2018-01-08"), FechaFinal = DateTime.Parse("2018-04-21"), Periodo=1, UsuarioId =1},
            new Matricula{FechaInicio = DateTime.Parse("2018-01-08"), FechaFinal = DateTime.Parse("2018-04-21"), Periodo=1, UsuarioId =2} //solo hay dos porque son los estudiates quienes necesitan estar matriculados no los otros usuarios
            
            };
            foreach (Matricula m in matriculas)
            {
                context.Matriculas.Add(m);
            }
            context.SaveChanges();

        }
    }
}

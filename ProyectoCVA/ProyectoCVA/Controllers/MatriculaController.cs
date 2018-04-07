using Microsoft.AspNetCore.Mvc;
using ProyectoCVA.Models.Matricula;
using ProyectoCVA.ViewModels.MatriculaMV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoCVA.Controllers
{
    public class MatriculaController : Controller
    {
        IMatriculaRepository repositorio;
        public MatriculaController(IMatriculaRepository _repositorio) //ni idea de que hace jajaja 
        {
            repositorio = _repositorio;
        }

        public IActionResult Index()
        {
            Matriculamv modelo = new Matriculamv();
            modelo.ListaMatriculas = repositorio.ObtenerMatriculas();
            modelo.Title = "Matriculas";
            return View(modelo);
        }
    }
}

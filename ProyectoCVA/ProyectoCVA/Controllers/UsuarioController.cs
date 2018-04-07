using Microsoft.AspNetCore.Mvc;
using ProyectoCVA.Models;
using ProyectoCVA.ViewModels;
using ProyectoCVA.Models.Entities;
using ProyectoCVA.ViewModels.EstudiantesVM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace ProyectoCVA.Controllers
{
    public class UsuarioController : Controller
    {
        IUsuarioRepository repositorio;
        public UsuarioController(IUsuarioRepository _repositorio) //ni idea de que hace jajaja 
        {
            repositorio = _repositorio;
        }

        public IActionResult Index()
        {
            PerfilViewModel modelo = new PerfilViewModel();
            modelo.ListaUsuarios = repositorio.ObtenerUsuarios();
            modelo.Title = "Perfil";
            return View(modelo);
        }
    }
}

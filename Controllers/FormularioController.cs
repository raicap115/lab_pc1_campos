using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab_pc1_campos.Models;
using lab_pc1_campos.Data;
namespace lab_pc1_campos.Controllers
{
    public class FormularioController : Controller
    {
        private readonly ILogger<FormularioController> _logger;

        public FormularioController(ILogger<FormularioController> logger,DatabaseContext context)
        {
            _logger = logger;
             _context = context;

        }

        public IActionResult Index()
        {
            return View();
        }
  private readonly DatabaseContext _context;
 [HttpPost]
           public IActionResult Enviar(Formulario objFormulario){

               if(ModelState.IsValid){
                objFormulario.Respuesta = "Gracias, hemos procesado su solicitud.";
                _context.Add(objFormulario);
                _context.SaveChanges();
               }
               
                 return View("index", objFormulario);
        }
    }
    
}
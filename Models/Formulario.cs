using System;
using System.ComponentModel.DataAnnotations;

namespace lab_pc1_campos.Models
{
    public class Formulario 
    {
        
        
        [Required(ErrorMessage="Ingrese su nombre")]  
        [Display(Name="Nombre")]  
        public string Nombre { get; set; }
        
        [Required(ErrorMessage="Ingrese sus apellidos")]  
        [Display(Name="Apellido")]
        public string Apellido { get; set; }
        
        [Required(ErrorMessage="Ingrese su distrito de residencia")]  
        [Display(Name="Distrito")]
        public String Distrito { get; set; }

        [Required(ErrorMessage="Ingrese su banco afiliado")]  
        [Display(Name="Bancos")]
        public string Bancos { get; set; }

        [Required(ErrorMessage="Ingrese su edad")]  
        [Display(Name="Edad")]
        public string Edad { get; set; }
        
        [Display(Name="Sexo")]
        public string Sexo { get; set; }

        [Display(Name="Autor")]
        public string Autor { get; }

        [Display(Name="Output")] 
         public string Respuesta { get; set; }

    }
}
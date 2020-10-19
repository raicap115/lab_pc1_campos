using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace lab_pc1_campos.Models
{
    [Table("t_solicitu_bono")]
    public class Formulario 
    {

        [Required(ErrorMessage="Ingrese su nombre")]  
        [Display(Name="nombre")] 
        [Column("nombre")] 
        public string Nombre { get; set; }
        
        [Required(ErrorMessage="Ingrese sus apellidos")]  
        [Display(Name="apellido")]
        [Column("apellido")]

        public string Apellido { get; set; }
        
        [Required(ErrorMessage="Ingrese su distrito de residencia")]  
        [Display(Name="Distrito")]
        [Column("distrito")]
        public String Distrito { get; set; }

        [Required(ErrorMessage="Ingrese su banco afiliado")]  
        [Display(Name="Bancos")]
        [Column("bancos")]
        public string Bancos { get; set; }

        [Required(ErrorMessage="Ingrese su edad")]  
        [Display(Name="Edad")]
        [Column("edad")]
        public string Edad { get; set; }
        
        [Display(Name="Sexo")]
        [Column("sexo")]
        public string Sexo { get; set; }

        [Display(Name="Autor")]
        [Column("autor")]
        public string Autor { get; }

        [Display(Name="Output")]
        [NotMapped]
         public string Respuesta { get; set; }

    }
}
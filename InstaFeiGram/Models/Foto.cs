using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstaFeiGram.Models
{
    [Authorize]
    public class Foto
    {
        [Key]
        public int idfoto { get; set; }
        public String rutaimagen { get; set; }
        [Required(ErrorMessage = "Necesitas ponerle un nombre acorde")]
        public string titulo { get; set; }
        public string resumen { get; set; }
        [Required(ErrorMessage = "Escribe al menos un tag para la foto")]
        public string tag { get; set; }
        public DateTime fechasubida { get; set; }
        public int numvisitas { get; set; }
        public ICollection<Comentario> Comentarios { get; set; }
        public string correousuario { get; set; }
        public int gusta { get; set; }
        public bool grises { get; set; }
    }
}

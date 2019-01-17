using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace InstaFeiGram.Models
{
    [Authorize]
    public class Comentario
    {
        [Key]
        public int idcomentario { get; set; }
        public string texto { get; set; }
        public string correousuario { get; set; }

        public Foto imgdatos { get; set; }
    }
}

using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InstaFeiGram.Models
{
    [Authorize]
    public class Like
    {
        public int cantidadlike { get; set; }
        public Foto Foto { get; set; }
    }
}

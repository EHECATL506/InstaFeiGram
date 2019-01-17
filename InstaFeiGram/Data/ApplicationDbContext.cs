using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using InstaFeiGram.Models;

namespace InstaFeiGram.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<InstaFeiGram.Models.Foto> Foto { get; set; }
        public DbSet<InstaFeiGram.Models.Comentario> Comentario { get; set; }
    }
}

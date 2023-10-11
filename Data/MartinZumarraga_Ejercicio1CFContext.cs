using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MartinZumarraga_Ejercicio1CF.Models;

namespace MartinZumarraga_Ejercicio1CF.Data
{
    public class MartinZumarraga_Ejercicio1CFContext : DbContext
    {
        public MartinZumarraga_Ejercicio1CFContext (DbContextOptions<MartinZumarraga_Ejercicio1CFContext> options)
            : base(options)
        {
        }

        public DbSet<MartinZumarraga_Ejercicio1CF.Models.Burger> Burger { get; set; } = default!;
    }
}

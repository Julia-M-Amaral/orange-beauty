using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Orange_Beauty.Models;

namespace Orange_Beauty.Data
{
    public class Orange_BeautyContext : DbContext
    {
        public Orange_BeautyContext (DbContextOptions<Orange_BeautyContext> options)
            : base(options)
        {
        }

        public DbSet<Orange_Beauty.Models.Funcionario> Funcionario { get; set; } = default!;
        public DbSet<Orange_Beauty.Models.Cliente> Cliente { get; set; } = default!;
    }
}

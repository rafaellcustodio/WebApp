﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Models
{
    public class WebAppContext : DbContext
    {
        public WebAppContext (DbContextOptions<WebAppContext> options)
            : base(options)
        {
        }

        public DbSet<WebApp.Models.Department> Department { get; set; }
    }
}

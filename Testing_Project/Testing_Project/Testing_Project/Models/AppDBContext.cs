﻿using Microsoft.EntityFrameworkCore;

namespace Testing_Project.Models
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
        }
    }

}

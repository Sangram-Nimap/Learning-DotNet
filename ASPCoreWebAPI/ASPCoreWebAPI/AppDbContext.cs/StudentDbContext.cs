﻿using ASPCoreWebAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPCoreWebAPI.AppDbContext.cs
{
    public class StudentDbContext: DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        public DbSet<Student> Students { get; set; }

    }
}

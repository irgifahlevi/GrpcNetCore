﻿using Microsoft.EntityFrameworkCore;
using ToDoGrpc.Models;

namespace ToDoGrpc.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
            
        }

        public DbSet<ToDoItems> ToDoItems => Set<ToDoItems>();
    }
}

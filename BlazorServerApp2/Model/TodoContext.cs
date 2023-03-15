using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerApp2.Model;

public partial class TodoContext : DbContext
{
    public TodoContext()
    {
    }

    public TodoContext(DbContextOptions<TodoContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Todolist> Todolists { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=LAPTOP-C43L1FOM\\MSSQLSERVER01;Initial Catalog=Todo;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Todolist>(entity =>
        {
            entity.HasKey(e => e.TodolistId).HasName("PK__Todolist__E6F8F429C4072A83");

            entity.ToTable("Todolist");

            entity.Property(e => e.BrugerId)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.TodoText).IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

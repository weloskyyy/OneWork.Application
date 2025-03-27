using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OneWorkContext.cs
using Microsoft.EntityFrameworkCore;
using OneWork.Domain.Entities;

namespace OneWork.Domain.Data
{
    public class OneWorkContext : DbContext
    {
        public OneWorkContext(DbContextOptions<OneWorkContext> options)
            : base(options) { }

        public DbSet<Tarea> Tareas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Primeros Datos

            modelBuilder.Entity<Tarea>().HasData(
                new Tarea
                {
                    Id = 1,
                    Titulo = "Revisar correos",
                    Descripcion = "Verificar y responder correos pendientes",
                    Completada = false
                },
                new Tarea
                {
                    Id = 2,
                    Titulo = "Reunion con el equipo",
                    Descripcion = "Reunion diaria a las 10:00 AM para discutir avances",
                    Completada = true,
                },

                new Tarea
                {
                    Id = 3,
                    Titulo = "Actualizar documentacion",
                    Descripcion = "Actualizar el READNE del proyecto OneWork",
                    Completada= true,
                }
                
           
                );

            
        }
    }
}

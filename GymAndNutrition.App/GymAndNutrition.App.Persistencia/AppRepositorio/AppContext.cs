using Microsoft.EntityFrameworkCore;
using GymAndNutrition.App.Dominio;


namespace GymAndNutrition.App.Persistencia
{
    public class AppContext:DbContext
    {
        public DbSet<Cliente> Clientes {get;set;}
        public DbSet<GrupoMuscular> GrupoMusculares {get;set;}
        public DbSet<Macronutrientes> Macronutrientes {get;set;}
        public DbSet<PlanEjercicio> PlanEjercicios {get;set;}
        public DbSet<PlanNutricional> PlanNutricionales {get;set;}
        public DbSet<Rutina> Rutinas {get;set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      {
         if(!optionsBuilder.IsConfigured)
         {
             optionsBuilder.UseSqlServer("Data Source =(localdb)\\MSSQLlocalDB; Initial Catalog= Gym");
         }
     }
    }
}
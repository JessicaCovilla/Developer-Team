using System;

namespace GymAndNutrition.App.Dominio
{
    public class PlanNutricional
    {
        public int Id {get;set;}
        public int peso {get;set;}
        public int Altura {get;set;}
        public int edad {get;set;}
        public Sexo Sexo {get;set;}
        public ActividadFisica ActividadFisica {get;set;}
        public ObjetivoAlcanzar ObjetivoAlcanzar {get;set;}


        



    }
}
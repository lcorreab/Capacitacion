using System ;

namespace Herencia_Ejemplo
{
     public class Student 
     {
         
         public Student(string primerNombre ,string apellido ,string sexo ,int id)
         {
             PrimerNombre=primerNombre;
             Apellido=apellido;
             Sexo=sexo;
             Student_ID= id;
         }

         public int Student_ID {get;set;}

         public string PrimerNombre{get;set;}

         public string Apellido{get;set;}

          public string Sexo{get;set;}


     }
}
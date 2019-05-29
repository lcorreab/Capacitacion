using System ;

namespace Herencia_Ejemplo
{
    public  class StudentDetails 
    {
     Student S= new Student("Luis","Correa","M",8210);

     public void Mostrar_Estudiante()
     {
       Console.WriteLine("El estudiante es " + S.PrimerNombre +S.Apellido + " tiene un sexo " + S.Sexo +" y tiene un ID " +S.Student_ID);
     }
    }
}
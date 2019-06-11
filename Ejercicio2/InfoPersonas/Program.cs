using System;


namespace InfoPersonas
{
    class Program
    {
        
        static void Main(string[] args)
        {
           //declara variables a usar 
            string nombre , apellido, sexo ;
            Console.WriteLine("ingrese su nombre ");
            nombre=Console.ReadLine();
            Console.WriteLine("ingrese su apellido ");
            apellido=Console.ReadLine();
            Console.WriteLine("ingrese su sexo M , F femenino ");
            sexo=Console.ReadLine();
            if(sexo.Equals("M") | sexo.Equals("F"))
            {
              Console.WriteLine(" mi nombre es "   + nombre + " y mi apellido es " + apellido );
            
            }
            else 
            {
             Console.WriteLine(" Debe Ingresar un sexo Valido solo se admite M o F");
            }

            
            
       
        
           
           

            
           
            



        }
    }
}

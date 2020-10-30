using System;
namespace DesingPatternsCreacionalLabo3
{
    public class ChemicalEngineer:IProfessional
    {
        public int Age { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }

        public ChemicalEngineer()
        {
            Title="Ingenierio Quimico";
        }

        public void ShowData()
        {
            Console.WriteLine("Nombre: " + Name);
            Console.WriteLine("Edad: " + Age);
            Console.WriteLine("Titulo: " + Title);
        }

        public void SetData()
        {
            Console.WriteLine("Ingrese su Nombre: ");
            Name=Console.ReadLine();
            Console.WriteLine("Ingrese su Edad: ");
            Age =Convert.ToInt16(Console.ReadLine());
        }
    }

}

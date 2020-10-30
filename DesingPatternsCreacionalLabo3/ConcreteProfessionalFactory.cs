using System;
namespace DesingPatternsCreacionalLabo3
{
    public class ConcreteProfessionalFactory:ProfessionalFactory
    {

        public override IProfessional GetProfessional(string Professional)
        {
            switch (Professional)
            {
                case "Sistemas":
                    return new SystemsEngineer();
                case "Quimico":
                    return new ChemicalEngineer();
                case "Civil":
                    return new CivilEngineering();
                default:
                    throw new Exception(string.Format("Professional '{0}' cannot be created", Professional));
            }
        }
    }
}

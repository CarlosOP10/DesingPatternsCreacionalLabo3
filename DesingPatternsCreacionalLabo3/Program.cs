using System;

namespace DesingPatternsCreacionalLabo3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            ProfessionalFactory FactoryProfessional = new ConcreteProfessionalFactory();
            IProfessional SystemEngineer= FactoryProfessional.GetProfessional("Sistemas");
            IProfessional ChemicalEngineer=FactoryProfessional.GetProfessional("Quimico");
            IProfessional CivilEngineer=FactoryProfessional.GetProfessional("Civil");
            SystemEngineer.SetData();
            ChemicalEngineer.SetData();
            CivilEngineer.SetData();
            LazySingletonProfesional.Instance.InsertProfessional(SystemEngineer);
            LazySingletonProfesional.Instance.InsertProfessional(ChemicalEngineer);
            LazySingletonProfesional.Instance.InsertProfessional(CivilEngineer);
            LazySingletonProfesional.Instance.ShowListProfessionals();
            LazySingletonProfesional.Instance.DeleteProfessional("carlos");
            LazySingletonProfesional.Instance.ShowListProfessionals();
            LazySingletonProfesional.Instance.FindProfessional("pedro").ShowData();
        }
    }
}

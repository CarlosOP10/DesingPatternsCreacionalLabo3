using System;
using System.Collections.Generic;

namespace DesingPatternsCreacionalLabo3
{
    public class LazySingletonProfesional
    {
        private static LazySingletonProfesional _instance = null;
        private IList<IProfessional> Professionals=new List<IProfessional>();

        private LazySingletonProfesional() { }

        public static LazySingletonProfesional Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new LazySingletonProfesional();

                return _instance;
            }
        }
        public void InsertProfessional(IProfessional professional)
        {
            Professionals.Add(professional);
        }
        public void ShowListProfessionals()
        {
            Console.WriteLine("-----LIST OF PROFESSIONALS----");
            foreach(IProfessional professional in Professionals)
            {
                professional.ShowData();
                Console.WriteLine("");
            }
        }
        public bool DeleteProfessional(string name)
        {
            foreach(IProfessional professional in Professionals)
            {
                if(professional.Name==name)
                {
                    Professionals.Remove(professional);
                    return true;
                }
            }
            return false;
        }
        public IProfessional FindProfessional(string name)
        {
            foreach (IProfessional professional in Professionals)
            {
                if (professional.Name == name)
                {
                    return professional;   
                }
            }
            return null;
        }
    }
}

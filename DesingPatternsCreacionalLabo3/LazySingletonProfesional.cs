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
            foreach(IProfessional professional in Professionals)
            {
                professional.ShowData();
                Console.WriteLine("");
            }
        }
    }
}

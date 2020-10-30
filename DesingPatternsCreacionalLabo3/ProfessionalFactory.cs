using System;
namespace DesingPatternsCreacionalLabo3
{
    public abstract class ProfessionalFactory
    {
        public abstract IProfessional GetProfessional(string Professional);
    }
}

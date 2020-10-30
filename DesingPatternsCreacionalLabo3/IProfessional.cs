using System;
namespace DesingPatternsCreacionalLabo3
{
    public interface IProfessional
    {
        int Age { get; set; }
        string Name { get; set; }
        string Title { get; set; }
        void ShowData();
        void SetData();
    }
}

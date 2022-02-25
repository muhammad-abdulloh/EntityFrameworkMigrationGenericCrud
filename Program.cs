using System;
using System.Threading.Tasks;
using static System.Console;

namespace TheroToHeroCRUDInVSCode
{
    class Program
    {
        // static NajotTalimDbContext _najotTalimDbContext = new NajotTalimDbContext();
        #pragma warning disable CS0169 // The field 'Program.studentRepository' is never used
        static async Task Main(string[] args)
        {
            ISudentRepository sudentRepository = new StudentRepository();
            var student = await sudentRepository.Get(1);

            WriteLine(student.FullName); 
        }

        #pragma warning restore CS0169 // The field 'Program.studentRepository' is never used
    }
}

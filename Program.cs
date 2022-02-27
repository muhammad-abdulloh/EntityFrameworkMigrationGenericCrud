using System;
using System.Threading.Tasks;
using static System.Console;

namespace TheroToHeroCRUDInVSCode
{
    class Program
    {
        // static NajotTalimDbContext _najotTalimDbContext = new NajotTalimDbContext();
        #pragma warning disable // The field 'Program.studentRepository' is never used
        static async Task Main(string[] args)
        {
            ISudentRepository sudentRepository = new StudentRepository();
            // var student = await sudentRepository.GetAsync(x => x.Id == 1);
            // WriteLine(student.FullName);
            var student = await sudentRepository.UpdateAsync(new Student 
            { 
                Id = 1, 
                FullName = "MUhammadhon Najimov",
            }); 
            
            WriteLine(student.FullName);
        }

        #pragma warning restore // The field 'Program.studentRepository' is never used
    }
}

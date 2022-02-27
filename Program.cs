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
            var student = await sudentRepository.GetAllAsync();
            var student2 = await sudentRepository.GetAllAsync( x => x.Id > 1); 

            foreach (var item in student2)
            {
                WriteLine(item.Id + " " + item.FullName + " " + item.UniversityId + " " + item.GroupId);
            }
        }

        #pragma warning restore // The field 'Program.studentRepository' is never used
    }
}

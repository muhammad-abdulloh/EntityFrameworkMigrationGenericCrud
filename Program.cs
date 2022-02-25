using System;
using static System.Console;

namespace TheroToHeroCRUDInVSCode
{
    class Program
    {
        static NajotTalimDbContext _najotTalimDbContext = new NajotTalimDbContext();
        static void Main(string[] args)
        {
            var students = _najotTalimDbContext.Students;

            /// WriteLine(students.GetType());
            /// <summary>
            /// TheroToHeroCRUDInVSCode.NajotTalimDbContext+EntityFrameworkQueryableExtensions`1[TheroToHeroCRUDInVSCode.NajotTalimDbContext+Student]
            /// </summary>


            foreach (var student in students)
            {       
                WriteLine(student.FullName);
            }
        }
    }
}

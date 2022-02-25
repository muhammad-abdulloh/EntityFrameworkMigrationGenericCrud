using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheroToHeroCRUDInVSCode
{
    [Table("Students")]
    internal class Student
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public int GroupId { get; set; }
        public int UniversityId { get; set; }

    }
}
//create subject class
namespace TheroToHeroCRUDInVSCode
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Subjects")]
    internal class Subject
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
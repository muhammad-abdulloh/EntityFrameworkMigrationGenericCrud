//create group class
namespace TheroToHeroCRUDInVSCode
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("Groups")]
    internal class Group
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        [Required]
        public int SubjectId { get; set; }
    }
}
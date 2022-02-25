//create base class university
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TheroToHeroCRUDInVSCode
{
    [Table("Universities")]
    internal class University 
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Level { get; set; }

    }
}
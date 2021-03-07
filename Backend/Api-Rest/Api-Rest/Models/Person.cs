using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Api_Rest.Models
{
    [Table("person")]
    public partial class Person
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }

        [Column("name")]
        public string name { get; set; }
    }
}

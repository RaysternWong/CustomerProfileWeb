using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProfileWeb.Models
{
    public class Customer
    {
        [Key]
        public Int64 CustomerID{ get; set; }

        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [StringLength(1000)]
        [Column(TypeName = "nvarchar(MAX)")]
        public string Address { get; set; }

        [EmailAddress]
        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        public DateTime BornDate { get; set; }

        [Phone]
        [Column(TypeName = "nvarchar(30)")]
        public string PhoneNo { get; set; }

    }
}

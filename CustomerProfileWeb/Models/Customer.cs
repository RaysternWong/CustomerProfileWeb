using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerProfileWeb.Models
{
    public class Customer
    {
        [Key]
        public Int64 CustomerId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Address { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string Email { get; set; }

        public DateTime BornDate { get; set; }

        [Column(TypeName = "nvarchar(30)")]
        public string PhoneNo { get; set; }

    }
}

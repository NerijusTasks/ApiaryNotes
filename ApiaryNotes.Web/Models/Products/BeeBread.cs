using ApiaryNotes.Web.Models.Hive;
using System.ComponentModel.DataAnnotations;

namespace ApiaryNotes.Web.Models.Products
{
    public class BeeBread
    {
        public Guid Id { get; set; }
        public double Quantity { get; set; }
        public Guid HivesId { get; set; }
        public Hives Hives { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

    }
}

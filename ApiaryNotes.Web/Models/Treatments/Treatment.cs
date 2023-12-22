using ApiaryNotes.Web.Models.Hive;
using ApiaryNotes.Web.Models.Notes;
using System.ComponentModel.DataAnnotations;

namespace ApiaryNotes.Web.Models.Treatments
{
    public class Treatment
    {
        public Guid TreatmentId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        public List<Note> Notes { get; set; }
        public Guid HiveId { get; set; }
        public Hives Hives { get; set; }
    }
}

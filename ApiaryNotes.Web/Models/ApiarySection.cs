using ApiaryNotes.Web.Models.Hive;
using ApiaryNotes.Web.Models.Notes;

namespace ApiaryNotes.Web.Models
{
    public class ApiarySection
    {
        public Guid ApiaryId { get; set; }
        public string Name  { get; set; }
        public List<Note> Notes { get; set; }
        public List<Hives> HiveQuantity { get; set; }

       
    }
}


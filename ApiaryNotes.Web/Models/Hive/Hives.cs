using ApiaryNotes.Web.Models.Notes;
using ApiaryNotes.Web.Models.Products;
using ApiaryNotes.Web.Models.Treatments;

namespace ApiaryNotes.Web.Models.Hive
{
    public class Hives
    {
        public Guid HiveId { get; set; }
        public string Name { get; set; }
        public Guid ApiarySectionId { get; set; }
        public ApiarySection ApiarySections { get; set; }

        public List<Note> Notes { get; set; }
        public List<BeeBread> BreadQuantity { get; set; }
        public List<Honey> HoneyQuantity { get; set; }
        public List<Pollen> PollenQuantity { get; set; }
        public List<Wax> WaxQuantity { get; set; }
        public List<Treatment> TreatmentsQuantity { get; set; }



    }
}

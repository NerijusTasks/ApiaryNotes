using System.ComponentModel.DataAnnotations;

namespace ApiaryNotes.Web.Models.Notes
{
    public class Note
    {
        public Guid NoteId { get; set; }

        [DataType(DataType.Date)]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Įrašykite tekstą")]
        public string? Text { get; set; }
        public Guid ApiarySectionId { get; set; }
        public ApiarySection ApiarySections { get; set; }
    }
}

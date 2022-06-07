using System.ComponentModel.DataAnnotations;

namespace TreeView.Models
{
    public class Section
    {        
        public int SectionId { get; set; }
        [Required]
        public string SectionName { get; set; }

        public string NavUrl { get; set; }

        public int ParentSecId { get; set; }
    }
}
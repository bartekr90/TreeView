using System.Collections.Generic;
using System.Linq;
using TreeView.Models;

namespace TreeView.Controllers
{
    public class SectionRepository
    {
        public List<Section> GetSections()
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Sections.ToList();
            }
        }

        public void AddPosition(Section section)
        {
            using (var context = new ApplicationDbContext())
            {
                context.Sections.Add(section);
                context.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                var sectionToDelete = context.Sections
                    .Single(x => x.SectionId == id);

                context.Sections.Remove(sectionToDelete);
                context.SaveChanges();
            }
        }

        public Section GetSections(int id)
        {
            using (var context = new ApplicationDbContext())
            {
                return context.Sections.Single(x => x.SectionId == id);
            }
        }
    }
}
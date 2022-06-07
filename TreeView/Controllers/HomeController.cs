using System.Web.Mvc;
using TreeView.Models;

namespace TreeView.Controllers
{
    public class HomeController : Controller
    {
        private SectionRepository _sectionRepository = new SectionRepository();
        public ActionResult Index()
        {
            var sections = _sectionRepository.GetSections();

            return View(sections);
        }
               
        public ActionResult SectionPosition(int parentSecId)
        {
            var newSection = new Section
            {
                SectionName = "Wpisz nazwę",
                NavUrl = "#",
                ParentSecId = parentSecId
            };

            return View(newSection);
        } 
        public ActionResult DeleteSection(int id)
        {
            var section = _sectionRepository.GetSections(id);
            return View(section);
        }

        [HttpPost]
        public ActionResult SectionPosition(Section section)
        {
            _sectionRepository.AddPosition(section);

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult DeleteSection(Section section)
        {
            _sectionRepository.Delete(section.SectionId);

            return RedirectToAction("Index");
        }
    }
}
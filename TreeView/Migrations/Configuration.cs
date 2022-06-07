namespace TreeView.Migrations
{
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<TreeView.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(TreeView.Models.ApplicationDbContext context)
        {
            context.Sections.AddOrUpdate(
                  new Models.Section { SectionId = 1, SectionName = "Elektronika", NavUrl = "#", ParentSecId = 0 },
                  new Models.Section { SectionId = 5, SectionName = "Telefony", NavUrl = "#", ParentSecId = 1 },
                  new Models.Section { SectionId = 6, SectionName = "Komputery", NavUrl = "#", ParentSecId = 1 },
                  new Models.Section { SectionId = 18, SectionName = "Pc", NavUrl = "#", ParentSecId = 6 },
                  new Models.Section { SectionId = 19, SectionName = "Laptopy", NavUrl = "#", ParentSecId = 6 },
                  new Models.Section { SectionId = 7, SectionName = "Rtv", NavUrl = "#", ParentSecId = 1 },
                  new Models.Section { SectionId = 20, SectionName = "Tv", NavUrl = "#", ParentSecId = 7 },
                  new Models.Section { SectionId = 21, SectionName = "Sprzęt audio", NavUrl = "#", ParentSecId = 7 },
                  new Models.Section { SectionId = 8, SectionName = "Agd", NavUrl = "#", ParentSecId = 1 },
                  new Models.Section { SectionId = 22, SectionName = "Agd drobne", NavUrl = "#", ParentSecId = 8 },
                  new Models.Section { SectionId = 23, SectionName = "Agd wolnostojące", NavUrl = "#", ParentSecId = 8 },
                  new Models.Section { SectionId = 2, SectionName = "Moda", NavUrl = "#", ParentSecId = 0 },
                  new Models.Section { SectionId = 9, SectionName = "On", NavUrl = "#", ParentSecId = 2 },
                  new Models.Section { SectionId = 10, SectionName = "Ona", NavUrl = "#", ParentSecId = 2 },
                  new Models.Section { SectionId = 11, SectionName = "Dziecko", NavUrl = "#", ParentSecId = 2 },
                  new Models.Section { SectionId = 3, SectionName = "Dom i ogród", NavUrl = "#", ParentSecId = 0 },
                  new Models.Section { SectionId = 12, SectionName = "Budownictwo", NavUrl = "#", ParentSecId = 3 },
                  new Models.Section { SectionId = 24, SectionName = "Elektryka", NavUrl = "#", ParentSecId = 12 },
                  new Models.Section { SectionId = 25, SectionName = "Hydraulika", NavUrl = "#", ParentSecId = 12 },
                  new Models.Section { SectionId = 13, SectionName = "Wyposażenie", NavUrl = "#", ParentSecId = 3 },
                  new Models.Section { SectionId = 26, SectionName = "Lustra", NavUrl = "#", ParentSecId = 13 },
                  new Models.Section { SectionId = 27, SectionName = "Poduszki", NavUrl = "#", ParentSecId = 13 },
                  new Models.Section { SectionId = 14, SectionName = "Ogród", NavUrl = "#", ParentSecId = 3 },
                  new Models.Section { SectionId = 28, SectionName = "Kompostownik", NavUrl = "#", ParentSecId = 14 },
                  new Models.Section { SectionId = 29, SectionName = "Doniczki", NavUrl = "#", ParentSecId = 14 },
                  new Models.Section { SectionId = 15, SectionName = "Meble", NavUrl = "#", ParentSecId = 3 },
                  new Models.Section { SectionId = 30, SectionName = "Kuchnia", NavUrl = "#", ParentSecId = 15 },
                  new Models.Section { SectionId = 31, SectionName = "Salon", NavUrl = "#", ParentSecId = 15 },
                  new Models.Section { SectionId = 32, SectionName = "Sypialnia", NavUrl = "#", ParentSecId = 15 },
                  new Models.Section { SectionId = 4, SectionName = "Supermarket", NavUrl = "#", ParentSecId = 0 },
                  new Models.Section { SectionId = 16, SectionName = "Zdrowa żywność", NavUrl = "#", ParentSecId = 4 },
                  new Models.Section { SectionId = 17, SectionName = "Słodycze", NavUrl = "#", ParentSecId = 4 }

                  );
        }
    }
}

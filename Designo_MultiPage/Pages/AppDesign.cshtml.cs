using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo_MultiPage.Pages
{
    public class AppDesignModel : PageModel
    {
        public ProjectLink[] Links { get; set; }
        public ProjectImages[] projectImages { get; set; }
        public Projects Project { get; set; }

        public void OnGet()
        {
            Project = new Projects()
            {
                Title = "app design",
                Description = "Our mobile designs bring intuitive digital solutions to your customers right at their fingertips."
            };

            projectImages = new ProjectImages[]
            {
                new ProjectImages {ImageSrc ="/assets/app-design/desktop/image-airfilter.jpg",Title = "airfilter", Description = "Solving the problem of poor indoor air quality by filtering the air"},
                new ProjectImages {ImageSrc ="/assets/app-design/desktop/image-eyecam.jpg",Title = "eyecam", Description = "Product that lets you edit your favorite photos and videos at any time"},
                new ProjectImages {ImageSrc ="/assets/app-design/desktop/image-faceit.jpg",Title = "faceit", Description = "Get to meet your favorite internet superstar with the faceit app"},
                new ProjectImages {ImageSrc ="/assets/app-design/desktop/image-todo.jpg",Title = "todo", Description = "A todo app that features cloud sync with light and dark mode"},
                new ProjectImages {ImageSrc ="/assets/app-design/desktop/image-loopstudios.jpg",Title = "loopstudios", Description = "A VR experience app made for Loopstudios"},

            };

            Links = new ProjectLink[]
            {
                new ProjectLink{ Title = "web"},
                new ProjectLink{ Title = "graphic"}
            };


        }
    }
}

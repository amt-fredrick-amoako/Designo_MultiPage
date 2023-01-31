using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo_MultiPage.Pages
{
    public class WebDesignModel : PageModel
    {
        public ProjectLink[] Links { get; set; }

        public Projects Projects { get; set; }

        public ProjectImages[] projectImages { get; set; }

        public void OnGet()
        {
            Projects = new Projects
            {
                Title = "web design",
                Description = "We build websites that serve as powerful marketing tools \n and bring memorable brand experiences."
            };

            projectImages = new ProjectImages[]
        {
            new ProjectImages {ImageSrc ="/assets/web-design/desktop/image-express.jpg",Title = "express", Description = "A multi-carrier shipping website for ecommerce businesses", ClassNumber = 1},
            new ProjectImages {ImageSrc ="/assets/web-design/desktop/image-transfer.jpg",Title = "transfer", Description = "Site for low-cost money transfers and sending money within seconds", ClassNumber = 2},
            new ProjectImages {ImageSrc ="/assets/web-design/desktop/image-photon.jpg",Title = "photon", Description = "A state-of-the-art music player with high-resolution audio and DSP effects", ClassNumber = 3},
            new ProjectImages {ImageSrc ="/assets/web-design/desktop/image-builder.jpg",Title = "builder", Description = "Connects users with local contractors based on their location", ClassNumber = 4},
            new ProjectImages {ImageSrc ="/assets/web-design/desktop/image-blogr.jpg",Title = "blogr", Description = "Blogr is a platform for creating an online blog or publication", ClassNumber = 5},
            new ProjectImages {ImageSrc ="/assets/web-design/desktop/image-camp.jpg",Title = "camp", Description = "Get expert training in coding, data, design, and digital marketing", ClassNumber = 6},
        };

            Links = new ProjectLink[]
        {
            new ProjectLink{ Title = "app"},
            new ProjectLink{ Title = "graphic"}
        };
        }
    }
}

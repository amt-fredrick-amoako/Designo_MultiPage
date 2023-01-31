using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo_MultiPage.Pages
{
    public class GraphicDesignModel : PageModel
    {
        public ProjectLink[] Links { get; set; }
        public ProjectImages[] projectImages { get; set; }
        public Projects Project { get; set; }

        public void OnGet()
        {
            Project = new Projects()
            {
                Title = "graphic design",
                Description = "We deliver eye-catching branding materials that are tailored to meet your business objectives."
            };

            projectImages = new ProjectImages[]
            {
                new ProjectImages {ImageSrc ="/assets/graphic-design/desktop/image-change.jpg",Title = "tim brown", Description = "A book cover designed for Tim Brown’s new release, ‘Change’"},
                new ProjectImages {ImageSrc ="/assets/graphic-design/desktop/image-boxed-water.jpg",Title = "boxed water", Description = "A simple packaging concept made for Boxed Water"},
                new ProjectImages {ImageSrc ="/assets/graphic-design/desktop/image-science.jpg",Title = "science", Description = "A poster made in collaboration with the Federal Art Project"},
            };

            Links = new ProjectLink[]
            {
                new ProjectLink{ Title = "app"},
                new ProjectLink{ Title = "web"}
            };


        }
    }
}

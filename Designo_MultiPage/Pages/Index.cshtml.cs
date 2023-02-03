using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Designo_MultiPage.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public Hero Hero { get; set; } = new();

        public MissionAndVision[]? Mission { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            Hero = new()
            {
                Title = "Award-winning custom designs and digital branding solutions",
                Description = "with over 10 years in the industry, we are experienced in\r\n creating fully responsive websites, app design, and engaging\r\n brand experiences. find out more about our services",
                ImageSrc = "/images/image-hero-phone.png"
            };

            Mission = new MissionAndVision[]
            {
                new MissionAndVision
                {
                    Title = "passionate",
                    Description = "Each project starts with an in-depth brand research to ensure we only create products that serve a purpose. We merge art, design, and technology into exciting new solutions.",
                    ImageSrc = "passionate"
                },
                new MissionAndVision
                {
                    Title = "resourceful",
                    Description = "Each project starts with an in-depth brand research to ensure we only create products that serve a purpose. We merge art, design, and technology into exciting new solutions.",
                    ImageSrc = "resourceful"
                },
                new MissionAndVision
                {
                    Title = "friendly",
                    Description = "Each project starts with an in-depth brand research to ensure we only create products that serve a purpose. We merge art, design, and technology into exciting new solutions.",
                    ImageSrc = "friendly"
                }
            };

        }
    }
}
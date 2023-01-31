using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;

namespace Designo_MultiPage.Components
{
    [ViewComponent]
    public class Project : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ProjectImages[] projectImages) => View(projectImages);
    }
}

using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;

namespace Designo_MultiPage.Components
{
    [ViewComponent]
    public class PortfolioLinks : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(ProjectLink[] projects) => View(projects);
    }
}

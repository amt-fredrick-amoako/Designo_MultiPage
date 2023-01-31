using Designo_MultiPage.Model;
using Microsoft.AspNetCore.Mvc;

namespace Designo_MultiPage.Components
{
    [ViewComponent]
    public class Design : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(Projects projects) => View(projects);
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Designo_MultiPage.Components
{
    [ViewComponent]
    public class Portfolio : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View();
    }
}

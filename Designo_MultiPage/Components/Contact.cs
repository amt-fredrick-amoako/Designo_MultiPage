using Microsoft.AspNetCore.Mvc;

namespace Designo_MultiPage.Components
{
    [ViewComponent]
    public class Contact : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync() => View();

    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Vouzamo.Web.WebApp.Pages
{
    public class PoolModel : PageModel
    {
        private readonly ILogger<PoolModel> _logger;

        public PoolModel(ILogger<PoolModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}

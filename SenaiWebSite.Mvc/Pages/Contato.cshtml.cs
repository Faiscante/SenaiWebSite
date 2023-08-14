using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SenaiWebSite.Mvc.Pages
{
    public class ContatoModel : PageModel
    {
        private readonly ILogger<ContatoModel> _logger;

        public ContatoModel(ILogger<ContatoModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TutorialPagesManuel.Pages
{
    public class SaludoModel : PageModel
    {
        [BindProperty]
        public string Nombre { get; set; }
        public void OnGet(string nombre)
        {
            Nombre = nombre;
        }
    }
}

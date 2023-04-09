using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TutorialPagesManuel.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string Hora { get; set; }
        public string Nombre { get; set; }
        public string Mensaje { get; set; }
        public void OnGet()
        {

        }

        public void OnPost()
        {
            if (Hora != null)
            {
                int horaInt = Int32.Parse(Hora);

                if (horaInt >= 6 && horaInt < 12)
                {
                    Mensaje = "Buenos días";
                }
                else if (horaInt >= 12 && horaInt < 20)
                {
                    Mensaje = "Buenas tardes";
                }
                else if (horaInt >= 20 || horaInt < 6)
                {
                    Mensaje = "Buenas noches";
                }
            }
        }
    }
}
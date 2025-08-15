using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WARazor.Pages
{
    public class SaludoModel : PageModel
    {
        public bool MostrarTexto { get; set; } = false;
        public string TextoBoton { get; set; } = "Mostrar Saludo";
        public string MensajeSaludo { get; set; } = "Bienvenido a mi primera pagina en Razor!";

        public void OnGet()
        {
        }

        public IActionResult OnPostToggleText()
        {
            MostrarTexto = !MostrarTexto;
            return Page();
        }
    }
}

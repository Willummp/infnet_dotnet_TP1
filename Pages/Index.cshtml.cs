using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace TP1.Pages
{
    public class IndexModel : PageModel
    {
        public string Saudacao { get; set; }

        public void OnGet(string nomeCompleto)
        {
            Saudacao = $"Ol�, {nomeCompleto}! Bem-vindo � p�gina de sauda��o.";
        }
    }
}

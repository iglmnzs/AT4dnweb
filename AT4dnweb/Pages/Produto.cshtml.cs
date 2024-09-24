using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AT4dnweb.Pages
{
    public class ProdutoModel : PageModel
    {
        private static List<Produto> Produtos = new List<Produto>();

        [BindProperty]
        public Produto NovoProduto { get; set; } = new Produto();

        public List<Produto> ProdutosList => Produtos;

        public void OnGet()
        {
            if (!Produtos.Any())
            {
                Produtos.Add(new Produto { Id = 1, Nome = "Café", Preco = 8.00M });
                Produtos.Add(new Produto { Id = 2, Nome = "Salgadinho", Preco = 5.20M });
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            Produtos.Add(NovoProduto);

            return RedirectToPage();
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace razor_pages_challenge1.Pages
{
    public class BooksModel : PageModel
    {
        public string[] BookTitles = ["Dune", "The Hitchhiker's Guide to the Galaxy", "Brave New World"];
        public string[] AuthorNames = ["Frank Herbert", "Douglas Adams", "Aldous Huxley"];
        public void OnGet()
        {
        }
    }
}

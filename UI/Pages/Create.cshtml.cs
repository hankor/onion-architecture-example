using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages
{
    public class CreateModel : PageModel
    {
        private readonly IMovieService _movieService;

        [BindProperty]
        public Movie Movie { get; set; }

        public CreateModel(IMovieService movieService)
        {
            _movieService = movieService;
        }

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            _movieService.Add(Movie);
            return RedirectToPage(nameof(Index));
        }
    }
}

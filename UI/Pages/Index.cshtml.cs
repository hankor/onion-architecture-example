using Core.Entities;
using Core.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace UI.Pages;

public class IndexModel : PageModel
{
    private readonly IMovieService _movieService;
    public ICollection<Movie> Movies { get; set; }

    public IndexModel(IMovieService movieService)
    {
        _movieService = movieService;
    }

    public void OnGet()
    {
        Movies = _movieService.GetList();
    }
}
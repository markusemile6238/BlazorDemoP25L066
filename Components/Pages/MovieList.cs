using BlazorDemoP25L066.Components.Models;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using BlazorDemoP25L066.Service;
namespace BlazorDemoP25L066.Components.Pages
{
    public partial class MovieList
    {
        [Inject]
        private MovieService movieService { get; set; }

         [Inject]
        public NavigationManager Navigation { get; set; }

        [SupplyParameterFromQuery(Name = "favorite")]
        public bool favoriteOnly { get; set; }

         public IEnumerable<Movie> Movies =>movieService.GetAllMovies().Where(m => !favoriteOnly || m.Favorit);


        protected override void OnInitialized()
        {
            breadcrumb.Set(
                new BreadCrumbItem { Label = "Home", Url = "/", IsActive = false },
                new BreadCrumbItem { Label = "Movie List", Url = "/MovieList", IsActive = true }
            );
        }

        



        private async Task ConfirmDelete(int id, string title)
        {
            bool ok = await Js.InvokeAsync<bool>("confirm", $"Are you sure you want to delete the movie '{title}'?");

            if (ok)
            {
                movieService.DeleteMovie(id);
                StateHasChanged();
            }
        }





    }
}

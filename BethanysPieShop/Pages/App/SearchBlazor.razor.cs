using BethanysPieShop.Models;
using Microsoft.AspNetCore.Components;

namespace BethanysPieShop.Pages.App
{
    public partial class SearchBlazor
    {
        private string SearchText = "";
        public List<Pie> FilteredPies { get; set; } = new List<Pie>();

        [Inject]
        public IPieRepository? PieRepository { get; set; }

        private void Search()
        {
            FilteredPies.Clear();
            if (PieRepository is not null && SearchText.Length >= 3)
            {
                FilteredPies = PieRepository.SearchPies(SearchText).ToList();
            }
        }
    }
}

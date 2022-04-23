using Microsoft.AspNetCore.Mvc.Rendering;
using ConcertFinal.Data.Entities;

namespace ConcertFinal.Helpers
{
    public interface ICombosHelper
    {
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync();
        Task<IEnumerable<SelectListItem>> GetComboEntrancesAsync(IEnumerable<Entrance> filter);
    }
}

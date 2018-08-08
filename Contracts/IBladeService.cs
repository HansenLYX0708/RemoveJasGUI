using Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Contracts
{
    public interface IBladeService
    {
        Task LoadBladesAsync();

        IEnumerable<Blade> Blades { get; }

        Blade GetBlade(int BladeId);

        Task<Blade> AddOrUpdateBladeAsync(Blade book);
    }
}

using System.Threading.Tasks;
using SixDegrees.Common.Models;

namespace SixDegrees.Core
{
    public interface ISixDegreesService
    {
        Task<MovieResult> GetMovieById(string id);
    }
}
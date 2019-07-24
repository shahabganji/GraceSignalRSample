using System.Threading.Tasks;

namespace GraceSignalRSample
{
    public interface IChatClient
    {
        Task MessagereceivedAsync(string message);
    }
}

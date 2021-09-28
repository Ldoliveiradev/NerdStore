using NerdStore.Core.Messages;
using System.Threading.Tasks;

namespace NerdStore.Core.Bus
{
    public interface IMediatorHandler
    {
        Task PublicarEventos<T>(T evento) where T : Event;
        Task<bool> EnviarCommand<T>(T comando) where T : Command;
    }
}

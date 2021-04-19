using System.Threading.Tasks;
using MediatR;
using NerdStore.Core.Messages;

namespace NerdStore.Core
{
    public class MediatrHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public Task<bool> EnviarComando<T>(T comando) where T : Command
        {
            throw new System.NotImplementedException();
        }

        public async Task PublicarEvento<T>(T evento) where T : Event
        {
            await _mediator.Publish(evento);
        }
    }
}
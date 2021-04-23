using Domain.Commands;
using Domain.Commands.Clientes.Actions;
using Domain.Core.Bus;
using Domain.Core.Notifications;
using Domain.Interfaces;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Domain.CommandHandlers.Clientes
{
    public class ClienteCommandHandler : CommandHandler,
                                    IRequestHandler<InsertClienteCommand, bool>
    {
        private readonly IMediatorHandler _bus;

        public ClienteCommandHandler(IUnitOfWork uow,
                                     IMediatorHandler bus,
                                     INotificationHandler<DomainNotification> notifications) : base(uow, bus, notifications)
        {
            _bus = bus;
        }

        public Task<bool> Handle(InsertClienteCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

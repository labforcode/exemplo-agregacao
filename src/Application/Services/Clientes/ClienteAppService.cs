using Application.Interfaces.Clientes;
using System;

namespace Application.Services.Clientes
{
    public class ClienteAppService : IClienteAppService
    {
        public void Add()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}

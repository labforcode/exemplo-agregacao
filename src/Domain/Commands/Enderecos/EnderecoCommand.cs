using Domain.Core.Commands;
using System;

namespace Domain.Commands.Clientes
{
    public abstract class EnderecoCommand : Command
    {
        public Guid EnderecoId { get; private set; }

        public string Cep { get; private set; }

        public string Logradouro { get; private set; }

        public string Numero { get; private set; }

        public string Complemento { get; private set; }

        public string Bairro { get; private set; }

        public string Cidade { get; private set; }

        public string Estado { get; private set; }
    }
}

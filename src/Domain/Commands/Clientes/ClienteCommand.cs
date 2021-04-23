using Domain.Commands.Enderecos;
using Domain.Core.Commands;
using System;
using System.Collections.Generic;

namespace Domain.Commands.Clientes
{
    public abstract class ClienteCommand : Command
    {
        public Guid ClienteId { get; protected set; }

        public string Nome { get; protected set; }

        public DateTime DataNascimento { get; protected set; }

        public EnderecoCommand Endereco { get; protected set; }

        public IEnumerable<ContatoCommand> Contatos { get; protected set; }
    }
}

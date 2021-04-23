using Domain.Core.Commands;
using Domain.Entities.Contatos;
using Domain.Entities.Enderecos;
using System;
using System.Collections.Generic;

namespace Domain.Commands.Clientes
{
    public abstract class ClienteCommand : Command
    {
        public Guid ClienteId { get; protected set; }

        public string Nome { get; protected set; }

        public DateTime DataNascimento { get; protected set; }

        public Endereco Endereco { get; protected set; }

        public IEnumerable<Contato> Contatos { get; protected set; }
    }
}

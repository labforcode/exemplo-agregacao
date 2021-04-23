using Domain.Core.Commands;
using System;

namespace Domain.Commands.Enderecos
{
    public abstract class ContatoCommand : Command
    {
        public Guid ContatoId { get; protected set; }

        public string Nome { get; protected set; }

        public string TelefoneResidencial { get; protected set; }

        public string Whatsapp { get; protected set; }

        public string TelefoneComercial { get; protected set; }
    }
}

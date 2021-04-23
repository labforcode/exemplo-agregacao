using Domain.Core.DomainObjects.Entities;
using Domain.Entities.Clientes;
using System;

namespace Domain.Entities.Contatos
{
    public class Contato : Entity
    {
        public Contato(Guid clienteId,
                       string nome,
                       string telefoneResidencial,
                       string whatsapp,
                       string telefoneComercial)
        {
            ClienteId = clienteId;
            Nome = nome;
            TelefoneResidencial = telefoneResidencial;
            Whatsapp = whatsapp;
            TelefoneComercial = telefoneComercial;
        }

        public Contato() { }

        public Guid ClienteId { get; private set; }

        public string Nome { get; private set; }

        public string TelefoneResidencial { get; private set; }

        public string Whatsapp { get; private set; }

        public string TelefoneComercial { get; private set; }

        public virtual Cliente Cliente { get; set; }
    }
}

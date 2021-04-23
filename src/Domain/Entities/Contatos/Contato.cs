using Domain.Core.DomainObjects.Entities;
using Domain.Entities.Clientes;

namespace Domain.Entities.Contatos
{
    public class Contato : Entity
    {
        public Contato(string nome,
                       string telefoneResidencial,
                       string whatsapp,
                       string telefoneComercial)
        {
            Nome = nome;
            TelefoneResidencial = telefoneResidencial;
            Whatsapp = whatsapp;
            TelefoneComercial = telefoneComercial;
        }

        public Contato() { }

        public string Nome { get; private set; }

        public string TelefoneResidencial { get; private set; }

        public string Whatsapp { get; private set; }

        public string TelefoneComercial { get; private set; }

        public virtual Cliente Cliente { get; set; }
    }
}

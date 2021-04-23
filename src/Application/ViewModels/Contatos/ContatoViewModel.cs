using System;

namespace Application.ViewModels.Contatos
{
    public class ContatoViewModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public string TelefoneResidencial { get; set; }

        public string Whatsapp { get; set; }

        public string TelefoneComercial { get; set; }
    }
}

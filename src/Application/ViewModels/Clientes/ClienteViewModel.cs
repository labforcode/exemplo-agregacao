using Application.ViewModels.Contatos;
using Application.ViewModels.Enderecos;
using System;
using System.Collections.Generic;

namespace Application.ViewModels.Clientes
{
    public class ClienteViewModel
    {
        public Guid Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataNascimento { get; set; }

        public EnderecoViewModel Endereco { get; set; }

        public IEnumerable<ContatoViewModel> Contatos { get; set; }
    }
}

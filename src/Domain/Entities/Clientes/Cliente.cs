using Domain.Core.DomainObjects.Entities;
using Domain.Core.DomainObjects.Interfaces;
using Domain.Entities.Contatos;
using Domain.Entities.Enderecos;
using System;
using System.Collections.Generic;

namespace Domain.Entities.Clientes
{
    public class Cliente : Entity, IAggregationRoot
    {
        public Cliente(string nome,
                       DateTime dataNascimento)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
        }

        public Cliente() { }

        public string Nome { get; private set; }

        public DateTime DataNascimento { get; private set; }

        public virtual Endereco Endereco { get; set; }

        public virtual ICollection<Contato> Contatos { get; set; }
    }
}

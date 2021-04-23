using Domain.Commands.Enderecos;
using System;
using System.Collections.Generic;

namespace Domain.Commands.Clientes.Actions
{
    public class InsertClienteCommand : ClienteCommand
    {
        public InsertClienteCommand(Guid clienteId,
                                    string nome,
                                    DateTime dataNascimento,
                                    EnderecoCommand endereco,
                                    IEnumerable<ContatoCommand> contatos)
        {
            ClienteId = clienteId;
            Nome = nome;
            DataNascimento = dataNascimento;
            Endereco = endereco;
            Contatos = contatos;
        }

        public override bool IsValid()
        {
            throw new NotImplementedException();
        }
    }
}

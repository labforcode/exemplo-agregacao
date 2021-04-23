using Application.ViewModels.Clientes;
using AutoMapper;
using Domain.Commands.Clientes.Actions;

namespace Application.Automapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {
            #region Cliente

            CreateMap<ClienteViewModel, InsertClienteCommand>()
            .ConstructUsing(c => new InsertClienteCommand(c.Id,
                                                          c.Nome,
                                                          c.DataNascimento,
                                                          c.Endereco,
                                                          c.Contatos));
            #endregion
        }
    }
}

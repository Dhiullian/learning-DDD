using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;

public class ViewModelToDomainMappingProfile : Profile
{
    public ViewModelToDomainMappingProfile()
    {
        CreateMap<ProdutoViewModel, Produto>()
            .ConvertUsing(prod => new Produto(prod.Nome, prod.Descricao, prod.Ativo,
                          prod.Valor, prod.CategoriaId, prod.DataCadastro,
                          prod.Imagem, new Dimensoes(prod.Altura, prod.Largura, prod.Profundidade)));

        CreateMap<CategoriaViewModel, Categoria>()
            .ConvertUsing(c => new Categoria(c.Nome, c.Codigo));
    }
}
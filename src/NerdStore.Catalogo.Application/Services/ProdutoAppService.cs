using AutoMapper;
using NerdStore.Catalogo.Application.ViewModels;
using NerdStore.Catalogo.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NerdStore.Catalogo.Application.Services
{
    internal class ProdutoAppService : IprodutoAppService
    {
        private readonly IProdutoRepository _produtoRepository;
        private readonly IMapper _mapper;

        public ProdutoAppService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Task AdicionarProduto(ProdutoViewModel produtoViewModel)
        {
            throw new NotImplementedException();
        }

        public Task AtualizarProduto(ProdutoViewModel produtoViewModel)
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoViewModel> DebitarEstoque(Guid id, int quantidade)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<CategoriaViewModel>> ObterCategorias()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoViewModel>> ObterPorCategoria(int codigo)
        {
            return _mapper.Map<IEnumerable<ProdutoViewModel>>(await _produtoRepository.ObterPorCategoria(codigo));
        }

        public Task<ProdutoViewModel> ObterPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<ProdutoViewModel>> ObterTodos()
        {
            throw new NotImplementedException();
        }

        public Task<ProdutoViewModel> ReporEstoque(Guid id, int quantidade)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
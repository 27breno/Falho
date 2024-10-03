using AutoMapper;
using Core._01_Services;
using Core._03_Entidades;
using Microsoft.AspNetCore.Mvc;
using TrabalhoFinal._01_Services;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class VendasController : ControllerBase
    {
        private readonly VendasService _service;
        private readonly IMapper _mapper;
        public VendasController(IConfiguration config, IMapper mapper)
        {
            string _config = config.GetConnectionString("DefaultConnection");
            _service = new VendasService(_config);
            _mapper = mapper;
        }
        [HttpPost("adicionar-produto")]
        public void AdicionarAluno(Vendas vendasDTO)
        {
            Vendas vendas = _mapper.Map<Vendas>(vendasDTO);
            _service.Adicionar(vendas);
        }
        [HttpGet("listar-produto")]
        public List<Vendas> ListarAluno()
        {
            return _service.Listar();
        }
        [HttpPut("editar-produto")]
        public void EditarProduto(Vendas v) 
        {
            _service.Editar(v);
        }
        [HttpDelete("deletar-produto")]
        public void DeletarProduto(int id)
        {
            _service.Remover(id);
        }
    }
}

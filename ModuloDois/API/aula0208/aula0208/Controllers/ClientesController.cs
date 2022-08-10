using Microsoft.AspNetCore.Mvc;
using aula0208.Models;
using aula0208.Infra;
using aula0208.DTOs;
using aula0208.ViewModel;
using aula0208.Repositories;

namespace aula0208.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientesController : ControllerBase
    {
        //private static List<Conta> Contas = new();

        //injetando a indeped�ncia do log pelo construtor
        private readonly LogAcao _logAcao;
        private readonly TipoClienteRepository _tipoClienteRepository;
        private readonly ClienteRepository _clienteRepository;

        public ClientesController
        (LogAcao log,
        TipoClienteRepository tipoClienteRepository,
        ClienteRepository clienteRepository
        )
        {
            _logAcao = log;
            _tipoClienteRepository = tipoClienteRepository;
            _clienteRepository = clienteRepository;
        }



        [HttpGet]
        //retorna os valores
        public List<Cliente> Get(
            [FromQuery] int? idade
        )
        {
            //personaliza o filtro recebendo pela query
            if (idade.HasValue)
            {
                return _clienteRepository.ObterPorIdade(idade.Value);
            }

            return _clienteRepository.ObterTodos();
        }

        // path -> /Clientes/Contas
        [HttpGet("ComContas")]
        public List<ClienteComContasViewModel> GetClienteContas()
        {
            return _clienteRepository.ObterClientesComContas();
        }

        [HttpGet("{idCliente}")]
        public Cliente GetById(
           [FromRoute] int idCliente)
        {
            return _clienteRepository.ObterPorId(idCliente);
        }



        [HttpPost]
        //armazena valores
        public ActionResult<Cliente> Post(
            [FromBody] ClienteDTO body
            //qual a estrutura que precisa ser mandada - nome e idade + valida��o
            )
        {
            //validar se existe o nome na lista
            if (_clienteRepository.ExisteClienteComNome(body.Nome))
            {
                return BadRequest(new ErroProcessamento("Cliente já cadastrado."));
            }

            var tipoCliente = _tipoClienteRepository.ObterPorId(body.TipoClienteId);

            //UM CLIENTE DTO SOMENTE COM AS PROPIREDADES OBRIGATÓRIAS (não é postado as outras propriedades)
            var cliente = new Cliente(
                body.Nome,
                body.Idade,
                tipoCliente
            );

            _clienteRepository.Adicionar(cliente);

            return Ok(cliente);
        }

        //Clientes/1 -> rota
        [HttpPut("{idCliente}")] //o id vira o 1
        //atualiza tudo
        public Cliente Put(
            [FromBody] ClienteDTO body,
            [FromRoute] int idCliente)
        {
            //pega o cliente
            var cliente = _clienteRepository.ObterPorId(idCliente);

            var tipoCliente = _tipoClienteRepository.ObterPorId(body.TipoClienteId);


            cliente.Nome = body.Nome;
            cliente.Idade = body.Idade;
            cliente.Tipo = tipoCliente;

            _clienteRepository.Atualizar(cliente);

            //gera depend�ncia desnecess�ria
            //var logo = new LogAcao("C:\\Logs\\Logs.txt")
            //log.GravarLog($"Cliente {body.Name} foi atualizado")

            //forma certa da depend�ncia 
            _logAcao.GravarLog($"Cliente {body.Nome} foi atualizado");

            return cliente;
        }

        [HttpDelete("{idCliente}")]
        //deleta o cliente da lista
        public void Delete(
            [FromRoute] int idCliente)
        {
            _clienteRepository.Remover(idCliente);
        }



        [HttpPost("{idCliente}/contas")]
        public ActionResult<Cliente> PostConta
            ([FromBody] Conta conta,
            [FromRoute] int idCliente)
        {
            var cliente = _clienteRepository.ObterPorId(idCliente);

            _clienteRepository.AdicionarConta(cliente, conta);

            return cliente;
        }
    };
}
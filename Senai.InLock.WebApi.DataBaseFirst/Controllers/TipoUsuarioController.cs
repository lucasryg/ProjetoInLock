using Microsoft.AspNetCore.Mvc;
using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using Senai.InLock.WebApi.DataBaseFirst.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class TipoUsuarioController : ControllerBase
    {
        private ITipoUsuarioRepository _tipoUsuarioRepository;

        public TipoUsuarioController()
        {
            _tipoUsuarioRepository = new TipoUsuarioRepository();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_tipoUsuarioRepository.Listar());

        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            return Ok(_tipoUsuarioRepository.BuscarPorId(id));

        }

        [HttpPost]
        public IActionResult Post(TipoUsuario novoTipo)
        {
            _tipoUsuarioRepository.Cadastrar(novoTipo);
            return StatusCode(200);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _tipoUsuarioRepository.Deletar(id);
            return StatusCode(200);
        }

        [HttpPut("{id}")]
        public IActionResult Atualizar(int id, TipoUsuario tipoUsuario)
        {
            _tipoUsuarioRepository.Atualizar(id, tipoUsuario);
            return StatusCode(200);
        }
    }
}

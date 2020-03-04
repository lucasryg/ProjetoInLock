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

    public class JogoController : ControllerBase
    {
            private IJogoRepository _jogoRepository;

            public JogoController()
            {
                _jogoRepository = new JogoRepository();
            }

            [HttpGet]
            public IActionResult Get()
            {
                return Ok(_jogoRepository.Listar());

            }

            [HttpGet("{id}")]
            public IActionResult GetById(int id)
            {
                return Ok(_jogoRepository.BuscarPorId(id));

            }

            [HttpPost]
            public IActionResult Post(Jogo novoJogo)
            {
                _jogoRepository.Cadastrar(novoJogo);
                return StatusCode(200);
            }
        }
    }


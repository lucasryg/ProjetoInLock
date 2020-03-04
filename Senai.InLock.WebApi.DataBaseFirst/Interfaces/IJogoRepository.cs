using Senai.InLock.WebApi.DataBaseFirst.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Interfaces
{
    interface IJogoRepository
    {
        List<Jogo> Listar();

        Jogo BuscarPorId(int id);

        void Cadastrar(Jogo novoJogo);
    }
}

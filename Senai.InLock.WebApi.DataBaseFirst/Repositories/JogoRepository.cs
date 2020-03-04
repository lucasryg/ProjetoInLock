using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class JogoRepository : IJogoRepository
    {
        InLockContext ctx = new InLockContext();

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogo.FirstOrDefault(e => e.IdJogo == id);
        }

        public void Cadastrar(Estudio novoEstudio)
        {
            ctx.Estudio.Add(novoEstudio);
            ctx.SaveChanges();
        }

        public void Cadastrar(Jogo novoJogo)
        {
            ctx.Jogo.Add(novoJogo);
            ctx.SaveChanges();
        }

        public List<Jogo> Listar()
        {
            return ctx.Jogo.ToList();
        }
    }
}

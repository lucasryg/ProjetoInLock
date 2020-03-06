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

        public void Atualizar(int id, Jogo jogo)
        {
            Jogo jogoAtualizado = new Jogo();
            jogoAtualizado = BuscarPorId(id);

            jogoAtualizado.DataDeLancamento = jogo.DataDeLancamento;
            jogoAtualizado.Descricao = jogo.Descricao;
            jogoAtualizado.IdEstudio = jogo.IdEstudio;
            jogoAtualizado.IdEstudioNavigation = jogo.IdEstudioNavigation;
            jogoAtualizado.Valor = jogo.Valor;

            ctx.Jogo.Update(jogoAtualizado);
            ctx.SaveChanges();
        }

        public Jogo BuscarPorId(int id)
        {
            return ctx.Jogo.FirstOrDefault(e => e.IdJogo == id);
        }

        public void Cadastrar(Jogo novoJogo)
        {
            ctx.Jogo.Add(novoJogo);
            ctx.SaveChanges();
        }


        public void Deletar(int id)
        {
            Jogo jogoApagado = new Jogo();
            jogoApagado = BuscarPorId(id);
            ctx.Jogo.Remove(jogoApagado);
            ctx.SaveChanges();
        }

        public List<Jogo> Listar()
        {
            return ctx.Jogo.ToList();
        }
    }
}

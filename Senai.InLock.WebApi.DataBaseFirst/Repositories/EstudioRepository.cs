using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{ 
    public class EstudioRepository : IEstudioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id, Estudio estudio)
        {
            Estudio estudioAtualizado = new Estudio();
            estudioAtualizado = BuscarPorId(id);
            estudioAtualizado.NomeEstudio = estudio.NomeEstudio;
            ctx.Estudio.Update(estudioAtualizado);
            ctx.SaveChanges();
        }

        public Estudio BuscarPorId(int id)
        {
            return ctx.Estudio.FirstOrDefault(e => e.IdEstudio == id);
        }

        public void Cadastrar(Estudio novoEstudio)
        {
            ctx.Estudio.Add(novoEstudio);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Estudio estudioApagado = new Estudio();
            estudioApagado = BuscarPorId(id);
            ctx.Estudio.Remove(estudioApagado);
            ctx.SaveChanges();
        }

        public List<Estudio> Listar()
        {
            return ctx.Estudio.ToList();
        }

        
    }
}

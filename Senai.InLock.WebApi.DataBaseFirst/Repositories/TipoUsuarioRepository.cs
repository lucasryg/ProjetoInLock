﻿using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class TipoUsuarioRepository : ITipoUsuarioRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id, TipoUsuario tipoUsuario)
        {
            TipoUsuario tipoUsuarioAtualizado = new TipoUsuario();
            tipoUsuarioAtualizado = BuscarPorId(id);

            tipoUsuarioAtualizado.Titulo = tipoUsuario.Titulo;
            tipoUsuarioAtualizado.Usuarios = tipoUsuario.Usuarios;

            ctx.TipoUsuario.Update(tipoUsuarioAtualizado);
            ctx.SaveChanges();
        }

        public TipoUsuario BuscarPorId(int id)
        {
            return ctx.TipoUsuario.FirstOrDefault(e => e.IdTipoUsuario == id);
        }

        public void Cadastrar(TipoUsuario novoTipo)
        {
            ctx.TipoUsuario.Add(novoTipo);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            TipoUsuario tipoApagado = new TipoUsuario();
            tipoApagado = BuscarPorId(id);
            ctx.TipoUsuario.Remove(tipoApagado);
            ctx.SaveChanges();
        }

        public List<TipoUsuario> Listar()
        {
            return ctx.TipoUsuario.ToList();
        }
    }
}

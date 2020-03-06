using Senai.InLock.WebApi.DataBaseFirst.Domains;
using Senai.InLock.WebApi.DataBaseFirst.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Senai.InLock.WebApi.DataBaseFirst.Repositories
{
    public class UsuariosRepository : IUsuariosRepository
    {
        InLockContext ctx = new InLockContext();

        public void Atualizar(int id, Usuarios usuarios)
        {
            Usuarios usuariosAtualizado = new Usuarios();
            usuariosAtualizado = BuscarPorId(id);

            usuariosAtualizado.Email = usuarios.Email;
            usuariosAtualizado.IdTipoUsuario = usuarios.IdTipoUsuario;
            usuariosAtualizado.IdTipoUsuarioNavigation = usuarios.IdTipoUsuarioNavigation;
            usuariosAtualizado.Senha = usuarios.Senha;

            ctx.Usuarios.Update(usuariosAtualizado);
            ctx.SaveChanges();
        }

        public Usuarios BuscarPorId(int id)
        {
            return ctx.Usuarios.FirstOrDefault(e => e.IdUsuario == id);
        }

        public void Cadastrar(Usuarios novoUsuario)
        {
            ctx.Usuarios.Add(novoUsuario);
            ctx.SaveChanges();
        }

        public void Deletar(int id)
        {
            Usuarios usuarioApagado = new Usuarios();
            usuarioApagado = BuscarPorId(id);
            ctx.Usuarios.Remove(usuarioApagado);
            ctx.SaveChanges();
        }

        public List<Usuarios> Listar()
        {
            return ctx.Usuarios.ToList();
        }
    }
}

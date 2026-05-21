using System.Collections.Generic;

namespace BibliotecaApp.Repositories
{
    public interface IRepository<T>
    {
        void Inserir(T entidade);
        IEnumerable<T> BuscarTodos();
        void Editar(T entidade);
        void Excluir(int id);
    }
}
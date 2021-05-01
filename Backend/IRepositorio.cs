using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface IRepositorio<T>
    {
        public T ObterPorId(int id);
        public List<T> ObterPorNome(string nome);
        public List<T> ObterTodos();
        public void Adicionar(T entidade);
        public void AdicionarVarios(List<T> entidades);
        public void Atualizar(T entidade);
        public void Deletar(T entidade);

    }
}

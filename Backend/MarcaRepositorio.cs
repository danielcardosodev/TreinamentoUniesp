using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class MarcaRepositorio : IRepositorio<Marca>
    {
        public void Adicionar(Marca entidade)
        {
            throw new NotImplementedException();
        }

        public void AdicionarVarios(List<Marca> entidades)
        {
            throw new NotImplementedException();
        }

        public void Atualizar(Marca entidade)
        {
            throw new NotImplementedException();
        }

        public void Deletar(Marca entidade)
        {
            throw new NotImplementedException();
        }

        public Marca ObterPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Marca> ObterPorNome(string nome)
        {
            throw new NotImplementedException();
        }

        public List<Marca> ObterTodos()
        {
            throw new NotImplementedException();
        }
    }
}

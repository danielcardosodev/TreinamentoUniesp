using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Marca
    {       
        //MAPEAMENTO UTILIZANDO FLUENT-API
        public int Id { get; set; }
        public string Nome { get; set; }
        public int IdPais { get; set; }
        public virtual Pais Pais { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public interface IVeiculo
    {
        public string Tipo { get; }
        public string Nome { get; set; }
        public string Cor { get; set; }
        public string Buzinar();
    }
}

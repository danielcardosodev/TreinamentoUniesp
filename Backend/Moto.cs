﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class Moto : IVeiculo
    {
        public string Cor { get; set; }
        public string Nome { get; set; }

        public string Tipo => "Moto";

        public string Buzinar()
        {
            return "Piiii";
        }
    }
}

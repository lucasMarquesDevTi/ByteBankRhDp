﻿using ByteBankRhDp.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRhDp.Parceria
{
    public class ParceiroComercial:IAutenticavel
    {

        public string Login { get; set; }
        public string Senha { get; set; }


        public bool Autenticar(string login, string senha)
        {
            return this.Login == login && this.Senha == senha;
        }
    }
}

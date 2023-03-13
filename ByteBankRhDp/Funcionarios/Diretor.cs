using ByteBankRhDp.SistemaInterno;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRhDp.Funcionarios
{
    public class Diretor:FuncionarioAutenticavel
    {

        public Diretor(string cpf):base(cpf, 5000)
        {
        }
        public override double GetBonificacao()//OVERRIDE - corrobora com a sobrescrição do método.
        {
            return Salario * 0.5;//BASE- permite acessarmos um elemento que está na 
        }                                               //classe que está sendo herdada.
        public override void AumentarSalario()
        {
            Salario *= 1.15;
        }

    }

}

//Para indicar que se trata da redefinição de comportamento da classe base, 
//o método deve usar em sua assinatura a palavra chave override. 
//E na definição deste método na classe base, deve ser usada a palavra virtual.

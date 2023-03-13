using ByteBankRhDp.Funcionarios;
using ByteBankRhDp.Parceria;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBankRhDp.SistemaInterno
{
    public class SistemaInterno
    {
        public bool Logar(IAutenticavel funcionario,string login, string senha)
        {
            bool usuarioAutenticado = funcionario.Autenticar(login, senha);
            if(usuarioAutenticado)
            {
                Console.WriteLine("Seja bem-vindo ao sistema byteBank!");
                return true;
            }
            else
            {
                Console.WriteLine("Login ou Senha incorretos!");
                return false;
            }
        }

    }
}

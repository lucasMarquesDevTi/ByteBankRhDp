using ByteBankRhDp.Funcionarios;
using ByteBankRhDp.Parceria;
using ByteBankRhDp.SistemaInterno;
using ByteBankRhDp.Utilitario;

#region
//Funcionario lucas = new Funcionario("123456789", 2000)
//{
//    Nome = "Lucas Marques",
//};
////Console.WriteLine(lucas.Nome);
////Console.WriteLine(lucas.GetBonificacao() + lucas.Salario);

//Diretor emmy = new Diretor("987654321")
//{
//    Nome = "Emmy",
//};
////Console.WriteLine(emmy.Nome);
////Console.WriteLine(emmy.GetBonificacao() + emmy.Salario);

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(lucas);
//gerenciador.Registrar(emmy);

//Console.WriteLine(gerenciador.TotalDeBonificacao);

//lucas.AumentarSalario();
//emmy.AumentarSalario();
//Console.WriteLine(emmy.Salario);
#endregion
CalcularBonificação();
UsarSistema();
void CalcularBonificação()
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer designUm = new Designer("123456789")
    {
        Nome = "Lincoln Lucas"
    };

    Diretor diretorUm = new Diretor("19758432")
    {
        Nome = "Emmy Monsueth"
    };

    Auxiliar auxiliarUm = new Auxiliar("987654321")
    {
        Nome = "Lucas Marques"
    };

    GerenteDeContas gerenteUm = new GerenteDeContas("123456789")
    {
        Nome = "Daniel Marques"
    };

    gerenciador.Registrar(designUm);
    gerenciador.Registrar(diretorUm);
    gerenciador.Registrar(auxiliarUm);
    gerenciador.Registrar(gerenteUm);

    Console.WriteLine(gerenciador.TotalDeBonificacao);

}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor emmy = new Diretor("123456789")
    {
        Nome = "Emmy",
        Login = "diretor1",
        Senha = "123"
    };

    GerenteDeContas lincoln = new GerenteDeContas("987654321")
    {
        Nome = "Lincoln",
        Login = "gerente1",
        Senha = "456"
    };

    ParceiroComercial daniel = new ParceiroComercial()
    {
        Login = "teste",
        Senha = "123"
    };

    sistema.Logar(emmy, "diretor1", "123");
    sistema.Logar(lincoln,"gerente1", "456");
    sistema.Logar(daniel, "teste", "123");
}
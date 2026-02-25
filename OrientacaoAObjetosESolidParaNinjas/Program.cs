using Problema = OrientacaoAObjetosESolidParaNinjas.Capitulo02.Problema;
using Solucao = OrientacaoAObjetosESolidParaNinjas.Capitulo02.Solucao;

// Implementação do código sugeriodo na pag. 6
var calculadoraDeSalarioP = new Problema.CalculadoraDeSalario();
var funcionarioP = new Problema.Funcionario
{
    Cargo = Problema.Cargo.DESEVOLVEDOR,
    Salario = 4000.0
};
var salarioCalculadoP = calculadoraDeSalarioP.Calcular(funcionarioP);

Console.WriteLine($"Valor do salário: {salarioCalculadoP}");

// Implementação do código sugeriodo nas pags. 9 à 12
var calculadoraDeSalarioS = new Solucao.CalculadoraDeSalario();
var funcionarioS = new Solucao.Funcionario
{
    Cargo = Solucao.Cargo.DESEVOLVEDOR,
    Salario = 4000.0
};
var salarioCalculadoS = calculadoraDeSalarioS.Calcular(funcionarioS);

Console.WriteLine($"Valor do salário: {salarioCalculadoS}");
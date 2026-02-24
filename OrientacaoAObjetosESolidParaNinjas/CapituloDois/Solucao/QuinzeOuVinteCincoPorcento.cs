using OrientacaoAObjetosESolidParaNinjas.CapituloDois.Problema;

namespace OrientacaoAObjetosESolidParaNinjas.CapituloDois.Solucao;

public class QuinzeOuVinteCincoPorcento : IRegraDeCalculo
{
    public double Calcular(Funcionario funcionario)
    {
        if (funcionario.Salario > 2000.0)
        {
            return funcionario.Salario * 0.85;
        }
        else
        {
            return funcionario.Salario * 0.75;
        }
    }
}

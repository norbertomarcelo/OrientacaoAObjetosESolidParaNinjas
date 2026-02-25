namespace OrientacaoAObjetosESolidParaNinjas.Capitulo02.Solucao;

public class DezOuVintePorcento : IRegraDeCalculo
{
    public double Calcular(Funcionario funcionario)
    {
        if (funcionario.Salario > 3000.0)
        {
            return funcionario.Salario * 0.8;
        }
        else
        {
            return funcionario.Salario * 0.9;
        }
    }
}

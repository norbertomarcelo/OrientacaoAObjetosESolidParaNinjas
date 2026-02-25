namespace OrientacaoAObjetosESolidParaNinjas.Capitulo02.Problema;

public class CalculadoraDeSalario
{
    public double Calcular(Funcionario funcionario)
    {
        if (funcionario.Cargo == Cargo.DESEVOLVEDOR)
        {
            return DezOuVintePorcento(funcionario);
        }

        if (funcionario.Cargo == Cargo.DBA || funcionario.Cargo == Cargo.TESTER)
        {
            return QuinzeOuVinteCincoPorcento(funcionario);
        }

        throw new InvalidOperationException("funcionario invalido");
    }

    private static double DezOuVintePorcento(Funcionario funcionario)
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

    private static double QuinzeOuVinteCincoPorcento(Funcionario funcionario)
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

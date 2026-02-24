namespace OrientacaoAObjetosESolidParaNinjas.CapituloDois.Solucao;

public class CalculadoraDeSalario
{
    public double Calcular(Funcionario funcionario)
    {
        return new DefineRegraCalculo().Definir(funcionario.Cargo).Calcular(funcionario);
    }
}

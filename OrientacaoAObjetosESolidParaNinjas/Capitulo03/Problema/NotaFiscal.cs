namespace OrientacaoAObjetosESolidParaNinjas.Capitulo03.Problema;

public class NotaFiscal
{
    public double Valor { get; set; }
    public double Imposto { get; set; }

    public NotaFiscal(double valor, double imposto)
    {
        Valor = valor;
        Imposto = imposto;
    }
}

namespace OrientacaoAObjetosESolidParaNinjas.Capitulo05.Solucao;

public class Pagamento
{
    public Pagamento(double valor, MeioDePagamento boleto)
    {
        Valor = valor;
        Boleto = boleto;
    }

    public double Valor { get; set; }
    public MeioDePagamento Boleto { get; }
}
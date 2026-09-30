namespace OrientacaoAObjetosESolidParaNinjas.Capitulo05.Solucao;

public class Fatura
{
    private List<Pagamento> Pagamentos { get; set; }
    private bool Pago { get; set; }
    private double Valor { get; set; }

    public void AdicionaPagamento(Pagamento pagamento)
    {
        this.Pagamentos.Add(pagamento);

        if (ValorTotalDosPagamentos() > this.Valor)
        {
            this.Pago = true;
        }
    }

    private double ValorTotalDosPagamentos()
    {
        double total = 0;

        foreach (Pagamento pagamento in this.Pagamentos)
        {
            total += pagamento.Valor;
        }

        return total;
    }
}
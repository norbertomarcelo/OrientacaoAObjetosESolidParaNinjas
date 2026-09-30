namespace OrientacaoAObjetosESolidParaNinjas.Capitulo05.Solucao;

public class ProcessadorDeBoletos
{
    public void Processar(List<Boleto> boletos, Fatura fatura)
    {
        foreach (Boleto boleto in boletos)
        {
            Pagamento pagamento = new Pagamento(
                boleto.Valor, 
                MeioDePagamento.Boleto);

            fatura.AdicionaPagamento(pagamento);
        }
    }
}

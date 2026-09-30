namespace OrientacaoAObjetosESolidParaNinjas.Capitulo05.Problema;

public class ProcessadorDeBoletos
{
    public void Processar(List<Boleto> boletos, Fatura fatura)
    {
        foreach (Boleto boleto in boletos)
        {
            Pagamento pagamento = new Pagamento(
                boleto.Valor, 
                MeioDePagamento.Boleto);

            fatura.GetPagamentos().Add(pagamento);

            total += boleto.Valor;
        }

        if (total >= fatura.Valor)
        {
            fatura.Pago(true);
        }
    }
}

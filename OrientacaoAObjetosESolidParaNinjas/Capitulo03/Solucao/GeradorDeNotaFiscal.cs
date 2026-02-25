namespace OrientacaoAObjetosESolidParaNinjas.Capitulo03.Solucao;

public class GeradorDeNotaFiscal
{
    private readonly List<IAcaoAposGerarNota> acoes;

    public GeradorDeNotaFiscal(List<IAcaoAposGerarNota> acoes)
    {
        this.acoes = acoes;
    }

    public NotaFiscal Gerar(Fatura fatura)
    {
        var valor = fatura.ValorMensal;
        var nf = new NotaFiscal(valor, ImpostoSimpllesSobre0(valor));
        foreach (var acao in acoes)
        {
            acao.Executa(nf);
        }
        return nf;
    }

    private double ImpostoSimpllesSobre0(double valor)
    {
        return valor * 0.06;
    }
}

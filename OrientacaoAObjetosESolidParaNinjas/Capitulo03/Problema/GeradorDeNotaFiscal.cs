namespace OrientacaoAObjetosESolidParaNinjas.Capitulo03.Problema;

public class GeradorDeNotaFiscal
{
    private readonly EnviadorDeEmail email;
    private readonly NotaFiscalDao dao;

    public GeradorDeNotaFiscal(EnviadorDeEmail enviadorDeEmail, NotaFiscalDao notaFiscalDao)
    {
        email = enviadorDeEmail;
        dao = notaFiscalDao;
    }

    public NotaFiscal Gerar(Fatura fatura)
    {
        var valor = fatura.ValorMensal;
        var nf = new NotaFiscal(valor, ImpostoSimpllesSobre0(valor));

        email.EnviarEmail(nf);
        dao.Persistir(nf);

        return nf;
    }

    private double ImpostoSimpllesSobre0(double valor)
    {
        return valor * 0.06;
    }
}

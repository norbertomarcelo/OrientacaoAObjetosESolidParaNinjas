namespace OrientacaoAObjetosESolidParaNinjas.Capitulo04.Problema;

public class CalculadoraDePrecos
{
    public double Calcula(Compra produto)
    {
        TabelaDePrecoPadrao tabela = new TabelaDePrecoPadrao();
        Frete corrios = new Frete();

        double desconto = tabela.DescontoPara(produto.Valor);
        double frete = corrios.Para(produto.Cidade);

        return produto.Valor * (1 - desconto) + frete;
    }
}

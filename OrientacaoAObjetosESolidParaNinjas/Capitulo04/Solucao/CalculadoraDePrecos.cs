namespace OrientacaoAObjetosESolidParaNinjas.Capitulo04.Solucao;

public class CalculadoraDePrecos
{
    private readonly ITabelaDePreco tabela;
    private readonly IServicoDeEntrega entrega;

    public CalculadoraDePrecos(ITabelaDePreco tabela, IServicoDeEntrega entrega)
    {
        this.tabela = tabela;
        this.entrega = entrega;
    }

    public double Calcula(Compra produto)
    {
        double desconto = tabela.DescontoPara(produto.Valor);
        double frete = entrega.Para(produto.Cidade);
        return produto.Valor * (1 - desconto) + frete;
    }
}

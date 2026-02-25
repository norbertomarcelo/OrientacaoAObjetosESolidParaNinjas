namespace OrientacaoAObjetosESolidParaNinjas.Capitulo04.Problema;

public class TabelaDePrecoPadrao
{
    public double DescontoPara(double valor)
    {
        if (valor > 500) return 0.03;
        if (valor > 1000) return 0.05;
        return 0;
    }
}

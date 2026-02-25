namespace OrientacaoAObjetosESolidParaNinjas.Capitulo04.Problema;

public class Frete
{
    public double Para(string cidade)
    {
        if ("SAO PAULO" == cidade.ToUpper())
        {
            return 15;
        }
        return 30;
    }
}

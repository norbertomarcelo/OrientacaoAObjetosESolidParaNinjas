namespace OrientacaoAObjetosESolidParaNinjas.Capitulo02.Solucao;

public class DefineRegraCalculo
{
    public IRegraDeCalculo Definir(Cargo cargo)
    {
        return cargo switch
        {
            Cargo.DESEVOLVEDOR => new DezOuVintePorcento(),
            Cargo.DBA => new QuinzeOuVinteCincoPorcento(),
            Cargo.TESTER => new QuinzeOuVinteCincoPorcento(),
            _ => throw new InvalidOperationException("Cargo inválido")
        };
    }
}

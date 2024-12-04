namespace TP3;

public class Livre : ArticleType, IRentable
{
    public bool IsBn { get; }
    public int NbPages { get; }

    public Livre(string nom, double prix, int quantite, bool isBn, int nbPages)
        : base(nom, prix, quantite, TypeArticle.Papeterie)
    {
        IsBn = isBn;
        NbPages = nbPages;
    }

    public double CalculateRent()
    {
        return Prix * 0.05;
    }

    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($"ISBN : {IsBn}, Nombre de pages : {NbPages}");
    }

    public override string ToString()
    {
        return base.ToString() + $", ISBN : {IsBn}, Pages : {NbPages}";
    }
}

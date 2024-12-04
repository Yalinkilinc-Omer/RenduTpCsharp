namespace TP3;

public class Video : ArticleType, IRentable
{
    public double Duree { get; }

    public Video(string nom, double prix, int quantite, double duree)
        : base(nom, prix, quantite, TypeArticle.Multimédia)
    {
        Duree = duree;
    }

    public double CalculateRent()
    {
        return Prix * 0.1;
    }

    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($"Durée : {Duree} minutes");
    }

    public override string ToString()
    {
        return base.ToString() + $", Durée : {Duree} minutes";
    }
}

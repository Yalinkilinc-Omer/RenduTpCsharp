namespace TP3;

public class Disque : ArticleType
{
    public string Label { get; }

    public Disque(string nom, double prix, int quantite, string label)
        : base(nom, prix, quantite, TypeArticle.Multimédia)
    {
        Label = label;
    }

    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($"Label : {Label}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Label : {Label}";
    }
}

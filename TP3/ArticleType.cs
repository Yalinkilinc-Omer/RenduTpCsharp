namespace TP3;

public class ArticleType : Article
{
    public TypeArticle Type { get; }

    public ArticleType(string nom, double prix, int quantite, TypeArticle type) : base(nom, prix, quantite)
    {
        Type = type;
    }

    public override void PublishDetails()
    {
        base.PublishDetails();
        Console.WriteLine($"Type : {Type}");
    }

    public override string ToString()
    {
        return base.ToString() + $", Type : {Type}";
    }
}

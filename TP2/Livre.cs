using TP1;

namespace TP2;

public class Livre : Article,IRentable
{
    private string ISBN;
    private int nbPages;

    public Livre(string nom, float prix, int quantite, ArticleType type, string isbn, int nbPages) : base(nom, prix, quantite, type)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
        this.type = type;
        ISBN = isbn;
        this.nbPages = nbPages;
    }

    public float calculateRent()
    {
        return (prix / nbPages) * 100;
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"{base.ToString()}, ISBN : {ISBN}, {nbPages} pages");
    }

    public void DiscountStrategy(float amount)
    {
        Console.WriteLine(Delegate.Remise(prix,amount));
    }


    public override string ToString()
    {
        return $"{base.ToString()}, ISBN : {ISBN}, {nbPages} pages";
    }
}
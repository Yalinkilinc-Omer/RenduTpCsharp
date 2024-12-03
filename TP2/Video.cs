using TP1;

using TP1;

namespace TP2;

public class Video : Article, IRentable
{
    private int duree;

    public Video(string nom, float prix, int quantite, ArticleType type, int duree) 
        : base(nom, prix, quantite, type)
    {
        this.duree = duree;
    }

    public void afficher()
    {
        Console.WriteLine("Afficher la durée");
    }

    public void DiscountStrategy(float amount)
    {
        // Applique la réduction et met à jour le prix
        prix -= prix * amount;
        Console.WriteLine($"Prix après réduction : {prix}€");
    }

    public float calculateRent()
    {
        float rent = (duree / prix) * 2;
        return rent;
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"{base.ToString()}, durée : {duree} minutes");
    }

    public override string ToString()
    {
        return $"{base.ToString()}, durée : {duree} minutes";
    }
}

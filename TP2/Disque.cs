using System.Transactions;
using TP1;

namespace TP2;

public class Disque : Article, IRentable
{
    private string label;

    public Disque(string nom, float prix, int quantite, ArticleType type, string label) 
        : base(nom, prix, quantite, type)
    {
        this.label = label;
    }

    public void ecouter()
    {
        Console.WriteLine("Entrer le nom du label:");
    }

    public void DiscountStrategy(float amount)
    {
        // Applique la réduction et met à jour le prix
        prix -= prix * amount;
        Console.WriteLine($"Prix après réduction : {prix}€");
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"{base.ToString()}, label : {label}");
    }

    public override string ToString()
    {
        return $"{base.ToString()}, label : {label}";
    }

    public float calculateRent()
    {
        return (prix / quantite) * 10;
    }
}

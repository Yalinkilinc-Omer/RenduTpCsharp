using TP1;

namespace TP2;

public class Poche : Livre
{
    private string categorie;

    public Poche(string nom, float prix, int quantite, ArticleType type, string isbn, int nbPages, string categorie) 
        : base(nom, prix, quantite, type, isbn, nbPages)
    {
        this.categorie = categorie;
    }

    public void DiscountStrategy(float amount)
    {
        // Applique la réduction et met à jour le prix
        prix -= prix * amount;
        Console.WriteLine($"Prix après réduction : {prix}€");
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"{base.ToString()}, catégorie : {categorie}");
    }
    
    public override string ToString()
    {
        return $"{base.ToString()}, catégorie : {categorie}";
    }
}

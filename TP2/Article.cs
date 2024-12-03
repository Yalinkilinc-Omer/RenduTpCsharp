using TP1;

namespace TP2;

public class Article : Publication
{
    protected string nom;
    protected float prix;
    protected int quantite;
    protected ArticleType type;

    /*
     * Constructor of Article
     */
    public Article(string nom, float prix, int quantite, ArticleType type)
    {
        this.nom = nom;
        this.prix = prix;
        this.quantite = quantite;
        this.type = type;
    }

    public float Prix => prix; // Propriété pour accéder au prix

    public void afficher()
    {
        Console.WriteLine(nom + ", " + prix + " euro , " + quantite + " exemplaires" + type.ToString());
    }

    public void afficher(string name)
    {
        Console.WriteLine(name + " : " + nom + ", " + prix + " euro, " + quantite + " exemplaires, " + type.ToString());
    }

    public void ajouter(int quantite)
    {
        this.quantite = this.quantite + quantite;
        Console.WriteLine("Ajout de " + quantite);
    }

    public void retirer(int quantite)
    {
        if (quantite > 0)
        {
            this.quantite = this.quantite - quantite;
            Console.WriteLine("Retirer " + quantite);
        }
    }

    // Méthode pour appliquer une réduction sur le prix
    public virtual void DiscountStrategy(float amount)
    {
        prix -= prix * amount; // Applique la réduction
        Console.WriteLine($"Prix après réduction : {prix}€");
    }

    public override void PublishDetails()
    {
        // Implémentation vide ici, à remplacer par le comportement des sous-classes
    }

    public override string ToString()
    {
        return $"{nom}, {prix} euros, {quantite} exemplaires, Type : {type}";
    }
}

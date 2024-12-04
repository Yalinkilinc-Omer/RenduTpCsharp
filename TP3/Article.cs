namespace TP3;

public class Article : Publication
{
    protected string Nom { get; }
    protected double Prix { get; private set; }
    protected int Quantite { get; private set; }

    public Article(string nom, double prix, int quantite)
    {
        Nom = nom ?? throw new ArgumentNullException(nameof(nom));
        Prix = prix > 0 ? prix : throw new ArgumentException("Le prix doit être positif.");
        Quantite = quantite >= 0 ? quantite : throw new ArgumentException("La quantité ne peut pas être négative.");
    }

    public void Ajouter(int quantite)
    {
        if (quantite > 0) Quantite += quantite;
    }

    public void Retirer(int quantite)
    {
        if (quantite > 0 && quantite <= Quantite) Quantite -= quantite;
    }

    public override void PublishDetails()
    {
        Console.WriteLine($"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}");
    }

    public override string ToString()
    {
        return $"Nom : {Nom}, Prix : {Prix} €, Quantité : {Quantite}";
    }
}

namespace TP1;

public class Article
{
    protected string designation;
    protected string nom;
    protected float  prix;
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

    public void afficher()
    {
        Console.WriteLine(nom + ", " + prix + " euro , " + quantite + " exemplaires" + type.ToString());
    }

    public void afficher(string name)
    {
        Console.WriteLine(name + " : " + nom + ", " + prix + " euro, " + quantite +" exemplaires, " + type.ToString());
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
    public override string ToString()
    {
        return $"{nom}, {prix} euros, {quantite} exemplaires, Type : {type}";
    }
}
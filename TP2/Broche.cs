using TP1;

namespace TP2;

public class Broche : Livre
{
    public Broche(string nom, float prix, int quantite, ArticleType type, string isbn, int nbPages) : base(nom, prix, quantite, type, isbn, nbPages)
    {
    }
}
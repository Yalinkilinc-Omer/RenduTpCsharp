using TP2;

namespace TP1;

public class ArticleTableau
{
  
    protected Article[] articles;

    public ArticleTableau(Article livre1, Article livre2, Article livre3)
    {
        
        this.articles = new Article[] { livre1, livre2, livre3 };
    }

    public void AfficherArticles()
    {
        foreach (var article in articles)
        {
            Console.WriteLine(article);
        }
    }
}

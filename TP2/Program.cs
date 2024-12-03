using TP1;
using TP2;
using Delegate = TP2.Delegate;

List<Article> articles = new List<Article>();

// Ajouter des articles à la liste
articles.Add(new Poche("Eragon", 21.99f, 14, ArticleType.LOISIR, "2342232", 478, "Poche"));
articles.Add(new Disque("Naheulbeuk", 18.20f, 25, ArticleType.LOISIR, "Johnson Records"));
articles.Add(new Video("Le c# pour les nuls : le guide", 24.99f, 30, ArticleType.LOISIR, 120));

foreach (var article in articles)
{
    // Affichage des détails de chaque article
    article.PublishDetails();
    
    // Si l'article est rentable, on calcule le prix de location
    if (article is IRentable rent)
    {
        Console.WriteLine($"Prix de location : {rent.calculateRent()}€");
    }

    // Appliquer les stratégies de réduction selon le type d'article
    switch (article)
    {
        case Poche poche:
            poche.DiscountStrategy(0.25f); // Réduction de 25%
            break;
        case Disque disque:
            disque.DiscountStrategy(0.50f); // Réduction de 50%
            break;
        case Video video:
            video.DiscountStrategy(0.75f); // Réduction de 75%
            break;
    }

    // Affichage du prix après réduction
    Console.WriteLine($"Prix après réduction de {article.ToString()} : {article.Prix}€");
}

namespace TP3;

using System.Text.Json;

internal static class Program
{
    private static void Main(string[] args)
    {
        const int nbTirets = 100;

        Console.WriteLine("\n\n" + new string('-', nbTirets));
        Console.WriteLine("--- TP1 ---");
        Console.WriteLine("" + new string('-', nbTirets));

        Response();
    }

    private static void Response()
    {
        // Étape 1 : Chargement des données
        Console.WriteLine("\n\nÉtape 1 : Chargement des données");

        // créé une liste d'articles de différents types
        List<ArticleType> articles = new List<ArticleType>
        {
            new("Fraise", 2.5, 10, TypeArticle.Alimentaire),
            new("Pomme", 1.5, 20, TypeArticle.Alimentaire),
            new("Banane", 1.0, 30, TypeArticle.Alimentaire),
            new("Brosse à dents", 3.0, 5, TypeArticle.Droguerie),
            new("Dentifrice", 2.0, 10, TypeArticle.Droguerie),
            new("Chemise", 15.0, 10, TypeArticle.Habillement),
            new("Pantalon", 25.0, 5, TypeArticle.Habillement),
            new("Raquette de tennis", 50.0, 2, TypeArticle.Loisir),
            new("Balle de tennis", 2.0, 10, TypeArticle.Loisir),
            new Disque("NRJ Hits", 10.0, 5, "NRJ"),
            new Disque("Skyrock Hits", 10.0, 5, "Skyrock"),
            new Livre("Les Misérables", 20.0, 3, true, 1500),
            new Livre("Le Petit Prince", 15.0, 5, false, 100),
            new Livre("Le Seigneur des Anneaux", 30.0, 2, true, 2000),
            new Video("Inception", 10.0, 5, 120),
            new Video("Interstellar", 10.0, 5, 150),
            new Video("The Dark Knight", 10.0, 5, 180)
        };

        // Étape 2 : Analyse des données avec LINQ
        Console.WriteLine("\n\nÉtape 2 : Analyse des données avec LINQ");

        // Étape 2.1 : Requêtes LINQ de base
        Console.WriteLine("Étape 2.1 : Requêtes LINQ de base");

        // récupère les articles alimentaires
        List<ArticleType> articlesAlimentaire =
            articles.Where(article => article.Type == TypeArticle.Alimentaire).ToList();

        // trié par prix décroissant
        articlesAlimentaire.Sort((article1, article2) => article2.Prix.CompareTo(article1.Prix));

        // affiche les articles alimentaires
        Console.WriteLine("Articles alimentaires :");
        foreach (ArticleType article in articlesAlimentaire)
        {
            Console.WriteLine($" -> {article}");
        }

        // calculer le Stock total de tous les articles
        int stockTotal = articles.Sum(article => article.Quantite);

        // affiche le stock total
        Console.WriteLine($"Stock total : {stockTotal}");

        // Étape 2.2 : Filtrage avancé avec l’opérateur OfType
        Console.WriteLine("Étape 2.2 : Filtrage avancé avec l’opérateur OfType");

        // Créez une liste contenant à la fois des objets Article et d’autres objets quelconques.
        List<object> articlesEtAutres = new List<object>
        {
            new { Nom = "Ordinateur", Prix = 500.0, Quantite = 1 },
            new { Nom = "Souris", Prix = 20.0, Quantite = 1 },
            new { Nom = "Clavier", Prix = 50.0, Quantite = 1 }
        };

        articlesEtAutres.AddRange(articles);

        // Utilisez l’opérateur OfType<ArticleTypé>() pour extraire uniquement les articles typés de cette collection.
        List<ArticleType> articlesTypés = articlesEtAutres.OfType<ArticleType>().ToList();

        // affiche les articles typés
        Console.WriteLine("Articles typés :");
        foreach (ArticleType article in articlesTypés)
        {
            Console.WriteLine($" -> {article}");
        }

        // Étape 2.3 : Projection avec des types anonymes
        Console.WriteLine("Étape 2.3 : Projection avec des types anonymes");

        // Créez une vue simplifiée de vos articles en ne conservant que le nom et le prix sous forme de type anonyme

        var articlesSimplifiés = articles.Select(article => new { article.Nom, article.Prix }).ToList();

        // Affichez ces types anonymes dans la console

        Console.WriteLine("Articles simplifiés :");
        foreach (var article in articlesSimplifiés)
        {
            Console.WriteLine($" -> {article.Nom} : {article.Prix} €");
        }

        // Étape 3 : Manipulations avancées
        Console.WriteLine("\n\nÉtape 3 : Manipulations avancées");

        // Étape 3.1 : Méthodes d’extension personnalisées
        Console.WriteLine("Étape 3.1 : Méthodes d’extension personnalisées");

        // Implémentez une méthode d'extension AfficherTous() permettant d'afficher dans la console tous les articles d’une liste avec leurs détails.
        // Utilisez cette méthode sur la liste d’articles pour tester son fonctionnement.
        articles.AfficherTous();

        // Étape 3.2 : Expressions lambda pour les calculs
        Console.WriteLine("Étape 3.2 : Expressions lambda pour les calculs");

        // Utilisez une expression lambda pour calculer la valeur totale du stock de tous les articles
        Func<ArticleType, double> calculerValeurStock = article => article.Prix * article.Quantite;
        double valeurStock = articles.Sum(calculerValeurStock);

        // affiche la valeur du stock
        Console.WriteLine($"Valeur du stock : {valeurStock} €");

        // Étape 4 : Export et import JSON
        Console.WriteLine("\n\nÉtape 4 : Export et import JSON");

        // Étape 4.1 : Sérialisation JSON
        Console.WriteLine("Étape 4.1 : Sérialisation JSON");
        // recupère le chemin absolu du fichier
        const string nomFichier = "articles.json";
        string cheminFichier = Path.GetFullPath(nomFichier);
        
        Console.WriteLine($"Chemin du fichier JSON : {cheminFichier}");
        
        // Exportez votre liste d’articles vers un fichier JSON à l’aide de la bibliothèque System.Text.Json.
        Console.WriteLine($"Création d'un fichier JSON : {nomFichier}");
        string json = JsonSerializer.Serialize(articles);
        File.WriteAllText(cheminFichier, json);
        Console.WriteLine("Fichier JSON créé avec succès");


        // Étape 4.2 : Désérialisation JSON
        Console.WriteLine("Étape 4.2 : Désérialisation JSON");
        Console.WriteLine("En Développement");

        // todo: Ne fonctionne pas pas car pas de constructeur par JSON pour les classes Article, ArticleType, Disque, Livre et Video
        // // Chargez les articles depuis le fichier JSON et affichez-les
        // Console.WriteLine($"Chargement du fichier JSON : {nomFichier}");
        // string jsonFromFile = File.ReadAllText(cheminFichier);
        // List<ArticleType> articlesFromJson =
        //     JsonSerializer.Deserialize<List<ArticleType>>(jsonFromFile) ?? new List<ArticleType>();
        //
        // Console.WriteLine("Articles depuis le fichier JSON :");
        // articlesFromJson.AfficherTous();
    }
}
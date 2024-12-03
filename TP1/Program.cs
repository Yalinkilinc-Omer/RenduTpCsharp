using TP1;

Console.WriteLine("Hello, World!");
Article livre1 = new Article("harry potter",15.90f,4,ArticleType.LOISIR);
Article livre2 = new Article("Seigneur des Anneaux",19.90f,11, ArticleType.LOISIR);
Article livre3 = new Article("La fille dans l'écran",11.90f,6, ArticleType.LOISIR);
Console.WriteLine("\nTableau d'articles : \n");

ArticleTableau tableau = new ArticleTableau(livre1, livre2, livre3);
tableau.AfficherArticles();


Console.WriteLine("\nTest exo 1: \n");
Console.WriteLine(nameof(livre1));
livre1.ajouter(2);
livre2.afficher(nameof(livre1));
Console.WriteLine(nameof(livre2));
livre2.retirer(6);
livre3.afficher(nameof(livre1));
Console.WriteLine(nameof(livre3));
livre3.ajouter(11);

Console.WriteLine("\n");

livre1.afficher(nameof(livre1));
livre2.afficher(nameof(livre2));
livre3.afficher(nameof(livre3));


Console.WriteLine("\nTest exo 2: \n");
while (true)
{
    Console.WriteLine("\nQuel livre souhaitez-vous modifier ? (Entrez 'exit' pour quitter)\n");
    Console.WriteLine("1 - Livre 1 (Harry Potter)");
    Console.WriteLine("2 - Livre 2 (Seigneur des Anneaux)");
    Console.WriteLine("3 - Livre 3 (La fille dans l'écran)");
    String target = Console.ReadLine();

    // Si l'utilisateur entre "exit", sortir de la boucle
    if (target.ToLower() == "exit")
    {
        Console.WriteLine("Au revoir !");
        break;
    }

    // Convertir la saisie en entier si c'est un numéro
    int livreIndex = 0;
    if (int.TryParse(target, out livreIndex) && livreIndex >= 1 && livreIndex <= 3)
    {
        // Modifier la cible en fonction du numéro
        switch (livreIndex)
        {
            case 1:
                target = "livre1";
                break;
            case 2:
                target = "livre2";
                break;
            case 3:
                target = "livre3";
                break;
        }
    }

    Console.WriteLine("\nQue souhaitez-vous modifier ?\n" +
                      "1 - Ajouter un exemplaire\n" +
                      "2 - Retirer un exemplaire\n" +
                      "3 - afficher les détails ?\n");
    var task = Console.ReadLine();
    Console.WriteLine("\n");

    switch (task)
    {
        case "1":
            Console.WriteLine("\nCombien souhaitez-vous ajouter ?\n");
            var quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (target)
            {
                case "livre1":
                    livre1.ajouter(quantity);
                    livre1.afficher();
                    break;
                case "livre2":
                    livre2.ajouter(quantity);
                    livre2.afficher();
                    break;
                case "livre3":
                    livre3.ajouter(quantity);
                    livre3.afficher();
                    break;
            }
            break;
        case "2":
            Console.WriteLine("\nCombien souhaitez-vous retirer ?\n");
            var quantityDel = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            switch (target)
            {
                case "livre1":
                    livre1.retirer(quantityDel);
                    livre1.afficher();
                    break;
                case "livre2":
                    livre2.retirer(quantityDel);
                    livre2.afficher();
                    break;
                case "livre3":
                    livre3.retirer(quantityDel);
                    livre3.afficher();
                    break;
            }
            break;
        case "3":
            switch (target)
            {
                case "livre1":
                    livre1.afficher();
                    break;
                case "livre2":
                    livre2.afficher();
                    break;
                case "livre3":
                    livre3.afficher();
                    break;
            }
            break;
    }
}

namespace TP1;

public class classExo {
    public class Article 
    {
        protected string designation;
        protected int prix;

        public void acheter()
        {
        }
    }

    public class Livre : Article
    {
        protected string ISBN;
        protected int nbPages;
    }

    public class Poche : Livre
    {
        private Boolean categorie;
    }
    public class Broche : Livre
    {
        
    }

    public class Disque : Article
    {
        protected string label;

        public void ecouter()
        {
        }
    }

    public class Video : Article
    {
        protected int duree;

        public void afficher()
        {
        }
    }
}


namespace TP2;

public static class Delegate
{
    private static float discount(float i, float j) => (i * j);
    
    
    delegate float RemiseArticle(float i, float j);

    static RemiseArticle[] discountStrategy = new RemiseArticle[1]{discount};
    
    public static float Remise(float i, float j) => discountStrategy[0](i,j);
    
}
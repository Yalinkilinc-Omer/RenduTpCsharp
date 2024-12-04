namespace TP3;

public static class Delegate
{
    public static double Calcule(double i, double j, int met)
    {
        return met switch
        {
            0 => i + j,
            1 => i * j,
            2 => i - j,
            3 => j != 0 ? i / j : throw new DivideByZeroException(),
            4 => i - (i * j),
            _ => throw new ArgumentOutOfRangeException(nameof(met))
        };
    }
}

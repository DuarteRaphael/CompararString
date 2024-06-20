using CompararString.Entities;

internal static class EntradaPalavraHelpers
{
    public static string LerPalavra1()
    {
        {
            Console.Write("Encrava a palavra 1: ");
            Palavra pa1 = new Palavra();
            pa1.Palavra1 = Console.ReadLine();
        }
    }
}
public class Program
{
    public static void Main(string[] args)
    {
        Player p1 = new Player("Jorge", 100, 3.5f, 3);
        Inimigo i1 = new Inimigo("Matheus", 80, 2.5f, 2);
        Batalha batalha = new Batalha(p1, i1);
        batalha.Iniciar();
    }
}


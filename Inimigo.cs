public class Inimigo
{
    public string Nome { get; set; }
    public int Vida { get; set; }
    public float Velocidade { get; set; }
    public int ItensDeCura { get; set; }

    public Inimigo(string nome, int vida, float velocidade, int itensDeCura)
    {
        Nome = nome;
        Vida = vida;
        Velocidade = velocidade;
        ItensDeCura = itensDeCura;
    }

    public void ReceberDano(int dano)
    {
        Vida -= dano;
        Vida = Math.Max(Vida, 0);
        Console.WriteLine($"{Nome} recebeu {dano} de dano. Vida restante: {Vida}");

        if (Vida <= 0)
        {
            Console.WriteLine($"{Nome} foi derrotado!");
        }
    }
}
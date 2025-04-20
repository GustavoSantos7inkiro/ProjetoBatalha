public class InimigoActions
{
    private Inimigo _inimigo;

    public InimigoActions(Inimigo inimigo)
    {
        _inimigo = inimigo;
    }

    public void Atacar(Player jogador)
    {
        int dano = new Random().Next(8, 16);
        Console.WriteLine($"{_inimigo.Nome} ataca {jogador.Nome} causando {dano} de dano!");
        jogador.ReceberDano(dano);
    }

    public void UsarItemDeCura()
    {
        if (_inimigo.ItensDeCura > 0)
        {
            int cura = new Random().Next(10, 25);
            _inimigo.Vida += cura;
            _inimigo.ItensDeCura--;
            Console.WriteLine($"{_inimigo.Nome} usou um item de cura e restaurou {cura} de vida! Vida atual: {_inimigo.Vida}. Itens de cura restantes: {_inimigo.ItensDeCura}");
        }
        else
        {
            Console.WriteLine($"{_inimigo.Nome} não tem mais itens de cura!");
        }
    }
}
public class JogadorActions
{
    private Player _player;

    public JogadorActions(Player player)
    {
        _player = player;
    }

    public void Atacar(Inimigo inimigo)
    {
        int dano = new Random().Next(10, 21);
        Console.WriteLine($"{_player.Nome} ataca {inimigo.Nome} causando {dano} de dano!");
        inimigo.ReceberDano(dano);
    }

    public void UsarItemDeCura()
    {
        if (_player.ItensDeCura > 0)
        {
            int cura = new Random().Next(15, 31);
            _player.Vida += cura;
            _player.ItensDeCura--;
            Console.WriteLine($"{_player.Nome} usou um item de cura e restaurou {cura} de vida! Vida atual: {_player.Vida}. Itens de cura restantes: {_player.ItensDeCura}");
        }
        else
        {
            Console.WriteLine($"{_player.Nome} não tem mais itens de cura!");
        }
    }
}
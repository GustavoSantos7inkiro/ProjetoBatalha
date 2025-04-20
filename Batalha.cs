public class Batalha
{
    private Player _player;
    private Inimigo _inimigo;
    private JogadorActions _jogadorActions;
    private InimigoActions _inimigoActions;

    public Batalha(Player player, Inimigo inimigo)
    {
        _player = player;
        _inimigo = inimigo;
        _jogadorActions = new JogadorActions(_player);
        _inimigoActions = new InimigoActions(_inimigo);
    }

    public void Iniciar()
    {
        Console.WriteLine("Início da batalha!");
        Console.WriteLine($"{_player.Nome} VS {_inimigo.Nome}");
        Console.WriteLine("----------------------------\n");

        while (_player.Vida > 0 && _inimigo.Vida > 0)
        {
            // Turno do jogador
            Console.WriteLine($"{_player.Nome}'s turno!");
            if (new Random().Next(0, 2) == 0)
            {
                _jogadorActions.Atacar(_inimigo);
            }
            else
            {
                _jogadorActions.UsarItemDeCura();
            }

            if (_inimigo.Vida <= 0) break;

            Thread.Sleep(1000); // Espera 1 segundo

            // Turno do inimigo
            Console.WriteLine($"{_inimigo.Nome}'s turno!");
            if (new Random().Next(0, 2) == 0)
            {
                _inimigoActions.Atacar(_player);
            }
            else
            {
                _inimigoActions.UsarItemDeCura();
            }

            if (_player.Vida <= 0) break;

            Thread.Sleep(1000); // Espera 1 segundo
            Console.WriteLine();
        }

        Console.WriteLine("\nFim da batalha!");
    }
}
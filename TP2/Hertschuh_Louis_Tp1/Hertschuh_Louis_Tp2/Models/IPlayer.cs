using Hertschuh_Louis_Tp1;
using Models;

namespace Models
{
    public interface IPlayer
    {
        Spaceship BattleShip { get; set; }
        string Name { get; }
        string Alias { get; }
    }
}
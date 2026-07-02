namespace PlayersManagerLib;

public class PlayersManager
{
    private readonly IPlayerMapper _playerMapper;

    public PlayersManager(IPlayerMapper playerMapper)
    {
        _playerMapper = playerMapper;
    }

    public List<Player> GetPlayers()
    {
        return _playerMapper.GetPlayers();
    }
}

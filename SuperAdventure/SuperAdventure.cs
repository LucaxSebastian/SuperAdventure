using SuperAdventure.Domain.Players;

namespace SuperAdventure;

public partial class SuperAdventure : Form
{
    private readonly Player _player;

    public SuperAdventure()
    {
        InitializeComponent();

        _player = new Player
        {
            CurrentHitPoints = 10,
            MaximumHitPoints = 10,
            Gold = 20,
            ExperiencePoints = 0,
            Level = 1
        };

        IblHitPoints.Text = _player.CurrentHitPoints.ToString();
        IblGold.Text = _player.Gold.ToString();
        IblExperience.Text = _player.ExperiencePoints.ToString();
        IblLevel.Text = _player.Level.ToString();
    }
}

using SuperAdventure.Domain;

namespace SuperAdventure;

public partial class SuperAdventure : Form
{
    private readonly Player _player;

    public SuperAdventure()
    {
        InitializeComponent();

        var location = new Location("Home", "This is your home"); 

        _player = new Player("Vecna", maximumHitPoints: 10);

        UpdatePlayerStatus();

    }

    private void UpdatePlayerStatus()
    {
        IblHitPoints.Text = _player.CurrentHitPoints.ToString();
        IblGold.Text = _player.Gold.ToString();
        IblExperience.Text = _player.ExperiencePoints.ToString();
        IblLevel.Text = _player.Level.ToString();
    }
}

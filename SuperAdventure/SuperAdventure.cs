namespace SuperAdventure;

public partial class SuperAdventure : Form
{
    public SuperAdventure()
    {
        InitializeComponent();
    }

    private void SuperAdventure_Load(object sender, EventArgs e)
    {

    }

    private void btnTest_Click(object sender, EventArgs e)
    {
        IblGold.Text = "123";
    }
}

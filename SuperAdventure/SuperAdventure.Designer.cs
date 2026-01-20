namespace SuperAdventure;

partial class SuperAdventure
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        IblHitPoints = new Label();
        IblGold = new Label();
        IblExperience = new Label();
        IblLevel = new Label();
        btnTest = new Button();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(18, 20);
        label1.Name = "label1";
        label1.Size = new Size(62, 15);
        label1.TabIndex = 0;
        label1.Text = "Hit Points:";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(18, 46);
        label2.Name = "label2";
        label2.Size = new Size(35, 15);
        label2.TabIndex = 1;
        label2.Text = "Gold:";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Location = new Point(18, 74);
        label3.Name = "label3";
        label3.Size = new Size(63, 15);
        label3.TabIndex = 2;
        label3.Text = "Experience";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(18, 100);
        label4.Name = "label4";
        label4.Size = new Size(37, 15);
        label4.TabIndex = 3;
        label4.Text = "Level:";
        // 
        // IblHitPoints
        // 
        IblHitPoints.AutoSize = true;
        IblHitPoints.Location = new Point(110, 19);
        IblHitPoints.Name = "IblHitPoints";
        IblHitPoints.Size = new Size(0, 15);
        IblHitPoints.TabIndex = 4;
        // 
        // IblGold
        // 
        IblGold.AutoSize = true;
        IblGold.Location = new Point(110, 45);
        IblGold.Name = "IblGold";
        IblGold.Size = new Size(0, 15);
        IblGold.TabIndex = 5;
        // 
        // IblExperience
        // 
        IblExperience.AutoSize = true;
        IblExperience.Location = new Point(110, 73);
        IblExperience.Name = "IblExperience";
        IblExperience.Size = new Size(0, 15);
        IblExperience.TabIndex = 6;
        // 
        // IblLevel
        // 
        IblLevel.AutoSize = true;
        IblLevel.Location = new Point(110, 99);
        IblLevel.Name = "IblLevel";
        IblLevel.Size = new Size(0, 15);
        IblLevel.TabIndex = 7;
        // 
        // btnTest
        // 
        btnTest.Location = new Point(262, 278);
        btnTest.Name = "btnTest";
        btnTest.Size = new Size(75, 23);
        btnTest.TabIndex = 8;
        btnTest.Text = "Test";
        btnTest.UseVisualStyleBackColor = true;
        btnTest.Click += btnTest_Click;
        // 
        // SuperAdventure
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(719, 651);
        Controls.Add(btnTest);
        Controls.Add(IblLevel);
        Controls.Add(IblExperience);
        Controls.Add(IblGold);
        Controls.Add(IblHitPoints);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Name = "SuperAdventure";
        Text = "My Game";
        Load += SuperAdventure_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label IblHitPoints;
    private Label IblGold;
    private Label IblExperience;
    private Label IblLevel;
    private Button btnTest;
}

namespace Task5;

public partial class Form1 : Form
{
    private EventHandler SuperMegaButtonCallbacks = new(delegate
    {
        MessageBox.Show("Я СУПЕР-МЕГА-КНОПКА!!!!!!!!!!!!!!!!!!!!");
    });

    //
    // For `OnOpacityButtonClicked`
    //
    private double[] OpacityValues = [1, 0.75, 0.5, 0.25];
    private int ActiveOpacityValue = 0;

    //
    // For `OnColorButtonClicked`
    //
    private Color[] BackgroundColors = [Color.Black, Color.Yellow, Color.White, Color.Red];
    private int ActiveBackgroundColor = 0;


    public Form1()
    {
        AllowTransparency = true;
        InitializeComponent();
    }


    private void OnSuperMegaButtonClicked(object? sender, EventArgs e)
        => SuperMegaButtonCallbacks(sender, e);

    private void OnOpacityButtonClicked(object? sender, EventArgs e)
        => Opacity = OpacityValues[unchecked(ActiveOpacityValue++) % OpacityValues.Length];

    private void OnColorButtonClicked(object? sender, EventArgs e)
        => BackColor = BackgroundColors[unchecked(ActiveBackgroundColor++) % BackgroundColors.Length];

    private void OnHelloWorldButtonClicked(object? sender, EventArgs e)
        => MessageBox.Show("Hello, World!");

    private void OnOpacityCheckboxChanged(object? sender, EventArgs e)
        => RemoveOrAdd(OnOpacityButtonClicked, opacity_checkbox.Checked);

    private void OnColorCheckboxChanged(object? sender, EventArgs e)
        => RemoveOrAdd(OnColorButtonClicked, color_checkbox.Checked);

    private void OnHelloWorldCheckboxChanged(object? sender, EventArgs e)
        => RemoveOrAdd(OnHelloWorldButtonClicked, hello_world_checkbox.Checked);


    private void RemoveOrAdd(EventHandler e, bool check)
    {
        //
        // The only `if-else` that I can't get rid off :(
        //
        if (check) SuperMegaButtonCallbacks += e;
        else SuperMegaButtonCallbacks -= e;
    }
}

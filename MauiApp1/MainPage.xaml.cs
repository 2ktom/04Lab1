namespace MauiApp1;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
    }

    public void onVerticalStart(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Start;
    }

    public void onVerticalCenter(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.Center;
    }
    public void onVerticalEnd(object sender, EventArgs e)
    {
        target.VerticalOptions = LayoutOptions.End;
    }
    public void onHorizontalStart(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Start;
    }
    public void onHorizontalCenter(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.Center;
    }
    public void onHorizontalEnd(object sender, EventArgs e)
    {
        target.HorizontalOptions = LayoutOptions.End;
    }
}


namespace MauiProject;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();
		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("Mgo+DSMBMAY9C3t2VVhiQlFaclxJVHxOYVF2R2FJeVRzdV9HaUwgOX1dQl9hSXZTfkVrW3tacHdWRWk=");
	}

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new MainPage());
    }
}

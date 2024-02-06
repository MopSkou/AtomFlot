namespace AtomFlot;

public partial class BerthingPage : ContentPage
{
	public BerthingPage()
	{
		InitializeComponent();
	}
    private void SaveStudent(object sender, EventArgs e)
    {
        var friend = (Berthing)BindingContext;
        if (!String.IsNullOrEmpty(friend.NameKor))
        {
            App.Database.SaveItem(friend);
        }
        this.Navigation.PopAsync();
    }
    private void DeleteStudent(object sender, EventArgs e)
    {
        var friend = (Berthing)BindingContext;
        App.Database.DeleteItem(friend.ID);
        this.Navigation.PopAsync();
    }
    private void Cancel(object sender, EventArgs e)
    {
        this.Navigation.PopAsync();
    }

    private void GroupPicker_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
}
namespace AtomFlot;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    protected override void OnAppearing()
    {
        AtomFlotList.ItemsSource = App.Database.GetItems();
        base.OnAppearing();
    }
    // обработка нажатия элемента в списке
    private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
    {
        Berthing selectedStudent = (Berthing)e.SelectedItem;
        BerthingPage studentPage = new BerthingPage();
        studentPage.BindingContext = selectedStudent;
        await Navigation.PushAsync(studentPage);
    }
    // обработка нажатия кнопки добавления
    private async void CreateStudent(object sender, EventArgs e)
    {
        Berthing student = new Berthing();
        BerthingPage studentPage = new BerthingPage();
        studentPage.BindingContext = student;
        await Navigation.PushAsync(studentPage);
    }
}


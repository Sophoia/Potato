namespace Potato
{
    public partial class MainPage : ContentPage
    {
       List<string> list = new List<string>() {"Appie", "Mango", "Orange", "Banana", "Lemon" };

        public MainPage()
        {
            InitializeComponent();
            FruitListView.ItemsSource = list;
        }
        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new Page2(txtName.Text));
        //}

        private void FruitListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            DisplayAlert("Selected", e.SelectedItem.ToString(), "OK");
            ((ListView)sender).SelectedItem = null;
        }
    }
}
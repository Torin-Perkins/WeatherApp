namespace WeatherApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
            entry.Text = "Portland";
        }

        public void CityButton_Clicked(object sender, EventArgs e)
        {
            string city = entry.Text;
            cityTxt.Text = city.ToString();
        }
    }

}

namespace PhotoGallery
{
    public partial class MainPage : ContentPage
    {
        int image = 1;
        Button button;

        public MainPage()
        {
            InitializeComponent();
            UpButton.IsEnabled = false;
            button = new Button
            {
                Text = "Click to Rotate Text!",
                VerticalOptions = LayoutOptions.Center,
                HorizontalOptions = LayoutOptions.Center,
                
            };
            button.Clicked += NewPage_Click;
            MainLayout.Add(button);
        }
        private void NewPage_Click(object sender, EventArgs e)
        {
            button.Text = "YOU MADE IT";
        }
        private void Prev_Image_Clicked(object sender, EventArgs e)
        {
            if (image > 1)
            {
                image--;
                string str = "nepal" + image + ".jpg";
                MyImage.Source = str;
                DownButton.IsEnabled = true;
            }
            if (image == 1) 
                UpButton.IsEnabled = false;
        }
        private void Next_Image_Clicked(object sender, EventArgs e)
        {
            new NavigationPage(new NewPage1());
            if (image < 5)
            {
                image++;
                string str = "nepal" + image + ".jpg";
                MyImage.Source = str;
                UpButton.IsEnabled = true;
            }
            if(image == 5)
                DownButton.IsEnabled = false;
        }
    }

}

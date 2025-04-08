namespace gory
{
    public partial class MainPage : ContentPage
    {
        int label = 0;

        public MainPage()
        {
            InitializeComponent();
        }
        private void OnSaveClicked(object sender, EventArgs e)
        {
            label=+0;
            if (label == 1)
                label2.Text = $"{label} polubienie";
            else
                label2.Text = $"{label} polubień";

            SemanticScreenReader.Announce(label2.Text);
        }
     
        private void OnDelateClicked(object sender, EventArgs e)
        {

            label--;
            if (label <= 1)
                label2.Text = $"{label} polubienie";
            else
                label2.Text = $"{label} polubień";

            SemanticScreenReader.Announce(label2.Text);
        }
        private void OnLikeClicked(object sender, EventArgs e)
        {
            label++;
            if (label == 1)
                label2.Text = $"{label} polubienie";
            else
                label2.Text = $"{label} polubień";

            SemanticScreenReader.Announce(label2.Text);
        }
    }

}
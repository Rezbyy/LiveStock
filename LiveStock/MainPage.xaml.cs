namespace LiveStock
{
    public partial class MainPage : ContentPage
    {
        private readonly DatabaseService _databaseService;

        public MainPage(DatabaseService databaseService)
        {
            InitializeComponent();
            _databaseService = databaseService;

            LoadData();
        }
        private void LoadData()
        {
            // Get the combined list of cows and sheep
            var animals = _databaseService.ReadAnimals();

            // Display or bind to UI elements, e.g., binding to a CollectionView
            AnimalsCollectionView.ItemsSource = animals;
        }


    }


}

using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DropDownButtonExamples;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();
		PopulateListView();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Button button = (Button)sender;
		button.ContextMenu.IsEnabled = true;
		button.ContextMenu.PlacementTarget = button;
		button.ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
		button.ContextMenu.IsOpen = true;
	}

	private void PopulateListView()
	{
		var items = new List<MyModel>
		{
			new MyModel { Property1 = "A1", Property2 = "B1", Property3 = "C1" },
			new MyModel { Property1 = "A2", Property2 = "B2", Property3 = "C2" },
			new MyModel { Property1 = "A3", Property2 = "B3", Property3 = "C3" }
		};

		myListView.ItemsSource = items;
	}
}
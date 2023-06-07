namespace ModalBugRepro.Views;

public partial class EditPage : ContentPage
{
	public EditPage(ListDetailDetailViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}

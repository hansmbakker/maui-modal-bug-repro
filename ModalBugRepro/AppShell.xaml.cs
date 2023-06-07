namespace ModalBugRepro;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("listdetail/details", typeof(ListDetailDetailPage));
        Routing.RegisterRoute("listdetail/edit", typeof(EditPage));
    }
}

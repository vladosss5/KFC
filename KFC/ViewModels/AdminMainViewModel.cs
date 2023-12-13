using System.Windows.Input;
using KFC.Models;
using ReactiveUI;

namespace KFC.ViewModels;

public class AdminMainViewModel : ViewModelBase
{
    private PageViewModelBase _CurrentPage;
    
    public PageViewModelBase CurrentPage
    {
        get { return _CurrentPage; }
        private set { this.RaiseAndSetIfChanged(ref _CurrentPage, value); }
    }
    
    private readonly PageViewModelBase[] Pages = 
    { 
        new MenuPageViewModel(),
        new EmployeesPageViewModel(),
        new ProfilePageViewModel(),
        new OrdersPageViewModel()
    };
    
    public ICommand OpenMenuDishPage { get; }
    public ICommand OpenEmployeesPage { get; }
    public ICommand OpenProfilePage { get; }
    public ICommand OpenOrdersPage { get; }

    public AdminMainViewModel()
    {
        _CurrentPage = Pages[0];
        
        var canOpenMenuDish = this.WhenAnyValue(x => x.CurrentPage.OpenMenuDishesPage);
        OpenMenuDishPage = ReactiveCommand.Create(OpenMenuDishPageImpl, canOpenMenuDish);
        
        var canOpenEmployeesPage = this.WhenAnyValue(x => x.CurrentPage.OpenEmployeesPage);
        OpenEmployeesPage = ReactiveCommand.Create(OpenEmployeespageImpl, canOpenEmployeesPage);
        
        var canOpenProfilePage = this.WhenAnyValue(x => x.CurrentPage.OpenProfilePage);
        OpenProfilePage = ReactiveCommand.Create(OpenProfilePageImpl, canOpenProfilePage);

        var canOpenOrdersPage = this.WhenAnyValue(x => x.CurrentPage.OpenOrdersPage);
        OpenOrdersPage = ReactiveCommand.Create(OpenOrdersPageImpl, canOpenOrdersPage);
    }

    private void OpenOrdersPageImpl()
    {
        CurrentPage = Pages[3];
    }

    private void OpenProfilePageImpl()
    {
        CurrentPage = Pages[2];
    }

    private void OpenEmployeespageImpl()
    {
        CurrentPage = Pages[1];
    }

    private void OpenMenuDishPageImpl()
    {
        CurrentPage = Pages[0];
    }
}
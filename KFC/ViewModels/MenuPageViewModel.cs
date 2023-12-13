using System;
using ReactiveUI;

namespace KFC.ViewModels;

public class MenuPageViewModel : PageViewModelBase
{
    private bool _OpenMenuDishesPage;
    
    public override bool OpenMenuDishesPage
    {
        get => _OpenMenuDishesPage;
        protected set => this.RaiseAndSetIfChanged(ref _OpenMenuDishesPage, value);
    }
    
    public override bool OpenEmployeesPage 
    { 
        get => true;
        protected set => throw new NotSupportedException(); 
    }
    
    public override bool OpenProfilePage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }

    public override bool OpenOrdersPage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }
    public MenuPageViewModel()
    {
        OpenMenuDishesPage = false;
    }
}
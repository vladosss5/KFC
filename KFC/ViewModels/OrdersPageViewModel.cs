using System;
using ReactiveUI;

namespace KFC.ViewModels;

public class OrdersPageViewModel : PageViewModelBase
{
    private bool _openOrderPage;
    
    public override bool OpenOrdersPage
    {
        get => _openOrderPage;
        protected set => this.RaiseAndSetIfChanged(ref _openOrderPage, value);
    }
    
    public override bool OpenProfilePage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }

    public override bool OpenMenuDishesPage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }

    public override bool OpenEmployeesPage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }
    

    public OrdersPageViewModel()
    {
        OpenOrdersPage = false;
    }
}
using System;
using ReactiveUI;

namespace KFC.ViewModels;

public class NewOrderPageViewModel : PageViewModelBase
{
    private bool _OpenNewOrderPage;
    
    public override bool OpenNewOrderWaiterPage
    {
        get => _OpenNewOrderPage;
        protected set => this.RaiseAndSetIfChanged(ref _OpenNewOrderPage, value);
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
    
    public override bool OpenOrdersCookPage
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
    
    public override bool OpenOrdersWaiterPage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }



    public NewOrderPageViewModel()
    {
        OpenNewOrderWaiterPage = false;
    }
}
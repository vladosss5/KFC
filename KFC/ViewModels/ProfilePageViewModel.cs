using System;
using ReactiveUI;

namespace KFC.ViewModels;

public class ProfilePageViewModel : PageViewModelBase
{
    private bool _OpenProfilePage;
    
    public override bool OpenProfilePage
    {
        get => _OpenProfilePage;
        protected set => this.RaiseAndSetIfChanged(ref _OpenProfilePage, value);
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
    
    
    public override bool OpenOrdersPage
    {
        get => true;
        protected set => throw new NotSupportedException();
    }
    
    public ProfilePageViewModel()
    {
        OpenProfilePage = false;
    }
}
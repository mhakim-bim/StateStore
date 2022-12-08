using Microsoft.Extensions.DependencyInjection;

namespace StateStore.ViewModels;

public class ViewModelLocator
{
    public FirstChildViewModel? FirstChildViewModel => App.Services.GetService<FirstChildViewModel>();
    public SecondChildViewModel? SecondChildViewModel => App.Services.GetService<SecondChildViewModel>();
}
using ReactiveUI;
using ReactiveUI.Fody.Helpers;
using StateStore.Models;
using StateStore.Store;

namespace StateStore.ViewModels;

public class FirstChildViewModel : ReactiveObject
{
    private readonly IPersonStore _personStore;

    [Reactive]
    public Person Person { get; set; }

    public FirstChildViewModel(IPersonStore personStore)
    {
        _personStore = personStore;
        Person = _personStore.Person;
        _personStore.PersonChanged += PersonStoreOnPersonChanged;
    }

    private void PersonStoreOnPersonChanged(object? sender, Person person)
    {
        Person = person;
    }

}
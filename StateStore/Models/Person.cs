using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace StateStore.Models;

public class Person : ReactiveObject
{
    [Reactive]
    public string FirstName { get; set; }
    [Reactive]
    public string LastName { get; set; }
}
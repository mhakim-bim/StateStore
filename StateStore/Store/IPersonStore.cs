using System;
using StateStore.Models;

namespace StateStore.Store;

public interface IPersonStore
{
    Person Person { get; }

    event EventHandler<Person> PersonChanged;

    Person UpdatePerson(Person person);
}


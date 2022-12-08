using System;
using StateStore.Models;

namespace StateStore.Store;

public class PersonStore : IPersonStore
{
    public Person Person { get; private set; }
    
    public event EventHandler<Person>? PersonChanged;

    public PersonStore()
    {
        Person = new Person();
    }

    public Person UpdatePerson(Person person)
    {
        Person = person;
        PersonChanged?.Invoke(this,Person);
        return Person;
    }


}
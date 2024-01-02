using PairProgramming.Data;
using PairProgramming.Models;

namespace PairProgramming.Services;

public class PersonService : IPersonService
{
    private readonly PersonContext _context;

    public PersonService(PersonContext context)
    {
        _context = context;
    }

    public Person Create(string firstName, string lastName, string email, DateTime birthDay)
    {
        return new Person
        {
            FirstName = firstName,
            LastName = lastName,
            Email = email,
            Birthday = birthDay
        };
    }

    public IEnumerable<Person> EverySecond()
    {
        var everySecondLine = new List<Person>();
        bool skippedLast = false;
        foreach (var person in _context.Person)
        {
            if (skippedLast)
            {
                everySecondLine.Add(person);
                skippedLast = false;
            }
            else
            {
                skippedLast = true;
            }
        }

        return everySecondLine;
    }
}
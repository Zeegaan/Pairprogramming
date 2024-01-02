using PairProgramming.Models;

namespace PairProgramming.Services;

public interface IPersonService
{
    Person Create(string firstName, string lastName, string email, DateTime birthDay);

    IEnumerable<Person> EverySecond();
}
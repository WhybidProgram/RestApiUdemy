using WebApiRest.Controllers;
using WebApiRest.Model;

namespace WebApiRest.Services;

public interface IPersonService
{
    Person Create(Person person);
    Person FindByID(long id);
    List<Person> FindAll();
    Person Update(Person person);
    public void Delete(long id);
    object? Create(PersonController person);
}


namespace praktika;

public class Person
{
    private string _name;
    public int Id
    {
        // getter - получаеь значение свойства
        get;
        // setter - не получает
        set;
    }
    public Person(int id, string name)
    {
        Id = id;
        _name = name;
    }

    //method
    public string GetName()
    {
        return _name;
    }
}

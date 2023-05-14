


// Comparison - Sorting

using System.Security.Cryptography.X509Certificates;

string a = "ali";
string b = "veli";

 
var result = string.Compare(a, b);

// result == 1  -> a is greater than b
// result == -1 -> b is greater than a
// result == 0  -> a and b are equal


var names = new List<Employee>();

names.Add(new Employee(1, "Salih"));
names.Add(new Employee(5, "Fatma"));
names.Add(new Employee(3, "Veli"));
names.Add(new Employee(4, "Ayşe"));
names.Add(new Employee(2, "Ali"));

names.Sort(new IdBaseComparer());

names.OrderBy(i => i.Id);

Print(names.OrderBy(i => i.Id));


Console.ReadLine();


void Print(IEnumerable<Employee> names)
{
    foreach (var name in names)
    {
        Console.WriteLine(name);
    }
}


class NameBaseComparer: IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        return x.FullName.CompareTo(y.FullName);
    }
}

class IdBaseComparer: IComparer<Employee>
{
    public int Compare(Employee? x, Employee? y)
    {
        string x1 = x.Id.ToString() + x.FullName;
        string y1 = y.Id.ToString() + y.FullName;
        return string.Compare(x1, y1);
        return x.Id.CompareTo(y.Id);
    }
}


class BaseEmployee
{
    public int Id { get; set; }
    public string FullName { get; set; }
}

class Accountant: BaseEmployee
{

}

class Employee: BaseEmployee
{
    public Employee(int id, string fullName)
    {
        Id = id;
        FullName = fullName ?? throw new ArgumentNullException(nameof(fullName));
    }

    public override string ToString()
    {
        return $"{Id} - {FullName}";
    }

    
}



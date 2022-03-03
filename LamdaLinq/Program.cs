// See https://aka.ms/new-console-template for more information
using LamdaLinq;

Console.WriteLine("Hello, World!");

List<DataModel> dm = new List<DataModel>()
{
    new DataModel{ID = 1, Name ="raju"},
    new DataModel{ID = 2, Name ="kanya"},
    new DataModel{ID = 3, Name ="kumari"},
    new DataModel{ID = 4, Name ="lela"},
    new DataModel{ID = 5, Name ="majnu"},
    new DataModel{ID = 6, Name ="ram"},
    new DataModel{ID = 7, Name ="pyari"},
};

DataModel emp = dm.Find(x => x.ID == 1);
Console.WriteLine(emp.Name);

int? count = dm.Count(x => x.Name.StartsWith("s"));
Console.WriteLine(count);
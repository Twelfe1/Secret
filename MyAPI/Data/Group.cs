public class Group
{
    public int Id { get;}
    public string Name { get; }
    public List<string> Members { get; }
    public Group(int id, string name){
        Id = id;
        Name = name;
        Members = new List<string>();
    }
    public Group(int id, string name, List<string> members){
        Id = id;
        Name = name;
        Members = members;
    }
}
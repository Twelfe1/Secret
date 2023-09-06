
public static class SingleData
{
    private const int id = 26353;
    private const string name = "ИД-301кис";
    private static Group group = new Group(id, name);
    public static Group Instance {
        get {
            return group;
        }
    }
}
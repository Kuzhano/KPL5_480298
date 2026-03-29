class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();

        string nama = "Wawan Saputra";

        halo.SapaUser<string>(nama);
    }
}


public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}
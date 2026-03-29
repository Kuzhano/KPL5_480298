class Program
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        string nama = "Wawan Saputra";
        halo.SapaUser<string>(nama);

        DataGeneric<string> dataNim = new DataGeneric<string>("103022400098");
        dataNim.PrintData();
    }
}

public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}

public class DataGeneric<T>
{
    private T data;

    public DataGeneric(T data)
    {
        this.data = data;
    }

    public void PrintData()
    {
        Console.WriteLine($"Data yang tersimpan adalah: {this.data}");
    }
}
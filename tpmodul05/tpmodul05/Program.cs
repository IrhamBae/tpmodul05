using System;

class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

<<<<<<< HEAD
=======
public class DataGeneric<T>
{
    public T Data { get; set; }

    public DataGeneric(T data)
    {
        Data = data;
    }

    public void PrintData()
    {
        Console.WriteLine("Data yang tersimpan adalah: " + Data);
    }
}

>>>>>>> generic-class
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan nama pengguna:");
        string namaPengguna = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(namaPengguna);
<<<<<<< HEAD
=======
        Console.WriteLine();

        Console.WriteLine("Masukkan data:");
        string inputData = Console.ReadLine();

        DataGeneric<string> dataGeneric = new DataGeneric<string>(inputData);
        dataGeneric.PrintData();
>>>>>>> generic-class
    }
}

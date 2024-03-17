using System;

class HaloGeneric
{
    public void SapaUser<T>(T nama)
    {
        Console.WriteLine("Halo user " + nama);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Masukkan nama pengguna:");
        string namaPengguna = Console.ReadLine();

        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser(namaPengguna);
    }
}

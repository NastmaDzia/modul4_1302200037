Console.WriteLine("Hasil : " + Penjumlahan<int>.JumlahTigaAngka(13, 02, 20));

public class Penjumlahan<T>
{
    private T data;

    public Penjumlahan(T data)
    {

    }

    public static int JumlahTigaAngka(T a1, T a2, T a3)
    {
        int A1 = Convert.ToInt32(a1);
        int A2 = Convert.ToInt32(a2);
        int A3 = Convert.ToInt32(a3);

        int hasil = A1 + A2 + A3;

        return hasil;
    }
}
using System.IO.Compression;

namespace Zip_and_Extract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZipFile.CreateFromDirectory(@"..\..\..\copyMe.png", @"..\..\..\archive.zip");
            ZipFile.ExtractToDirectory(@"..\..\..\archive.zip", Environment.CurrentDirectory);
        }
    }
}
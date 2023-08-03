namespace Copy_Binary_File
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using(var sourceStream = new FileStream(@"..\..\..\copyMe.png", FileMode.Open, FileAccess.Read))
            {
                using (var destinationStream = new FileStream(@"..\..\..\newCopyMe.png", FileMode.Create, FileAccess.Write))
                {
                    sourceStream.CopyTo(destinationStream);
                }
            }
        }
    }
}
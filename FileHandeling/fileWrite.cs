public class CreateFile
{
    public static void WriteFile(string filename)
    {
        using(StreamWriter streamWriter = new StreamWriter($"{filename}.txt",true))
        {

        Console.WriteLine("Enter text");

        string input = Console.ReadLine();

        streamWriter.WriteLine(input);
        }
    }

    public static void ReadFile(string filename)
    {
        using(StreamReader streamReader = new StreamReader($"{filename}.txt"))
        {

        streamReader.BaseStream.Seek(0,SeekOrigin.Begin);

        string data = streamReader.ReadLine();

        while(data!=null)
        {
            Console.WriteLine(data);
            data = streamReader.ReadLine();
        }

        }
    }

   

}
// See https://aka.ms/new-console-template for more information

string path = @"C:\temp\nomes.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<string> list = new List<string>();

        while (!sr.EndOfStream)
        {
            list.Add(sr.ReadLine());
        }
        list.Sort();
        foreach (string str in list)
        {
            Console.WriteLine(str);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

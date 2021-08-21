// See https://aka.ms/new-console-template for more information

/* Agora é pra ler um arquivo com funcionários e salários.
 */

using Curso202.Entities;

string path = @"C:\temp\nomes.txt";

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        List<Employee> list = new List<Employee>();

        while (!sr.EndOfStream)
        { 
            list.Add(new Employee(sr.ReadLine()));
        }
        list.Sort();
        foreach (Employee emp in list)
        {
            Console.WriteLine(emp);
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

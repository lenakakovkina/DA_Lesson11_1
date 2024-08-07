using System.Threading.Tasks;

List<string> notDoneTask = new List<string>();
List<string> doneTask = new List<string>();
string input = "";
var filename = "C:/TESTING/testOlena.txt";
while (input != "stop")
{

    Console.WriteLine("Hi it is To do list. Input your task, please");
    input = Console.ReadLine();
    if (input != "stop")
    {
        if (notDoneTask.Contains(input))
        {
            doneTask.Add(input);
            notDoneTask.Remove(input);
        }
        else
        {
            notDoneTask.Add(input);
        }
    }
    Console.WriteLine("\nIt is active to-do list:");
    foreach (string task in notDoneTask)
    {
        Console.WriteLine(task);
        
    }

    Console.WriteLine("\nIt is done list:");
    foreach (string task in doneTask)
    {
        Console.WriteLine(task);
    }

}
// Writing the active to-do list to the file
using (var streamWriter = new StreamWriter(filename)) { }//to wipe file
    using (var streamWriter = new StreamWriter(filename, true))
{
    streamWriter.WriteLine("Active To-Do List:");
    foreach (string task in notDoneTask)
    {
        streamWriter.WriteLine(task);
    }
}
using (var streamWriter = new StreamWriter(filename, true))
{
    streamWriter.WriteLine("Done To-Do List:");
    foreach (string task in doneTask)
    {
        streamWriter.WriteLine(task);
    }
}
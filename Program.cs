using System.Threading.Tasks;
List<string> notDoneTask = new List<string>();
List<string> doneTask = new List<string>();
string input = "";
var filename = "C:/TESTING/testOlena.txt";
if (File.Exists(filename))
{
    using (var streamReader = new StreamReader(filename))
    {
        string line;
        bool isDoneList = false;
        while ((line = streamReader.ReadLine()) != null)
        {
            if (line == "Active To-Do List:")
            {
                isDoneList = false;
            }
            else if (line == "Done To-Do List:")
            {
                isDoneList = true;
            }
            else
            {
                if (isDoneList)
                {
                    doneTask.Add(line);
                }
                else
                {
                    notDoneTask.Add(line);
                }
            }
        }
    }
}


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
//Writing to-do list to the file
using (var streamWriter = new StreamWriter(filename))
{ }
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
// See https://aka.ms/new-console-template for more information
DateTime today = DateTime.Today;
string response;


do
{
    Console.WriteLine($"Which date? (or 'exit') \n");
    response = Console.ReadLine();

    if (response == "exit")
    {
        break;
    }

    DateTime parsedDate;
    TimeSpan daysBetween;

    if (DateTime.TryParse(response, out parsedDate))
    {

        if (parsedDate == today)
        {
            Console.WriteLine($"That's today! {parsedDate:d}.");

        }
        else if (parsedDate < today)
        {
            daysBetween = today - parsedDate;
            Console.WriteLine($"That day went by {daysBetween.Days} ago!");
        }
        else
        {
            daysBetween = parsedDate - today;
            Console.WriteLine($"That will be in {daysBetween.Days} days!");
        }
    }
    else
    {
        Console.WriteLine($"That doesn't seem to be a valid date!");


    }
} while (response != "exit");
using System;

class Program
{
    static void Main(string[] args)


    {
        PromptGenerator myPrompt = new PromptGenerator();

        Journal myJournal = new Journal();

        Console.WriteLine("Hello, Wellcome to your Journal!");
        int _options = 0;

        do
        {
            Console.WriteLine("\n" +
                              "\n.1-To write in Jounal" +
                               "\n.2-Display your Journal" +
                               "\n.3-load" +
                               "\n.4-Save" +
                               "\n.5-Quit");
            _options = Convert.ToInt32(Console.ReadLine());

            switch (_options)

            {
                case 1:
                    Entry myEntry = new Entry();
                    string promptC = (myPrompt.GetRandomPrompt());
                    Console.WriteLine(promptC);

                    myEntry._entryText = Console.ReadLine();
                    myEntry._promptText = promptC;
                    myJournal.AddEntry(myEntry);

                    break;

                case 2:

                    myJournal.DisplayAll();
                    break;

                case 3:
                    myJournal.LoadFromFile();
                    break;
                case 4:
                    myJournal.saveEntriesToFile();
                    Console.WriteLine("saved");
                    break;
                default:
                    Console.WriteLine("Not Valid Option");
                    break;
            }
            Console.ReadKey();

        } while (_options != 5);
        Console.WriteLine("Thanks, see you morrow");
    }

}
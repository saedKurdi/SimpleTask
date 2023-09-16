using DelegateTask.classes;

namespace DelegateTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
          while (true)
            {
                Console.Clear();
                Console.Write("Enter Key (basic,pro or expert) : ");
                string ? key = Console.ReadLine();
                try
                {
                    if (key == "basic" || key == "Basic" || key == "BASIC")
                    {
                        DocumentProgram documentProgram = new DocumentProgram();
                        documentProgram.OpenDocument();
                        documentProgram.EditDocument();
                        documentProgram.SaveDocument();
                    }

                    else if (key == "pro" || key == "Pro" || key == "PRO")
                    {
                        DocumentProgram proDocumentProgram = new ProDocumentProgram();
                        proDocumentProgram.OpenDocument();
                        proDocumentProgram.EditDocument();
                        proDocumentProgram.SaveDocument();
                    }

                    else if (key == "expert" || key == "Expert" || key == "EXPERT")
                    {
                        DocumentProgram expertDocumentProgram = new ExpertDocument();
                        expertDocumentProgram.OpenDocument();
                        expertDocumentProgram.EditDocument();
                        expertDocumentProgram.SaveDocument();
                    }

                    else
                    {
                        throw new Exception("Enter Valid Key !");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                }
                Console.WriteLine("Continue ? Press Any Key (To Exit Press ESCAPE Button )");
                ConsoleKey Key = Console.ReadKey().Key;
                if(Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Console.WriteLine("EExited ! \n\n\n\n\n");
                    break;
                }
                continue;
            }
        }
    }
}
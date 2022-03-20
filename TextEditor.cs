using System;
using System.IO;

namespace TextEditor
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu(){
            Console.Clear();

            Console.WriteLine("What would you like to do?");

            Console.WriteLine("");

            Console.WriteLine("1 - Open file.");
            Console.WriteLine("2 - Create new file.");         
            Console.WriteLine("0 - Exit");
            Console.WriteLine("");

            short option = short.Parse(Console.ReadLine());

            switch(option){
                case 0: System.Environment.Exit(0);break;
                case 1: Open();break;
                case 2: CreatePart1();break;

                default: Menu();break;

            }

            static void Open(){
                Console.Clear();

                Console.WriteLine("Specify file's path: ");
                //C:\test\text.txt

                var path =  Console.ReadLine();
                
                using(var file = new StreamReader(path)){

                string text = file.ReadToEnd();
                Console.WriteLine(text);

                }

                Console.WriteLine("");
                Console.ReadKey();
                Menu();
            
            }


             static void CreatePart1(){

                Console.Clear();

                Console.WriteLine("Type the text below: ");
                Console.WriteLine("(Esc) to leave.");

                Console.WriteLine("----------------------");

                var text = "";

                do {

                    text = text + Console.ReadLine(); // text += Console.ReadLine();
                    
                    text += Environment.NewLine;

                } while(Console.ReadKey().Key != ConsoleKey.Escape);

                CreatePart2(text);
    
            }       

            static void CreatePart2(string text){

                Console.Clear();

                Console.WriteLine("SSpecify the path to save the file: ");
                //C:\test\text.txt

                var path =  Console.ReadLine();

                using(var file = new StreamWriter(path)){ // using System.IO; ^^

                    file.Write(text);

                }

                Console.WriteLine($"File {path} Saved!");
                Console.ReadKey();
                Menu();

            }

        }

    }
}

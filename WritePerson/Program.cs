/**************************************************************************************************************************
 *  
 *  Übungsnr.:		24/1of2
 *	Programmname:	WritePerson
 *	Autor:			Christian SCHADLER
 *	Klasse:			4ABIF
 *	Datum:			16.03.2020
 *	
 *	-----------------------------------------------------------------------------------------------------------------------
 *	Verbesserungsmoeglichkeit/en:
 *  -----------------------------------------------------------------------------------------------------------------------
 *  Kurzbeschreibung:
 *	
 *	Das Programm WritePerson ist Teil der Aufgabe SimpleFileIO
 *  Liest die Daten einer Person(Name,Alter) von der Konsole ein und speichert diese in die Datei person.csv,
 *  die sich in dem der Solution uebergeordneten Ordner befindet.
 *  Danach koennen mehrere Hobbies, mittels <Enter> getrennt, eingegeben werden, welche dann zur Person in person.csv 
 *  gespeichert werden.
 *  
 **************************************************************************************************************************
 */

using System;
using System.IO;
using System.Text;


namespace WritePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int age;
            string hobby;

            Console.WriteLine("Person erfassen");
            Console.WriteLine("===============");
            
            //Stammdaten eingeben
            do
            {
                Console.Write("Bitte Namen eingeben: ");
                name = Console.ReadLine();
            }while(name=="");

            do
            {
                Console.Write("Bitte Alter eingeben: ");
                age = Convert.ToInt32(Console.ReadLine());
            } while(age < 0 || age > 120);

            //Daten speichern
            name = $"Sie heissen {name} und sind {age} Jahre alt!\nIhre Hobbies sind:\n";
            File.WriteAllText("..//..//..//..//..//person.csv", name);

            //Hobbies eingeben und speichern
            do
            {
                Console.Write("Bitte Hobby eingeben (leerlassen zum Beenden): ");
                hobby = Console.ReadLine();
                if(hobby != "")
                {
                    File.AppendAllText("..//..//..//..//..//person.csv", $"{hobby}\n");
                }
            } while (hobby != "");


        }
    }
}

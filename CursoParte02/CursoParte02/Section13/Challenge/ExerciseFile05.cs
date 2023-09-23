﻿using System.Globalization;

namespace CursoParte02.Section13.Challenge;

internal class ExerciseFile05
{
    public static void Executar()
    {
        Console.Write("Enter file full path: ");
        string sourceFilePath = Console.ReadLine();

        try
        {
            string[] lines = File.ReadAllLines(sourceFilePath);

            string sourceFolderPath = Path.GetDirectoryName(sourceFilePath);
            string targetFolderPath = sourceFolderPath + @"\out";
            string targetFilePath = targetFolderPath + @"\summary.csv";

            Directory.CreateDirectory(targetFolderPath);

            using (StreamWriter sw = File.AppendText(targetFilePath))
            {
                foreach (string line in lines)
                {

                    string[] fields = line.Split(',');
                    string name = fields[0];
                    double price = double.Parse(fields[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2]);

                    Product prod = new Product(name, price, quantity);

                    sw.WriteLine(prod.Name + "," + prod.GetTotalItemValue().ToString("F2", CultureInfo.InvariantCulture));
                }
            }
        }
       
        catch (Exception ex)
        {
            Console.WriteLine("An error ocurred");
            Console.WriteLine(ex.Message);
        }
    }
}

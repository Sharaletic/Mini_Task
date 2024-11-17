using System;
using System.IO;
using System.Net.NetworkInformation;
namespace Mini_Task
{
    public class MyTask
    {
        public static bool CheckLengthOfLineText(string txt, int numberOfSymbol)
        {
            if (txt.Length > numberOfSymbol)
                return false;
            return true;
        }
        public static string[] ReadFile(string path)
        {
            return File.ReadAllText(path).Trim().Split('\n');
        }

        public static string RearrangingStringsInCenterOfSheet(string[] txt)
        {
            int numberOfSymbol = parseInt(txt[0].Split(' ')[0]);
            string result = ""; for (int i = 1; i < txt.Length; i++)
            {
                if (CheckLengthOfLineText(txt[i], numberOfSymbol))
                {
                    int lengthOfSpace = (numberOfSymbol - txt[i].Trim().Length) / 2;
                    var SpacesForFirstPart = new string('+', lengthOfSpace);
                    var SpacesForSecondPart = new string('+', (numberOfSymbol - txt[i].Trim().Length) - lengthOfSpace);
                    result += SpacesForFirstPart + txt[i].Trim() + SpacesForSecondPart + '\n';
                }
                else
                {
                    result = "Impossible.";
                    break;
                }
            }
            return result;
        }
        public static int parseInt(string number)
        {
            if (!int.TryParse(number, out int nb))
                throw new Exception("Число имеет неверный формат");
            return Convert.ToInt16(number);
        }

        public static void WritingToFile(string result, string path)
        {
            File.WriteAllText(path, result);
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string path1 = "input.txt"; string path2 = "output.txt";
                MyTask.WritingToFile(MyTask.RearrangingStringsInCenterOfSheet(MyTask.ReadFile(path1)), path2);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
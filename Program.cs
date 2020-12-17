using System;

namespace musicScale
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] scaleBase = new string[] { "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G", "Ab", "A", "Bb", "B", "C", "Db", "D", "Eb", "E", "F", "Gb", "G" };
            Console.WriteLine("Enter a root note (Ab A Bb B C Db D Eb E F Gb G)");
            string rootNote = Console.ReadLine();
            int indexOfScale = Array.IndexOf(scaleBase, rootNote);


            Console.WriteLine("Major Scale (maj) or Minor Scale (min)?");
            string whichScale = Console.ReadLine();


            if (whichScale == "maj")
            {
                Console.WriteLine(Major(indexOfScale, scaleBase));
            }
            else if (whichScale == "min")
            {
                Console.WriteLine(Minor(indexOfScale, scaleBase));
            }

        }

        public static string Major(int index, string[] array)
        {
            string result = array[index] + " ";
            int[] majorScale = new int[] { 2, 2, 1, 2, 2, 2, 1 };

            
            for (int i = 0; i < 7; i++)
            {
                result += array[(index + majorScale[i])] + " ";
                index += majorScale[i];
            }
            result = Sharps(result);
            return result;
        }

        public static string Minor(int index, string[] array)
        {
            string result = array[index] + " ";
            int[] minorScale = new int[] { 2, 1, 2, 2, 1, 2, 2 };


            for (int i = 0; i < 7; i++)
            {
                result += array[(index + minorScale[i])] + " ";
                index += minorScale[i];
            }
            result = Sharps(result);
            return result;
        }

        public static string Sharps(string addSharps)
        {
            string result = addSharps;

            if (result.Contains("A") && result.Contains("Ab"))
            {
                result = result.Replace("Ab", "G#");
            }
            if (result.Contains("B") && result.Contains("Bb"))
            {
                result = result.Replace("Bb", "A#");
            }
            if (result.Contains("D") && result.Contains("Db"))
            {
                result = result.Replace("Db", "C#");
            }
            if (result.Contains("E") && result.Contains("Eb"))
            {
                result = result.Replace("Eb", "D#");
            }
            if (result.Contains("G") && result.Contains("Gb"))
            {
                result = result.Replace("Gb", "F#");
            }

            return result;
        }
    }
}
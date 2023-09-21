using System;
class codebasetest

{
    public static void positionsChange()
    {
        Console.WriteLine("Removed position strings :");
        string[] inputs = { "Python", "Python", "Python" };
        int[] positions = { 1, 0, 4 };



        for (int i = 0; i < inputs.Length; i++)
        {
            string s = inputs[i];
            int position = positions[i];



            if (position >= 0 && position < s.Length)
            {
                string output = s.Remove(position, 1);
                Console.WriteLine($"{output}");



            }
            else
            {
                Console.WriteLine("Invalid Position");
            }
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        codebasetest.positionsChange();

        Console.ReadLine();
    }
}
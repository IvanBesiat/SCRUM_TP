// See https://aka.ms/new-console-template for more information
Console.WriteLine("Indiquez un nombre entre 0 et 1000.");
int selectedValue = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("vous avez choisi le nombre : {0}", selectedValue);
FizzBuzz essaie = new FizzBuzz(selectedValue);
Console.WriteLine(essaie.NbrTest(selectedValue));
public class FizzBuzz
{
    private int value;

    public FizzBuzz(int value)
    {
        this.value = value;
    }

    public int Value { get => value; set => this.value = value; }

    public string NbrTest(int selectedValue)
    {
        value = selectedValue;
        if (value % 15 == 0)
        {
            return "FIZZBUZZ";
        }
        else if (value % 5 == 0)
        {
            return "BUZZ";
        }
        else if (value % 3 == 0)
        {
            return "FIZZ";
        }
        else
        {
            return "PERDU";
        }
    }
}
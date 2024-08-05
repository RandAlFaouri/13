internal class Program
{
    private static void Main(string[] args)
    {
        Money m1 = new Money(10);
        Money m2 = new Money(20);
        Money m3 = m1 - m2;
    /*    var x = 1; var y = 2;
        var z = x + y;
        var m = x > y;
        var j = !m;*/
        Console.WriteLine($"Money m1 : ${m1.Amount},Money m2: ${m2.Amount }");
        Console.WriteLine($"Money m3: ${m3.Amount}");
        
    }

}
class Money
{
    private decimal amount;
    public decimal Amount => amount;
    public Money(decimal value)
    {

    this.amount = Math.Round(value,2); 
    }
    public static Money operator - (Money money1, Money money2)
    {
        var value = money1.Amount - money2.Amount;
        return new Money( value);
    }
}
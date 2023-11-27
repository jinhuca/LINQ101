namespace AggregateSeed;

file class Program
{
  static void Main()
  {
    var numbers_ = new int[] { 1, 2, 3 };
    var result_ = numbers_.Aggregate(10, (a, b) => a + b);
    Console.WriteLine(result_);
  }
}
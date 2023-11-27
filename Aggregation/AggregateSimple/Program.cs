using static System.Console;

namespace AggregateSimple;

file class Program
{
  static void Main()
  {
    var numbers_ = new int[] { 1, 2, 3, 4, 5 };
    var result_ = numbers_.Aggregate((a, b) => a * b);
    WriteLine(result_);
  }
}
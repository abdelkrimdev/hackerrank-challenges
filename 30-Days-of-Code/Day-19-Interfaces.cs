public class Calculator : AdvancedArithmetic
{
  public int divisorSum(int n)
  {
    var result = 0;

    for (var i = n; i > 0; i--)
      if (n % i == 0) result += i;

    return result;
  }
}

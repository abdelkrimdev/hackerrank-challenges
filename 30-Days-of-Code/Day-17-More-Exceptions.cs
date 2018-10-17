//Write your code here
class Calculator
{
  public int power(int n, int p)
  {
    if (n < 0 ||p < 0)
      throw new Exception($"{nameof(n)} and {nameof(p)} should be non-negative");

    int result = 1;

    while(p-- > 0) result *= n;

    return result;
  }
}

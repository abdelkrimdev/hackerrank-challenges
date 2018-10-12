  // Add your code here
  public Difference(int[] arr)
  {
    elements = arr;
    maximumDifference = 0;
  }

  public void computeDifference()
  {
    for (int i = 0; i < elements.Length - 1; i++)
    {
      for (int j = i + 1; j < elements.Length; j++)
      {
        int current = Math.Abs(elements[i] - elements[j]);
        if (current > maximumDifference) maximumDifference = current;
      }
    }
  }

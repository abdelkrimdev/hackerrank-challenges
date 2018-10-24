  static class TestDataEmptyArray
  {
      public static int[] GetArray()
      {
        // complete this function
        return new int[] {};
      }
  }

  static class TestDataUniqueValues
  {
      public static int[] GetArray()
      {
        // complete this function
        return new int[] {58, 87, 13, 74};
      }

      public static int GetExpectedResult()
      {
        // complete this function
        return 2;
      }
  }

  static class TestDataExactlyTwoDifferentMinimums {
    public static int[] GetArray()
    {
      // complete this function
      return new int[] {58, 87, 76, 58};
    }

    public static int GetExpectedResult()
    {
      // complete this function
      return 0;
    }
  }

class Student : Person
{
  private int[] testScores;

  /*
  *   Class Constructor
  *
  *   Parameters:
  *   firstName - A string denoting the Person's first name.
  *   lastName - A string denoting the Person's last name.
  *   id - An integer denoting the Person's ID number.
  *   scores - An array of integers denoting the Person's test scores.
  */
  // Write your constructor here
  public Student(string firstName, string lastName, int identification, int[] testScores)
    :base(firstName, lastName, identification)
  {
    this.testScores = testScores;
  }

  /*
  *   Method Name: Calculate
  *   Return: A character denoting the grade.
  */
  // Write your method here
  public char Calculate()
  {
    var averageScore = Average(testScores);

    if (averageScore < 40) return 'T';
    if (averageScore < 55) return 'D';
    if (averageScore < 70) return 'P';
    if (averageScore < 80) return 'A';
    if (averageScore < 90) return 'E';

    return 'O';
  }

  private double Average(int[] scores)
  {
    var result = 0;

    for(var i = 0; i < scores.Length; i++)
      result += scores[i];

    return result / scores.Length;
  }
}

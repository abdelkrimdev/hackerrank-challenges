	static void levelOrder(Node root)
  {
    //Write your code here
    if (root == null) return;

    var height = getHeight(root);

    for (var level = 0; level <= height; level++)
      printLevel(root, level);
  }

  static void printLevel(Node root, int level)
  {
    if (level == 0) Console.Write($"{root.data} ");
    else
    {
      if (root.left != null) printLevel(root.left, level - 1);
      if (root.right != null) printLevel(root.right, level - 1);
    }
  }

  static int getHeight(Node root)
  {
    if (root == null)
      return -1;

    return 1 + max(getHeight(root.left), getHeight(root.right));
  }

  static int max(int a, int b)
  {
    return a > b ? a : b;
  }

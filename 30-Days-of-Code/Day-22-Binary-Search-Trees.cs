static int getHeight(Node root)
{
  //Write your code here
  if (root == null) return -1;

  return 1 + max(getHeight(root.left), getHeight(root.right));
}

static int max(int a, int b)
{
  return a > b ? a : b;
}

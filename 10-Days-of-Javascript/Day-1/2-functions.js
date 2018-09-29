/*
 * Create the function factorial here
 */
var factorial = function (num) {
  return num < 1 ? 1 : num * factorial(num - 1);
}

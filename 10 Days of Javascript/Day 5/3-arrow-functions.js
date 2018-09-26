/*
 * Modify and return the array so that all even elements are doubled and all odd elements are tripled.
 *
 * Parameter(s):
 * nums: An array of numbers.
 */
function modifyArray(nums) {
  return nums.map(e => e % 2 === 0 ? e * 2 : e * 3);
}

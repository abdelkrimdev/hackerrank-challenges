/**
*   Return the second largest number in the array.
*   @param {Number[]} nums - An array of numbers.
*   @return {Number} The second largest number in the array.
**/
function getSecondLargest(nums) {
  let unique_array = Array.from(new Set(nums));

  unique_array.sort((x, y) => x > y);

  return unique_array[unique_array.length - 2];
}

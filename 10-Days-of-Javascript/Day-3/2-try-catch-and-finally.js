/*
 * Complete the reverseString function
 * Use console.log() to print to stdout.
 */
function reverseString(s) {
  try {
    let arr = s.split("");
    arr.reverse();
    let r = arr.join("");
    console.log(r);
  } catch (ex) {
    console.log(ex.message);
    console.log(s);
  }
}

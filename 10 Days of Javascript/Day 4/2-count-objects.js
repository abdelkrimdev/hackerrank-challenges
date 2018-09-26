/*
 * Return a count of the total number of objects 'o' satisfying o.x == o.y.
 *
 * Parameter(s):
 * objects: an array of objects with integer properties 'x' and 'y'
 */
function getCount(objects) {
  let count = 0;

  objects.forEach((o) => {
    if (o.x === o.y) {
      count++;
    }
  });

  return count;
}

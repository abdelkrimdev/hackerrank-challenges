/*
 * Determine the original side lengths and return an array:
 * - The first element is the length of the shorter side
 * - The second element is the length of the longer side
 *
 * Parameter(s):
 * literals: The tagged template literal's array of strings.
 * expressions: The tagged template literal's array of expression values (i.e., [area, perimeter]).
 */
function sides(literals, ...expressions) {
  const p = expressions[1];
  const a = expressions[0];

  const sqrt = Math.sqrt((p * p) - (16 * a));
  const s1 = (p + sqrt) / 4;
  const s2 = (p - sqrt) / 4;

  return [s1, s2].sort();
}

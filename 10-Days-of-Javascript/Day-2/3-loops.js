/*
 * Complete the vowelsAndConsonants function.
 * Print your output using 'console.log()'.
 */
function vowelsAndConsonants(s) {
  for (let l in s) {
    switch (s[l]) {
      case 'a':
      case 'o':
      case 'i':
      case 'e':
      case 'u':
        console.log(s[l]);
    }
  }

  for (let l in s) {
    switch (s[l]) {
      case 'a':
      case 'o':
      case 'i':
      case 'e':
      case 'u':
        break;
      default:
        console.log(s[l]);
    }
  }
}

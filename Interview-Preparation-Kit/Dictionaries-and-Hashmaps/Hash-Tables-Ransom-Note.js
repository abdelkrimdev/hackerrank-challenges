'use strict';

process.stdin.resume();
process.stdin.setEncoding('utf-8');

let inputString = '';
let currentLine = 0;

process.stdin.on('data', inputStdin => {
  inputString += inputStdin;
});

process.stdin.on('end', _ => {
  inputString = inputString.replace(/\s*$/, '')
    .split('\n')
    .map(str => str.replace(/\s*$/, ''));

  main();
});

function readLine() {
  return inputString[currentLine++];
}

function canDoIt(m, n, magazine, ransom) {
  if (m < n) return false;

  for (let word of ransom) {
    let index = magazine.indexOf(word);

    if (index < 0) return false;

    magazine.splice(index, 1);
  };

  return true;
}

function main() {
  const mn = readLine().split(' ');

  const m = parseInt(mn[0], 10);
  const n = parseInt(mn[1], 10);

  const magazine = readLine().split(' ');
  const ransom = readLine().split(' ');

  console.log(canDoIt(m, n, magazine, ransom) ? 'Yes' : 'No');
}

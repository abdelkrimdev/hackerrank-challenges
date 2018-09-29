function getMaxLessThanK(n, k) {
  let maximum = 0;

  for (let i = 1; i <= n; i++) {
    for (let j = i + 1; j <= n; j++) {
      let p = i & j;
      if ((p < k) && (p > maximum))
        maximum = p;
    }
  }

  return maximum;
}

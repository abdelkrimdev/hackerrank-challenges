let counter = document.getElementById('btn');
let value = 0;

counter.onclick = function () {
  value++;
  counter.textContent = value;
};

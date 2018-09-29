let btns = document.querySelectorAll("button:not([id=btn5])");
let btn5 = document.getElementById('btn5');

btn5.onclick = function () {
  let tmp = btns[0].innerHTML;
  btns[0].innerHTML = btns[3].innerHTML;
  btns[3].innerHTML = btns[5].innerHTML;
  btns[5].innerHTML = btns[6].innerHTML;
  btns[6].innerHTML = btns[7].innerHTML;
  btns[7].innerHTML = btns[4].innerHTML;
  btns[4].innerHTML = btns[2].innerHTML;
  btns[2].innerHTML = btns[1].innerHTML;
  btns[1].innerHTML = tmp;
};

let screen = document.getElementById('res');

let operand1 = "";
let operand2 = "";
let operator = "";

function appendOperand(e) {
    if (operator === "") {
        operand1 += e.target.innerHTML;
        update(e.target.id);
    } else {
        operand2 += e.target.innerHTML;
        update(e.target.id);
    }
}

function appendOperator(e) {
    if ((operator === "") && (operand1 != "")) {
        operator += e.target.innerHTML;
        update(e.target.id);
    }
}

function clear() {
    operand1 = "";
    operand2 = "";
    operator = "";
    screen.innerHTML = "";
}

function resolve() {
    let result = 0;
    let expression = parseInt(operand1, 2) + operator + parseInt(operand2, 2);
    result = eval(expression);

    screen.innerHTML = result.toString(2);
}

function update(value) {
    screen.innerHTML += document.getElementById(value).innerHTML;
}

document.getElementById('btn0').onclick = appendOperand;
document.getElementById('btn1').onclick = appendOperand;
document.getElementById('btnClr').onclick = clear;
document.getElementById('btnEql').onclick = resolve;
document.getElementById('btnSum').onclick = appendOperator;
document.getElementById('btnSub').onclick = appendOperator;
document.getElementById('btnMul').onclick = appendOperator;
document.getElementById('btnDiv').onclick = appendOperator;

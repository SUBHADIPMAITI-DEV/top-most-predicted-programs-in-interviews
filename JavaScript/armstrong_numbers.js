function isArmstrong(num) {
    let digits = num.toString().split('');
    let n = digits.length;
    return num === digits.reduce((acc, digit) => acc + Math.pow(parseInt(digit), n), 0);
}

let armstrongNumbers = [];
for (let i = 1; i < 1000; i++) {
    if (isArmstrong(i)) armstrongNumbers.push(i);
}

console.log(armstrongNumbers);

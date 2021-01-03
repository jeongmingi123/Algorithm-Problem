let input = require('fs').readFileSync('/dev/stdin', 'utf8').toString().split("\n").map(n => Number(n));
let total = 0;

for (let i = 0; i < 9; i++) {
    total += input[i];
}

for (let i = 0; i < 9; i++) {
    for (let j = i + 1; j < 9; j++) {
        if (100 == total - (input[i] + input[j])) {
            input.splice(i, 1)
            input.splice(j - 1, 1)
        }
    }
}

input.sort((a, b) => a - b)

for (let i = 0; i < input.length; i++) {
    console.log(input[i])
}
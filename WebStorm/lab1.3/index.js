let prev = 0;
let current = 1;
let next;

console.log('1: ' + prev)
console.log('2: ' + current)

for (let i = 1; i < 19; i++) {
    next = prev + current
    prev = current
    current = next
    console.log(i + 2 + ': ' + current)
}

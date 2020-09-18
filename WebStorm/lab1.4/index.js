let prevprev = 0
let prev = 0
let current = 1
let next

console.log('1: ' + prevprev)
console.log('2: ' + prev)
console.log('3: ' + current)

for (let i = 1; i < 18; i++) {
    next = prevprev + prev + current
    prevprev = prev
    prev = current
    current = next
    console.log(i + 3 + ': ' + current)
}

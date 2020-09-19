var o = {}
o.x = 1

var p = Object.create(o)
p.y = 2

var q = Object.create(p)
q.z = 3

var s = q.toString()

console.log(q.x + q.y)
console.log(s)
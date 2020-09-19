let o = {};
o.x = 1

let p = Object.create(o);
p.y = 2

let q = Object.create(p);
q.z = 3

let s = q.toString();

console.log(q.x + q.y)
console.log(s)

console.log("\n##############################################\n")

let unitCircle = {r: 1};
let c = Object.create(unitCircle);
c.x=1
c.y=1
c.r=2
console.log('unitCircle.r: ' + unitCircle.r)

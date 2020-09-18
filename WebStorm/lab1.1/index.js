let students = []
let numOfStudents = 10

// Init and print array
for (let i = 0; i < numOfStudents; i++) {
    students.push(Math.floor(Math.random() * 10 + 1))
    console.log((i + 1) + '[' + i + ']: ' + students[i])
}

// Find and print max mark
maxMark = Math.max(...students)
console.log('\nMax mark: ' + maxMark)

// Find and print indexes of max mark
console.log('\nIndexes of max marks:')
for (let i = 0; i < numOfStudents; i++) {
    if (students[i] === maxMark) {
        console.log('\t' + (i + 1) + '[' + i + ']: ' + students[i])
    }
}

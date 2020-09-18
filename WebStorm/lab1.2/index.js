let arr = []
let sizeOfArr = 10

// Init array
for (let i = 0; i < sizeOfArr; i++) {
    arr.push(Math.floor(Math.random() * 100))
}


console.log('Before sort:')
console.log(arr.toString())

// Bubble sort
for (let i = 0; i < arr.length; i++)
{
    for (let j = 0; j < arr.length-i-1; j++)
    {
        if (arr[j]>arr[j+1])
        {
            let temp=arr[j];
            arr[j]=arr[j+1];
            arr[j+1]=temp;
        }
    }
}

console.log('\nAfter sort:')
console.log(arr.toString())
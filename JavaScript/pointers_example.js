//JavaScript doesn't have pointers, but objects and arrays are passed by reference.

function modifyArray(arr) {
    arr[0] = 100;
}

let myArray = [1, 2, 3];
modifyArray(myArray);
console.log(myArray);

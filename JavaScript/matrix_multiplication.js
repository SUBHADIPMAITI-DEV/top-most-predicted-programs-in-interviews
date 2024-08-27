function matrixMultiply(A, B) {
    let result = Array.from({ length: A.length }, () => Array(B[0].length).fill(0));

    for (let i = 0; i < A.length; i++) {
        for (let j = 0; j < B[0].length; j++) {
            for (let k = 0; k < B.length; k++) {
                result[i][j] += A[i][k] * B[k][j];
            }
        }
    }

    return result;
}

let A = [[1, 2], [3, 4]];
let B = [[5, 6], [7, 8]];

let result = matrixMultiply(A, B);
result.forEach(row => console.log(row));

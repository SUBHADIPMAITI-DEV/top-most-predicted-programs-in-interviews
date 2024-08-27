function fibonacci(n) {
    let fib_sequence = [0, 1];
    for (let i = 2; i < n; i++) {
        fib_sequence[i] = fib_sequence[i - 1] + fib_sequence[i - 2];
    }
    return fib_sequence;
}

console.log(fibonacci(10));

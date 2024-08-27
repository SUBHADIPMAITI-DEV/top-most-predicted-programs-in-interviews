function isPrime(num) {
    if (num <= 1) return false;
    for (let i = 2; i <= Math.sqrt(num); i++) {
        if (num % i === 0) return false;
    }
    return true;
}

let primes = [];
for (let i = 2; i <= 100; i++) {
    if (isPrime(i)) primes.push(i);
}

console.log(primes);

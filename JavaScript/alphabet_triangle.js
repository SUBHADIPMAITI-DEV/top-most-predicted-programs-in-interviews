function alphabetTriangle(n) {
    let alphabet = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ';
    for (let i = 0; i < n; i++) {
        console.log(' '.repeat(n - i - 1) + alphabet.slice(0, i + 1));
    }
}

alphabetTriangle(5);

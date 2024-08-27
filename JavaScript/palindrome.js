function isPalindrome(s) {
    return s === s.split('').reverse().join('');
}

console.log(isPalindrome("radar"));

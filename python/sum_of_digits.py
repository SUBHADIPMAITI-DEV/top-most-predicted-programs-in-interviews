def sum_of_digits(num):
    return sum(int(digit) for digit in str(num))

print(sum_of_digits(12345))

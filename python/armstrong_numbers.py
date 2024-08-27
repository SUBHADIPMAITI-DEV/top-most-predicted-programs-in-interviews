def is_armstrong(num):
    n = len(str(num))
    return num == sum(int(digit) ** n for digit in str(num))

armstrong_numbers = [x for x in range(1, 1000) if is_armstrong(x)]
print(armstrong_numbers)

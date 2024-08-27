def alphabet_triangle(n):
    alphabet = 'ABCDEFGHIJKLMNOPQRSTUVWXYZ'
    for i in range(n):
        print(' ' * (n - i - 1) + alphabet[0:i + 1])

alphabet_triangle(5)

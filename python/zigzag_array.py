def zigzag(arr):
    n = len(arr)
    flag = True  # true means "<" expected, else ">" expected
    for i in range(n - 1):
        if flag:
            if arr[i] > arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
        else:
            if arr[i] < arr[i + 1]:
                arr[i], arr[i + 1] = arr[i + 1], arr[i]
        flag = not flag
    return arr

arr = [4, 3, 7, 8, 6, 2, 1]
print(zigzag(arr))

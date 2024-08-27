#Python doesn't have pointers like C/C++, but we can use references to demonstrate a similar concept.


def modify_list(lst):
    lst[0] = 100

my_list = [1, 2, 3]
modify_list(my_list)
print(my_list)

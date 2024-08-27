#Python uses classes instead of structures.

class Point:
    def __init__(self, x, y):
        self.x = x
        self.y = y

p = Point(10, 20)
print(p.x, p.y)

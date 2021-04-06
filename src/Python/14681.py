class Quad():
    def __init__(self, x, y):
        self.x = x
        self.y = y

    def where_is_quadant(self):
        if self.x > 0 and self.y > 0:
            return 1
        elif self.x < 0 and self.y > 0:
            return 2
        elif self.x < 0 and self.y < 0:
            return 3
        elif self.x > 0 and self.y < 0:
            return 4


# main
x = int(input())
y = int(input())
q = Quad(x, y)
print(q.where_is_quadant())
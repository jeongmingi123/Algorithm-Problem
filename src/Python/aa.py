class N():
    def __init__(self, n):
        self.n = n

    def seek_n(self):
        while self.n != 0:
            print(self.n)
            self.n -= 1


# main
input = int(input())
n = N(input)
n.seek_n()



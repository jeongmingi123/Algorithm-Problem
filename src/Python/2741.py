class N():
    def __init__(self, n):
        self.n = n

    def seek_n(self):
        for i in range(1, self.n + 1):
            print(i)

# main
input = int(input())
n = N(input)
n.seek_n()

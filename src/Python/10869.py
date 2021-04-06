class Cal():
    def __init__(self, num1, num2):
        self.num1 = num1
        self.num2 = num2

    def plus(self):
        return self.num1 + self.num2

    def sub(self):
        return self.num1 - self.num2

    def mul(self):
        return self.num1 * self.num2

    def div(self):
        return self.num1 / self.num2

    def rem(self):
        return self.num1 % self.num2


# main
input = input()
input_list = input.split(" ")
A = int(input_list[0])
B = int(input_list[1])
c = Cal(A, B)
print(c.plus())
print(c.sub())
print(c.mul())
print(int(c.div()))
print(c.rem())

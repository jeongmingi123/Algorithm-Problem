class Mul():

    def __init__(self, num1, num2):
        self.num1 = num1
        self.num2 = num2

    def first(self):
        self.num2 = str(self.num2)
        num2_first = self.num2[2]
        num2_first = int(num2_first)
        return self.num1 * num2_first

    def two(self):
        self.num2 = str(self.num2)
        num2_two = self.num2[1]
        num2_two = int(num2_two)
        return self.num1 * num2_two

    def three(self):
        self.num2 = str(self.num2)
        num2_three = self.num2[0]
        num2_three = int(num2_three)
        return self.num1 * num2_three


# main
num1 = int(input())
num2 = int(input())
c = Mul(num1, num2)
print(c.first())
print(c.two())
print(c.three())
print(c.first() + c.two()*10 + c.three()*100)

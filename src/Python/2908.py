class TwoNumComparison:
    def __init__(self, num1, num2):
        self.num1 = num1
        self.num2 = num2

    def reverseNum1(self):
        num1_len = 3 - 1
        reverse_num1 = ""

        while True:
            if num1_len == -1:
                break
            else:
                reverse_num1 += self.num1[num1_len]
                num1_len -= 1

        return reverse_num1

    def reverseNum2(self):
        num2_len = 3 - 1
        reverse_num2 = ""

        while True:
            if num2_len == -1:
                break
            else:
                reverse_num2 += self.num2[num2_len]
                num2_len -= 1

        return reverse_num2

    def compareTwoNumber(self):
        if int(self.reverseNum1()) >= int(self.reverseNum2()):
            return self.reverseNum1()
        elif int(self.reverseNum1()) <= int(self.reverseNum2()):
            return self.reverseNum2()


numbers = input().split(" ")
num1 = numbers[0]
num2 = numbers[1]

t = TwoNumComparison(num1, num2)
print(t.compareTwoNumber())

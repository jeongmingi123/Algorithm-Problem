# 10개 입력받는다.
# 입력받은 반복문을 사용하여, 10개에 대하여 42로 나눈 나머지를 구한다.
#

class Rest:

    def __init__(self, numbers, rests):
        self.rests = rests
        self.numbers = numbers

    def make_rests(self):
        for number in self.numbers:
            self.rests.append(number % 42)

    def find_difference_rest(self):
        pass


# main
input_list = []
for i in range(10):
    input = int(input())
    input_list.append(input)

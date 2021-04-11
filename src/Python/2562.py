# 첫째 줄에 최댓값을 출력하고, 둘째 줄에 최댓값이 몇 번째 수인지를 출력한다.

class Max():

    def __init__(self, test_case, num_list):
        self.test_case = test_case
        self.num_list = num_list

    def find_max(self):
        max = self.num_list[0]
        max_count = 0
        for i in range(1, self.test_case):
            if self.num_list[i] > max:
                max = self.num_list[i]
                max_count = i
        print(max)
        print(max_count + 1)


num_list = []

for i in range(9):
    num_list.append(int(input()))

m = Max(9, num_list)
m.find_max()

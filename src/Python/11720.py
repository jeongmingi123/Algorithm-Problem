# 문제
# N개의 숫자가 공백 없이 쓰여있다. 이 숫자를 모두 합해서 출력하는 프로그램을 작성하시오.
#
# 입력
# 첫째 줄에 숫자의 개수 N (1 ≤ N ≤ 100)이 주어진다. 둘째 줄에 숫자 N개가 공백없이 주어진다.
#
# 출력
# 입력으로 주어진 숫자 N개의 합을 출력한다.
#
# 예제 입력 1
# 1
# 1
# 예제 출력 1
# 1
# 예제 입력 2
# 5
# 54321
# 예제 출력 2
# 15
# 예제 입력 3
# 25
# 7000000000000000000000000
# 예제 출력 3
# 7
# 예제 입력 4
# 11
# 10987654321
# 예제 출력 4
# 46

class FindHap():
    def __init__(self, len_str, strs):
        self.len_str = len_str
        self.strs = strs

    def search_str_hap(self):
        str_list = []

        for i in range(self.len_str):
            str_list.append(self.strs[i])

        str_list = list(map(int, str_list))

        total = 0

        for str in str_list:
            total += str

        return total


str_len = int(input())
numbers = input()

f = FindHap(str_len, numbers)
print(f.search_str_hap())

# 알파벳 -> 숫자 바꾸는 부분 필요
# 각 숫자의 최소 시간을 구해서, 총 시간 구하기

class Dial():
    def __init__(self, alphabets):
        self.alphabets = alphabets

    def searchDialCount(self):
        alpa_list = []
        for i in range(len(self.alphabets)):
            alpa_list.append(self.alphabets[i])

        dial_strs = ['ABC', 'DEF', 'GHI', 'JKL', 'MNO', 'PQRS', 'TUV', 'WXYZ']
        count = 0
        for i in range(len(alpa_list)):
            for str in dial_strs:
                for j in range(len(str)):
                    if alpa_list[i] == str[j]:
                        count += dial_strs.index(str) + 3
        return count

str_input = input()
d = Dial(str_input)
print(d.searchCount())


'''
A가 A,B,C 에 있는지
A가 D,E,F 에 있는지
A가 G,H,I 에 있는지 확인한다.

1. 입력받은 글자 한글자씩 가져온다.
2. 반복문을 돌리는데 dial_ strs 길이 만큼 돌린다.
A가 dial_strs에 있는가?
A,B,C
AD

A 
A가 어디에 있는지

'''

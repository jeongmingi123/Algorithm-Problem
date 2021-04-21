# 고정 비용 A: 임대료, 재산세, 보험료, 급여
# 가변 비용 B: 한 대의 노트북을 생산하는 데에는 재료비와 인건비

# 총수입 C > 총비용(A+B) 이 되는 순간을 BREAK EVEN POINT

'''

A+B*count < C*count

'''
import sys


class BreakEvenPoint():
    def __init__(self, A, B, C):
        self.A = A
        self.B = B
        self.C = C

    def searchBEP(self):
        count = 0
        if self.B >= self.C:
            return -1
        else:
            while True:
                if self.A + self.B * count < self.C * count:
                    break
                else:
                    count += 1
            return count


test_case = sys.stdin.readline()[:-1].split()
A = int(test_case[0])
B = int(test_case[1])
C = int(test_case[2])

B = BreakEvenPoint(A, B, C)
print(B.searchBEP())

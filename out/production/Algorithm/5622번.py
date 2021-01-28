# 1. 문자 입력을 받는다.
input1 = input()

# 2.
dia = ["ABC", "DEF", "GHI", "JKL", "MNO", "PORS", "TUV", "WXYZ"]
total = 0

# 3. 최소 시간 구하기
for i in range(len(input1)):
    for j in dia:
        if input1[i] in j:
            total += dia.index(j) + 3

print(total)

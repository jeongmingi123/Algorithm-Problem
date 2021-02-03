# n ~ 2*n 사이에는 소수가 적어도 한개 존재한다.

# 1. 줄라인으로 입력을 받는다.
# 2. 마지막 0이 되면 입력을 종료시킨다.

# 소수를 가지기위한 조건
# 만약 1과 자기자신을 제외하여 나눴을 때 나머지가 0이 아니면 그건 소수가아니다.

# ex) 10
# 10 ~ 20
# for 10 ~ 20 의 숫자를 하나씩돌림
# 처음에 10이 들어감
# 10이 소수인지 판별하기위해 1부터 10까지

sosu_count_list = []

while True:
    data = int(input(""))
    if data == 0:
        break
    else:
        sosu_count = 0
        for i in range(data, 2 * data + 1):
            sosu_check = True
            for j in range(2, i):
                if i % j == 0:
                    sosu_check = False
            if i != 1 and sosu_check == True:
                sosu_count += 1
        sosu_count_list.append(sosu_count)

for count in sosu_count_list:
    print(count)

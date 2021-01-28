# 매년 임대료, 재산세, 보험료, 급여, .... = A만원(고정비용)
# 한 대의 노트북을 생산하는 비용 (재료비+인건비+...) = B만원(가변 비용)
# 노트북 가격 = C만원

# 노트북 생산 하기 위한 비용 = A+B
# 노트북 10대 생산 비용 = A+B*10

# 총 수입(판매비용) > 총 비용이 되는 순간을 구하시오
# C > A+B ?

'''

C*count > A+B*count

'''

A,B,C = map(int, input().split(" "))

notebook_count = 1

if B>=C:
    print("-1")
else :
    while True:
        if C*notebook_count > A+B*notebook_count:
            print(notebook_count)
            break
        else:
            notebook_count+=1

# main

# list variable
list_total = []

count = int(input())

for i in range(count):
    score = 0
    total = 0

    quiz_input = input()

    for j in range(len(quiz_input)):
        if quiz_input[j] == "O":
            score += 1
            total += score
        else:
            score = 0
    list_total.append(total)

for i in range(len(list_total)):
    print(list_total[i])

class RepeatString():

    def searchStr(self, count, str):
        str_result = ""
        for i in range(len(str)):
            str_result += str[i] * count
        return str_result


# main
test_case = int(input())
results = []

r = RepeatString()
for i in range(test_case):
    str_input = input().split(" ")

    count = int(str_input[0])
    str = str_input[1]

    results.append(r.searchStr(count, str))

for result in results:
    print(result)

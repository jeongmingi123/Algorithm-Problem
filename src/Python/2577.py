class NumberCount():
    def __init__(self, A, B, C):
        self.A = int(A)
        self.B = int(B)
        self.C = int(C)

    def searchHapABC(self):
        hap = int(self.A) * int(self.B) * int(self.C)
        return hap

    def searchNumberCount(self):
        counts = []
        for i in range(10):
            counts.append(0)

        hap = self.searchHapABC()
        hap = str(hap)

        hap_list = []
        for i in range(len(hap)):
            hap_list.append(hap[i])

        for i in range(len(hap_list)):
            counts[int(hap_list[i])] += 1

        for i in range(len(counts)):
            print(counts[i])


# main
A = int(input())
B = int(input())
C = int(input())
n = NumberCount(A, B, C)
n.searchNumberCount()

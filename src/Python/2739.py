class MultiTable():
    global TABLE
    TABLE = 9

    def __init__(self, number):
        self.number = number

    def search_table(self):
        for i in range(1, TABLE + 1):
            final_number = int(self.number) * int(i)

            final_number = str(final_number)
            i = str(i)
            self.number = str(self.number)

            print(f"{self.number} * {i} = {final_number}")


number = int(input())
m = MultiTable(number)
m.search_table()

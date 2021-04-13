class WordCount():
    def __init__(self, words):
        self.words = words

    def search_word_count(self):
        word_list = []
        word_list = self.words.split(" ")

        word_count = 0

        for word in word_list:
            if word == "":
                continue
            else:
                word_count += 1

        return word_count

str_input = input()
w = WordCount(str_input)
print(w.search_word_count())
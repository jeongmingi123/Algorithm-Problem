'''
# 이 단어에서 가장 많이 사용된 알파벳이 무엇인지 찾는다. 대소문자 구분 X
# 가장 많이 사용된 알파벳이 여러개 일 경우에는 ? 출력함

1. 문자열 입력받는다.
2. 한글자씩 list 형태로 문자열을 대문자로 바꾼다
3. 각 문자 별로 리스트를 만들어서 중복되는 것을 제거한다.

Zbzd -> ZBZD로 바꾼 상태


'''


class StudyWord():
    def __init__(self, words):
        self.words = words

    def upperWords(self):  # 입력받은 문자를 다 대문자로 리턴하는 함수
        upper_words = self.words.upper()
        return upper_words

    def removeOverlapWord(self):  # 각 문자별로 리스트를 만들어서 중복되는것을 제거한 리스트를 반환 하는 함수
        upper_words = self.upperWords()
        removed_overlap_word_list = list(set(upper_words)) # 중복을 제거하여 리스트로 밚롼한다.

        return removed_overlap_word_list

    def searchMaxAlphabet(self):  # 알파벳 갯수를 파악하고, 제일 가장 많이 사용된 알파벳을 파악하며 반환하는 함수
        removed_overlap_word_list = self.removeOverlapWord()
        upper_words = self.upperWords()
        word_count_list = []
        for word in removed_overlap_word_list:
            count = 0
            for i in range(len(upper_words)):
                if word == upper_words[i]:
                    count += 1
            word_count_list.append(count)

        max_count = 0
        for i in range(len(word_count_list)):
            if max_count <= word_count_list[i]:
                max_count = word_count_list[i]

        overlap_check_count = 0
        for count in word_count_list:
            if max_count == count:
                overlap_check_count += 1

        if overlap_check_count > 1:
            return "?"
        elif overlap_check_count == 1:
            for i in range(len(word_count_list)):
                if word_count_list[i] == max_count:
                    return removed_overlap_word_list[i]

# main
str_input = input()
s = StudyWord(str_input)
print(s.searchMaxAlphabet())


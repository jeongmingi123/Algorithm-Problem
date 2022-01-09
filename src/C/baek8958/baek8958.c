#include <stdio.h>
#include <string.h>

#define LINE_LENGTH (1024)

int main(void) {
	unsigned int test_case;

	char str[LINE_LENGTH];

	size_t i;

	scanf_s("%d", &test_case);
	
	for (i = 0; i < test_case; i++) {
		
		while (fgets(str, LINE_LENGTH, stdin) != NULL) {
			printf("%s\n", str);
		}

	}



}


/*

1. 테스트 케이스 받기
2. 줄별로 테스트 케이스에 대한 문자열 입력받기
3. 

*/

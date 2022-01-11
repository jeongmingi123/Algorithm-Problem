#define LINE_LENGTH (256)
#define TRUE (1)
#include <stdio.h>

int main(void) {
	unsigned int test_case;
	unsigned int idx = 0;

	char line[LINE_LENGTH][LINE_LENGTH];

	size_t i;

	scanf_s("%u", &test_case);

	for (i = 0; i < test_case; i++) {
		fgets(line[i], LINE_LENGTH, stdin);
		line[i][strlen(line[i]) - 1] = '\0';
	}

	for (i = 0; i < test_case; i++) {
		printf("%s\n", line[i]);
	}


	/*
	fgets(line, LINE_LENGTH, stdin);
	
	line[strlen(line) - 1] = '\0';
	
	printf("%s\n", line);
	printf("%d\n", strlen(line));
	*/
	return 0;
}

/*

입력
5
OOXXOXXOOO
OOXXOOXXOO
OXOXOXOXOXOXOX
OOOOOOOOOO
OOOOXOOOOXOOOOX

출력
10
9
7
55
30

*/
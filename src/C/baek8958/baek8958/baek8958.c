#define LINE_LENGTH (128)
#define TRUE (1)
#include <stdio.h>

int main(void) {
	unsigned int test_case;
	unsigned int idx = 0;
	unsigned int i = 0;

	char line[LINE_LENGTH];

	fgets(line, LINE_LENGTH, stdin);
	/*
	line[strlen(line) - 1] = '\0';
	*/
	printf("%s\n", line);
	printf("%d\n", strlen(line));

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
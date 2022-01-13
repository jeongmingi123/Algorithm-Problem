#include <stdio.h>

int main(void) {
	char str[128] = { 0, };
	unsigned int str_length;
	int total = 0;

	size_t i;

	scanf_s("%u", &str_length);

	scanf_s("%s", str, 128);

	for (i = 0; i < str_length; i++) {
		total += *(str + i) - 48;
		
	}

	printf("%d\n", total);

	return 0;
}
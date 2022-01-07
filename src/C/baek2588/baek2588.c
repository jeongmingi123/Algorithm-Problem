#include <stdio.h>

int main(void) {
	int num1;
	int num2;

	int result1;
	int result2;
	int result3;

	int total;

	scanf("%d", &num1);
	scanf("%d", &num2);

	result1 = num1 * (num2 % 10);
	result2 = num1 * (num2 % 100 / 10);
	result3 = num1 * (num2 / 100);

	total = result1 + (result2 * 10) + (result3 * 100);

	printf("%d\n", result1);
	printf("%d\n", result2);
	printf("%d\n", result3);
	printf("%d\n", total);

	return 0;
}

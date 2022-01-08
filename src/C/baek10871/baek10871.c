#include <stdio.h>

int main(void) {
	unsigned int n_length;
	unsigned int x;
	unsigned int temp;

	int nums_over_x[10000] = { 0, };

	size_t i;

	scanf_s("%d %d", &n_length, &x);

	for (i = 0; i < n_length; i++) {
		scanf_s("%d", &temp);
		if (temp < x) {
			nums_over_x[i] = temp;
		}
	}

	for (i = 0; i < n_length; i++) {
		if (nums_over_x[i] != 0) {
			printf("%d ", nums_over_x[i]);
		}
	}
	
	return 0;
}

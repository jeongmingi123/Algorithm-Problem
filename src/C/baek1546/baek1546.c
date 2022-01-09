#include <stdio.h>

int main(void) {
	unsigned int arr_length;

	float scores[1024];

	float max;
	float total;
	float avg;
	float temp;

	size_t i;

	scanf_s("%u", &arr_length);

	for (i = 0; i < arr_length; i++) {
		scanf_s("%f", &scores[i]);
	}
	
	max = scores[0];
	for (i = 0; i < arr_length; i++) {
		if (max < scores[i]) {
			max = scores[i];
		}
	}

	for (i = 0; i < arr_length; i++) {
		temp = (scores[i] / max) * 100;
		total += temp;
	}

	avg = total / arr_length;
	printf("%f\n", avg);

	return 0;
}

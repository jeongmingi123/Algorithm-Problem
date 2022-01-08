#include <stdio.h>

int main(void) {
	unsigned int arr_length;

	int scores[1024];

	int max;

	double total = 0.0;
	double avg;

	size_t i;

	scanf_s("%u", &arr_length);

	for (i = 0; i < arr_length; i++) {
		scanf_s("%d", &scores[i]);
	}
	
	max = scores[i];
	for (i = 0; i < arr_length; i++) {
		if (max < scores[i]) {
			max = scores[i];
		}
		printf("%d ", (int)scores[i]);
	}

	printf("max value : %d", (int)max);

	for (i = 0; i < arr_length; i++) {
		total += (scores[i] / max) * 100;
	}

	avg = total / arr_length;

	printf("%lf", (double)avg);

	return 0;
}

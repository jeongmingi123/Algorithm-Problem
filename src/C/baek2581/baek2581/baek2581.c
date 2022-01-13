#include <stdio.h>

int* get_desimals(const int M, const int N) {
	int is_desimal = 1;
	int desimal_idx = 0;

	int desimals[300] = { 0, };

	size_t i;
	size_t j;

	for (i = M; i <= N; i++) {
		if (i == 1) {
			continue;
		}

		is_desimal = 1;
		for (j = 2; j <= i - 1; j++) {
			if (i % j == 0) {
				is_desimal = 0;
			}
		}

		if (is_desimal == 1) {
			desimals[desimal_idx++] = i;
		}
	}
	return desimals;
}

int get_min(int* desimals) {
	int min;

	size_t i;

	min = desimals[0];
	for (i = 0; desimals[i] != 0; i++) {
		if (min > desimals[i]) {
			min = desimals[i];
		}
	}
	return min;
}

int main(void) {
	int* arr;

	int M;
	int N;
	int min;
	int desimals_total = 0;

	size_t i;

	scanf_s("%d", &M);
	scanf_s("%d", &N);

	arr = get_desimals(M,N);
	min = get_min(arr);

	for (i = 0; arr[i] != 0; i++) {
		desimals_total += arr[i];
	}

	if (desimals_total == 0) {
		printf("-1\n");
	}
	else {
		printf("%d\n", desimals_total);
		printf("%d\n", min);
	}

	return 0;
}

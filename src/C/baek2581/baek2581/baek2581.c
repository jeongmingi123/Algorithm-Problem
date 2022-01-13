#include <stdio.h>

int main(void) {
	int M;
	int N;
	int desimals_total = 0;
	int min_desimal = 0;
	int desimal_idx = 0;

	int is_desimal = 1;

	size_t i;
	size_t j;

	scanf_s("%d", &M);
	scanf_s("%d", &N);

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
			desimals_total += i;
		}

		if (is_desimal == 1 && desimal_idx == 0) {
			min_desimal = i;
			++desimal_idx;
		}

		if (min_desimal > i) {
			min_desimal = i;
		}

	}

	if (desimals_total == 0) {
		printf("-1\n");
	}
	else {
		printf("%d\n", desimals_total);
		printf("%d\n", min_desimal);
	}

	return 0;
}

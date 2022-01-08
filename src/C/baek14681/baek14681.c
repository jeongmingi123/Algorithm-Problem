#include <stdio.h>

int get_quadrant(int x, int y) {
	if (x > 0 && y > 0) {
		return 1;
	}
	if (x < 0 && y > 0) {
		return 2;
	}
	if (x < 0 && y < 0) {
		return 3;
	}

	return 4;
}

int main(void){
	int num1;
	int num2;

	scanf("%d\n", &num1);
	scanf("%d\n", &num2);
	
	printf("%d", get_quadrant(num1, num2));

}

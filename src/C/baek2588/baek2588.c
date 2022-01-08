#include <stdio.h>

int main(void) {
	int a = 30;

	int* p;
	p = &a;

	printf("%p \n", (void*)&a);

	printf("%p \n", (void*)p);
	
	return 0;
}

#include <stdio.h>

int main(void) {
    unsigned int test_case;
    unsigned int student_count;

    float total = 0;

    float student_over_avg_count = 0;
    float avg;
    float student_over_avg_ratio;

    float scores[1024] = { 0, };
    float results[1024] = { 0, };
    float avgs[1024];

    size_t i;
    size_t j;
    
    scanf_s("%u", &test_case);

    for (i = 0; i < test_case; i++) {
        scanf_s("%u", &student_count);
        total = 0;
        for (j = 0; j < student_count; j++) {
            scanf_s("%f", &scores[j]);
            total += scores[j];
        }

        avg = total / student_count;
        avgs[i] = avg;
        for (j = 0; j < student_count; j++) {
            if (avg < scores[j]) {
                ++student_over_avg_count;
            }
        }
        student_over_avg_ratio = (student_over_avg_count / student_count) * 100;
        results[i] = student_over_avg_ratio;
    }

    for (i = 0; i < test_case; i++) {
        printf("over : %f\n", results[i]);
    }


    for (i = 0; i < test_case; i++) {
        printf("avg : %f\n", avgs[i]);
    }

    return 0;
}


/*
각 케이스마다 한 줄씩 평균을 넘는 학생들의 비율을 반올림하여 소수점 셋째 자리까지 출력한다.

5
5 50 50 70 80 100
7 100 95 90 80 70 60 50
3 70 90 80
3 70 90 81
9 100 99 98 97 96 95 94 93 91

40.000%
57.143%
33.333%
66.667%
55.556%

*/

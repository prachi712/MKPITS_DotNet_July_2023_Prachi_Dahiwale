#include<stdio.h>
int main()
{
	int num=5;
	int *ptr=&num;
	printf("address=%X\n",ptr);
	printf("value of address =%d",*ptr);
}

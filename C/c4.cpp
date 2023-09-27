#include<stdio.h>
int main()
{
	int i;
	int num;
	int cube;
	printf("enter any number");
	scanf("\n%d",&num);
	for(i=1;i<=num;i++)
	{
		cube=i*i*i;
		printf("\n%d cube is %d",cube);
	}
}

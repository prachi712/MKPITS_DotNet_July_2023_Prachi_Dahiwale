#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[5];
	for(i=0;i<5;i++)
	{
		printf("enter marks");
		scanf("%d",&marks[i]);
	}
	for(i=0;i<5;i++)
	{
		printf("\nmarks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\ntotal marks=%d",sum);
}

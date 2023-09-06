#include<stdio.h>
int main()
{
	int i,n, num[3];
	printf("enter n");
	scanf("%d",&n);
	//Accepting values
	for(i=0;i<n;i++)
	{
		printf("enter num");
		scanf("%d",&num);
	}
	for(i=n-1;i>=0;i--)
	{
	
		printf("\nnum=%d",num[i]);
	}
}

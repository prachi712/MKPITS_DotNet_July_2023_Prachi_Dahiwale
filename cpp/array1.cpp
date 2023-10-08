#include<stdio.h>
int main()
{
	int i;
	int sum=0;
	int marks[3];
	marks[0]=99;
	marks[1]=90;
	marks[2]=89;
	for(i=0;i<3;i++)
	{
		printf("\n marks=%d",marks[i]);
		sum=sum+marks[i];
	}
	printf("\ntotal marks=%d",sum);
	}


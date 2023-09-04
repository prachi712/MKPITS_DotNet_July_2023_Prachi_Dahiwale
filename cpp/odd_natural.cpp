#include<std io.h>
int main()
{
	int i; 
	int num;
	int num1;
	int num2;
	int sum=0;
	printf("enter number");
	scanf("%d",&num);
	for(i=1;i<=num;i++)
	{
		printf("/n%d",2*i-1);
		sum+=2*i-1;
	
    printf("/nsum of odd no.is %d",sum);                                 
}
}

#include<stdio.h>
int main()
{
	int num,res=0,i,sum=0;
	printf("enter any number");
	scanf("%d",&num);
	
	for(res=num;num!=0 ;num=num/10)
	{
		i=num%10;
		sum=sum+(i*i*i);
	}
	if(sum==res)
	printf("%d is an armstrong number",res);
	else
	printf("%d is not armsrong number",res);

}
	
	


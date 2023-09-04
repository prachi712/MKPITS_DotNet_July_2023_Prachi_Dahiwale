#include<stdio.h>
int main()
{
	int counter=5;
	int num;
	int rem;
	for(num=2;num<=20;num++)
	{
		counter=5;
		while(counter<num)
		{
			rem=num%counter;
	    if(rem==0)
	    {
	    	break;
		}
		counter++;
		if(num==counter)
		{
			printf("/n%d is a prime number",num);
		}
		}
	}
}

#include<stdio.h>
void prime(int)
{
	int main(){
int counter=2;
int rem=0;
int num;
	printf("enter number");
	scanf("%d",&num);
	while(counter<num){
		rem=num%counter;
		if(rem==0){
			printf("it is not prime number");
			break;
			counter=counter+1;
		}
		if(num==counter){
			printf("it is prime number");
		
		}
		}
	}
}
	
	

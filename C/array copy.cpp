#include<stdio.h>
int main(){
	int i,arr1[5],arr2[5];
	for(i=0;i<5;i++)
	{
		printf("enter array");
		scanf("%d",&arr1);
	}
	for(i=0;i<5;i++)
	{
		arr2[i]=arr1[i];
	}
	printf("\nelements of arr1");
	for(i=0;i<5;i++)
	{
		printf("%d",arr1[i]);
	}
	    printf("\nenter elements of arr2");
	    
		for(i=0;i<5;i++)
		{
			printf("\n%d",&arr2[i]);
		}
	}



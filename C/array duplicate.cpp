#include<stdio.h>
int main()
{
	int arr[5];
	int i,cnt=0;int j;
	for(i=0;i<5;i++)
	{
		printf("\nenter array");
		scanf("%d",&arr[i]);
	}
	for(i=0;i<5;i++)
	{
		for(j=i+1;j<5;j++)
		{
			if(arr[i]==arr[j])
			{
				cnt++;
				break;
				
			}
		}
	}
	printf("\n no.of duplicate elements=%d",cnt);
}

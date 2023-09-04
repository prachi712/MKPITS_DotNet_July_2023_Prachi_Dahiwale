#include<stdio.h>
#include<iostream>
using namespace std;
int main()
{
	
	int num,fact=1;
	int *ptr=&fact;
	cout<<"enter two number";
	cin>>num;
	while(num>0)
	{
	    *ptr=*ptr*num;
		num=num-1;
	}
	cout<<" fact= "<<*ptr;
	return 0;
} 

#include<stdio.h>
#include<string.h>
 int main()
 {
 	int count;
 	char name[10];
 	char *ptr;
 	printf("enter name");
 	gets(name);
 	ptr=name;
 	while(*ptr != '\0')
 	{
 		if(*ptr=='a'|| *ptr=='e'|| *ptr=='i' || *ptr=='o' ||*ptr=='u')
 		{
 			count=count+1;
		 }
		 ptr++;
	 }
 printf("no.of vowels in a string =%d",count);
}

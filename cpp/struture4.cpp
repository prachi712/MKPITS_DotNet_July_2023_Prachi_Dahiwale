#include<stdio.h>
#include<string.h>
struct student
 {
 	int rno;
 	char name[20];
 };
 int main()
 {
 	struct student stud[2];
 	int counter;
 	for(counter=0;counter<2;counter++)
 	{
 		printf("enter rno and name");
 		scanf("%d",&stud[counter].rno);
 		scanf("%s",&stud[counter].name);
 		
	 }
	 printf("\nstudent details");
	 for(counter=0;counter<2 ;counter++)
	 {
	 	printf("\nrno=%d",stud[counter].rno);
	 	printf("\nname=%d,stud[counter].name[counter].name");
	 }
 }

#include<stdio.h>
#include<string.h>
struct book
{
char title[50];
char author[50];
int bookid;
};
void printbook(struct book b1);
int main()
{
	struct book b1;
	printf("\nenter title,author and bookid");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",b1.bookid);
	printbook(b1);
}
void printbook(struct book b1)
{
	printf("\ntitle=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\nbookid=%d",b1.bookid);
}

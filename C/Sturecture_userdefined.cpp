#include<stdio.h>
#include<string.h>
struct book
{
	char title[20];
	char author[20];
	int bookid;
};
int main()
{
	struct book b1;
	printf("\nenter title,author and bookid");
	scanf("%s",b1.title);
	scanf("%s",b1.author);
	scanf("%d",&b1.bookid);
	printf("\ntitle=%s",b1.title);
	printf("\nauthor=%s",b1.author);
	printf("\n  bookid=%d",b1.bookid);
}

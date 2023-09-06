#include<string.h>
struct Book
{
	char title[50];
	char author[50];
	int Bookid;
};
int main()
{
	struct Book b1;
	strcpy(b1.title,"Dotnet");
	strcpy(b1.author,"ashish");
	b1.Bookid=123;
	printf("title=%s",b1.title);
	printf("author=%s",b1.author);
	printf("Bookid=%d",b1.Bookid)
}

#include<iostream>
using namespace std;
class Customer
{
	public:
		int custno;
		string custname;
		Customer()
		{
			custno=258;
			custname="prachi";
		}
		void display()
		{
			cout<<"custno:"<<custno<<endl;
			cout<<"custname:"<<custname;
		}
};
int main()
{
	Customer cust1;
	cust1.display();
	return 0;
}

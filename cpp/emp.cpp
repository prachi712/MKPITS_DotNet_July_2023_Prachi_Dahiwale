#include<iostream>
using namespace std;
class Employee
{
	public:
		int empno;
		string empname;
		Employee()
		{
			empno=1234;
			empname="prachi";
		}
		void display()
		{
			cout<<"empno"<<empno<<endl;
			cout<<"empname"<<empname;
		}
};
int main()
{
	Employee emp1;
	emp1.display();
	return 0;
}

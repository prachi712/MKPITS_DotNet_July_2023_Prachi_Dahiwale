#include<iostream>
using namespace std;
class Student{
	public:
	int rollno;
	string name;
	string course;
	void getData()
	{
		cout<<"enter roll no,name,course";
		cin>>rollno>>name>>course;
		
	}
	void displayData()
	{
		cout<<"roll no:"<<rollno<<endl;
		cout<<"name:"<<name<<endl;
		cout<<"course:"<<course<<endl;
	}
};
int main()
{
	Student stud1,stud2;
	cout<<"student 1"<<endl;
	stud1.getData();
	stud1.displayData();
	cout<<"student 2"<<endl;
	stud2.getData();
	stud2.displayData();
	return 0;
	
}

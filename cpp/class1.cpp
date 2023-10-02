 #include<iostream>
 using namespace std;
 class car{
 	public:
 		string make;
 		string model;
 		int year;
    void StartEngine()
    {
    	cout<<"engine is started"<<endl;
	}
	void Break()
	{
		cout<<"break applied";
	}
	
 };
 int main()
 {
 	car c1;
 	c1.make="march";
 	c1.model="tata";
 	c1.year=2021;
 	cout<<"make:"<<c1.make<<endl;
 	cout<<"model:"<<c1.model<<endl;
 	cout<<"year:"<<c1.year<<endl;
    c1.StartEngine();
	c1.Break();
	return 0; 	
 }


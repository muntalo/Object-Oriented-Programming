#include<iostream>
#include <string>
#include <sstream>
#include <iomanip>

class Counter {
private:
	int count;
	std::string name;

public:
	Counter()
	{
		count = 0;
	}

	void Increment() 
	{
		count++;
	}

	void Reset()
	{
		count = 0;
	}

	int Ticks(){
		return count;
	}
};

class Clock {
private:
	std::string name;
	Counter hour;
	Counter minute;
	Counter second;

public:
	Clock()
	{
		
	}

	void Increment()
	{
		if (second.Ticks() < 59)
		{
			second.Increment();
		}
		else if (minute.Ticks() < 59)
		{
			second.Reset();
			minute.Increment();
		}
		else if (hour.Ticks() < 24)
		{
			second.Reset();
			minute.Reset();
			hour.Increment();
		}
		else
		{
			hour.Reset();
			minute.Reset();
			second.Reset();
		}
	}

	void Reset()
	{
		hour.Reset();
		minute.Reset();
		second.Reset();
	}

	std::string Time()
	{
		std::stringstream ss;
		ss << std::setw(2) << std::setfill('0') << std::to_string(hour.Ticks()) 
		   << ":" 
		   << std::setw(2) << std::to_string(minute.Ticks()) 
		   << ":" 
		   << std::setw(2) << std::to_string(second.Ticks());

		std::string time = ss.str();
		return time;
	}
};


int main()
{
	Clock clockObj;

	for (int i = 0; i < 60; i++)
	{
		clockObj.Increment();
	}
	std::cout << clockObj.Time() << std::endl;

	clockObj.Reset();
	for (int i = 0; i < 3600; i++)
	{
		clockObj.Increment();
	}
	std::cout << clockObj.Time() << std::endl;
	
	clockObj.Reset();
	for (int i = 0; i < 86400; i++)
	{
		clockObj.Increment();
	}
	std::cout << clockObj.Time() << std::endl;

	clockObj.Reset();
	std::cout << clockObj.Time() << std::endl;
}

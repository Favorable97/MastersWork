// AppForTest.cpp: определяет точку входа для консольного приложения.
//

#include "stdafx.h"
#include <iostream>
#include <list>
#include <vector>
#include <map>
#include <windows.h>

#define N 800000
#define P 1000
using namespace std;
int main()
{
	setlocale(LC_ALL, "rus");
	std::vector<double> somethingVector(N);
	std::list<double> somethingList(N);
	std::map<double, int> somethingMap;
	for (int i = 0; i < N; i++)
	{
		somethingVector[i] = (double)rand();
		somethingList.push_back(somethingVector[i]);
		somethingMap.insert(make_pair(somethingVector[i], i));
	}

	std::vector<double> ToFind(P);
	int ind;
	for (int i = 0; i < P; i++)
	{
		ind = (int)((double)N * (double)rand() / (double)RAND_MAX - 0.5);
		ToFind[i] = somethingVector.at(ind);
	}




	DWORD start1 = GetTickCount();
	for (int i = 0; i<P; i++)
	{
	auto result1 = std::find(std::begin(somethingVector), std::end(somethingVector), ToFind[i]);
	//std::cout << (result1 != somethingVector.end());
	}
	DWORD time1 = GetTickCount() - start1;

	DWORD start2 = GetTickCount();
	for (int i = 0; i<P; i++)
	{
	auto result2 = std::find(std::begin(somethingList), std::end(somethingList), ToFind[i]);
	//std::cout << (result2 != somethingList.end());
	}
	DWORD time2 = GetTickCount() - start2;

	DWORD start3 = GetTickCount();
	for (int i = 0; i<P; i++)
	{
		auto result3 = somethingMap.find(ToFind[i]);
		//std::cout << (result3 != somethingMap.end());
	}
	DWORD time3 = GetTickCount() - start3;

	cout << "\nВремя, затрачиваемое контейнером vector:" << time1 << endl;
	cout << "Время, затрачиваемое контейнером list:" << time2 << endl;
	cout << "Время, затрачиваемое контейнером map:" << time3 << endl;


	system("pause");
    return 0;
}


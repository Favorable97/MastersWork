// AppForExample.cpp: определ¤ет точку входа дл¤ консольного приложени¤.
//

#include "stdafx.h"
#include <iostream>
#include <vector>
#include <map>
#include <list>

using namespace std;

int main()
{
	setlocale(LC_ALL, "rus");
	int n1 = 3;
	int n2 = 5;

	std::vector<int> x1;
	std::vector<double> x2;
	std::list<int> x3;

	//создание и заполнение массивов
	for (int i = 0; i<1000; i++) x1.push_back(i);
	for (int i = 0; i<700; i++) x2.push_back((double)i);
	for (int i = 0; i<500; i++) x3.push_back(i);


	//поиск в массивах
	for (int i = 0; i<3000; i++) {
		auto result1 = std::find(std::begin(x1), std::end(x1),
			(int)(1000.0*(double)rand() / (double)RAND_MAX));
		cout << (result1 != x1.end() ? "«начение найдено!" :
			"«начение не найдено!");
	}

	for (int i = 0; i < 200; i++) {
		auto result2 = std::find(std::begin(x2), std::end(x2),
			700.0*(double)rand() / (double)RAND_MAX);
		std::cout << (result2 != x2.end() ? "«начение найдено!" :
			"«начение не найдено!");

		auto result3 = std::find(std::begin(x3), std::end(x3),
			(int)(500.0*(double)rand() / (double)RAND_MAX));
		std::cout << (result3 != x3.end() ? "«начение найдено!" :
			"«начение не найдено!");
	}

	system("pause");
	return 0;
}


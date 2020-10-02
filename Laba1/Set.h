#pragma once
#include <iostream>

class Set {
public:
	// Конструктор
	Set(): _setElements(nullptr), _power(0) {}
	Set(const int* setElements, const int power);
	Set(const Set& source);
	// Деструктор
	~Set();
	// Методы
	int GetPower() const;
	void ChangeSet(const int* setElements, const int power);
	void AddElement(int element);
	bool IsIntersect(const Set& source) const;
	// Перегрузка
	int operator[](const int index) const;
	friend std::ostream& operator << (std::ostream& , const Set& source);
private:
	int* _setElements;
	int _power;
	void Copy(const int* setElements, const int power);
};
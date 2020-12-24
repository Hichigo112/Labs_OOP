#pragma once
#include <iostream>
#include "Operation.h"
#include "Factory.h"

using std::string;

class ConsoleInteractor
{
public:
	ConsoleInteractor();
	~ConsoleInteractor();

	void Init() const;
private:
	int GetIndex(const string& name) const;
	void Help() const;
	void CreateShape() const;
	void DeleteShape() const;
	void PrintShape() const;
	void Compare() const;
	void IsIntersect() const;
	void IsInclude() const;
	void Move() const;
	void Rotate() const;
	void Area() const;
	void CenterOfGravity() const;

	Shape** _cases = nullptr;
	string* _names = nullptr;
	int _count = 0;
};
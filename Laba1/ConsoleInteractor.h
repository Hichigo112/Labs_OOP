#pragma once
#include "Set.h"
// ConsoleInteractor.h

class ConsoleInteractor
{
public:
	ConsoleInteractor();

	void Init() ;
private:
	void AddElement();
	void GetPower() const;
	void IsIntersect() const;
	void Help() const;
	void Print() const;
	void GetElement() const;

	Set _firstSet;
	Set _secondSet;
};
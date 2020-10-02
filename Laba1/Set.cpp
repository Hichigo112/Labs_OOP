#include "Set.h"

Set::Set(const int* setElements, const int power)
{
	Copy(setElements, power);
}

Set::Set(const Set& source)
{
	Copy(source._setElements, source._power);
}

Set::~Set()
{
	delete[] _setElements;
}

int Set::GetPower() const
{
	return _power;
}

void Set::ChangeSet(const int* setElements, const int power)
{
	Copy(setElements, power);
}

void Set::Copy(const int* setElements, const int power)
{
	if (_power != power)
	{
		_power = power;
		delete[] _setElements;
		_setElements = new int[_power];
	}

	memcpy(_setElements, setElements, sizeof(int) * _power);
}

void Set::AddElement(const int element)
{
	int* temp = _setElements;
	_setElements = new int[_power+1];
	Copy(temp, _power);
	_power++;
	_setElements[_power - 1] = element;
	delete[] temp;
}

bool Set::IsIntersect(const Set& source) const
{
	for (int i = 0; i < _power; i++)
	{
		for (int j = 0; j < source._power; j++)
		{
			if (_setElements[i] == source._setElements[j])
			{
				return true;
			}
		}
	}
	return false;
}

int Set::operator[](const int index) const
{
	if (index >= _power)
	{
		throw std::out_of_range("OUT_OF_RANGE");
	}
	return _setElements[index];
}

std::ostream& operator << (std::ostream& flow, const Set& source)
{
	flow << "{ ";
	for (int i = 0; i < source._power; i++)
	{
		flow << source._setElements[i];
		if (i != source._power - 1)
		{
			flow << ", ";
		}
	}
	flow << " }\n";
	return flow;
}

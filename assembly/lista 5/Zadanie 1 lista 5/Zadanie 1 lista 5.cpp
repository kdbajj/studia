#include "stdafx.h"

double phi = 0;
double r = 2;

double x;
double y;

int main()
{
	__asm
	{
	FLD phi
	FCOS
	FMUL r
	FSTP x

	FLD phi
	FSIN
	FMUL r
	FSTP y
	}
	std::cout << x << std::endl;
	std::cout << y;

	std::cin.get();
}
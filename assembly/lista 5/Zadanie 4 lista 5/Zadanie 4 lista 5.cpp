#include "stdafx.h"

double l;//licznik
double m;//mianownik
double x = 2;
double y = 5;
double a = 9;
double b = -2;
double c = 4;
double wynik;


int main()
{
	__asm
	{
	FLD a
	FMUL x
	FLD b
	FMUL y

	FADD ST(0), ST(1)
	FADD c

	FABS

	FST l
	FLD a
	FMUL a
	FST a

	FLD b
	FMUL b
	FST b

	FADD a
	FSQRT
	FST m
	FLD l
	FDIV m
	FST wynik;
	}
	std::cout << l << std::endl;
	std::cout << m << std::endl;
	std::cout << wynik << std::endl;
	std::cin.get();
}
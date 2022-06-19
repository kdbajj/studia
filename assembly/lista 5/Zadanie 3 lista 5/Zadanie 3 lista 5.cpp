#include "stdafx.h"

double liczba1 = -4;
double liczba2 = 0;
double liczba3 = -1;
double liczba4 = 2;
double delta;
double wynik;
__int16 wynik2;
double a = 3;
double b = 2;
double c = 6;

double x1 = 0;
double x2 = 0;

int main()
{
	__asm
	{
		// kwadrat z liczby
		FLD b
		FMUL b

		FLD a
		FMUL c
		FMUL liczba1

		FADD ST(0), ST(1)

		
		ftst
		fstsw ax
		fwait
		sahf

		ja   st0_positive; 
		jb   st0_negative; 
		jz   st0_zero; 

		jmp koniec //przechwyt wyj¹tku
			st0_positive : mov wynik2, 1 // jeœli delta > 0
			FSQRT 
			FST delta
			FLD b
			FMUL liczba3
			FST b

			FLD a
			FMUL liczba4
			FST a

			FLD b
			FADD delta
			FDIV a

			FST x1 // wynik x1

			FLD b
			FSUB delta
			FDIV a

			FST x2 // wynik x2
			jmp koniec

			st0_negative : mov wynik2, 2 // je¿eli delta < 0
			jmp koniec

			st0_zero : mov wynik2, 3 // je¿eli delta równa 0
			FSQRT // pierwiastek z ST(0)
			FST delta

			FLD a
			FMUL liczba4
			FST a

			FLD b
			FMUL liczba3
			FDIV a

			FST x1
			FST x2
			jmp koniec

			koniec :
	}
	// je¿eli delta = 0 to wynik x1 i x2 przyjmuj¹ tê sam¹ wartoœæ
	// je¿eli delta < od 0 to x1=0 i x2 =0
	std::cout << x1 << std::endl;
	std::cout << x2 << std::endl;
	std::cin.get();
}
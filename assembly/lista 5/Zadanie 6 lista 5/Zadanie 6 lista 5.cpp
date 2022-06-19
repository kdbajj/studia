#include "stdafx.h"

int const wielkosc = 4;
double tablica[wielkosc] = { 5,9,12 };
double liczba0 = 0;
double liczbam1 = -1;
double liczba2;
double wynik1;
double wynik2;
int pom1; // przechowuje wielkosc tablicy
int pom2 = 0; // aktualny index w tablicy
double pom3 = 1;
int pom4;
double pom5;

int main()
{
	__asm
	{
		// liczymy srednia arytmetyczna

		mov EBX, wielkosc
		mov pom1, EBX
		FLD liczba0;
	petla1:
		mov EBX, pom2
		FADD tablica[EBX]
		add EBX, 8
		mov pom2, EBX
		mov EBX, pom1
		sub EBX, 1

		cmp EBX, 0
		jz dalej1

		mov pom1, EBX
		jmp petla1

	dalej1 :
		mov EAX, wielkosc
		mov pom4, EAX

		FBLD pom4
		FSUB pom3
			FDIV ST(1), ST(0)

			FXCH ST(1)
			FST wynik1; // œrednia arytmetyczna

			// obliczamy odchylenie standardowe
		mov EBX, wielkosc
		mov pom1, EBX
		FLD liczba0;
		mov EBX, 0
		mov pom2, EBX

			petla2 :
		mov EBX, pom2
		FLD tablica[EBX]
		add EBX, 8
		mov pom2, EBX
		mov EBX, pom1
		sub EBX, 1

		FSUB wynik1
		FMUL ST(0), ST(0)
		FADD pom5
		FST pom5

		cmp EBX, 1
		jz dalej2
		mov pom1, EBX
		jmp petla2

			dalej2 :
		FDIV wynik1
		FSQRT
		FST wynik2;
	}
	std::cout << wynik2 << std::endl; 
	std::cin.get();
}
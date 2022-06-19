#include "stdafx.h"

double liczba = 22.005;
double n = 1000;
int wynik;


int main()
{
	__asm
	{
		FLD liczba;
		FMUL n;

		FIST wynik;

		xor EAX, EAX
		xor EDX, EDX

		xor EBX, EBX
		xor EAX, EAX
		mov EAX, wynik

		petla : mov ECX, 5
		sub EAX, ECX
		cmp EAX, 0
		jz koniec1
		jb koniec2
		jmp petla

			koniec1 :
	mov wynik, EAX
		jmp end

		koniec2 :
	mov wynik, -1
		end :
	}
	// wynik 0 oznacza liczbê 5 na 3 miejscu, a wynik -1, ¿e jej nie by³o
	std::cout << wynik;
	std::cin.get();
}
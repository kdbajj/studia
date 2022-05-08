#include "stdafx.h"

__int32 wynik;
__int16 liczba = 16;

int main()
{
	__asm
	{
		mov BX, 1

		jeszcze_raz:mov  AX, CX
		mov  BX, CX
		mul  BX 
		sub AX, liczba
		cmp AX, 0
		jz zakoncz
		add CX, 1
		jmp jeszcze_raz
		zakoncz : mov liczba, CX
	}
	std::cout << liczba;
	std::cin.get();
}
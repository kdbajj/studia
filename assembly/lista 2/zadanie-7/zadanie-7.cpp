#include "stdafx.h"

__int16 podzielnoœæPrzez16;
__int16 liczba = 19;

int main()
{
	__asm
	{
		mov AX, liczba
		and AX, 15
		mov BX, 16
		sub BX, AX
		shr BX, 4
		mov podzielnoœæPrzez16, BX
	}
	std::cout << podzielnoœæPrzez16;
	std::cin.get();
}
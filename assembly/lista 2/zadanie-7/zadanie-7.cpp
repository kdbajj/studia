#include "stdafx.h"

__int16 podzielno��Przez16;
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
		mov podzielno��Przez16, BX
	}
	std::cout << podzielno��Przez16;
	std::cin.get();
}
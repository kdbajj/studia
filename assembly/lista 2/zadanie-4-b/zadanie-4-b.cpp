#include "stdafx.h"

__int16 tablica[3] = { 5,2,10 };
__int16 suma;

int main()
{
	__asm
	{
		xor ax, ax

		add AX, tablica[0]
		add AX, tablica[2]
		add AX, tablica[4]

		mov suma, ax
	}
	std::cout << (int)suma;
	std::cin.get();
}
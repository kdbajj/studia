#include "stdafx.h"

__int8 wynik = 0;
char napis[14] = "napis";

int main()
{
	__asm
	{
		mov EAX, offset napis

		petla : mov DL, [EAX]
		cmp DL, 0
		jz zakoncz
		add wynik, 1
		inc EAX
		jmp petla
		zakoncz :
	}
	std::cout << (int)wynik;
	std::cin.get();
}
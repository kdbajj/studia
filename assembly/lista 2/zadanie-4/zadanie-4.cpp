#include "stdafx.h"

char tablica[4] = { 8,1,5 };
char suma[2];

int main()//Zadanie 4 a.
{
	__asm
	{
		mov AL, tablica[0]
		mov AH, tablica[1]
		mov BL, tablica[2]

		add AH, AL
		add AH, BL

		mov suma[0], AH
	}
	std::cout << (int)suma[0];
	std::cin.get();
}
#include "stdafx.h"

__int16 tablica [4] = { 8,8,5,4};
__int8 liczba = 12;

int main()
{
	__asm
	{
		mov CL, liczba
		mov BL, CL
		and CL, 1
		xor CL, 1

		mov AL, BL
		mul CL
		add tablica[6], AX

		xor CL, 1
		mov AL, BL
		mul CL
		add tablica[0], AX
	}
	std::cout << "Elementy tablicy: " << (int)tablica[0] << ", " << (int)tablica[1] << ", " << (int)tablica[2] << ", " << (int)tablica[3] << std::endl;
	std::cin.get();
}
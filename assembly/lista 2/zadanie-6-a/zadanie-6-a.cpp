#include "stdafx.h"
unsigned short int liczba = 6868;
char resztaZDzielenia;
int main()
{
	__asm
	{
		mov AX, liczba
		and AX, 3
		mov resztaZDzielenia, AL
	}
	std::cout << (int)resztaZDzielenia;
	std::cin.get();
}
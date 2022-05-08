#include "stdafx.h"


char zdania[] = "Zdanie. Nastepne_zdanie! Kolejne_zdanie? Jeszcze_jedno_zdanie!";
__int8 wynik = 0;
int main()
{
	__asm
	{
		mov EDX, offset zdania

		jeszcze_raz : mov AH, [EDX]
		cmp AH, 0
		jz koniec
		inc EDX

		mov AL, AH
		sub AH, 46
		cmp AH, 0
		jz dodawanie

		mov AH, AL
		sub AH, 33
		cmp AH, 0
		jz dodawanie

		mov AH, AL
		sub AH, 63
		cmp AH, 0
		jz dodawanie

		jmp jeszcze_raz
		dodawanie : add wynik, 1
		jmp jeszcze_raz
		koniec :
	}
	std::cout << (int)wynik;
	std::cin.get();
}
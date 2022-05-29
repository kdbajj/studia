
#include "stdafx.h"


__int16 licznik;
__int16 mianownik;

__int16 l1 = 1;//licznik pierwszej liczby
__int16 m1 = 6;//mianownik pierwszej liczby
__int16 l2 = 2;//licznik drugiej liczby
__int16 m2 = 6;//mianownik drugiej liczby
int main()
{
	__asm
	{
		xor ECX, ECX
		xor EAX, EAX
		xor EDX, EDX

		mov AX, l2
		cmp AX, 0// jesli mianownik to 0
		jz koniec

		mov AX, l1
		mov CX, m2
		mul CX

		mov licznik, AX

		mov AX, m1
		mov CX, l2
		mul CX
		mov mianownik, AX
		koniec :
	}
	std::cout << "licznik: " << licznik << std::endl;
	std::cout << "mianownik: " << mianownik;
	std::cin.get();
}

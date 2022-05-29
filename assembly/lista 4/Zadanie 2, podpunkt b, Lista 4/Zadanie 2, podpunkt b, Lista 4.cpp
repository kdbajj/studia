
#include "stdafx.h"

__int16 l1 = 1;//licznik pierwszej liczby
__int16 m1 = 5;//mianownik pierwszej liczby
__int16 l2 = 5;//licznik drugiej liczby
__int16 m2 = 9;//mianownik drugiej liczby

__int16 licznik;
__int16 mianownik;

int main()
{
	__asm
	{		xor ECX, ECX
			xor EDX, EDX
			xor EAX, EAX

			mov AX, l1
			mov CX, l2
			mul CX
			mov licznik, AX

			mov AX, m1
			mov CX, m2
			mul CX
			mov mianownik, AX
	}
		std::cout << "Licznik to: " << licznik << std::endl;
		std::cout << "Mianownik to: " << mianownik;
		std::cin.get();
}
#include "stdafx.h"
	
__int16 licznik;
__int16 mianownik;

__int16 l1 = 12;//licznik pierwszej liczby
__int16 m1 = 2;//mianownik pierwszej liczby


__int16 l2 = 33;//licznik drugiej liczby
__int16 m2 = 5; //mianownik drugiej liczby

int main()
{
	__asm
	{
		xor EAX, EAX
		xor EDX, EDX
		xor ECX, ECX

		mov AX, m1
		mov CX, m2
		mul CX

		mov mianownik, AX
		mov AX, l1
		mov CX, m2
		mul CX

		push AX

		mov AX, l2
		mov CX, m1
		mul CX

		pop CX
		add AX, CX
		mov licznik, AX
	}
	std::cout << "Licznik to:  " << licznik << std::endl;
	std::cout << "Mianownik to:  " << mianownik;
	std::cin.get();
}
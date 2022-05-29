#include "stdafx.h"

__int16 a;
__int16 liczba1 = 15;
__int16 liczba2 = 123;

__int16 Liczba1;
__int16 Liczba2;
__int16 wynikKoñcowy;
int main()
{
	__asm
	{
		mov AX, liczba1
		mov Liczba1, AX
		mov AX, liczba2
		mov Liczba2, AX

		xor EAX, EAX
		xor EDX, EDX

	petla :
		mov AX, Liczba2 
			mov a, AX 
			
			xor EAX, EAX
			xor EDX, EDX

			mov AX, Liczba1
			mov BX, Liczba2
			div BX

			xor EDX, EDX
			mov BX, Liczba2
			mul BX

			mov BX, AX
			mov AX,Liczba1
			sub AX, BX

			mov Liczba2, AX
			mov AX, a
			mov Liczba1, AX

			cmp Liczba2, 0

			jz koniec
			jmp petla
			

	koniec :
		 
		mov AX, liczba1
			mov BX, Liczba1
			div BX 
			// u¿ywamy wzoru: (a/NWD) * b
			mov BX, liczba2
			mul BX
			mov wynikKoñcowy, AX
	}
	std::cout << wynikKoñcowy;
	std::cin.get();
}
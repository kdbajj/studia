#include "stdafx.h"
double ilosc = 6;
int liczby[7] = { 1,3,3,4,5,87};
int a;
double wynik;

int main()
{
	__asm
	{
	   mov CL, 0

		petla:	 mov EAX, liczby[ECX]
				push EAX

				add CL, 4
				cmp CL, 24
				jz koniec
				jmp petla


		koniec : xor EAX, EAX
				xor EDX, EDX
				xor EDX, EDX

				pop EAX
				mov BL, 5
		petla2 : pop ECX
				add EAX, ECX

				sub BL, 1
				cmp BL, 0
				jz koniec2
				jmp petla2
		koniec2 : push EAX
				xor EAX, EAX
				xor EDX, EDX
				xor EDX, EDX

				pop EAX

				mov a, EAX

				FILD a
				FDIV ilosc
				FSTP wynik
	}
	std::cout << wynik;
	std::cin.get();
}
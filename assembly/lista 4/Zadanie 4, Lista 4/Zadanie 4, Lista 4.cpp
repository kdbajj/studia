
#include "stdafx.h"


int a;
int b;
int c;
int liczba = 24;

int main()
{
	__asm
	{
			mov b, 1
			mov BL, 0
	petla1: xor EDX, EDX
			xor EAX, EAX

			mov EAX, a
			mul EAX
			push EAX

			mov EAX, b
			mul EAX

			mov ECX, EAX
			pop EAX

			add EAX, ECX
			mov c, EAX

			mov EAX, a
			mov ECX, b
			add EAX, ECX
			mov ECX, c
			add EAX, ECX


			cmp EAX, liczba
			jz koniec1

			cmp BL, 1 
			jz odejmij
			
			mov EAX, a
			add EAX, 1
			mov a, EAX

			add BL, 1
			jmp petla1

	odejmij :
			sub BL, 1

			mov EAX, b
			add EAX, 1
			mov b, EAX
			jmp petla1
	koniec1 :

	}
	std::cout << "a: " << a << std::endl;
	std::cout << "b: " << b << std::endl;
	std::cout << "c: " << c << std::endl;
	std::cin.get();
}
#include "stdafx.h"


int potêga;
__int8 liczba = 2;

int main()
{
	__asm
	{
		xor EAX, EAX
		mov AL, liczba
		and EAX, 7

		mov ebx, eax

		mul eax
		mul eax
		mul eax
		mul ebx

		mov potêga, eax
	}
	std::cout << potêga;
	std::cin.get();
}
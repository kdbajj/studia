#include "stdafx.h"


int pot�ga;
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

		mov pot�ga, eax
	}
	std::cout << pot�ga;
	std::cin.get();
}
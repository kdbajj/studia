
#include "stdafx.h"

char litery[] = "napis";
__int8 index = 0;

int main()
{
	__asm
	{
		mov EDI, offset litery
		mov BL, 1
		petla:mov AL, BL
		add BL, 1
		add[EDI], AL 

		inc EDI
		mov AL, [EDI] 
		cmp AL, 0 
		jne petla 
	}
	std::cout << litery;
	std::cin.get();
}
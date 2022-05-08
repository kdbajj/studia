#include "stdafx.h"
//#include <iostream>
char litery[] = "sfdjds";



int main()
{
	__asm
	{
		mov EAX, offset litery
		petla : mov BL, 1
		add[EAX], BL
		inc EAX
		mov BL, [EAX]
		cmp BL, 0
		jne petla
	}
	std::cout << litery;
	std::cin.get();
}
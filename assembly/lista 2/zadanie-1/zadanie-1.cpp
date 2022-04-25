
#include "stdafx.h"

char slowo[] = "AAAA";

int main()
{
	__asm
	{
		mov EDX, offset slowo

		add[EDX], 32
		inc EDX

		add[EDX], 32
		inc EDX

		add[EDX], 32
		inc EDX
		add[EDX], 32
		
	}
	std::cout << slowo;
	std::cin.get();
}
#include "stdafx.h"

char napis[4] = "aaa";
char napis1[4] = "bbb";
char napis2[7] = "";

int main()
{	__asm
	{
		mov EAX, 0
		mov AL, napis[0]
		mov AH, napis1[0]
		mov napis2[0], AL
		mov napis2[1], AH

		mov AL, napis[1]
		mov AH, napis1[1]
		mov napis2[2], AL
		mov napis2[3], AH

		mov AL, napis[2]
		mov AH, napis1[2]
		mov napis2[4], AL
		mov napis2[5], AH
		mov napis2[6], 0
	}
		std::cout << napis2;

		std::cin.get();
}
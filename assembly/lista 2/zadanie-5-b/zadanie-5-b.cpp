#include "stdafx.h"

__int16 liczba = 23;

int main()
{
	__asm
	{
		xor eax, eax
		xor ebx, ebx
		xor ecx, ecx

		mov AX, liczba

		mov BX, AX

		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX

		shr AX, 1
		mov BX, AX
		not BX
		and BX, 1
		add CX, BX
		mov liczba, cx
	}
	std::cout << liczba << std::endl;
	std::cin.get();
}
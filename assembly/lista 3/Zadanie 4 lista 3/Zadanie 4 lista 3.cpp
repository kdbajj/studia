#include "stdafx.h"

char wynik[] = "";
char odwroconyNapis[] = "Odwrocony napis";


int main()
{
	__asm
	{
	mov EDX, offset odwroconyNapis
	mov EBX, offset wynik

	wykonaj : mov AL, [EDX]
	cmp AL, 0
	jz koniec
	inc EDX
	jmp wykonaj
	koniec :

	kopiuj: dec EDX
	mov AL, [EDX]
	mov AH, AL
	cmp AH, 0
	jz zakoncz
	mov[EBX], AL
	inc EBX
	jmp kopiuj
	zakoncz :
	}
	std::cout << wynik;
	std::cin.get();
}
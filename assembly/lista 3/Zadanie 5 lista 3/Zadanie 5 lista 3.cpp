#include "stdafx.h"

__int32 tablica[4];
char liczba[8] = "1C";



int main()
{
	__asm
	{
		xor EAX, EAX
		mov AL, liczba[0]
		push AL
		sub AL, 48
		cmp AL, 10
		jg dalej1
		mov tablica[0], EAX
		jmp koniec
	dalej1 : pop AL
	mov tablica[0], EAX

	koniec :
	xor EAX, EAX
			mov AL, liczba[1]
			push AL
			sub AL, 48
			cmp AL, 10
			jg nastepne
			mov tablica[4], EAX
			jmp zakoncz

	nastepne : pop AL
	mov tablica[4], EAX

	zakoncz :

	}
	std::cout << tablica[0] << tablica[1];
	std::cin.get();
}

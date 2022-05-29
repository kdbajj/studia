

#include <iostream>
#include "stdafx.h"

const int n = 6;//ilosc parametrów
int tablica[n] = { 4, 2, 3, 56, 8 };
int wynik;
int koniec;
int main()
{
	__asm
	{

			mov EBX, 0
			xor EAX, EAX
			xor EDX, EDX

			mov EAX, n
			mov ECX, 4
			mul ECX
			add EAX, 4
			mov koniec, EAX

petla1 :	xor EAX, EAX
			xor EDX, EDX

			mov EAX, tablica[EBX]
			mov ECX, 5
			div ECX

			cmp EAX, 0
			jne spr

			mov ECX, wynik
			mov EAX, tablica[EBX]
			add ECX, EAX
			mov wynik, ECX

	spr :
			cmp EBX, koniec
			jz koniecPetli
			add EBX, 4
			jmp petla1
koniecPetli :
		}
			std::cout << wynik;
			std::cin.get();
}
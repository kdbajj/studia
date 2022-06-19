#include "stdafx.h"

double tablica[16] = { 19,2,52,12,31,30,8,8,6,5,5,4,6,2,2 };

int i = 0; // iterator pêtli zewnêtrznej
int j = 1; // iterator pêtli wewnêtrznej
int n = 14; // iloœæ elementów w pêtli
int m = 1;
int index1 = 0;
int index2 = 8;

// using namespace std;

int main()
{
	__asm
	{
	petla2:
	petla1: mov ECX, index1
		mov EBX, index2
		xor EAX, EAX

		FLD tablica[ECX]
		FLD tablica[EBX]
		FSUB ST(1), ST(0)
		FXCH ST(1)
		ftst // przyrównujemy do zera
		fstsw ax
		fwait
		sahf

		ja   st0_positive; // je¿eli wynik wiêkszy od 0
	jb   st0_negative; // only the C0 bit(CF flag) would be set if no error
	jz   st0_zero; // only the C3 bit(ZF flag) would be set if no error
	jmp dalej1

		st0_positive :
	FLD tablica[ECX]
		FLD tablica[EBX]

		FSTP tablica[ECX]
		FSTP tablica[EBX]

		st0_negative :
		st0_zero :
	dalej1 :

		add index1, 8
		add index2, 8
		add j, 1

		mov EAX, n
		cmp j, EAX
		jz koniec

		jmp petla1

	koniec :
		mov index1, 0
		mov index2, 8
		mov j, 1
		add i, 1
		mov EAX, m
		cmp i, EAX
		jz koniec2
		jmp petla2
	koniec2 :
	}
	// wyœwietlamy elementy z tablicy
	std::cout << tablica[0] << std::endl;
	std::cout << tablica[1] << std::endl;
	std::cout << tablica[2] << std::endl;
	std::cout << tablica[3] << std::endl;
	std::cout << tablica[4] << std::endl;
	std::cout << tablica[5] << std::endl;
	std::cout << tablica[6] << std::endl;
	std::cout << tablica[7] << std::endl;
	std::cout << tablica[8] << std::endl;
	std::cout << tablica[9] << std::endl;
	std::cout << tablica[10] << std::endl;
	std::cout << tablica[11] << std::endl;
	std::cout << tablica[12] << std::endl;
	std::cout << tablica[13] << std::endl;
	std::cout << tablica[14] << std::endl;
	std::cout << tablica[15] << std::endl;

	std::cin.get();
}
function wynik = macierzOdwrotna2_2(m1)

  [a,b] = size(m1);

  if(a != 2 && b != 2)
    wynik = "Macierz odwrotna nie istnieje!(Nie jest 2x2)";
  return;
  endif

  wyznacznik = m1(1,1) * m1(2,2) - m1(1,2) * m1(2,1);
  if(wyznacznik == 0)
  wynik = "Macierz odwrotna nie istnieje";
    return;
  endif

  wynik = [m1(2,2) -m1(1,2); -m1(2,1) m1(1,1)];

  for i=1:a
    for j=1:b
 wynik(i,j) *= (1/wyznacznik);
    endfor
  endfor
endfunction
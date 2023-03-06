function wynik = macierzOdwrotnaKwadratowa (m)

 [a,b] = size(m);

 if(a > 3)
    wynik = "Da siê policzyæ tylko macierze odwrotne macierza 3 stopnia";
    return;
 endif

 if(a != b)
    wynik = "Macierz nie jest kwadratowa";
    return;
 endif

  wyznacznik = oblWyzn(m, a);
 if(wyznacznik == 0)
    wynik = "Macierz nie jest odwracalna";
    return;
 endif

  c = m(2,2) * m(3,3) - m(2,3) * m(3,2);
  d = m(1,3) * m(3,2) - m(1,2) * m(3,3);
  e = m(1,2) * m(2,3) - m(1,3) * m(2,2);
  f = m(2,3) * m(3,1) - m(2,1) * m(3,3);
  g = m(1,1) * m(3,3) - m(1,3) * m(3,1);
  h = m(1,3) * m(2,1) - m(1,1) * m(2,3);
  i = m(2,1) * m(3,2) - m(2,2) * m(3,1);
  j = m(1,2) * m(3,1) - m(1,1) * m(3,2);
  k = m(1,1) * m(2,2) - m(1,2) * m(2,1);

  wynik = [c d e; f g h; i j k];

 for l=1:a
    for m=1:b
      wynik(l,m) *= 1/wyznacznik;
    endfor
  endfor
endfunction

function wyznacznik2 = oblWyzn(m, a)
  if(a == 3)
wyznacznik2 = m(1,1) * m(2,2) * m(3,3);
wyznacznik2 += m(1,2) * m(2,3) * m(3,1);
wyznacznik2 += m(1,3) * m(2,1) * m(3,2);

wyznacznik2 -= m(1,3) * m(2,2) * m(3,1);
wyznacznik2 -= m(1,1) * m(2,3) * m(3,2);
wyznacznik2 -= m(1,2) * m(2,1) * m(3,3);
 elseif (a == 2)
    wyznacznik2 = m(1,1) * m(2,2) - m(1,2) * m(2,1);
    return;
 elseif (a == 1)
   wyznacznik2 = m(1,1)
    return;
 endif
endfunction


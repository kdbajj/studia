function wynik=mnozenie_macierzy(m1,m2)
  [a,b]=size(m1);
  [c,d]=size(m2);
  if(b==c)
    wynik(a,d)=0;
  for i=1:a
    for j=1:d
      for k=1:b
        wynik(i,j)=wynik(i,j)+(m1(i,k)*m2(k,j));
      endfor
    endfor
  endfor
  else
    wynik = "Nie mo¿na pomno¿yc macierzy!"; # jezeli liczba kolumn w m1 nie jest równa liczbie wierszy w m2
  endif
endfunction
function wyznacznik=wyznacnzik_macierzy_diagonalnej(m1);
 czyJestDiagonalna=1;
[a,b]=size(m1);

if(a==b)
  for i=1:a
    for j=1:a
      if(i!=j && m1(i,j)!=0)
        czyJestDiagonalna=0;
      endif
    endfor
  endfor
      if(czyJestDiagonalna==1)
      wyznacznik=1;
      for i=1:a
          wyznacznik=wyznacznik*m1(i,i);
    endfor
  else
       wyznacznik="macierz nie jest diagonalna!";#czynniki poza przek¹tn¹ g³ówn¹ nie s¹ zerowe
   endif
  else
      wyznacznik="macierz nie jest kwadratowa!";# liczba kolumn i wierszy w macierzy nie s¹ sobie równe
   endif
endfunction